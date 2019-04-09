using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SubTrans
{
    class RTLCorrection
    {
        /// <summary>
        /// RTL Global Correction in LTR Layout V1.0.0.1
        /// </summary>
        /// <author>
        /// Mohammad Reza A.
        /// m_ra_r@yahoo.com
        /// 2012/1/20
        /// </author>
        /// Problems: Dont Support Space on English Words,Only Support one space in severaal english words,some peoblem on english writhing(same alp chars),Dont Support Qustion Symbol On the end of english word
        public static string Correction(string Translation)
        {
            string TempText = Translation, NounSymbolText = Translation, Correct_Text = "", splitedText = "", SplitFirstChars = "", SplitLastChars = "";
            string[] SentenceSplitter = { "" };


            //if there is only english and/or symbols
            for (int i = 0; i < illegal_Symbols.Length; i++)
                NounSymbolText = NounSymbolText.Replace(illegal_Symbols[i].ToString(), "");

            int onlyEnglish=0;
            for (int i = 0; i < NounSymbolText.Length; i++)
            {
                if(Regex.IsMatch(NounSymbolText[i].ToString(), "[a-zA-Z0-9]"))
                {
                    onlyEnglish++;
                }
            }
            if (onlyEnglish != NounSymbolText.Length)
            {
                //correction
                //
                //Split First illegal Symbols
                int F;
                for (F = 0; F < TempText.Length; F++)
                {
                    if (Array.IndexOf(illegal_Symbols, TempText[F]) != -1)
                        SplitFirstChars += ReverseBrackedChar(TempText[F]);
                    else
                        break;
                }
                TempText = TempText.Remove(0, F);//Remove detected chars from source

                //Split Last illegal Symbols
                for (int L = TempText.Length - 1; L >= 0; L--)
                {
                    if (Array.IndexOf(illegal_Symbols, TempText[L]) != -1)
                    {
                        SplitLastChars += ReverseBrackedChar(TempText[L]);
                        TempText = TempText.Remove(L, 1);
                    }
                    else
                        break;
                }
                //Detect and Regroup Several English Words Behind each other into a single array element
                List<string> MergeEnglishWords_Array = new List<string>();
                string[] WordSplitter = TempText.Split(' ');
                for (int i = 0; i < WordSplitter.Length; i++)
                {

                    if (Regex.IsMatch(WordSplitter[i], "[a-zA-Z]"))
                    {
                        int c;
                        string merge = "";
                        for (c = 0; i + c < WordSplitter.Length && Regex.IsMatch(WordSplitter[i + c], "[a-zA-Z]"); c++)
                        {
                            if (c == 0)
                                merge += WordSplitter[i + c];
                            else
                                merge += " " + WordSplitter[i + c];
                        }
                        MergeEnglishWords_Array.Add(merge);
                        i += c - 1;
                    }
                    else
                        MergeEnglishWords_Array.Add(WordSplitter[i]);
                }
                //is there any english char/word
                if (Regex.IsMatch(TempText, "[a-zA-Z]"))
                {
                    //Chanage Direction on English Words
                    for (int i = 0; i < MergeEnglishWords_Array.Count; i++)
                    {
                        int j = 0, p = 0;//Return count of lentgh untill new english words
                        if (Regex.IsMatch(MergeEnglishWords_Array[i], "[a-zA-Z]"))//Check Words Contained English Words Or Not (If First Word Was En you Must Put it in the End Of the Text)
                        {
                            SentenceSplitter = TempText.Split(new string[] { MergeEnglishWords_Array[i] }, StringSplitOptions.None);//Make A Array Without English(splitted with English Word in two Elements)
                            if (SentenceSplitter.Length > 1)
                            {
                                for (j = 0, p = 0; j < SentenceSplitter[1].Length; j++, p++)//Start to Grab Everiting until Next English Word
                                {
                                    if (Regex.IsMatch(SentenceSplitter[1][j].ToString(), "[a-zA-Z]"))
                                    {
                                        //Fix Words Like This: "reza",("reza"),etc
                                        for (int k = j; k >= 0; k--)
                                        {
                                            if (j - k >= 0 && Array.IndexOf(illegal_Symbols, SentenceSplitter[1][j - k]) != -1 && SentenceSplitter[1][j - k] != ' ')
                                                p--;
                                        }
                                        splitedText = SentenceSplitter[1].Substring(0, p);//Return All exept illegall symbols
                                        break;// Achive to first english word and exit from "for"
                                    }
                                    else
                                        splitedText += SentenceSplitter[1][j];//Put Non-english into another String
                                }

                            }
                            //Fix Illegal Char
                            MergeEnglishWords_Array[i] = FixIllegalCharsLocation(MergeEnglishWords_Array[i]);

                            //Correct The Word And Make Varible Null to prevent Add them Again
                            Correct_Text = FixIllegalCharsLocation(splitedText) + " " + MergeEnglishWords_Array[i] + " " + FixIllegalCharsLocation(SentenceSplitter[0].Trim());//Reverse Elements and Correct The Sentece
                            //FixIllegalCharsLocation(SentenceSplitter[0].Trim()
                            //چون خودم قبل و بعد انگلیسی اسپیس میزارم)جلوگیری از ضافه شدن اسپیس دوم وقتی کلمه انگلیسی بعدش تایپ کنیم)
                            //example: word سلام خوبی (Trim())
                            //و امکان تایپ همچین جملاتی
                            //reza :مترجم(FixIllegalCharLocation())
                            splitedText = "";
                            int u = TempText.Length;
                            if (SentenceSplitter[0].Length < TempText.Length)//جمله هایی که یه تیکه اند و انگلیسی دارن یا فقط فاصله دارن
                            {
                                string shadow = TempText.Substring(0, p + MergeEnglishWords_Array[i].Length + SentenceSplitter[0].Length);//Grab All Words before Next English Word
                                TempText = TempText.Replace(shadow, Correct_Text);//Replace Theme into Main Text That in up again will splitt with SentenceSplitter to correct that line befor start again
                            }
                            //Example: |:D
                            //Text:  سلام jack خوبی دیگه چه خبر john کجاس به bill بگو برگرده؟
                            //Step1: خوبی دیگه چه خبر|jack|سلام john کجاس به bill بگو برگرده؟
                            //Step2: کجاس به|john|خوبی دیگه چه خبر jack سلام bill بگو برگرده؟
                            //Final: بگو برگرده؟|bill|کجاس به john خوبی دیگه چه خبر jack سلام
                        }
                    }
                }
                //string is non-english
                else
                    Correct_Text = TempText.Trim();
                //
                //Reverse "Split first chars" (Important)
                char[] ReversedFirstChar = SplitFirstChars.ToCharArray();
                Array.Reverse(ReversedFirstChar);

                //Rrturn Corrected Text
                return SplitLastChars + Correct_Text.Trim() + new string(ReversedFirstChar);
            }
            else
                return Translation;
        }

        static char[] illegal_Symbols = {'"','!','-','(',')',':',',','*','.','،',' '
                                        ,'#','%',';','{','_','}','[','|','?','×','÷'
                                        ,']','+','=','&','^','$','@','~','`','\"','\''
                                        ,'|','\\','>','<','/','©','®','»','«','♪','♫'};

        static string FixIllegalCharsLocation(string text)
        {
            //Split Last illegal Symbols
            //
            int F;
            string SplitFirstChars = "";
            for (F = 0; F < text.Length; F++)
            {
                if (Array.IndexOf(illegal_Symbols, text[F]) != -1)
                    SplitFirstChars += ReverseBrackedChar(text[F]);
                else
                    break;
            }
            text = text.Remove(0, F);//Remove detected chars from source
            //
            //Split Last illegal Symbols
            //
            string SplitLastChars = "";
            for (int L = text.Length - 1; L >= 0; L--)
            {
                if (Array.IndexOf(illegal_Symbols, text[L]) != -1)
                {
                    SplitLastChars += ReverseBrackedChar(text[L]);
                    text = text.Remove(L, 1);//Remove detected chars from source
                }
                else
                    break;
            }
            char[] ReversedSplitFirstChars = SplitFirstChars.ToCharArray();
            Array.Reverse(ReversedSplitFirstChars);

            //
            return SplitLastChars + text + new string(ReversedSplitFirstChars);

        }
        static char ReverseBrackedChar(char c)
        {
            switch (c)
            {
                case '(':
                    return ')';
                case ')':
                    return '(';
                case '[':
                    return ']';
                case ']':
                    return '[';
                case '{':
                    return '}';
                case '}':
                    return '{';
                case '«':
                    return '»';
                case '»':
                    return '«';
                case '>':
                    return '<';
                case '<':
                    return '>';
                default:
                    return c;
            }
        }
    }
}
