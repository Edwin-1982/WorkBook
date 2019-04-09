using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Reflection;

namespace Subtrans
{
    class EnToFaDic
    {
        static char[] illegal_Symbols = {'"','!','-','(',')',':',',','*','.','،'
                                        ,'#','%',';','{','_','}','[','|','?','×','÷'
                                        ,']','+','=','&','^','$','@','~','`','\"'
                                        ,'|','\\','>','<','/','©','®','»','«','♪','♫'};

        public static string Meanings(string source, List<string> list, bool selected)
        {
            string Meaning = "";
            string[] wordsplit = { "" };
            source = source.ToLower().Replace("-", " ");
            source = source.ToLower().Replace("won't", "will not");
            source = source.ToLower().Replace("wont", "will not");
            source = source.ToLower().Replace("'s", "");
            source = source.ToLower().Replace("'ll", " will");
            source = source.ToLower().Replace("'d", " would");
            source = source.ToLower().Replace("'re", " are");
            source = source.ToLower().Replace("'ve", " have");
            source = source.ToLower().Replace("n't", " not");
            source = source.ToLower().Replace("'", "");
            
            source = source.Trim().Replace(Environment.NewLine, " ");
            for (int i = 0; i < illegal_Symbols.Length; i++)
                source = source.Replace(illegal_Symbols[i].ToString(), "");

            if (!selected)
                wordsplit = source.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            else
                wordsplit[0] = source;

            if (source.Length > 0)
            {
                for (int i = 0; i < wordsplit.Length; i++)
                {
                    switch (wordsplit[i][0].ToString().ToLower())
                    {
                        case "a":
                            Meaning += ReturnEqual(0, 6918, list, wordsplit[i]);
                            break;
                        case "b":
                            Meaning += ReturnEqual(6918, 12320, list, wordsplit[i]);
                            break;
                        case "c":
                            Meaning += ReturnEqual(12320, 21502, list, wordsplit[i]);
                            break;
                        case "d":
                            Meaning += ReturnEqual(21502, 27552, list, wordsplit[i]);
                            break;
                        case "e":
                            Meaning += ReturnEqual(27552, 31712, list, wordsplit[i]);
                            break;
                        case "f":
                            Meaning += ReturnEqual(31712, 36806, list, wordsplit[i]);
                            break;
                        case "g":
                            Meaning += ReturnEqual(36806, 40614, list, wordsplit[i]);
                            break;
                        case "h":
                            Meaning += ReturnEqual(40614, 44892, list, wordsplit[i]);
                            break;
                        case "i":
                            Meaning += ReturnEqual(44892, 49762, list, wordsplit[i]);
                            break;
                        case "j":
                            Meaning += ReturnEqual(49762, 50800, list, wordsplit[i]);
                            break;
                        case "k":
                            Meaning += ReturnEqual(50800, 51664, list, wordsplit[i]);
                            break;
                        case "l":
                            Meaning += ReturnEqual(51664, 55834, list, wordsplit[i]);
                            break;
                        case "m":
                            Meaning += ReturnEqual(55834, 61490, list, wordsplit[i]);
                            break;
                        case "n":
                            Meaning += ReturnEqual(61490, 63376, list, wordsplit[i]);
                            break;
                        case "o":
                            Meaning += ReturnEqual(63376, 65738, list, wordsplit[i]);
                            break;
                        case "p":
                            Meaning += ReturnEqual(65738, 75098, list, wordsplit[i]);
                            break;
                        case "q":
                            Meaning += ReturnEqual(75098, 75636, list, wordsplit[i]);
                            break;
                        case "r":
                            Meaning += ReturnEqual(75636, 80794, list, wordsplit[i]);
                            break;
                        case "s":
                            Meaning += ReturnEqual(80794, 94534, list, wordsplit[i]);
                            break;
                        case "t":
                            Meaning += ReturnEqual(94534, 100894, list, wordsplit[i]);
                            break;
                        case "u":
                            Meaning += ReturnEqual(100894, 102866, list, wordsplit[i]);
                            break;
                        case "v":
                            Meaning += ReturnEqual(102866, 104772, list, wordsplit[i]);
                            break;
                        case "w":
                            Meaning += ReturnEqual(104772, 107802, list, wordsplit[i]);
                            break;
                        case "x":
                            Meaning += ReturnEqual(107802, 107880, list, wordsplit[i]);
                            break;
                        case "y":
                            Meaning += ReturnEqual(107880, 108172, list, wordsplit[i]);
                            break;
                        case "z":
                            Meaning += ReturnEqual(108172, list.Count - 1, list, wordsplit[i]);
                            break;
                    }
                }
            }
            return Meaning.Trim();
        }

        static string ReturnEqual(int start, int end, List<string> list,string SourceWord)
        {
            
            for (int i = start; i < end; i+=2)
            {
                string[] split = list[i].Split('|');
                for (int s = 0; s < split.Length; s++)
                {
                    if (SourceWord.ToLower() == split[s].ToLower())
                        return SourceWord + Environment.NewLine + list[i + 1] + Environment.NewLine + Environment.NewLine;
                }
            }
            return SourceWord + Environment.NewLine + "- Not Found -" + Environment.NewLine + Environment.NewLine;
        }
    }
}
