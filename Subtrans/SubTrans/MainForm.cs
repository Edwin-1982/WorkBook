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
using System.Xml;
using System.Web;
using System.Net;
using System.Text.RegularExpressions;


namespace SubTrans
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //History Array
        public List<string> HistoryArray = new List<string>();

        private string Prompt_Source = "", Prompt_Translation = "", PromptNSE = "";//exit ,new ,open save prompt

        private void Movie_On_Right()
        {
            //group box
            AutoMove_chkBox.Enabled = true;
            Seccond_cmbBox.Enabled = true;
            label1.Enabled = true;
            PlaySubtitle_rdobtn.Enabled = true;
            PlaySeccond_rdobtn.Enabled = true;
            DonotPlay_rdobtn.Enabled = true;
            //
            splitContainer1.SplitterDistance = splitContainer1.Width - 696;
            splitContainer1.Orientation = System.Windows.Forms.Orientation.Vertical;
            splitContainer1.Panel1.Controls.Add(Subtitle_listView);
            splitContainer1.Panel1.Controls.Add(Dictionary_listView);
            splitContainer1.Panel2.Controls.Add(time_lblD);
            splitContainer1.Panel2.Controls.Add(time_lbln);
            splitContainer1.Panel2.Controls.Add(timelabel);
            splitContainer1.Panel2.Controls.Add(subtitle_lbl);
            splitContainer1.Panel2.Controls.Add(axWindowsMediaPlayer1);
            movieOnTopMenuItem.Checked = false;
            movieOnLeftToolStripMenuItem.Checked = false;
            movieOnRightToolStripMenuItem.Checked = true;
            time_lblD.Location = new Point(axWindowsMediaPlayer1.Width - 78, time_lblD.Location.Y);
            time_lbln.Location = new Point(axWindowsMediaPlayer1.Width - 161, time_lblD.Location.Y);
            timelabel.Location = new Point(axWindowsMediaPlayer1.Width - 85, timelabel.Location.Y);
            if (Subtitle_listView.Items.Count > 0)
            {
                Subtitle_listView.FocusedItem = Subtitle_listView.Items[lvs];
                Subtitle_listView.EnsureVisible(lvs);
            }
            subtitle_lbl.Left = axWindowsMediaPlayer1.Width / 2 - subtitle_lbl.Width / 2;
            subtitle_lbl.Location = new Point(subtitle_lbl.Location.X, (axWindowsMediaPlayer1.Height - subtitle_lbl.Height - 70));
        }

        private void movieOnRightToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Movie_On_Right();
        }
        private void Movie_On_Top()
        {
            //group box
            AutoMove_chkBox.Enabled = true;
            Seccond_cmbBox.Enabled = true;
            label1.Enabled = true;
            PlaySubtitle_rdobtn.Enabled = true;
            PlaySeccond_rdobtn.Enabled = true;
            DonotPlay_rdobtn.Enabled = true;
            //
            splitContainer1.Panel2.Controls.Add(Subtitle_listView);
            splitContainer1.Panel2.Controls.Add(Dictionary_listView);
            splitContainer1.Panel1.Controls.Add(time_lblD);
            splitContainer1.Panel1.Controls.Add(time_lbln);
            splitContainer1.Panel1.Controls.Add(timelabel);
            splitContainer1.Panel1.Controls.Add(subtitle_lbl);
            splitContainer1.Panel1.Controls.Add(axWindowsMediaPlayer1);
            subtitle_lbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            splitContainer1.SplitterDistance = splitContainer1.Height - 150;
            movieOnTopMenuItem.Checked = true;
            movieOnLeftToolStripMenuItem.Checked = false;
            movieOnRightToolStripMenuItem.Checked = false;
            time_lblD.Location = new Point(axWindowsMediaPlayer1.Width - 78, time_lblD.Location.Y);
            time_lbln.Location = new Point(axWindowsMediaPlayer1.Width - 161, time_lblD.Location.Y);
            timelabel.Location = new Point(axWindowsMediaPlayer1.Width - 85, timelabel.Location.Y);

            if (Subtitle_listView.Items.Count > 0)//یه سری دستورات اضافه گذاشتم چون وقتی جای فیلم عوض میشد فوکوسد آیتم رو دیگه نمیشناخت کلا مجبورم شدم به جای رویداد سللکتد ایندکس چنج رویداد کلیک رو انتخاب کنم
            {
                Subtitle_listView.FocusedItem = Subtitle_listView.Items[lvs];
                Subtitle_listView.EnsureVisible(lvs);
            }
            subtitle_lbl.Left = axWindowsMediaPlayer1.Width / 2 - subtitle_lbl.Width / 2;
            subtitle_lbl.Location = new Point(subtitle_lbl.Location.X, (axWindowsMediaPlayer1.Height - subtitle_lbl.Height - 70));
        }

        private void movieOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Movie_On_Top();
        }

        private void Movie_On_Left()
        {
            //group box
            AutoMove_chkBox.Enabled = true;
            Seccond_cmbBox.Enabled = true;
            label1.Enabled = true;
            PlaySubtitle_rdobtn.Enabled = true;
            PlaySeccond_rdobtn.Enabled = true;
            DonotPlay_rdobtn.Enabled = true;
            //
            splitContainer1.Panel2.Controls.Add(Subtitle_listView);
            splitContainer1.Panel2.Controls.Add(Dictionary_listView);
            splitContainer1.Panel1.Controls.Add(time_lblD);
            splitContainer1.Panel1.Controls.Add(time_lbln);
            splitContainer1.Panel1.Controls.Add(timelabel);
            splitContainer1.Panel1.Controls.Add(subtitle_lbl);
            splitContainer1.Panel1.Controls.Add(axWindowsMediaPlayer1);
            splitContainer1.Orientation = System.Windows.Forms.Orientation.Vertical;
            splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            splitContainer1.SplitterDistance = splitContainer1.Width - 500;
            movieOnTopMenuItem.Checked = false;
            movieOnRightToolStripMenuItem.Checked = false;
            movieOnLeftToolStripMenuItem.Checked = true;
            time_lblD.Location = new Point(axWindowsMediaPlayer1.Width - 78, time_lblD.Location.Y);
            time_lbln.Location = new Point(axWindowsMediaPlayer1.Width - 161, time_lblD.Location.Y);
            timelabel.Location = new Point(axWindowsMediaPlayer1.Width - 85, timelabel.Location.Y);

            if (Subtitle_listView.Items.Count > 0)
            {
                Subtitle_listView.FocusedItem = Subtitle_listView.Items[lvs];
                Subtitle_listView.EnsureVisible(lvs);
            }
            subtitle_lbl.Left = axWindowsMediaPlayer1.Width / 2 - subtitle_lbl.Width / 2;
            subtitle_lbl.Location = new Point(subtitle_lbl.Location.X, (axWindowsMediaPlayer1.Height - subtitle_lbl.Height - 70));
        }
        private void movieOnLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Movie_On_Left();
        }

        int savelastmode = 0;

        private void Movie_Off()
        {
            if (splitContainer1.Panel2.Controls.Contains(Subtitle_listView))
                splitContainer1.Panel1Collapsed = true;
            else if (splitContainer1.Panel1.Controls.Contains(Subtitle_listView))
                splitContainer1.Panel2Collapsed = true;
            //ther is no movie
            //group box
            Seccond_cmbBox.Enabled = false;
            label1.Enabled = false;
            PlaySubtitle_rdobtn.Enabled = false;
            PlaySeccond_rdobtn.Enabled = false;
            AutoMove_chkBox.Enabled = false;
            DonotPlay_rdobtn.Enabled = false;
            //

            axWindowsMediaPlayer1.Ctlcontrols.pause();
            if (movieOffToolStripMenuItem.Checked == false)
            {
                if (movieOnLeftToolStripMenuItem.Checked == true)
                {
                    savelastmode = 1;
                }

                if (movieOnRightToolStripMenuItem.Checked == true)
                {
                    savelastmode = 2;
                }

                if (movieOnTopMenuItem.Checked == true)
                {
                    savelastmode = 3;
                }
                //disable other item
                movieOffToolStripMenuItem.Checked = true;
                movieOnLeftToolStripMenuItem.Checked = false;
                movieOnRightToolStripMenuItem.Checked = false;
                movieOnTopMenuItem.Checked = false;
                movieOnLeftToolStripMenuItem.Enabled = false;
                movieOnRightToolStripMenuItem.Enabled = false;
                movieOnTopMenuItem.Enabled = false;
                Open_movie_ToolStripMenuItem.Enabled = false;
            }
            else
            {
                if (savelastmode == 1)
                {
                    movieOnLeftToolStripMenuItem.Checked = true;
                    Movie_On_Left();
                }
                if (savelastmode == 2)
                {
                    movieOnRightToolStripMenuItem.Checked = true;
                    Movie_On_Right();
                }
                if (savelastmode == 3)
                {
                    movieOnTopMenuItem.Checked = true;
                    Movie_On_Top();
                }
                //disable other item
                movieOffToolStripMenuItem.Checked = false;
                movieOnLeftToolStripMenuItem.Enabled = true;
                movieOnRightToolStripMenuItem.Enabled = true;
                movieOnTopMenuItem.Enabled = true;
                Open_movie_ToolStripMenuItem.Enabled = true;
                splitContainer1.Panel2Collapsed = false;
                splitContainer1.Panel1Collapsed = false;
            }
        }
        private void movieOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Movie_Off();
        }


        string tk = "";
        //Play Subtitle With movie
        //(هر چی دستورات کمتر باشن احتمال رد شدن یه زیرنویس کمتر میشه(اگه هر دوتا رو کلی با هم مقایسه میکردم جواب نمیداد یعنی نمیرسید بهش
        //رو که 1 کردم دیگه چیزی رو از دست نداد ولی هنوزم صدم ثانیه تنظیمه یعنی دهم ثانیه وهزارم رو پشتیبانی نمیکنه که یخورده دیر بالا میادinterval 
        TextBox temptxtbox = new TextBox();//گذاشتمش اینجا که سرعت کد پایین بالاتر بره
        int focusedinx;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                TimeSpan CurrentTime = TimeSpan.FromSeconds(axWindowsMediaPlayer1.Ctlcontrols.currentPosition);
                time_lbln.Text = String.Format("{0:00}:{1:00}:{2:00},{3:000}", CurrentTime.Hours, CurrentTime.Minutes, CurrentTime.Seconds, CurrentTime.Milliseconds);

                foreach (ListViewItem item in Subtitle_listView.Items)
                {
                    string[] sTimeArr = item.SubItems[1].Text.Split(':', ',');
                    TimeSpan sTime = new TimeSpan(0, Convert.ToInt32(sTimeArr[0]), Convert.ToInt32(sTimeArr[1]), Convert.ToInt32(sTimeArr[2]), Convert.ToInt32(sTimeArr[3]));

                    string[] eTimeArr = item.SubItems[2].Text.Split(':', ',');
                    TimeSpan eTime = new TimeSpan(0, Convert.ToInt32(eTimeArr[0]), Convert.ToInt32(eTimeArr[1]), Convert.ToInt32(eTimeArr[2]), Convert.ToInt32(eTimeArr[3]));

                    if (sTime.TotalMilliseconds <= CurrentTime.TotalMilliseconds && eTime.TotalMilliseconds >= CurrentTime.TotalMilliseconds)//این کار باعث میشه اگه با موس فیلم رو جلو ببری هم زیرنویس جاری ولی از اول شروع مشده رو باز بخونه و کلا بهتر از قبلیه
                    {
                        if (Show_translateToolStripMenuItem.Checked)
                        {
                            temptxtbox.Text = item.SubItems[4].Text.Replace("[/L]", "");
                            string shadow = "";
                            for (int i = temptxtbox.Lines.Length - 1; i >= 0; i--)//باید برعکس بریزمش چون تو برنامه برعکس نوشتم که درست دیده شه
                                shadow += temptxtbox.Lines[i] + Environment.NewLine;
                            subtitle_lbl.Text = shadow;
                            focusedinx = item.Index;//اگه بدون ایندکس شرط الس آخری رو بذارم رو عناصر قبل از زیرنویس فعلی همه لیبل رو خالی میکنه که باعث چشمک زدن میشه با استفاده از این مشکل حل شد ودرست به موقع نمایش میده
                        }
                        else
                        {
                            subtitle_lbl.Text = item.SubItems[3].Text;
                            focusedinx = item.Index;
                        }
                        subtitle_lbl.Left = axWindowsMediaPlayer1.Width / 2 - subtitle_lbl.Width / 2;
                        subtitle_lbl.Location = new Point(subtitle_lbl.Location.X, (axWindowsMediaPlayer1.Height - subtitle_lbl.Height - 70));
                    }
                    else if (item.Index == focusedinx && eTime.TotalMilliseconds <= CurrentTime.TotalMilliseconds)//اگه اینکارو نمیکردم زیرنویس چشمک میزد چون تایم های قبلی رو هم با دستور فورایچ چک میکنه و وقتی غلط بشه میره رو الس ،برای درست کردن مشکل نشون دادن ساب وقتی با موس میرم رو یه جای دیگه ای از فیلم تو رویداد کارنت چنج سای رو خالی کردم
                    {
                        subtitle_lbl.Text = "";
                        focusedinx = -1;
                    }
                }
            }
        }


        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            //(نمایش مدت فیلم(چون میخواستم زمان دستورات تایمر رو کم کنم اینو انداختم اینجا که اونا بهتر اجرا شن
            TimeSpan t = TimeSpan.FromSeconds(axWindowsMediaPlayer1.currentMedia.duration);
            time_lblD.Text = String.Format("{0:00}:{1:00}:{2:00},{3:000}", t.Hours, t.Minutes, t.Seconds, t.Milliseconds);

        }

        internal string GetFromResources(string resourceName)
        {
            Assembly assem = this.GetType().Assembly;
            using (Stream stream = assem.GetManifestResourceStream(resourceName))
            {
                using (var reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        List<string> Dic_List = new List<string>();
        private void MainForm_Load(object sender, EventArgs e)
        {
            //splitContainer1.Panel1.Controls.Add(tabControl1);
            //Load Dic Resourse
            Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Subtrans.DicResource.txt");
            StreamReader reader = new StreamReader(stream);
            while (!reader.EndOfStream)
                Dic_List.Add(reader.ReadLine());

            //4000 تا کلمه مشکل دارن که باید معنی شن  
            for (int d = 1; d < Dic_List.Count; d += 2)
                if (Dic_List[d].Contains("="))
                    Dic_List[d] = "Not Found";
            //setting
            axWindowsMediaPlayer1.stretchToFit = true;
            Seccond_cmbBox.Items.Add("1");
            Seccond_cmbBox.Items.Add("3");
            Seccond_cmbBox.Items.Add("5");
            Seccond_cmbBox.Items.Add("7");
            Seccond_cmbBox.Items.Add("10");
            Seccond_cmbBox.Items.Add("30");
            Seccond_cmbBox.Items.Add("60");
            Seccond_cmbBox.Items.Add("90");
            Seccond_cmbBox.Items.Add("120");
            Seccond_cmbBox.SelectedIndex = 2;

            //Load ini Setting
            if (File.Exists(Application.StartupPath + "\\Subtrans.ini"))
            {
                //Psconf.ini
                StreamReader Psconf_ini_Reader = new StreamReader(Application.StartupPath + "\\Psconf.ini");
                string psconfvalue;
                psconfvalue = Psconf_ini_Reader.ReadToEnd();

                if (psconfvalue.Trim() == "1")
                {
                    persianSupportToolStripMenuItem.Checked = true;
                    TranslationBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                    PSIE_D_lbl.ForeColor = Color.Green;
                    if (englishToolStripMenuItem.Checked == true)
                        PSIE_D_lbl.Text = "Persian Support is Enabled";
                    else
                        PSIE_D_lbl.Text = "پشتیبانی از فارسی فعال است";
                }
                else if (psconfvalue.Trim() == "0")
                {
                    persianSupportToolStripMenuItem.Checked = false;
                    TranslationBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
                    PSIE_D_lbl.ForeColor = Color.Red;
                    if (englishToolStripMenuItem.Checked == true)
                        PSIE_D_lbl.Text = "Persian Support is Disabled";
                    else
                        PSIE_D_lbl.Text = "پشتیبانی از فارسی غیرفعال است";
                }
                //SubTrans.ini
                StreamReader Subtrans_ini_Reader = new StreamReader(Application.StartupPath + "\\SubTrans.ini");
                ListBox ReadSetting_lstbox = new ListBox();
                while (!Subtrans_ini_Reader.EndOfStream)
                {
                    ReadSetting_lstbox.Items.Add(Subtrans_ini_Reader.ReadLine());
                }
                Subtrans_ini_Reader.Close();

                ListBox lstbox_ready = new ListBox();
                for (int i = 0; i < ReadSetting_lstbox.Items.Count; i++)
                {
                    string[] splite = ReadSetting_lstbox.Items[i].ToString().Split(':');
                    if (splite[0] == "fullscreen")
                    {
                        if (splite[1] == "1")
                            this.WindowState = FormWindowState.Maximized;
                    }

                    else if (splite[0] == "volume")
                    {
                        axWindowsMediaPlayer1.settings.volume = Convert.ToInt32(splite[1]);
                    }

                    else if (splite[0] == "language")
                    {
                        if (splite[1] == "0")
                        {
                            englishToolStripMenuItem.Checked = true;
                            persianToolStripMenuItem.Checked = false;
                            English_lng();
                        }
                        else if (splite[1] == "1")
                        {
                            persianToolStripMenuItem.Checked = true;
                            englishToolStripMenuItem.Checked = false;
                            Persian_lng();
                        }

                    }

                    else if (splite[0] == "play_movie")
                    {
                        if (splite[1] == "1")
                            AutoMove_chkBox.Checked = true;
                        else if (splite[1] == "0")
                            AutoMove_chkBox.Checked = false;
                    }

                    else if (splite[0] == "play_select")
                    {
                        if (splite[1] == "1")
                            PlaySeccond_rdobtn.Checked = true;
                        else if (splite[1] == "0")
                            PlaySubtitle_rdobtn.Checked = true;
                    }
                    else if(splite[0]=="donotplay")
                    {
                        if (splite[1] == "1")
                            DonotPlay_rdobtn.Checked = true;
                        else if (splite[1] == "0")
                            DonotPlay_rdobtn.Checked = false;
                    }

                    else if (splite[0] == "play_second")//index ro moghe khoroj zakhire kon
                    {
                        Seccond_cmbBox.SelectedIndex = Convert.ToInt32(splite[1]);
                    }

                    else if (splite[0] == "save_translation")
                    {
                        if (splite[1] == "1")
                            SaveTranslation_chkBox.Checked = true;
                        else if (splite[1] == "0")
                            SaveTranslation_chkBox.Checked = false;
                    }

                    else if (splite[0] == "mode")
                    {
                        if (splite[1] == "0")
                            Movie_On_Top();
                        else if (splite[1] == "1")
                            Movie_On_Left();
                        else if (splite[1] == "2")
                            Movie_On_Right();
                        else if (splite[1] == "3")
                            Movie_Off();
                    }

                    else if (splite[0] == "viewsub")
                    {
                        if (splite[1] == "0")
                        {
                            Show_originalToolStripMenuItem.Checked = true;
                            Show_translateToolStripMenuItem.Checked = false;
                        }
                        else if (splite[1] == "1")
                        {
                            Show_originalToolStripMenuItem.Checked = false;
                            Show_translateToolStripMenuItem.Checked = true;
                        }
                    }

                    else if (splite[0] == "timer")
                    {
                        if (splite[1] == "0")
                        {
                            btn_d2_Down.Enabled = false;
                            btn_n2_Down.Enabled = false;
                            btn_s2_Down.Enabled = false;
                            btn_h2_Down.Enabled = false;

                            btn_d2_up.Enabled = false;
                            btn_n2_up.Enabled = false;
                            btn_s2_up.Enabled = false;
                            btn_h2_up.Enabled = false;

                            Time20.Enabled = false;
                            Time21.Enabled = false;
                            Time22.Enabled = false;
                            Time23.Enabled = false;

                            Hide_lbl.Enabled = false;

                            btn_n3_Down.Enabled = true;
                            btn_n3_up.Enabled = true;
                            Duration_lbl.Enabled = true;
                            Time33.Enabled = true;
                        }
                        else if (splite[1] == "1")
                        {
                            btn_n3_Down.Enabled = false;
                            btn_n3_up.Enabled = false;
                            Duration_lbl.Enabled = false;
                            Time33.Enabled = false;

                            btn_d2_Down.Enabled = true;
                            btn_n2_Down.Enabled = true;
                            btn_s2_Down.Enabled = true;
                            btn_h2_Down.Enabled = true;

                            btn_d2_up.Enabled = true;
                            btn_n2_up.Enabled = true;
                            btn_s2_up.Enabled = true;
                            btn_h2_up.Enabled = true;

                            Time20.Enabled = true;
                            Time21.Enabled = true;
                            Time22.Enabled = true;
                            Time23.Enabled = true;

                            Hide_lbl.Enabled = true;
                        }
                        else if (splite[1] == "2")
                        {
                            btn_d2_Down.Enabled = true;
                            btn_n2_Down.Enabled = true;
                            btn_s2_Down.Enabled = true;
                            btn_h2_Down.Enabled = true;

                            btn_d2_up.Enabled = true;
                            btn_n2_up.Enabled = true;
                            btn_s2_up.Enabled = true;
                            btn_h2_up.Enabled = true;

                            Time20.Enabled = true;
                            Time21.Enabled = true;
                            Time22.Enabled = true;
                            Time23.Enabled = true;

                            Hide_lbl.Enabled = true;

                            btn_n3_Down.Enabled = true;
                            btn_n3_up.Enabled = true;
                            Duration_lbl.Enabled = true;
                            Time33.Enabled = true;
                        }
                    }

                    else if (splite[0] == "subtitle_font")
                    {
                        TypeConverter converter = TypeDescriptor.GetConverter(typeof(Font));
                        Font subtitle_savedfont = (Font)converter.ConvertFromString(splite[1]);
                        subtitle_lbl.Font = subtitle_savedfont;
                    }
                    else if (splite[0] == "Source/original_font")
                    {
                        TypeConverter converter = TypeDescriptor.GetConverter(typeof(Font));
                        Font translate_original_savedfont = (Font)converter.ConvertFromString(splite[1]);
                        //listView1.Font = other_savedfont;
                        TranslationBox.Font = translate_original_savedfont;
                        EntextBox.Font = translate_original_savedfont;
                    }
                    else if (splite[0] == "subtitle_color")
                    {
                        TypeConverter converter_color = TypeDescriptor.GetConverter(typeof(Color));
                        Color subtitle_savedcolor = (Color)converter_color.ConvertFromString(splite[1]);
                        subtitle_lbl.ForeColor = subtitle_savedcolor;
                    }
                    else if (splite[0] == "Source/original_color")
                    {
                        TypeConverter converter_color = TypeDescriptor.GetConverter(typeof(Color));
                        Color translate_original_savedcolor = (Color)converter_color.ConvertFromString(splite[1]);
                        TranslationBox.ForeColor = translate_original_savedcolor;
                        EntextBox.ForeColor = translate_original_savedcolor;
                        //listView1.ForeColor = other_savedcolor;
                    }
                }
            }
            if (!File.Exists(Application.StartupPath + "\\Psconf.ini"))
            {
                StreamWriter SaveIntoPsconf = new StreamWriter(Application.StartupPath + "\\Psconf.ini");
                SaveIntoPsconf.Write("1");
                SaveIntoPsconf.Close();
            }
            Subtitle_listView.Focus();
        }
        private void Add_After_into_ListView()
        {
            if (Subtitle_listView.Items.Count > 0)
            {
                History(-1, Subtitle_listView.FocusedItem.Index);//-1 yani yedoone bayad az list kam beshe choon inja yedoone ezafe mishe

                int fitem = Subtitle_listView.FocusedItem.Index + 1;
                Subtitle_listView.Items.Insert(fitem, "");

                //Show 1 mil after
                TimeSpan _1milAfter = new TimeSpan(0, Convert.ToInt32(Time20.Text), Convert.ToInt32(Time21.Text), Convert.ToInt32(Time22.Text), Convert.ToInt32(Time23.Text));
                Double _1minShow = _1milAfter.TotalSeconds + 0.001;
                TimeSpan show = TimeSpan.FromSeconds(_1minShow);
                Subtitle_listView.Items[fitem].SubItems.Add(String.Format("{0:00}:{1:00}:{2:00},{3:000}", show.Hours, show.Minutes, show.Seconds, show.Milliseconds));

                //Hide 1second after Show
                _1minShow += 1;
                TimeSpan hide = TimeSpan.FromSeconds(_1minShow);
                Subtitle_listView.Items[fitem].SubItems.Add(String.Format("{0:00}:{1:00}:{2:00},{3:000}", hide.Hours, hide.Minutes, hide.Seconds, hide.Milliseconds));

                Subtitle_listView.Items[fitem].SubItems.Add("- Untranslated -");
                Subtitle_listView.Items[fitem].SubItems.Add("- ترجمه نشده -");
                int j = 1;
                for (int i = 0; i < Subtitle_listView.Items.Count; i++)
                {
                    Subtitle_listView.Items[i].SubItems[0].Text = j.ToString();
                    j++;
                }
                lvs += 1;
                IndexChange();




            }
        }

        private void Add_Befor_into_ListView()
        {
            if (Subtitle_listView.Items.Count > 0)
            {
                History(-2, Subtitle_listView.FocusedItem.Index);
                int fitem = Subtitle_listView.FocusedItem.Index;
                Subtitle_listView.Items.Insert(fitem, "");

                if (Subtitle_listView.FocusedItem.Index == 1)
                {
                    Subtitle_listView.Items[fitem].SubItems.Add("00:00:00,000");
                    Subtitle_listView.Items[fitem].SubItems.Add("00:00:00,000");
                    Subtitle_listView.Items[fitem].SubItems.Add("- Untranslated -");
                    Subtitle_listView.Items[fitem].SubItems.Add("- ترجمه نشده -");
                    int j = 1;
                    for (int i = 0; i < Subtitle_listView.Items.Count; i++)
                    {
                        Subtitle_listView.Items[i].SubItems[0].Text = j.ToString();
                        j++;
                    }
                    lvs += 1;
                    IndexChange();
                }
                else
                {
                    TimeSpan _1milAfter = new TimeSpan(0, Convert.ToInt32(Time10.Text), Convert.ToInt32(Time11.Text), Convert.ToInt32(Time12.Text), Convert.ToInt32(Time13.Text));
                    Double _1minShow = _1milAfter.TotalSeconds - 1.001;
                    TimeSpan show = TimeSpan.FromSeconds(_1minShow);
                    Subtitle_listView.Items[fitem].SubItems.Add(String.Format("{0:00}:{1:00}:{2:00},{3:000}", show.Hours, show.Minutes, show.Seconds, show.Milliseconds));

                    //Hide 1second after Show
                    _1minShow += 1;
                    TimeSpan hide = TimeSpan.FromSeconds(_1minShow);
                    Subtitle_listView.Items[fitem].SubItems.Add(String.Format("{0:00}:{1:00}:{2:00},{3:000}", hide.Hours, hide.Minutes, hide.Seconds, hide.Milliseconds));
                    Subtitle_listView.Items[fitem].SubItems.Add("- Untranslated -");
                    Subtitle_listView.Items[fitem].SubItems.Add("- ترجمه نشده -");
                    int j = 1;
                    for (int i = 0; i < Subtitle_listView.Items.Count; i++)
                    {
                        Subtitle_listView.Items[i].SubItems[0].Text = j.ToString();
                        j++;
                    }
                    lvs += 1;
                    IndexChange();
                }
            }
        }

        private void Delete_From_ListView()
        {
            if (Subtitle_listView.Items.Count > 1)//خط آخرو پاک نمیکنه
            {
                DialogResult Result_exit;
                if (englishToolStripMenuItem.Checked == true)
                    Result_exit = MessageBox.Show("Are You Sure?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                else
                    Result_exit = MessageBox.Show("آیا اطمینان دارید؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (Result_exit == DialogResult.Yes)
                {
                    History(Subtitle_listView.SelectedItems.Count, Subtitle_listView.FocusedItem.Index);//tedadi ke select shode ya 1 doonas ya har chand ta ke bashe
                    foreach (ListViewItem item in Subtitle_listView.SelectedItems)
                    {
                        Subtitle_listView.Items.Remove(item);
                    }
                    int j = 1;
                    for (int i = 0; i < Subtitle_listView.Items.Count; i++)
                    {
                        Subtitle_listView.Items[i].SubItems[0].Text = j.ToString();
                        j++;
                    }
                    lvs += 1;
                }

                IndexChange();

            }
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.PageDown || e.Shift && e.KeyCode == Keys.Enter || e.KeyCode == Keys.F12)
            {
                keydown();
                SaveTranslationOnKeyDown();
                e.SuppressKeyPress = true;
            }

            if (e.KeyCode == Keys.PageUp || e.Control && e.KeyCode == Keys.Enter || e.KeyCode == Keys.F1)
            {
                keyup();
                e.SuppressKeyPress = true;
            }

            if (e.Shift && e.Control && e.KeyCode == Keys.Insert)
            {
                Add_onlyinto_Translation();
                e.SuppressKeyPress = true;
            }

            else if (e.Shift && e.Control && e.KeyCode == Keys.Delete)
            {
                Del_Onlyfrom_Translation();
                e.SuppressKeyPress = true;
            }

            else if (e.Shift && e.KeyCode == Keys.Insert)
            {
                Add_Befor_into_ListView();
                e.SuppressKeyPress = true;
            }

            else if (e.KeyCode == Keys.Insert)
            {
                Add_After_into_ListView();
                e.SuppressKeyPress = true;
            }

            else if (e.KeyCode == Keys.Delete)
            {
                Delete_From_ListView();
                e.SuppressKeyPress = true;
            }

            else if (e.KeyCode == Keys.Space)
            {
                if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
                    axWindowsMediaPlayer1.Ctlcontrols.pause();
                else
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                e.SuppressKeyPress = true;
            }
        }

        int lvs = 1;
        public void IndexChange()
        {
            if (Subtitle_listView.SelectedItems.Count == 1)
            {
                if (Subtitle_listView.FocusedItem.Index < 0)//نزاری موقع ور رفتن بالیست یهو ارور میده به خصوص دلیت پشت سر هم
                    lvs = 1;
                if (lvs > Subtitle_listView.Items.Count)
                    lvs = Subtitle_listView.Items.Count - 1;
                //برای خاکستری کردن از رویداد هاید سلکشن خودش استفاده کردم این دستورم اونو میبرش خط بعد
                Subtitle_listView.Items[Subtitle_listView.FocusedItem.Index].Selected = true;
                lvs = Subtitle_listView.FocusedItem.Index;
                EntextBox.Text = Subtitle_listView.FocusedItem.SubItems[3].Text;// ریختن در کادر تکست

                //correct
                if (persianSupportToolStripMenuItem.Checked == true)
                {
                    //این خط جلوی خراب شدن جمله رو گرفت
                    string[] array = Subtitle_listView.FocusedItem.SubItems[4].Text.Replace("[/L]", Environment.NewLine).Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = RTLCorrection.Correction(array[i]);
                    }
                    Array.Reverse(array);
                    TranslationBox.Text = string.Join(Environment.NewLine, array);//add into translationbox
                }
                else
                {
                    string[] array = Subtitle_listView.FocusedItem.SubItems[4].Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                    TranslationBox.Text = string.Join(Environment.NewLine, array);
                }
                //
                CurrentLine_lbl.Text = "Line: " + (Subtitle_listView.FocusedItem.Index + 1 + "/" + Subtitle_listView.Items.Count).ToString();
                //Timer
                string[] az = Subtitle_listView.FocusedItem.SubItems[1].Text.Split(':', ',');
                Time10.Text = az[0];
                Time11.Text = az[1];
                Time12.Text = az[2];
                Time13.Text = az[3];
                string[] ta = Subtitle_listView.FocusedItem.SubItems[2].Text.Split(':', ',');
                Time20.Text = ta[0];
                Time21.Text = ta[1];
                Time22.Text = ta[2];
                Time23.Text = ta[3];
                //--مدت--
                TimeSpan start_time = new TimeSpan(0, Convert.ToInt32(Time10.Text), Convert.ToInt32(Time11.Text), Convert.ToInt32(Time12.Text), Convert.ToInt32(Time13.Text));
                double st = start_time.TotalSeconds;

                TimeSpan end_time = new TimeSpan(0, Convert.ToInt32(Time20.Text), Convert.ToInt32(Time21.Text), Convert.ToInt32(Time22.Text), Convert.ToInt32(Time23.Text));
                double et = end_time.TotalSeconds;

                double st_et = et - st;

                string[] split = Math.Round(st_et, 4).ToString().Split('.');
                if (split.Length > 1)
                {
                    if (split[1].Length == 1)
                        Time33.Text = Math.Round(st_et, 4).ToString() + "00";
                    else if (split[1].Length == 2)
                        Time33.Text = Math.Round(st_et, 4).ToString() + "0";
                    else
                        Time33.Text = Math.Round(st_et, 4).ToString();//وقتی با دست تایپ کرده باشه
                }
                else
                    Time33.Text = Math.Round(st_et, 4).ToString();

                if (Math.Round(st_et, 4) > 0)
                    Time33.BackColor = Color.White;
                else
                    Time33.BackColor = Color.Red;

                //faghat agar rooye pakhsh list dictionary bood updatesh mikone
                if (showDicToolStripMenuItem.Checked)
                {
                    GenerateDicForDiclistview();
                }

            }

        }

        private void TranslationBox_TextChanged(object sender, EventArgs e)
        {
            //TranslationBox.ClearUndo();//اگه فعال باشه با آندو من تداخل پیدا میکنه این دستور خالی یا همون غیر فعالش میکنه

            if (Subtitle_listView.Items.Count > 0)
            {
                if (persianSupportToolStripMenuItem.Checked == true)
                {
                    string[] array = TranslationBox.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = RTLCorrection.Correction(array[i]);
                    }
                    Array.Reverse(array);
                    Subtitle_listView.FocusedItem.SubItems[4].Text = string.Join("[/L]" + Environment.NewLine, array);
                }
                else
                {
                    string[] array = TranslationBox.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                    Subtitle_listView.FocusedItem.SubItems[4].Text = string.Join(Environment.NewLine + "[/L]", array);
                }
                if (TranslationBox.Text == "- ترجمه نشده -")
                    TranslationBox.Text = "";
                else if (TranslationBox.Text == "")
                    Subtitle_listView.FocusedItem.SubItems[4].Text = "- ترجمه نشده -";
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.URL != "")//اگه فیلم لو نکرده بود دیگه تایم رو نشون نده
            {
                //تبدیل زمان ها به ثانیه با صدم
                TimeSpan ConvertTime = new TimeSpan(0, Convert.ToInt32(Time10.Text), Convert.ToInt32(Time11.Text), Convert.ToInt32(Time12.Text), Convert.ToInt32(Time13.Text));
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition = ConvertTime.TotalSeconds;
                time_lbln.Text = Time10.Text + ":" + Time11.Text + ":" + Time12.Text + "," + Time13.Text;
            }
        }

        private void axWindowsMediaPlayer1_DoubleClickEvent(object sender, AxWMPLib._WMPOCXEvents_DoubleClickEvent e)
        {
            if (axWindowsMediaPlayer1.fullScreen == true)
                axWindowsMediaPlayer1.fullScreen = false;
        }
        private void TranslationBox_Enter(object sender, EventArgs e)
        {
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {

                if (lang.LayoutName == "Farsi" || lang.LayoutName == "Persian")
                    InputLanguage.CurrentInputLanguage = lang;
            }

        }

        private void TranslationBox_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {

                if (lang.LayoutName == "Farsi" || lang.LayoutName == "Persian")
                    InputLanguage.CurrentInputLanguage = lang;
            }

        }

        private void EntextBox_Click(object sender, EventArgs e)
        {
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                if (lang.LayoutName == "US" || lang.LayoutName == "English" || lang.LayoutName == "EN")
                    InputLanguage.CurrentInputLanguage = lang;
            }
        }

        private void EntextBox_Enter(object sender, EventArgs e)
        {
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                if (lang.LayoutName == "US" || lang.LayoutName == "English" || lang.LayoutName == "EN")
                    InputLanguage.CurrentInputLanguage = lang;
            }
        }
        private void keydown()
        {
            if (Subtitle_listView.FocusedItem.Index + 1 < Subtitle_listView.Items.Count)
            {
                int savecurrentindex = Subtitle_listView.FocusedItem.Index + 1;
                Subtitle_listView.SelectedItems.Clear();
                Subtitle_listView.Items[savecurrentindex].Selected = true;
                Subtitle_listView.Items[savecurrentindex].Focused = true;
                IndexChange();
                Subtitle_listView.FocusedItem.EnsureVisible();
            }
            if (AutoMove_chkBox.Checked && axWindowsMediaPlayer1.URL != "" && !splitContainer1.Panel1Collapsed && !splitContainer1.Panel2Collapsed)//در حالت مووی آف دیگه این کارو نمیکنه
            {
                if (Subtitle_listView.Items.Count > 0)
                {
                    if (!DonotPlay_rdobtn.Checked)
                    {
                        TimeSpan ConvertTime = new TimeSpan(0, Convert.ToInt32(Time10.Text), Convert.ToInt32(Time11.Text), Convert.ToInt32(Time12.Text), Convert.ToInt32(Time13.Text));
                        axWindowsMediaPlayer1.Ctlcontrols.currentPosition = ConvertTime.TotalSeconds;
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        if (PlaySeccond_rdobtn.Checked)
                            SubtitleSeccondTimer.Start();
                        else if (PlaySubtitle_rdobtn.Checked)
                            SubtitlePlayTimer.Start();
                    }
                    else
                    {
                        TimeSpan ConvertTime = new TimeSpan(0, Convert.ToInt32(Time10.Text), Convert.ToInt32(Time11.Text), Convert.ToInt32(Time12.Text), Convert.ToInt32(Time13.Text));
                        axWindowsMediaPlayer1.Ctlcontrols.currentPosition = ConvertTime.TotalSeconds;
                        time_lbln.Text = Time10.Text + ":" + Time11.Text + ":" + Time12.Text + "," + Time13.Text;
                        axWindowsMediaPlayer1.Ctlcontrols.pause();
                    }
                }
              
            }
        }

        private void keyup()
        {
            if (Subtitle_listView.Items.Count > 0)
            {
                if (Subtitle_listView.FocusedItem.Index - 1 >= 0)//خط قبلی
                {
                    int savecurrentindex = Subtitle_listView.FocusedItem.Index - 1;
                    Subtitle_listView.SelectedItems.Clear();
                    Subtitle_listView.Items[savecurrentindex].Selected = true;
                    Subtitle_listView.Items[savecurrentindex].Focused = true;
                    IndexChange();
                    Subtitle_listView.FocusedItem.EnsureVisible();
                }
                if (AutoMove_chkBox.Checked && axWindowsMediaPlayer1.URL != "" && !splitContainer1.Panel1Collapsed && !splitContainer1.Panel2Collapsed)//در حالت مووی آف دیگه این کارو نمیکنه
                {
                    if (!DonotPlay_rdobtn.Checked)
                    {
                        TimeSpan ConvertTime = new TimeSpan(0, Convert.ToInt32(Time10.Text), Convert.ToInt32(Time11.Text), Convert.ToInt32(Time12.Text), Convert.ToInt32(Time13.Text));
                        axWindowsMediaPlayer1.Ctlcontrols.currentPosition = ConvertTime.TotalSeconds;
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        if (PlaySeccond_rdobtn.Checked)
                            SubtitleSeccondTimer.Start();
                        else if (PlaySubtitle_rdobtn.Checked)
                            SubtitlePlayTimer.Start();
                    }
                    else
                    {
                        TimeSpan ConvertTime = new TimeSpan(0, Convert.ToInt32(Time10.Text), Convert.ToInt32(Time11.Text), Convert.ToInt32(Time12.Text), Convert.ToInt32(Time13.Text));
                        axWindowsMediaPlayer1.Ctlcontrols.currentPosition = ConvertTime.TotalSeconds;

                        time_lbln.Text = Time10.Text + ":" + Time11.Text + ":" + Time12.Text + "," + Time13.Text;
                        axWindowsMediaPlayer1.Ctlcontrols.pause();
                    }
                }
            }
        }
        private void SaveTranslationOnKeyDown()
        {
            if (SaveTranslation_chkBox.Checked)
            {
                if (Auto_save_trans == null)
                {
                    if (englishToolStripMenuItem.Checked)
                        MessageBox.Show("'Save Translation' is on ,Please choose where you want to save the translation. (You Can Change it From File-> Save As-> Translation As)");
                    else
                        MessageBox.Show("ذخیره ترجمه فعال است، لطفا محل ذخیره سازی ترجمه را مشخص کنید. شما میتوانید از مسیر فایل-> ذخیره در-> ترجمه در، این آدرس را تعویض نمایید");
                    Save_As_Translate();
                }
                else
                    Save_Translate();
            }
        }
        private void TranslationBox_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.PageDown || e.Shift && e.KeyCode == Keys.Enter || e.KeyCode == Keys.F12)
                {
                    keydown();
                    SaveTranslationOnKeyDown();
                    e.SuppressKeyPress = true;
                }

                if (e.KeyCode == Keys.PageUp || e.Control && e.KeyCode == Keys.Enter || e.KeyCode == Keys.F1)
                {
                    keyup();
                    e.SuppressKeyPress = true;
                }
        }

        private void subtitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog sub_font = new FontDialog();
            sub_font.Font = subtitle_lbl.Font;
            sub_font.Color = subtitle_lbl.ForeColor;
            sub_font.ShowColor = true;
            if (sub_font.ShowDialog() == DialogResult.OK)
            {
                subtitle_lbl.Font = sub_font.Font;
                subtitle_lbl.ForeColor = sub_font.Color;
                subtitle_lbl.Left = axWindowsMediaPlayer1.Width / 2 - subtitle_lbl.Width / 2;
                subtitle_lbl.Location = new Point(subtitle_lbl.Location.X, (axWindowsMediaPlayer1.Height - subtitle_lbl.Height - 70));
            }
        }

        private void OthersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog OT_font = new FontDialog();
            OT_font.ShowColor = true;
            OT_font.Font = TranslationBox.Font;
            OT_font.Color = TranslationBox.ForeColor;
            if (OT_font.ShowDialog() == DialogResult.OK)
            {
                EntextBox.Font = OT_font.Font;
                EntextBox.ForeColor = OT_font.Color;
                TranslationBox.Font = OT_font.Font;
                TranslationBox.ForeColor = OT_font.Color;
            }
        }

        private void Open_translation_Sub__Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenDialogFrm = new OpenFileDialog();
            OpenDialogFrm.Filter = "Text Files (*.txt)|*.txt|SubRip (*.srt) |*.srt|All File|*.*";
            OpenDialogFrm.FilterIndex = 2;
            OpenDialogFrm.Title = "Open Translated Subtitle";
            if (OpenDialogFrm.ShowDialog() == DialogResult.OK)
            {
                string OpenedFileLocation = OpenDialogFrm.FileName;

                List<string> addtxttolstbox = new List<string>();
                StreamReader ReadSubFromHDD = new StreamReader(OpenDialogFrm.FileName, Encoding.Default);
                while (!ReadSubFromHDD.EndOfStream)
                {
                    addtxttolstbox.Add(ReadSubFromHDD.ReadLine());//ریختن زیرنویس در لیست باکس
                }
                addtxttolstbox.Add("0");//اگه نمیزاشتم اگر خط آخر چند خطی می بود فقط یه خطشو اد میکرد
                int EncoderItemsLineCount = addtxttolstbox.Count;
                int k = 0;

                bool isasrtfile = false;
                for (int i = 0; i < 50; i++)
                {
                    if (addtxttolstbox[i].ToString().Trim().Contains("-->"))
                    {
                        isasrtfile = true;
                        break;
                    }
                }
                if (isasrtfile)
                {
                    for (int i = 0; i < EncoderItemsLineCount; i++)
                    {
                        if (addtxttolstbox[i].ToString().Contains("-->"))
                        {
                            tk = null;

                            for (int f = 1; i + f + 1 < EncoderItemsLineCount && !addtxttolstbox[i + f + 1].ToString().Contains("-->"); f++)//چون رو خط تایمر شرط گذاشتم خطهای شماره و خالی قبلشون هم لود میشن
                                tk += addtxttolstbox[i + f].ToString() + Environment.NewLine;

                            if (k >= Subtitle_listView.Items.Count)
                            {
                                k++;//اینو نزاری یه بار شماره رو تکراری میندازه
                                string[] split = addtxttolstbox[i].ToString().Split(new Char[] { ' ' });//جدا کردن تایم نمایش و عدم نمایش 0 از 2 تا
                                ListViewItem x = Subtitle_listView.Items.Add(k.ToString());
                                x.SubItems.Add(split[0]);
                                x.SubItems.Add(split[2]);
                                x.SubItems.Add("");

                                //correct
                                string[] array = tk.TrimEnd().Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

                                for (int s = 0; s < array.Length; s++)
                                    array[s] = array[s];
                                Array.Reverse(array);
                                tk = string.Join(Environment.NewLine + "[/L]", array);//add into translationvox
                                x.SubItems.Add(tk);
                            }
                            else
                            {
                                if (tk != null)//اگه بین تایمرا چیزی نباشه وبه هم چسبیده باشن اینوطری ارور نمیده و تایمرو بدون متن اد میکنه
                                {
                                    //correct
                                    string[] array = tk.TrimEnd().Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

                                    for (int s = 0; s < array.Length; s++)
                                        array[s] = array[s];
                                    Array.Reverse(array);
                                    tk = string.Join(Environment.NewLine + "[/L]", array);//add into translationbox
                                    Subtitle_listView.Items[k].SubItems[4].Text = tk;
                                }
                                else
                                    Subtitle_listView.Items[k].SubItems[4].Text = "- ترجمه نشده -";

                                k++;
                            }
                        }
                    }
                    ReadSubFromHDD.Close();
                    addtxttolstbox.Clear();
                    IndexChange();
                    SaveForPrompt();
                }
                else
                    MessageBox.Show("[" + OpenDialogFrm.FileName + "]" + " is a invalid file!", "Open translation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_Translate()
        {
            StreamWriter sw = new StreamWriter(Auto_save_trans, false, Encoding.Default);
            foreach (ListViewItem item in Subtitle_listView.Items)
            {
                TextBox savetxtbox = new TextBox();
                TextBox temptxtbox = new TextBox();
                temptxtbox.Text = item.SubItems[4].Text.Replace("[/L]", "");//علامت خط بعد رو برمیداریم

                if (persianSupportToolStripMenuItem.Checked == true)
                {
                    for (int i = temptxtbox.Lines.Length - 1; i >= 0; i--)//باید برعکس بریزمش چون تو برنامه برعکس نوشتم که خوبتر دیده شه
                    {
                        savetxtbox.Text += temptxtbox.Lines[i] + Environment.NewLine;
                    }
                }
                else
                    savetxtbox.Text = temptxtbox.Text + Environment.NewLine;//عادی میریزه اگه پشتیبانی از فارسی غیر فعال باشه

                sw.WriteLine(item.SubItems[0].Text + Environment.NewLine + item.SubItems[1].Text + " --> " + item.SubItems[2].Text + Environment.NewLine + savetxtbox.Text);
                translationToolStripMenuItem1.Enabled = true;
            }
            sw.Close();
            SaveForPrompt();
        }

        string Auto_save_trans = null;
        private void translationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Auto_save_trans != null)
                Save_Translate();
            else
                Save_As_Translate();
        }

        private void Save_As_Translate()
        {
            SaveFileDialog SaveDialogFrm = new SaveFileDialog();
            SaveDialogFrm.Title = "Saving Translated Subtitle";
            SaveDialogFrm.Filter = "Text Files |*.txt|SubRip |*.srt";
            SaveDialogFrm.FilterIndex = 2;
            SaveDialogFrm.OverwritePrompt = true;
            SaveDialogFrm.DefaultExt = "srt";
            if (SaveDialogFrm.ShowDialog() == DialogResult.OK)
            {
                string SavedFileLocation = SaveDialogFrm.FileName;
                Auto_save_trans = SaveDialogFrm.FileName;
                StreamWriter sw = new StreamWriter(SavedFileLocation, false, Encoding.Default);

                foreach (ListViewItem item in Subtitle_listView.Items)
                {
                    TextBox savetxtbox = new TextBox();
                    TextBox temptxtbox = new TextBox();
                    temptxtbox.Text = item.SubItems[4].Text.Replace("[/L]", "");//علامت خط بعد رو برمیداریم
                    if (persianSupportToolStripMenuItem.Checked == true)
                    {
                        for (int i = temptxtbox.Lines.Length - 1; i >= 0; i--)//باید برعکس بریزمش چون تو برنامه برعکس نوشتم که خوبتر دیده شه
                        {
                            savetxtbox.Text += temptxtbox.Lines[i] + Environment.NewLine;
                        }
                    }
                    else
                        savetxtbox.Text = temptxtbox.Text + Environment.NewLine;//عادی میریزه اگه پشتیبانی از فارسی غیر فعال باشه
                    sw.WriteLine(item.SubItems[0].Text + Environment.NewLine + item.SubItems[1].Text + " --> " + item.SubItems[2].Text + Environment.NewLine + savetxtbox.Text);
                    translationToolStripMenuItem1.Enabled = true;
                }
                sw.Close();
                SaveForPrompt();
            }
        }

        string Auto_save_Original = null;
        private void save_translate_AS_menu_Click(object sender, EventArgs e)
        {
            Save_As_Translate();
        }

        private void Save_Original()
        {
            StreamWriter sw = new StreamWriter(Auto_save_Original, false, Encoding.Default);
            foreach (ListViewItem item in Subtitle_listView.Items)
            {
                sw.WriteLine(item.SubItems[0].Text + Environment.NewLine + item.SubItems[1].Text + " --> " + item.SubItems[2].Text + Environment.NewLine + item.SubItems[3].Text + Environment.NewLine);
            }
            sw.Close();
            SaveForPrompt();
        }

        private void Save_As_Original()
        {
            SaveFileDialog SaveDialogFrm = new SaveFileDialog();
            SaveDialogFrm.Title = "Saving Original Subtitle";
            SaveDialogFrm.Filter = "Text Files |*.txt|SubRip |*.srt";
            SaveDialogFrm.FilterIndex = 2;
            SaveDialogFrm.OverwritePrompt = true;
            SaveDialogFrm.DefaultExt = "srt";

            if (SaveDialogFrm.ShowDialog() == DialogResult.OK)
            {

                string SavedFileLocation = SaveDialogFrm.FileName;
                Auto_save_Original = SaveDialogFrm.FileName;
                StreamWriter sw = new StreamWriter(SavedFileLocation, false, Encoding.Default);
                foreach (ListViewItem item in Subtitle_listView.Items)
                {
                    sw.WriteLine(item.SubItems[0].Text + Environment.NewLine + item.SubItems[1].Text + " --> " + item.SubItems[2].Text + Environment.NewLine + item.SubItems[3].Text + Environment.NewLine);
                }
                sw.Close();
                originalToolStripMenuItem1.Enabled = true;
                SaveForPrompt();
            }
        }

        private void save_text_menu_Click(object sender, EventArgs e)
        {
            if (Auto_save_Original != null)
                Save_Original();
            else
                Save_As_Original();

        }
        private void save_text_AS_menu_Click(object sender, EventArgs e)
        {
            Save_As_Original();
        }

        private void EntextBox_TextChanged(object sender, EventArgs e)
        {
            if (Subtitle_listView.Items.Count > 0)
            {
                Subtitle_listView.FocusedItem.SubItems[3].Text = EntextBox.Text;
            }
        }
        //prompt 1 step
        //save all list items into string when thy loading (open/source and translation)
        private void SaveForPrompt()
        {
            PromptNSE = "";
            Prompt_Source = "";
            Prompt_Translation = "";
            foreach (ListViewItem item in Subtitle_listView.Items)
            {
                PromptNSE += item.Text;
                PromptNSE += item.SubItems[1].Text;
                PromptNSE += item.SubItems[2].Text;

                Prompt_Source += item.SubItems[3].Text;
                Prompt_Translation += item.SubItems[4].Text;
            }
        }
        //prompt 2 step
        //campare saved string with final list items
        private int GetPrompt()
        {
            string Current_Source = "", Current_Translation = "", Currrent_NSE = "";
            foreach (ListViewItem item in Subtitle_listView.Items)
            {
                Currrent_NSE += item.Text;
                Currrent_NSE += item.SubItems[1].Text;
                Currrent_NSE += item.SubItems[2].Text;

                Current_Source += item.SubItems[3].Text;
                Current_Translation += item.SubItems[4].Text;
            }
            int status=0;
            if (PromptNSE != Currrent_NSE || (Prompt_Translation != Current_Translation && Prompt_Source != Current_Source))
                status = 1;
            else if (Prompt_Source != Current_Source)
                status = 2;
            else if (Prompt_Translation != Current_Translation)
                status = 3;


            if (status > 0)
                return status;
            else
                return 0;
        }
        //prompt step 3
        //use it on exit
        private void CheckForChanges(FormClosingEventArgs c)
        {
            int Status = GetPrompt();
            DialogResult Result_Prompt_Source, Result_Prompt_Translation;
            bool Cancel = false;

            if (Status == 1)
            {
                if (englishToolStripMenuItem.Checked == true)
                    Result_Prompt_Source = MessageBox.Show("Source Subtitle Has Changed, Do you Want to save the changes?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                else
                    Result_Prompt_Source = MessageBox.Show("فایل متن تغییر کرده است،آیا آن را ذخیره میکنید؟", "خروج", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                if (Result_Prompt_Source == DialogResult.Yes)
                {
                    if (Auto_save_Original == null)
                        Save_As_Original();
                    else
                        Save_Original();
                }
                else if (Result_Prompt_Source == DialogResult.No)
                    Cancel = false;
                else
                    Cancel = true;

                if (Result_Prompt_Source != DialogResult.Cancel)//
                {
                    if (englishToolStripMenuItem.Checked)
                        Result_Prompt_Translation = MessageBox.Show("Translation Subtitle Has Changed, Do you Want to save the changes?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    else
                        Result_Prompt_Translation = MessageBox.Show("فایل ترجمه تغییر کرده است،آیا آن را ذخیره میکنید؟", "خروج", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    if (Result_Prompt_Translation == DialogResult.Yes)
                    {
                        if (Auto_save_trans == null)
                            Save_As_Translate();
                        else
                            Save_Translate();
                    }
                    else if (Result_Prompt_Translation == DialogResult.No)
                        Cancel = false;
                    else
                        Cancel = true;
                }

            }
            else if (Status == 2)
            {
                if (englishToolStripMenuItem.Checked == true)
                    Result_Prompt_Source = MessageBox.Show("Source Subtitle Has Changed, Do you Want to save the changes?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                else
                    Result_Prompt_Source = MessageBox.Show("فایل متن تغییر کرده است،آیا آن را ذخیره میکنید؟", "خروج", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                if (Result_Prompt_Source == DialogResult.Yes)
                {
                    if (Auto_save_Original == null)
                        Save_As_Original();
                    else
                        Save_Original();
                }
                else if (Result_Prompt_Source == DialogResult.No)
                    Cancel = false;
                else
                    Cancel = true;
            }
            else if (Status == 3)
            {
                if (englishToolStripMenuItem.Checked == true)
                    Result_Prompt_Translation = MessageBox.Show("Translation Subtitle Has Changed, Do you Want to save the changes?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                else
                    Result_Prompt_Translation = MessageBox.Show("فایل ترجمه تغییر کرده است،آیا آن را ذخیره میکنید؟", "خروج", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                if (Result_Prompt_Translation == DialogResult.Yes)
                {
                    if (Auto_save_trans == null)
                        Save_As_Translate();
                    else
                        Save_Translate();
                }
                else if (Result_Prompt_Translation == DialogResult.No)
                    Cancel = false;
                else
                    Cancel = true;
            }
            c.Cancel = Cancel;
        }

        //prompt step 4
        //use it on new ,open
        private void CheckForChanges()
        {
            int Status = GetPrompt();
            DialogResult Result_Prompt_Source, Result_Prompt_Translation;

            if (Status == 1)
            {
                if (englishToolStripMenuItem.Checked == true)
                    Result_Prompt_Source = MessageBox.Show("Source Subtitle Has Changed, Do you Want to save the changes?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                else
                    Result_Prompt_Source = MessageBox.Show("فایل متن تغییر کرده است،آیا آن را ذخیره میکنید؟", "خروج", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                if (Result_Prompt_Source == DialogResult.Yes)
                {
                    if (Auto_save_Original == null)
                        Save_As_Original();
                    else
                        Save_Original();
                }

                if (Result_Prompt_Source != DialogResult.Cancel)//
                {
                    if (englishToolStripMenuItem.Checked == true)
                        Result_Prompt_Translation = MessageBox.Show("Translation Subtitle Has Changed, Do you Want to save the changes?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    else
                        Result_Prompt_Translation = MessageBox.Show("فایل ترجمه تغییر کرده است،آیا آن را ذخیره میکنید؟", "خروج", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    if (Result_Prompt_Translation == DialogResult.Yes)
                    {
                        if (Auto_save_trans == null)
                            Save_As_Translate();
                        else
                            Save_Translate();
                        newmenuitem();
                    }
                    else if (Result_Prompt_Translation == DialogResult.No)
                        newmenuitem();
                }
            }
            else if (Status == 2)
            {
                if (englishToolStripMenuItem.Checked == true)
                    Result_Prompt_Source = MessageBox.Show("Source Subtitle Has Changed, Do you Want to save the changes?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                else
                    Result_Prompt_Source = MessageBox.Show("فایل متن تغییر کرده است،آیا آن را ذخیره میکنید؟", "خروج", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                if (Result_Prompt_Source == DialogResult.Yes)
                {
                    if (Auto_save_Original == null)
                        Save_As_Original();
                    else
                        Save_Original();
                    newmenuitem();
                }
                else if (Result_Prompt_Source == DialogResult.No)
                    newmenuitem();
            }
            else if (Status == 3)
            {
                if (englishToolStripMenuItem.Checked == true)
                    Result_Prompt_Translation = MessageBox.Show("Translation Subtitle Has Changed, Do you Want to save the changes?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                else
                    Result_Prompt_Translation = MessageBox.Show("فایل ترجمه تغییر کرده است،آیا آن را ذخیره میکنید؟", "خروج", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                if (Result_Prompt_Translation == DialogResult.Yes)
                {
                    if (Auto_save_trans == null)
                        Save_As_Translate();
                    else
                        Save_Translate();
                    newmenuitem();
                }
                else if (Result_Prompt_Translation == DialogResult.No)
                    newmenuitem();
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            subtitle_lbl.Text = "";//اگه هنگ کرد دیگه دیده نشه

            //Exit Prompt
            CheckForChanges(e);

            //save settings into subtrans.ini

            StreamWriter SaveIntoSubTranse = new StreamWriter(Application.StartupPath + "\\Subtrans.ini");
            TextBox SaveIt_txtbox = new TextBox();
            SaveIt_txtbox.Text = "[subtrans settings]" + Environment.NewLine;

            if (this.WindowState == FormWindowState.Maximized)
                SaveIt_txtbox.Text += "fullscreen:1" + Environment.NewLine;
            else
                SaveIt_txtbox.Text += "fullscreen:0" + Environment.NewLine;

            SaveIt_txtbox.Text += "volume:" + axWindowsMediaPlayer1.settings.volume + Environment.NewLine;

            if (englishToolStripMenuItem.Checked == true)
                SaveIt_txtbox.Text += "language:0" + Environment.NewLine;
            else
                SaveIt_txtbox.Text += "language:1" + Environment.NewLine;

            if (AutoMove_chkBox.Checked == true)
                SaveIt_txtbox.Text += "play_movie:1" + Environment.NewLine;
            else
                SaveIt_txtbox.Text += "play_movie:0" + Environment.NewLine;

            if (PlaySeccond_rdobtn.Checked == true)
                SaveIt_txtbox.Text += "play_select:1" + Environment.NewLine;
            else
                SaveIt_txtbox.Text += "play_select:0" + Environment.NewLine;

            if(DonotPlay_rdobtn.Checked)
                SaveIt_txtbox.Text += "donotplay:1" + Environment.NewLine;
            else
                SaveIt_txtbox.Text += "donotplay:0" + Environment.NewLine;

            SaveIt_txtbox.Text += "play_second:" + Seccond_cmbBox.SelectedIndex + Environment.NewLine;

            if (SaveTranslation_chkBox.Checked == true)
                SaveIt_txtbox.Text += "save_translation:1" + Environment.NewLine;
            else
                SaveIt_txtbox.Text += "save_translation:0" + Environment.NewLine;

            if (movieOnTopMenuItem.Checked == true)
                SaveIt_txtbox.Text += "mode:0" + Environment.NewLine;
            else if (movieOnLeftToolStripMenuItem.Checked == true)
                SaveIt_txtbox.Text += "mode:1" + Environment.NewLine;
            else if (movieOnRightToolStripMenuItem.Checked == true)
                SaveIt_txtbox.Text += "mode:2" + Environment.NewLine;
            else if (movieOffToolStripMenuItem.Checked == true)
                SaveIt_txtbox.Text += "mode:3" + Environment.NewLine;

            if (Show_originalToolStripMenuItem.Checked == true)
                SaveIt_txtbox.Text += "viewsub:0" + Environment.NewLine;
            else
                SaveIt_txtbox.Text += "viewsub:1" + Environment.NewLine;

            //save fonts
            TypeConverter converter_font = TypeDescriptor.GetConverter(typeof(Font));

            string subtitle_Font = converter_font.ConvertToString(subtitle_lbl.Font);
            SaveIt_txtbox.Text += "subtitle_font:" + subtitle_Font + Environment.NewLine;

            string other_Font = converter_font.ConvertToString(TranslationBox.Font);
            SaveIt_txtbox.Text += "Source/original_font:" + other_Font + Environment.NewLine;
            //end save fonts

            //save color
            TypeConverter converter_color = TypeDescriptor.GetConverter(typeof(Color));

            string subtitle_color = converter_color.ConvertToString(subtitle_lbl.ForeColor);
            SaveIt_txtbox.Text += "subtitle_color:" + subtitle_color + Environment.NewLine;

            string other_color = converter_color.ConvertToString(TranslationBox.ForeColor);
            SaveIt_txtbox.Text += "Source/original_color:" + other_color + Environment.NewLine;

            SaveIntoSubTranse.Write(SaveIt_txtbox.Text);
            SaveIntoSubTranse.Close();

            //save persian support status
            if (pschanged == 1)
            {
                StreamWriter SaveIntoPsconf = new StreamWriter(Application.StartupPath + "\\Psconf.ini");
                if (persianSupportToolStripMenuItem.Checked == true)
                    SaveIntoPsconf.Write("0");
                else
                    SaveIntoPsconf.Write("1");
                SaveIntoPsconf.Close();
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void axWindowsMediaPlayer1_ClickEvent(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
                axWindowsMediaPlayer1.Ctlcontrols.pause();
            else
                axWindowsMediaPlayer1.Ctlcontrols.play();

            if (axWindowsMediaPlayer1.fullScreen == true)
                axWindowsMediaPlayer1.fullScreen = false;
        }
        private void newmenuitem()
        {
            Auto_save_Original = null;
            Auto_save_trans = null;
            axWindowsMediaPlayer1.close();
            EntextBox.Clear();
            TranslationBox.Clear();
            Subtitle_listView.Items.Clear();
            CurrentLine_lbl.Text = "Line: 0/0";
            time_lblD.Text = "00:00:00,000";
            time_lbln.Text = "00:00:00,000";
            subtitle_lbl.Text = "";
            Open_translation_Sub_ToolStripMenuItem.Enabled = false;
            saveToolStripMenuItem.Enabled = false;
            saveAsToolStripMenuItem.Enabled = false;
            autoTranslateToolStripMenuItem.Enabled = false;
            autoTranslateToolStripMenuItem.Enabled = false;
            goToToolStripMenuItem.Enabled = false;
            showDicToolStripMenuItem.Enabled = false;
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    ((TextBox)x).Text = String.Empty;
                }
            }

            this.Text = "Subtrans ";
            SaveForPrompt();
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (GetPrompt() == 0)
                newmenuitem();
            else
                CheckForChanges();
        }

        /// <summary>
        /// تنظیمات تایمر شروع
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_n1_up_Click(object sender, EventArgs e)
        {
            if (Subtitle_listView.Items.Count > 0)
            {
                TimeSpan timeupsec = new TimeSpan(0, Convert.ToInt32(Time10.Text), Convert.ToInt32(Time11.Text), Convert.ToInt32(Time12.Text), Convert.ToInt32(Time13.Text));
                double s = timeupsec.TotalSeconds;
                s += 0.010;

                TimeSpan t2 = TimeSpan.FromSeconds(s);
                string time2text = String.Format("{0:00}:{1:00}:{2:00},{3:000}", t2.Hours, t2.Minutes, t2.Seconds, t2.Milliseconds);
                string[] splite = time2text.Split(':', ',');
                Time10.Text = splite[0];
                Time11.Text = splite[1];
                Time12.Text = splite[2];
                Time13.Text = splite[3];

                TimeSpan start_time = new TimeSpan(0, Convert.ToInt32(Time10.Text), Convert.ToInt32(Time11.Text), Convert.ToInt32(Time12.Text), Convert.ToInt32(Time13.Text));
                double st = start_time.TotalSeconds;

                TimeSpan end_time = new TimeSpan(0, Convert.ToInt32(Time20.Text), Convert.ToInt32(Time21.Text), Convert.ToInt32(Time22.Text), Convert.ToInt32(Time23.Text));
                double et = end_time.TotalSeconds;

                double st_et = et - st;

                Time33.Text = Math.Round(st_et, 4).ToString();
                if (Math.Round(st_et, 4) > 0)
                    Time33.BackColor = Color.White;
                else
                    Time33.BackColor = Color.Red;
            }
        }

        private void btn_s1_up_Click(object sender, EventArgs e)
        {
            if (Subtitle_listView.Items.Count > 0)
            {
                TimeSpan timeupsec = new TimeSpan(0, Convert.ToInt32(Time10.Text), Convert.ToInt32(Time11.Text), Convert.ToInt32(Time12.Text), Convert.ToInt32(Time13.Text));
                double s = timeupsec.TotalSeconds;
                s += 1;

                TimeSpan t2 = TimeSpan.FromSeconds(s);
                string time2text = String.Format("{0:00}:{1:00}:{2:00},{3:000}", t2.Hours, t2.Minutes, t2.Seconds, t2.Milliseconds);
                string[] splite = time2text.Split(':', ',');
                Time10.Text = splite[0];
                Time11.Text = splite[1];
                Time12.Text = splite[2];
                Time13.Text = splite[3];

                TimeSpan start_time = new TimeSpan(0, Convert.ToInt32(Time10.Text), Convert.ToInt32(Time11.Text), Convert.ToInt32(Time12.Text), Convert.ToInt32(Time13.Text));
                double st = start_time.TotalSeconds;

                TimeSpan end_time = new TimeSpan(0, Convert.ToInt32(Time20.Text), Convert.ToInt32(Time21.Text), Convert.ToInt32(Time22.Text), Convert.ToInt32(Time23.Text));
                double et = end_time.TotalSeconds;

                double st_et = et - st;

                Time33.Text = Math.Round(st_et, 4).ToString();
                if (Math.Round(st_et, 4) > 0)
                    Time33.BackColor = Color.White;
                else
                    Time33.BackColor = Color.Red;
            }
        }

        private void btn_d1_up_Click(object sender, EventArgs e)
        {
            if (Subtitle_listView.Items.Count > 0)
            {
                TimeSpan timeupsec = new TimeSpan(0, Convert.ToInt32(Time10.Text), Convert.ToInt32(Time11.Text), Convert.ToInt32(Time12.Text), Convert.ToInt32(Time13.Text));
                double s = timeupsec.TotalSeconds;
                s += 60;

                TimeSpan t2 = TimeSpan.FromSeconds(s);
                string time2text = String.Format("{0:00}:{1:00}:{2:00},{3:000}", t2.Hours, t2.Minutes, t2.Seconds, t2.Milliseconds);
                string[] splite = time2text.Split(':', ',');
                Time10.Text = splite[0];
                Time11.Text = splite[1];
                Time12.Text = splite[2];
                Time13.Text = splite[3];

                TimeSpan start_time = new TimeSpan(0, Convert.ToInt32(Time10.Text), Convert.ToInt32(Time11.Text), Convert.ToInt32(Time12.Text), Convert.ToInt32(Time13.Text));
                double st = start_time.TotalSeconds;

                TimeSpan end_time = new TimeSpan(0, Convert.ToInt32(Time20.Text), Convert.ToInt32(Time21.Text), Convert.ToInt32(Time22.Text), Convert.ToInt32(Time23.Text));
                double et = end_time.TotalSeconds;

                double st_et = et - st;

                Time33.Text = Math.Round(st_et, 4).ToString();
                if (Math.Round(st_et, 4) > 0)
                    Time33.BackColor = Color.White;
                else
                    Time33.BackColor = Color.Red;
            }
        }

        private void btn_h1_up_Click(object sender, EventArgs e)
        {
            if (Subtitle_listView.Items.Count > 0)
            {
                TimeSpan timeupsec = new TimeSpan(0, Convert.ToInt32(Time10.Text), Convert.ToInt32(Time11.Text), Convert.ToInt32(Time12.Text), Convert.ToInt32(Time13.Text));
                double s = timeupsec.TotalSeconds;
                s += 3600;

                TimeSpan t2 = TimeSpan.FromSeconds(s);
                string time2text = String.Format("{0:00}:{1:00}:{2:00},{3:000}", t2.Hours, t2.Minutes, t2.Seconds, t2.Milliseconds);
                string[] splite = time2text.Split(':', ',');
                Time10.Text = splite[0];
                Time11.Text = splite[1];
                Time12.Text = splite[2];
                Time13.Text = splite[3];

                TimeSpan start_time = new TimeSpan(0, Convert.ToInt32(Time10.Text), Convert.ToInt32(Time11.Text), Convert.ToInt32(Time12.Text), Convert.ToInt32(Time13.Text));
                double st = start_time.TotalSeconds;

                TimeSpan end_time = new TimeSpan(0, Convert.ToInt32(Time20.Text), Convert.ToInt32(Time21.Text), Convert.ToInt32(Time22.Text), Convert.ToInt32(Time23.Text));
                double et = end_time.TotalSeconds;

                double st_et = et - st;

                Time33.Text = Math.Round(st_et, 4).ToString();
                if (Math.Round(st_et, 4) > 0)
                    Time33.BackColor = Color.White;
                else
                    Time33.BackColor = Color.Red;
            }
        }

        private void btn_n1_Down_Click(object sender, EventArgs e)
        {
            if (Subtitle_listView.Items.Count > 0)
            {
                TimeSpan timeupsec = new TimeSpan(0, Convert.ToInt32(Time10.Text), Convert.ToInt32(Time11.Text), Convert.ToInt32(Time12.Text), Convert.ToInt32(Time13.Text));
                double s = timeupsec.TotalSeconds;
                if (s > 0.009)
                    s -= 0.010;

                TimeSpan t2 = TimeSpan.FromSeconds(s);
                string time2text = String.Format("{0:00}:{1:00}:{2:00},{3:000}", t2.Hours, t2.Minutes, t2.Seconds, t2.Milliseconds);
                string[] splite = time2text.Split(':', ',');
                Time10.Text = splite[0];
                Time11.Text = splite[1];
                Time12.Text = splite[2];
                Time13.Text = splite[3];

                TimeSpan start_time = new TimeSpan(0, Convert.ToInt32(Time10.Text), Convert.ToInt32(Time11.Text), Convert.ToInt32(Time12.Text), Convert.ToInt32(Time13.Text));
                double st = start_time.TotalSeconds;

                TimeSpan end_time = new TimeSpan(0, Convert.ToInt32(Time20.Text), Convert.ToInt32(Time21.Text), Convert.ToInt32(Time22.Text), Convert.ToInt32(Time23.Text));
                double et = end_time.TotalSeconds;

                double st_et = et - st;

                Time33.Text = Math.Round(st_et, 4).ToString();
                if (Math.Round(st_et, 4) > 0)
                    Time33.BackColor = Color.White;
                else
                    Time33.BackColor = Color.Red;
            }
        }

        private void btn_s1_Down_Click(object sender, EventArgs e)
        {
            if (Subtitle_listView.Items.Count > 0)
            {
                TimeSpan timeupsec = new TimeSpan(0, Convert.ToInt32(Time10.Text), Convert.ToInt32(Time11.Text), Convert.ToInt32(Time12.Text), Convert.ToInt32(Time13.Text));
                double s = timeupsec.TotalSeconds;
                if (s > 0.999)
                    s -= 1;

                TimeSpan t2 = TimeSpan.FromSeconds(s);
                string time2text = String.Format("{0:00}:{1:00}:{2:00},{3:000}", t2.Hours, t2.Minutes, t2.Seconds, t2.Milliseconds);
                string[] splite = time2text.Split(':', ',');
                Time10.Text = splite[0];
                Time11.Text = splite[1];
                Time12.Text = splite[2];
                Time13.Text = splite[3];

                TimeSpan start_time = new TimeSpan(0, Convert.ToInt32(Time10.Text), Convert.ToInt32(Time11.Text), Convert.ToInt32(Time12.Text), Convert.ToInt32(Time13.Text));
                double st = start_time.TotalSeconds;

                TimeSpan end_time = new TimeSpan(0, Convert.ToInt32(Time20.Text), Convert.ToInt32(Time21.Text), Convert.ToInt32(Time22.Text), Convert.ToInt32(Time23.Text));
                double et = end_time.TotalSeconds;

                double st_et = et - st;

                Time33.Text = Math.Round(st_et, 4).ToString();
                if (Math.Round(st_et, 4) > 0)
                    Time33.BackColor = Color.White;
                else
                    Time33.BackColor = Color.Red;
            }
        }

        private void btn_d1_Down_Click(object sender, EventArgs e)
        {
            if (Subtitle_listView.Items.Count > 0)
            {
                TimeSpan timeupsec = new TimeSpan(0, Convert.ToInt32(Time10.Text), Convert.ToInt32(Time11.Text), Convert.ToInt32(Time12.Text), Convert.ToInt32(Time13.Text));
                double s = timeupsec.TotalSeconds;
                if (s > 59)
                    s -= 60;

                TimeSpan t2 = TimeSpan.FromSeconds(s);
                string time2text = String.Format("{0:00}:{1:00}:{2:00},{3:000}", t2.Hours, t2.Minutes, t2.Seconds, t2.Milliseconds);
                string[] splite = time2text.Split(':', ',');
                Time10.Text = splite[0];
                Time11.Text = splite[1];
                Time12.Text = splite[2];
                Time13.Text = splite[3];

                TimeSpan start_time = new TimeSpan(0, Convert.ToInt32(Time10.Text), Convert.ToInt32(Time11.Text), Convert.ToInt32(Time12.Text), Convert.ToInt32(Time13.Text));
                double st = start_time.TotalSeconds;

                TimeSpan end_time = new TimeSpan(0, Convert.ToInt32(Time20.Text), Convert.ToInt32(Time21.Text), Convert.ToInt32(Time22.Text), Convert.ToInt32(Time23.Text));
                double et = end_time.TotalSeconds;

                double st_et = et - st;

                Time33.Text = Math.Round(st_et, 4).ToString();
                if (Math.Round(st_et, 4) > 0)
                    Time33.BackColor = Color.White;
                else
                    Time33.BackColor = Color.Red;
            }
        }
        private void btn_h1_Down_Click(object sender, EventArgs e)
        {
            if (Subtitle_listView.Items.Count > 0)
            {
                TimeSpan timeupsec = new TimeSpan(0, Convert.ToInt32(Time10.Text), Convert.ToInt32(Time11.Text), Convert.ToInt32(Time12.Text), Convert.ToInt32(Time13.Text));
                double s = timeupsec.TotalSeconds;
                if (s > 3599)
                    s -= 3600;

                TimeSpan t2 = TimeSpan.FromSeconds(s);
                string time2text = String.Format("{0:00}:{1:00}:{2:00},{3:000}", t2.Hours, t2.Minutes, t2.Seconds, t2.Milliseconds);
                string[] splite = time2text.Split(':', ',');
                Time10.Text = splite[0];
                Time11.Text = splite[1];
                Time12.Text = splite[2];
                Time13.Text = splite[3];

                TimeSpan start_time = new TimeSpan(0, Convert.ToInt32(Time10.Text), Convert.ToInt32(Time11.Text), Convert.ToInt32(Time12.Text), Convert.ToInt32(Time13.Text));
                double st = start_time.TotalSeconds;

                TimeSpan end_time = new TimeSpan(0, Convert.ToInt32(Time20.Text), Convert.ToInt32(Time21.Text), Convert.ToInt32(Time22.Text), Convert.ToInt32(Time23.Text));
                double et = end_time.TotalSeconds;

                double st_et = et - st;

                Time33.Text = Math.Round(st_et, 4).ToString();
                if (Math.Round(st_et, 4) > 0)
                    Time33.BackColor = Color.White;
                else
                    Time33.BackColor = Color.Red;
            }
        }

        /// <summary>
        /// تنظیمات تایمر پایان
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_n2_up_Click(object sender, EventArgs e)
        {
            if (Subtitle_listView.Items.Count > 0)
            {
                TimeSpan timeupsec = new TimeSpan(0, Convert.ToInt32(Time20.Text), Convert.ToInt32(Time21.Text), Convert.ToInt32(Time22.Text), Convert.ToInt32(Time23.Text));
                double s = timeupsec.TotalSeconds;
                s += 0.010;

                TimeSpan t2 = TimeSpan.FromSeconds(s);
                string time2text = String.Format("{0:00}:{1:00}:{2:00},{3:000}", t2.Hours, t2.Minutes, t2.Seconds, t2.Milliseconds);
                string[] splite = time2text.Split(':', ',');
                Time20.Text = splite[0];
                Time21.Text = splite[1];
                Time22.Text = splite[2];
                Time23.Text = splite[3];

                TimeSpan start_time = new TimeSpan(0, Convert.ToInt32(Time10.Text), Convert.ToInt32(Time11.Text), Convert.ToInt32(Time12.Text), Convert.ToInt32(Time13.Text));
                double st = start_time.TotalSeconds;

                TimeSpan end_time = new TimeSpan(0, Convert.ToInt32(Time20.Text), Convert.ToInt32(Time21.Text), Convert.ToInt32(Time22.Text), Convert.ToInt32(Time23.Text));
                double et = end_time.TotalSeconds;

                double st_et = et - st;

                Time33.Text = Math.Round(st_et, 4).ToString();
                if (Math.Round(st_et, 4) > 0)
                    Time33.BackColor = Color.White;
                else
                    Time33.BackColor = Color.Red;
            }
        }


        private void btn_s2_up_Click(object sender, EventArgs e)
        {
            if (Subtitle_listView.Items.Count > 0)
            {
                TimeSpan timeupsec = new TimeSpan(0, Convert.ToInt32(Time20.Text), Convert.ToInt32(Time21.Text), Convert.ToInt32(Time22.Text), Convert.ToInt32(Time23.Text));
                double s = timeupsec.TotalSeconds;
                s += 1;

                TimeSpan t2 = TimeSpan.FromSeconds(s);
                string time2text = String.Format("{0:00}:{1:00}:{2:00},{3:000}", t2.Hours, t2.Minutes, t2.Seconds, t2.Milliseconds);
                string[] splite = time2text.Split(':', ',');
                Time20.Text = splite[0];
                Time21.Text = splite[1];
                Time22.Text = splite[2];
                Time23.Text = splite[3];

                TimeSpan start_time = new TimeSpan(0, Convert.ToInt32(Time10.Text), Convert.ToInt32(Time11.Text), Convert.ToInt32(Time12.Text), Convert.ToInt32(Time13.Text));
                double st = start_time.TotalSeconds;

                TimeSpan end_time = new TimeSpan(0, Convert.ToInt32(Time20.Text), Convert.ToInt32(Time21.Text), Convert.ToInt32(Time22.Text), Convert.ToInt32(Time23.Text));
                double et = end_time.TotalSeconds;

                double st_et = et - st;

                Time33.Text = Math.Round(st_et, 4).ToString();
                if (Math.Round(st_et, 4) > 0)
                    Time33.BackColor = Color.White;
                else
                    Time33.BackColor = Color.Red;
            }
        }

        private void btn_d2_up_Click(object sender, EventArgs e)
        {
            if (Subtitle_listView.Items.Count > 0)
            {
                TimeSpan timeupsec = new TimeSpan(0, Convert.ToInt32(Time20.Text), Convert.ToInt32(Time21.Text), Convert.ToInt32(Time22.Text), Convert.ToInt32(Time23.Text));
                double s = timeupsec.TotalSeconds;
                s += 60;

                TimeSpan t2 = TimeSpan.FromSeconds(s);
                string time2text = String.Format("{0:00}:{1:00}:{2:00},{3:000}", t2.Hours, t2.Minutes, t2.Seconds, t2.Milliseconds);
                string[] splite = time2text.Split(':', ',');
                Time20.Text = splite[0];
                Time21.Text = splite[1];
                Time22.Text = splite[2];
                Time23.Text = splite[3];
                TimeSpan start_time = new TimeSpan(0, Convert.ToInt32(Time10.Text), Convert.ToInt32(Time11.Text), Convert.ToInt32(Time12.Text), Convert.ToInt32(Time13.Text));
                double st = start_time.TotalSeconds;

                TimeSpan end_time = new TimeSpan(0, Convert.ToInt32(Time20.Text), Convert.ToInt32(Time21.Text), Convert.ToInt32(Time22.Text), Convert.ToInt32(Time23.Text));
                double et = end_time.TotalSeconds;

                double st_et = et - st;

                Time33.Text = Math.Round(st_et, 4).ToString();
                if (Math.Round(st_et, 4) > 0)
                    Time33.BackColor = Color.White;
                else
                    Time33.BackColor = Color.Red;
            }

        }

        private void btn_h2_up_Click(object sender, EventArgs e)
        {
            if (Subtitle_listView.Items.Count > 0)
            {
                TimeSpan timeupsec = new TimeSpan(0, Convert.ToInt32(Time20.Text), Convert.ToInt32(Time21.Text), Convert.ToInt32(Time22.Text), Convert.ToInt32(Time23.Text));
                double s = timeupsec.TotalSeconds;
                s += 3600;

                TimeSpan t2 = TimeSpan.FromSeconds(s);
                string time2text = String.Format("{0:00}:{1:00}:{2:00},{3:000}", t2.Hours, t2.Minutes, t2.Seconds, t2.Milliseconds);
                string[] splite = time2text.Split(':', ',');
                Time20.Text = splite[0];
                Time21.Text = splite[1];
                Time22.Text = splite[2];
                Time23.Text = splite[3];

                TimeSpan start_time = new TimeSpan(0, Convert.ToInt32(Time10.Text), Convert.ToInt32(Time11.Text), Convert.ToInt32(Time12.Text), Convert.ToInt32(Time13.Text));
                double st = start_time.TotalSeconds;

                TimeSpan end_time = new TimeSpan(0, Convert.ToInt32(Time20.Text), Convert.ToInt32(Time21.Text), Convert.ToInt32(Time22.Text), Convert.ToInt32(Time23.Text));
                double et = end_time.TotalSeconds;

                double st_et = et - st;

                Time33.Text = Math.Round(st_et, 4).ToString();
                if (Math.Round(st_et, 4) > 0)
                    Time33.BackColor = Color.White;
                else
                    Time33.BackColor = Color.Red;
            }
        }

        private void btn_n2_Down_Click(object sender, EventArgs e)
        {
            if (Subtitle_listView.Items.Count > 0)
            {
                TimeSpan timeupsec = new TimeSpan(0, Convert.ToInt32(Time20.Text), Convert.ToInt32(Time21.Text), Convert.ToInt32(Time22.Text), Convert.ToInt32(Time23.Text));
                double s = timeupsec.TotalSeconds;
                if (s > 0.009)
                    s -= 0.010;

                TimeSpan t2 = TimeSpan.FromSeconds(s);
                string time2text = String.Format("{0:00}:{1:00}:{2:00},{3:000}", t2.Hours, t2.Minutes, t2.Seconds, t2.Milliseconds);
                string[] splite = time2text.Split(':', ',');
                Time20.Text = splite[0];
                Time21.Text = splite[1];
                Time22.Text = splite[2];
                Time23.Text = splite[3];

                TimeSpan start_time = new TimeSpan(0, Convert.ToInt32(Time10.Text), Convert.ToInt32(Time11.Text), Convert.ToInt32(Time12.Text), Convert.ToInt32(Time13.Text));
                double st = start_time.TotalSeconds;

                TimeSpan end_time = new TimeSpan(0, Convert.ToInt32(Time20.Text), Convert.ToInt32(Time21.Text), Convert.ToInt32(Time22.Text), Convert.ToInt32(Time23.Text));
                double et = end_time.TotalSeconds;

                double st_et = et - st;

                Time33.Text = Math.Round(st_et, 4).ToString();
                if (Math.Round(st_et, 4) > 0)
                    Time33.BackColor = Color.White;
                else
                    Time33.BackColor = Color.Red;
            }

        }

        private void btn_s2_Down_Click(object sender, EventArgs e)
        {

            if (Subtitle_listView.Items.Count > 0)
            {
                TimeSpan timeupsec = new TimeSpan(0, Convert.ToInt32(Time20.Text), Convert.ToInt32(Time21.Text), Convert.ToInt32(Time22.Text), Convert.ToInt32(Time23.Text));
                double s = timeupsec.TotalSeconds;
                if (s > 0.999)
                    s -= 1;

                TimeSpan t2 = TimeSpan.FromSeconds(s);
                string time2text = String.Format("{0:00}:{1:00}:{2:00},{3:000}", t2.Hours, t2.Minutes, t2.Seconds, t2.Milliseconds);
                string[] splite = time2text.Split(':', ',');
                Time20.Text = splite[0];
                Time21.Text = splite[1];
                Time22.Text = splite[2];
                Time23.Text = splite[3];

                TimeSpan start_time = new TimeSpan(0, Convert.ToInt32(Time10.Text), Convert.ToInt32(Time11.Text), Convert.ToInt32(Time12.Text), Convert.ToInt32(Time13.Text));
                double st = start_time.TotalSeconds;

                TimeSpan end_time = new TimeSpan(0, Convert.ToInt32(Time20.Text), Convert.ToInt32(Time21.Text), Convert.ToInt32(Time22.Text), Convert.ToInt32(Time23.Text));
                double et = end_time.TotalSeconds;

                double st_et = et - st;

                Time33.Text = Math.Round(st_et, 4).ToString();
                if (Math.Round(st_et, 4) > 0)
                    Time33.BackColor = Color.White;
                else
                    Time33.BackColor = Color.Red;
            }
        }

        private void btn_d2_Down_Click(object sender, EventArgs e)
        {
            if (Subtitle_listView.Items.Count > 0)
            {
                TimeSpan timeupsec = new TimeSpan(0, Convert.ToInt32(Time20.Text), Convert.ToInt32(Time21.Text), Convert.ToInt32(Time22.Text), Convert.ToInt32(Time23.Text));
                double s = timeupsec.TotalSeconds;
                if (s > 59)
                    s -= 60;

                TimeSpan t2 = TimeSpan.FromSeconds(s);
                string time2text = String.Format("{0:00}:{1:00}:{2:00},{3:000}", t2.Hours, t2.Minutes, t2.Seconds, t2.Milliseconds);
                string[] splite = time2text.Split(':', ',');
                Time20.Text = splite[0];
                Time21.Text = splite[1];
                Time22.Text = splite[2];
                Time23.Text = splite[3];

                TimeSpan start_time = new TimeSpan(0, Convert.ToInt32(Time10.Text), Convert.ToInt32(Time11.Text), Convert.ToInt32(Time12.Text), Convert.ToInt32(Time13.Text));
                double st = start_time.TotalSeconds;

                TimeSpan end_time = new TimeSpan(0, Convert.ToInt32(Time20.Text), Convert.ToInt32(Time21.Text), Convert.ToInt32(Time22.Text), Convert.ToInt32(Time23.Text));
                double et = end_time.TotalSeconds;

                double st_et = et - st;

                Time33.Text = Math.Round(st_et, 4).ToString();
                if (Math.Round(st_et, 4) > 0)
                    Time33.BackColor = Color.White;
                else
                    Time33.BackColor = Color.Red;
            }
        }

        private void btn_h2_Down_Click(object sender, EventArgs e)
        {
            if (Subtitle_listView.Items.Count > 0)
            {
                TimeSpan timeupsec = new TimeSpan(0, Convert.ToInt32(Time20.Text), Convert.ToInt32(Time21.Text), Convert.ToInt32(Time22.Text), Convert.ToInt32(Time23.Text));
                double s = timeupsec.TotalSeconds;
                if (s > 3599)
                    s -= 3600;

                TimeSpan t2 = TimeSpan.FromSeconds(s);
                string time2text = String.Format("{0:00}:{1:00}:{2:00},{3:000}", t2.Hours, t2.Minutes, t2.Seconds, t2.Milliseconds);
                string[] splite = time2text.Split(':', ',');
                Time20.Text = splite[0];
                Time21.Text = splite[1];
                Time22.Text = splite[2];
                Time23.Text = splite[3];

                TimeSpan start_time = new TimeSpan(0, Convert.ToInt32(Time10.Text), Convert.ToInt32(Time11.Text), Convert.ToInt32(Time12.Text), Convert.ToInt32(Time13.Text));
                double st = start_time.TotalSeconds;

                TimeSpan end_time = new TimeSpan(0, Convert.ToInt32(Time20.Text), Convert.ToInt32(Time21.Text), Convert.ToInt32(Time22.Text), Convert.ToInt32(Time23.Text));
                double et = end_time.TotalSeconds;

                double st_et = et - st;

                Time33.Text = Math.Round(st_et, 4).ToString();
                if (Math.Round(st_et, 4) > 0)
                    Time33.BackColor = Color.White;
                else
                    Time33.BackColor = Color.Red;
            }
        }

        //Duration Timer setting
        private void btn_n3_up_Click(object sender, EventArgs e)
        {
            if (Subtitle_listView.Items.Count > 0)
            {
                TimeSpan timeupsec = new TimeSpan(0, Convert.ToInt32(Time20.Text), Convert.ToInt32(Time21.Text), Convert.ToInt32(Time22.Text), Convert.ToInt32(Time23.Text));
                double s = timeupsec.TotalSeconds;
                s += 0.100;

                TimeSpan t2 = TimeSpan.FromSeconds(s);
                string time2text = String.Format("{0:00}:{1:00}:{2:00},{3:000}", t2.Hours, t2.Minutes, t2.Seconds, t2.Milliseconds);
                string[] splite = time2text.Split(':', ',');
                Time20.Text = splite[0];
                Time21.Text = splite[1];
                Time22.Text = splite[2];
                Time23.Text = splite[3];

                TimeSpan start_time = new TimeSpan(0, Convert.ToInt32(Time10.Text), Convert.ToInt32(Time11.Text), Convert.ToInt32(Time12.Text), Convert.ToInt32(Time13.Text));
                double st = start_time.TotalSeconds;

                TimeSpan end_time = new TimeSpan(0, Convert.ToInt32(Time20.Text), Convert.ToInt32(Time21.Text), Convert.ToInt32(Time22.Text), Convert.ToInt32(Time23.Text));
                double et = end_time.TotalSeconds;

                double st_et = et - st;

                Time33.Text = Math.Round(st_et, 4).ToString();
                if (Math.Round(st_et, 4) > 0)
                    Time33.BackColor = Color.White;
                else
                    Time33.BackColor = Color.Red;
            }
        }

        private void btn_n3_Down_Click(object sender, EventArgs e)
        {
            if (Subtitle_listView.Items.Count > 0)
            {
                TimeSpan timeupsec = new TimeSpan(0, Convert.ToInt32(Time20.Text), Convert.ToInt32(Time21.Text), Convert.ToInt32(Time22.Text), Convert.ToInt32(Time23.Text));
                double s = timeupsec.TotalSeconds;
                if (s > 0.099)
                    s -= 0.100;

                TimeSpan t2 = TimeSpan.FromSeconds(s);
                string time2text = String.Format("{0:00}:{1:00}:{2:00},{3:000}", t2.Hours, t2.Minutes, t2.Seconds, t2.Milliseconds);
                string[] splite = time2text.Split(':', ',');
                Time20.Text = splite[0];
                Time21.Text = splite[1];
                Time22.Text = splite[2];
                Time23.Text = splite[3];

                TimeSpan start_time = new TimeSpan(0, Convert.ToInt32(Time10.Text), Convert.ToInt32(Time11.Text), Convert.ToInt32(Time12.Text), Convert.ToInt32(Time13.Text));
                double st = start_time.TotalSeconds;

                TimeSpan end_time = new TimeSpan(0, Convert.ToInt32(Time20.Text), Convert.ToInt32(Time21.Text), Convert.ToInt32(Time22.Text), Convert.ToInt32(Time23.Text));
                double et = end_time.TotalSeconds;
                double st_et = et - st;
                Time33.Text = Math.Round(st_et, 4).ToString();
                if (Math.Round(st_et, 4) > 0)
                    Time33.BackColor = Color.White;
                else
                    Time33.BackColor = Color.Red;
            }
        }
        private void Time33_TextChanged(object sender, EventArgs e)
        {
            if (Subtitle_listView.Items.Count > 0 && Time33.Text != "" && !Time33.Text.Contains("!") && !Time33.Text.Contains("@") && !Time33.Text.Contains("#") && !Time33.Text.Contains("%") && !Time33.Text.Contains("&") && !Time33.Text.Contains("*") && !Time33.Text.Contains("(") && !Time33.Text.Contains(")") && !Time33.Text.Contains("-") && !Time33.Text.Substring(0, 1).Contains("."))
            {
                int q = 0;
                foreach (char c in Time33.Text)
                {
                    if (c == '.')
                    {
                        q++;//اگه بیشتر از 1دونه بزنه عمل نمیکنه
                    }
                }
                if (q < 2)
                {
                    TimeSpan Duration = new TimeSpan(0, Convert.ToInt32(Time10.Text), Convert.ToInt32(Time11.Text), Convert.ToInt32(Time12.Text), Convert.ToInt32(Time13.Text));
                    double du = Duration.TotalSeconds + Convert.ToDouble(Time33.Text);

                    TimeSpan t2 = TimeSpan.FromSeconds(du);
                    string time2text = String.Format("{0:00}:{1:00}:{2:00},{3:000}", t2.Hours, t2.Minutes, t2.Seconds, t2.Milliseconds);
                    Subtitle_listView.FocusedItem.SubItems[2].Text = time2text;
                    string[] splite = time2text.Split(':', ',');
                    Time20.Text = splite[0];
                    Time21.Text = splite[1];
                    Time22.Text = splite[2];
                    Time23.Text = splite[3];

                    //start
                    TimeSpan Duration2 = new TimeSpan(0, Convert.ToInt32(Time10.Text), Convert.ToInt32(Time11.Text), Convert.ToInt32(Time12.Text), Convert.ToInt32(Time13.Text));
                    double du2 = Duration2.TotalSeconds;// -Convert.ToDouble(Time33.Text);
                    TimeSpan t = TimeSpan.FromSeconds(du2);
                    Subtitle_listView.FocusedItem.SubItems[1].Text = String.Format("{0:00}:{1:00}:{2:00},{3:000}", t.Hours, t.Minutes, t.Seconds, t.Milliseconds);

                    if (Convert.ToDouble(Time33.Text) > 0)
                        Time33.BackColor = Color.White;
                    else
                        Time33.BackColor = Color.Red;
                }

            }
            else if (Time33.Text.Contains("!") || Time33.Text.Contains("@") || Time33.Text.Contains("#") || Time33.Text.Contains("%") || Time33.Text.Contains("&") || Time33.Text.Contains("*") || Time33.Text.Contains("(") || Time33.Text.Contains(")") || Time33.Text.Contains("-"))
            {
                ToolTip buttonToolTip = new ToolTip();
                //buttonToolTip.ToolTipTitle = "Under 60";
                buttonToolTip.UseFading = true;
                buttonToolTip.UseAnimation = true;
                buttonToolTip.IsBalloon = true;
                buttonToolTip.ShowAlways = true;
                buttonToolTip.AutoPopDelay = 5000;
                buttonToolTip.InitialDelay = 1000;
                buttonToolTip.ReshowDelay = 500;
                if (persianToolStripMenuItem.Checked == true)
                    buttonToolTip.SetToolTip(Time33, "!تنها عدد قابل قبول است");
                else
                    buttonToolTip.SetToolTip(Time33, "Only Numbers!");
            }
        }


        private void Open_movie_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenDialogFrm = new OpenFileDialog();
            OpenDialogFrm.Filter = "ALL Files|*.*|Video|*.mkv;*.avi;*.mpg;*.wmv;*.rmvb;*.vob;*.3gp;*.mov;*.divx";
            OpenDialogFrm.FilterIndex = 2;
            OpenDialogFrm.Title = "Open Movie/Video";

            if (OpenDialogFrm.ShowDialog() == DialogResult.OK)
            {
                VideoTimer.Start();
                axWindowsMediaPlayer1.URL = OpenDialogFrm.FileName;
            }
        }

        string sourceaddress;

        private void Open_original_Sub_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenDialogFrm = new OpenFileDialog();
            OpenDialogFrm.Filter = "Text Files (*.txt)|*.txt|SubRip (*.srt)|*.srt|All File|*.*";
            OpenDialogFrm.FilterIndex = 2;
            OpenDialogFrm.Title = "Open English/Text Subtitle";

            if (OpenDialogFrm.ShowDialog() == DialogResult.OK)
            {

                sourceaddress = OpenDialogFrm.FileName;
                List<string> addtxttolstbox = new List<string>();
                StreamReader ReadSubFromHDD = new StreamReader(OpenDialogFrm.FileName, Encoding.Default);
                while (!ReadSubFromHDD.EndOfStream)
                {
                    addtxttolstbox.Add(ReadSubFromHDD.ReadLine());//ریختن زیرنویس در لیست باکس
                }
                addtxttolstbox.Add("0");//اگه نمیزاشتم اگر خط آخر چند خطی می بود فقط یه خطشو اد میکرد
                int EncoderItemsLineCount = addtxttolstbox.Count;
                int j = 1;

                bool isasrtfile = false;
                for (int i = 0; i < 50; i++)
                {
                    if (addtxttolstbox[i].ToString().Trim().Contains("-->"))
                    {
                        isasrtfile = true;
                        break;
                    }
                }
                if (isasrtfile)
                {
                    //listView1.Clear();
                    saveToolStripMenuItem.Enabled = true;
                    saveAsToolStripMenuItem.Enabled = true;
                    Open_translation_Sub_ToolStripMenuItem.Enabled = true;
                    autoTranslateToolStripMenuItem.Enabled = true;
                    goToToolStripMenuItem.Enabled = true;
                    showDicToolStripMenuItem.Enabled = true;
                    Subtitle_listView.Items.Clear();
                    lvs = 1;

                    for (int i = 0; i < EncoderItemsLineCount; i++)
                    {
                        if (addtxttolstbox[i].ToString().Contains("-->"))
                        {
                            ListViewItem x = Subtitle_listView.Items.Add(j++.ToString());//درج شماره زیرنویس بدون توجه به شماره های خود زیرنویس

                            string[] split = addtxttolstbox[i].ToString().Split(' ');//جدا کردن تایم نمایش و عدم نمایش 0 از 2 تا                   
                            x.SubItems.Add(split[0]);
                            x.SubItems.Add(split[2]);

                            //main adder
                            for (int f = 1; i + f + 1 < EncoderItemsLineCount && !addtxttolstbox[i + f + 1].ToString().Contains("-->"); f++)//f+1 نمیزاه شمار خط لود شه
                                tk += addtxttolstbox[i + f].ToString() + Environment.NewLine;
                            //
                            if (tk != null)//اگه بین تایمرا چیزی نباشه وبه هم چسبیده باشن اینوطری ارور نمیده و تایمرو بدون متن اد میکنه
                            {
                                x.SubItems.Add(tk.Trim());//خط خالی آخرو حذف میکنه
                            }
                            else
                            {
                                x.SubItems.Add("");
                            }
                            tk = null;


                            x.SubItems.Add("- ترجمه نشده -");
                            //tarjome be save rabt nadare pas nazashtam
                            //Prompt_Source += "- ترجمه نشده -";
                        }
                        TranslationBox.Focus();
                        ReadSubFromHDD.Close();
                    }

                    addtxttolstbox.Clear();
                    Subtitle_listView.Items[0].Selected = true;
                    Subtitle_listView.FocusedItem = Subtitle_listView.Items[0];
                    IndexChange();
                    columnHeader_num.AutoResize(System.Windows.Forms.ColumnHeaderAutoResizeStyle.HeaderSize);
                    columnHeader_start.AutoResize(System.Windows.Forms.ColumnHeaderAutoResizeStyle.HeaderSize);
                    columnHeader_end.AutoResize(System.Windows.Forms.ColumnHeaderAutoResizeStyle.HeaderSize);
                    this.Text = "Subtrans " + " - " + OpenDialogFrm.FileName;

                    //
                    SaveForPrompt();
                    //باز کردن ویدیو همنام
                    //mkv
                    if (OpenDialogFrm.FileName != "")
                    {
                        //اگه اینکارو نکنم اگر اول فیلم باز نه بعد زیرنویسی که فیلم نداره رو باز کنه فیلم قطع میشه
                        //اگه زیرنویس جدید بعدش دوباره لود کرد استاپ میکنه که دیگه قبلی رو نشون نده
                        time_lblD.Text = "00:00:00,000";
                        time_lbln.Text = "00:00:00,000";
                        subtitle_lbl.Text = "";
                        //end
                        string path = OpenDialogFrm.FileName.Replace(OpenDialogFrm.SafeFileName, "");
                        string[] filePaths = Directory.GetFiles(path, OpenDialogFrm.SafeFileName.Substring(0, OpenDialogFrm.SafeFileName.Length - 4) + ".mkv");
                        if (filePaths.Length == 1)
                            axWindowsMediaPlayer1.URL = filePaths[0];
                        if (movieOffToolStripMenuItem.Checked)
                            axWindowsMediaPlayer1.Ctlcontrols.stop();
                        //avi
                        if (axWindowsMediaPlayer1.URL == "")//دستور چرت که اگه دوتا فایل همنام ولی با پسوندای مختلف داشتیم اول ام کی وی رو بریزه
                        {
                            string path2 = OpenDialogFrm.FileName.Replace(OpenDialogFrm.SafeFileName, "");
                            string[] filePaths2 = Directory.GetFiles(path2, OpenDialogFrm.SafeFileName.Substring(0, OpenDialogFrm.SafeFileName.Length - 4) + ".avi");
                            if (filePaths2.Length == 1)
                            {
                                axWindowsMediaPlayer1.URL = filePaths2[0];
                            }
                            if (movieOffToolStripMenuItem.Checked)
                                axWindowsMediaPlayer1.Ctlcontrols.stop();
                        }
                        VideoTimer.Start();
                    }
                }
                else
                    MessageBox.Show("[" + OpenDialogFrm.FileName + "]" + " is a invalid file!", "Open source error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoMove_chkBox.Checked == false)
            {
                Seccond_cmbBox.Enabled = false;
                label1.Enabled = false;
                PlaySubtitle_rdobtn.Enabled = false;
                PlaySeccond_rdobtn.Enabled = false;
                DonotPlay_rdobtn.Enabled = false;
            }
            else if (AutoMove_chkBox.Checked == true)
            {
                Seccond_cmbBox.Enabled = true;
                label1.Enabled = true;
                PlaySubtitle_rdobtn.Enabled = true;
                PlaySeccond_rdobtn.Enabled = true;
                DonotPlay_rdobtn.Enabled = true;
            }
        }
        int chk = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            chk++;
            if (chk == Convert.ToInt32(Seccond_cmbBox.SelectedItem))//با کمبو باکس تنظیم میشه ثانیه اش
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                chk = 0;
                SubtitleSeccondTimer.Stop();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            TimeSpan CurrentTime = TimeSpan.FromSeconds(axWindowsMediaPlayer1.Ctlcontrols.currentPosition);
            //string[] split= time_lbln.Text.Split(':',',');
            //TimeSpan CurrentTime = new TimeSpan(0, Convert.ToInt32(split[0]), Convert.ToInt32(split[1]), Convert.ToInt32(split[2]), Convert.ToInt32(split[3]));
            TimeSpan eTime = new TimeSpan(0, Convert.ToInt32(Time20.Text), Convert.ToInt32(Time21.Text), Convert.ToInt32(Time22.Text), Convert.ToInt32(Time23.Text));



            if (eTime.TotalMilliseconds < CurrentTime.TotalMilliseconds)
            {
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition = eTime.TotalSeconds;
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                time_lbln.Text = Time20.Text + ":" + Time21.Text + ":" + Time22.Text + "," + Time23.Text;
                subtitle_lbl.Text = "";
                SubtitlePlayTimer.Stop();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 frm = new AboutBox1();
            frm.Show();
        }


        private void Persian_lng()
        {
            englishToolStripMenuItem.Checked = false;
            persianToolStripMenuItem.Checked = true;

            //file menu
            menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            fileToolStripMenuItem.Text = "فایل";
            newToolStripMenuItem.Text = "جدید";
            openToolStripMenuItem.Text = "باز کردن";
            Open_movie_ToolStripMenuItem.Text = "فیلم";
            Open_original_Sub_ToolStripMenuItem.Text = "متن";
            Open_translation_Sub_ToolStripMenuItem.Text = "ترجمه";
            saveToolStripMenuItem.Text = "ذخیره";
            saveAsToolStripMenuItem.Text = "ذخیره در";
            translationToolStripMenuItem1.Text = "ترجمه";
            translationAsToolStripMenuItem.Text = "ترجمه در";
            originalToolStripMenuItem1.Text = "متن";
            originalAsToolStripMenuItem.Text = "متن در";
            exitToolStripMenuItem.Text = "خروج";
            //edit menu
            editToolStripMenuItem.Text = "ویرایش";
            HistoryToolStripMenuItem.Text = "تاریخچه تغییرات";
            insertToolStripMenuItem.Text = "درج";
            afterToolStripMenuItem.Text = "خط بعدی";
            beforToolStripMenuItem.Text = "خط قبلی";
            deleteToolStripMenuItem.Text = "حذف";
            addToolStripMenuItem.Text = "ترجمه";
            onlyInTranslationToolStripMenuItem.Text = "درج خط جدید در بخش ترجمه";
            onlyFromTranslationToolStripMenuItem1.Text = "حذف خط فعلی از بخش ترجمه";
            fontToolStripMenuItem.Text = "قلم ها";
            subtitleToolStripMenuItem.Text = "زیرنویس";
            OthersToolStripMenuItem.Text = "ترجمه/متن";
            timingToolStripMenuItem.Text = "زمانبندی";
            delayToolStripMenuItem.Text = "دستی";
            shiftPLUS1SeccondToolStripMenuItem.Text = "1 ثانیه اضافه کن";
            shiftMINES1SeccondToolStripMenuItem.Text = "1 ثانیه کم کن";
            findToolStripMenuItem.Text = "جستجو و جایگذاری";
            //view
            viewToolStripMenuItem.Text = "نمایش";
            languageToolStripMenuItem.Text = "زبان";
            englishToolStripMenuItem.Text = "انگلیسی";
            persianToolStripMenuItem.Text = "فارسی";
            toolStripMenuItem1.Text = "حالت";
            movieOnLeftToolStripMenuItem.Text = "نمایش فیلم در چپ";
            movieOnTopMenuItem.Text = "نمایش فیلم در بالا";
            movieOnRightToolStripMenuItem.Text = "نمایش فیلم در راست";
            movieOffToolStripMenuItem.Text = "عدم نمایش فیلم";
            Show_SubtitleToolStripMenuItem1.Text = "نمایش";
            Show_originalToolStripMenuItem.Text = "متن";
            Show_translateToolStripMenuItem.Text = "ترجمه";
            listToolStripMenuItem.Text = "لیست";
            ListAllToolStripMenuItem.Text = "همه";
            ListTransToolStripMenuItem.Text = "ترجمه";
            ListSourceTransToolStripMenuItem.Text = "متن و ترجمه";
            //tools
            toolsToolStripMenuItem.Text = "ابزار";
            persianSupportToolStripMenuItem.Text = "پشتیبانی از فارسی نسخه بتا 2";
            showDicToolStripMenuItem.Text = " دیکشنری (انگلیسی به فارسی)";
            goToToolStripMenuItem.Text = "باز کردن سایت";
            autoTranslateToolStripMenuItem.Text = "ترجمه خودکار";
            //help
            helpToolStripMenuItem.Text = "راهنما";
            helpToolStripMenuItem1.Text = "کمک";
            aboutToolStripMenuItem.Text = "درباره نرم افزار";
            checkForUpdateToolStripMenuItem.Text = "بروز رسانی";
            //group box
            groupBox1.Text = "خط قبلی/بعدی";
            AutoMove_chkBox.Text = "حرکت خودکار";
            SaveTranslation_chkBox.Text = "ذخیره ترجمه";
            PlaySeccond_rdobtn.Text = "ثانیه";
            PlaySubtitle_rdobtn.Text = "پخش تا انتهای زیرنویس";
            label1.Text = "پخش به مدت";
            DonotPlay_rdobtn.Text = "فیلم را پخش نکن";
            //lebels
            Translate_lbl.Text = ":ترجمه";
            Translate_lbl.Location = new Point(splitContainer1.Width - 20, Translate_lbl.Location.Y);//راست چین
            CurrentLine_lbl.Location = new Point(splitContainer2.Location.X - 40 + splitContainer2.Width / 2, CurrentLine_lbl.Location.Y);//چپ چین
            Original_lbl.Location = new Point(splitContainer2.Location.X + splitContainer2.Width / 2 - 25, Original_lbl.Location.Y);//راست چین
            Translate_lbl.Anchor = (System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom);
            Original_lbl.Text = ":متن";
            Original_lbl.Anchor = (System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom);
            Show_lbl.Location = new Point(btn_n1_up.Location.X - 20, Show_lbl.Location.Y);
            Show_lbl.Text = "شروع";
            Hide_lbl.Location = new Point(btn_n2_up.Location.X - 18, Hide_lbl.Location.Y);
            Hide_lbl.Text = "پایان";
            Duration_lbl.Location = new Point(btn_n3_up.Location.X - 12, Duration_lbl.Location.Y);
            Duration_lbl.Text = "مدت";
            if (persianSupportToolStripMenuItem.Checked == true)
            {
                PSIE_D_lbl.Text = "پشتیبانی از فارسی فعال است";
                PSIE_D_lbl.ForeColor = Color.Green;
            }
            else
            {
                PSIE_D_lbl.Text = "پشتیبانی از فارسی غیرفعال است";
                PSIE_D_lbl.ForeColor = Color.Red;
            }
            //listview
            columnHeader_num.Text = "ش";
            columnHeader_start.Text = "شروع";
            columnHeader_end.Text = "پایان";
            columnHeader_source.Text = "متن";
            columnHeader_translation.Text = "ترجمه";
        }
        private void English_lng()
        {
            englishToolStripMenuItem.Checked = true;
            persianToolStripMenuItem.Checked = false;

            //file menu
            menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            fileToolStripMenuItem.Text = "File";
            newToolStripMenuItem.Text = "New";
            openToolStripMenuItem.Text = "Open";
            Open_movie_ToolStripMenuItem.Text = "Movie";
            Open_original_Sub_ToolStripMenuItem.Text = "Source";
            Open_translation_Sub_ToolStripMenuItem.Text = "Translation";
            saveToolStripMenuItem.Text = "Save";
            saveAsToolStripMenuItem.Text = "Save As";
            translationToolStripMenuItem1.Text = "Translation";
            translationAsToolStripMenuItem.Text = "Translation As";
            originalToolStripMenuItem1.Text = "Source";
            originalAsToolStripMenuItem.Text = "Source As";
            exitToolStripMenuItem.Text = "Exit";
            //edit menu
            editToolStripMenuItem.Text = "Edit";
            HistoryToolStripMenuItem.Text = "History";
            insertToolStripMenuItem.Text = "Insert";
            afterToolStripMenuItem.Text = "After";
            beforToolStripMenuItem.Text = "Before";
            deleteToolStripMenuItem.Text = "Delete";
            addToolStripMenuItem.Text = "Translation";
            onlyInTranslationToolStripMenuItem.Text = "Insert (only into translation)";
            onlyFromTranslationToolStripMenuItem1.Text = "Delete (only from translation)";
            fontToolStripMenuItem.Text = "Fonts";
            subtitleToolStripMenuItem.Text = "Subtitle";
            OthersToolStripMenuItem.Text = "Source/Original";
            timingToolStripMenuItem.Text = "Timing";
            delayToolStripMenuItem.Text = "Manual";
            shiftPLUS1SeccondToolStripMenuItem.Text = "Shift +1 Seccond";
            shiftMINES1SeccondToolStripMenuItem.Text = "Shift  -1 Seccond";
            findToolStripMenuItem.Text = "Find and Replace";
            //view
            viewToolStripMenuItem.Text = "View";
            languageToolStripMenuItem.Text = "Language";
            englishToolStripMenuItem.Text = "English";
            persianToolStripMenuItem.Text = "Persian";
            toolStripMenuItem1.Text = "Mode";
            movieOnLeftToolStripMenuItem.Text = "Movie On Left";
            movieOnTopMenuItem.Text = "Movie On Top";
            movieOnRightToolStripMenuItem.Text = "Movie On Right";
            movieOffToolStripMenuItem.Text = "Movie Off";
            Show_SubtitleToolStripMenuItem1.Text = "Display";
            Show_originalToolStripMenuItem.Text = "Source";
            Show_translateToolStripMenuItem.Text = "Translation";
            listToolStripMenuItem.Text = "List";
            ListAllToolStripMenuItem.Text = "All";
            ListTransToolStripMenuItem.Text = "Translation";
            ListSourceTransToolStripMenuItem.Text = "Source And Translation";
            //tools
            toolsToolStripMenuItem.Text = "Tools";
            persianSupportToolStripMenuItem.Text = "Persian Support (Beta 2)";
            showDicToolStripMenuItem.Text = "Dictionary (En to Fa)";
            goToToolStripMenuItem.Text = "Go to";
            autoTranslateToolStripMenuItem.Text = "Auto Translate";
            //help
            helpToolStripMenuItem.Text = "Help";
            helpToolStripMenuItem1.Text = "Help";
            aboutToolStripMenuItem.Text = "About";
            checkForUpdateToolStripMenuItem.Text = "Check for update";
            //group box
            groupBox1.Text = "Next/Previous";
            AutoMove_chkBox.Text = "Auto Move";
            SaveTranslation_chkBox.Text = "Save Translation";
            PlaySeccond_rdobtn.Text = "Play";
            PlaySubtitle_rdobtn.Text = "Play Subtitle Then Stop";
            label1.Text = "Second Then Stop";
            DonotPlay_rdobtn.Text = "Do not play";
            //lebels
            Translate_lbl.Text = "Translation:";
            Translate_lbl.Location = new Point(splitContainer2.Location.X - 2 + splitContainer2.Width / 2, Translate_lbl.Location.Y);//چپ چین
            CurrentLine_lbl.Location = new Point(splitContainer1.Width - 73, CurrentLine_lbl.Location.Y);// راست چین
            Original_lbl.Location = new Point(splitContainer2.Location.X - 2, Original_lbl.Location.Y);//چپ چین
            Original_lbl.Text = "Source:";
            Original_lbl.Anchor = (System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom);
            Show_lbl.Location = new Point(Time10.Location.X - 2, Show_lbl.Location.Y);
            Hide_lbl.Location = new Point(Time20.Location.X - 2, Hide_lbl.Location.Y);
            Duration_lbl.Location = new Point(Time33.Location.X - 2, Duration_lbl.Location.Y);
            Show_lbl.Text = "Start";
            Hide_lbl.Text = "End";
            Duration_lbl.Text = "Duration";
            if (persianSupportToolStripMenuItem.Checked == true)
            {
                PSIE_D_lbl.Text = "Persian Support is Active";
                PSIE_D_lbl.ForeColor = Color.Green;
            }
            else
            {
                PSIE_D_lbl.Text = "Persian Support is inactive";
                PSIE_D_lbl.ForeColor = Color.Red;
            }

            //subtitle listview
            columnHeader_num.Text = "Num";
            columnHeader_start.Text = "Start";
            columnHeader_end.Text = "End";
            columnHeader_source.Text = "Source";
            columnHeader_translation.Text = "Translation";



        }
        private void persianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Persian_lng();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            English_lng();
        }

        private void afterToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Add_After_into_ListView();

        }

        private void beforToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Add_Befor_into_ListView();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete_From_ListView();
        }

        int pschanged = 0;
        private void persianSupportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            pschanged = 1;
            DialogResult reset;
            if (englishToolStripMenuItem.Checked == true)
                reset = MessageBox.Show("You must restart program to changes effect, Exit now?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            else
                reset = MessageBox.Show("شما باید برنامه رو بسته و دوباره اجرا کنید،از برنامه خارج می شوید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (reset == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                axWindowsMediaPlayer1.Ctlcontrols.play();

        }

        private void Add_onlyinto_Translation()
        {
            if (Subtitle_listView.Items.Count > 0)
            {
                History(-5, Subtitle_listView.FocusedItem.Index);
                int fitem = Subtitle_listView.FocusedItem.Index + 1;
                Subtitle_listView.Items.Insert(fitem, "");
                Subtitle_listView.Items[fitem].SubItems.Add("00:00:00,000");
                Subtitle_listView.Items[fitem].SubItems.Add("00:00:00,000");
                Subtitle_listView.Items[fitem].SubItems.Add(" ");
                Subtitle_listView.Items[fitem].SubItems.Add(" ");
                int j = 1;
                for (int i = 0; i < Subtitle_listView.Items.Count; i++)
                {
                    Subtitle_listView.Items[i].SubItems[0].Text = j.ToString();
                    j++;
                }
                lvs += 1;
                for (int i = fitem; i < Subtitle_listView.Items.Count - 1; i++)
                {
                    Subtitle_listView.Items[i].SubItems[1].Text = Subtitle_listView.Items[i + 1].SubItems[1].Text;
                    Subtitle_listView.Items[i].SubItems[2].Text = Subtitle_listView.Items[i + 1].SubItems[2].Text;
                    Subtitle_listView.Items[i].SubItems[3].Text = Subtitle_listView.Items[i + 1].SubItems[3].Text;
                }
                Subtitle_listView.Items[Subtitle_listView.Items.Count - 1].SubItems[3].Text = "";//delete duplicated valu of end line
                // Subtitle_listView.Items.Remove(Subtitle_listView.Items[Subtitle_listView.Items.Count - 1]);//easy delete item end
                IndexChange();
            }

        }

        private void onlyInTranslationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_onlyinto_Translation();
        }

        private void Del_Onlyfrom_Translation()
        {
            DialogResult Result_exit;
            if (englishToolStripMenuItem.Checked == true)
                Result_exit = MessageBox.Show("Are You Sure?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            else
                Result_exit = MessageBox.Show("آیا اطمینان دارید؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (Result_exit == DialogResult.Yes)
            {
                if (Subtitle_listView.Items.Count > 0)
                {
                    History(-6, Subtitle_listView.FocusedItem.Index);//0 - yani hich taghiiry da teda anasor list rooy nadae va koleshoo dobare bargardoone
                    int fitem = Subtitle_listView.FocusedItem.Index;
                    for (int i = fitem; i < Subtitle_listView.Items.Count - 1; i++)
                    {
                        Subtitle_listView.Items[i].SubItems[4].Text = Subtitle_listView.Items[i + 1].SubItems[4].Text;
                    }
                    Subtitle_listView.Items[Subtitle_listView.Items.Count - 1].SubItems[4].Text = "- ترجمه نشده -";
                    IndexChange();
                }
            }
        }

        private void onlyFromTranslationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Del_Onlyfrom_Translation();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            IndexChange();
        }

        private void Show_originalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_originalToolStripMenuItem.Checked = true;
            Show_translateToolStripMenuItem.Checked = false;
        }

        private void Show_translateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_originalToolStripMenuItem.Checked = false;
            Show_translateToolStripMenuItem.Checked = true;
        }

        private void OnlyinsertDigit_keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            PlaySeccond_rdobtn.Checked = true;
        }

        private void radiobtn_show_CheckedChanged(object sender, EventArgs e)
        {
            btn_d2_Down.Enabled = false;
            btn_n2_Down.Enabled = false;
            btn_s2_Down.Enabled = false;
            btn_h2_Down.Enabled = false;

            btn_d2_up.Enabled = false;
            btn_n2_up.Enabled = false;
            btn_s2_up.Enabled = false;
            btn_h2_up.Enabled = false;

            Time20.Enabled = false;
            Time21.Enabled = false;
            Time22.Enabled = false;
            Time23.Enabled = false;

            Hide_lbl.Enabled = false;

            btn_n3_Down.Enabled = true;
            btn_n3_up.Enabled = true;
            Duration_lbl.Enabled = true;
            Time33.Enabled = true;

        }

        private void radiobtn_Duration_CheckedChanged(object sender, EventArgs e)
        {
            btn_n3_Down.Enabled = false;
            btn_n3_up.Enabled = false;
            Duration_lbl.Enabled = false;
            Time33.Enabled = false;

            btn_d2_Down.Enabled = true;
            btn_n2_Down.Enabled = true;
            btn_s2_Down.Enabled = true;
            btn_h2_Down.Enabled = true;

            btn_d2_up.Enabled = true;
            btn_n2_up.Enabled = true;
            btn_s2_up.Enabled = true;
            btn_h2_up.Enabled = true;

            Time20.Enabled = true;
            Time21.Enabled = true;
            Time22.Enabled = true;
            Time23.Enabled = true;

            Hide_lbl.Enabled = true;
        }

        private void radiobtn_Both_CheckedChanged(object sender, EventArgs e)
        {
            btn_d2_Down.Enabled = true;
            btn_n2_Down.Enabled = true;
            btn_s2_Down.Enabled = true;
            btn_h2_Down.Enabled = true;

            btn_d2_up.Enabled = true;
            btn_n2_up.Enabled = true;
            btn_s2_up.Enabled = true;
            btn_h2_up.Enabled = true;

            Time20.Enabled = true;
            Time21.Enabled = true;
            Time22.Enabled = true;
            Time23.Enabled = true;

            Hide_lbl.Enabled = true;

            btn_n3_Down.Enabled = true;
            btn_n3_up.Enabled = true;
            Duration_lbl.Enabled = true;
            Time33.Enabled = true;
        }

        private void listView1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                IndexChange();
            }
            else if (e.KeyCode == Keys.Up)
            {
                IndexChange();
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (englishToolStripMenuItem.Checked == true)
                Translate_lbl.Location = new Point(splitContainer2.Location.X + splitContainer2.Width / 2, Translate_lbl.Location.Y);//چپ چین  
            else
                Original_lbl.Location = new Point(splitContainer2.Location.X + splitContainer2.Width / 2 - 25, Original_lbl.Location.Y);//راست چین
        }


        private void axWindowsMediaPlayer1_PositionChange(object sender, AxWMPLib._WMPOCXEvents_PositionChangeEvent e)
        {
            subtitle_lbl.Text = "";//برای درست کردن نشنون دادن ساب وقتی میرم رو یه جای دیگه ای از فیلم اینو گذاشتم
        }

        private void Google_btn_Click(object sender, EventArgs e)
        {
            if (Subtitle_listView.Items.Count > 0 && EntextBox.Text != "")
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                if (EntextBox.SelectedText != "")
                    System.Diagnostics.Process.Start("http://translate.google.com/#auto|fa|" + EntextBox.SelectedText.Replace(Environment.NewLine, "%0A"));
                else
                    System.Diagnostics.Process.Start("http://translate.google.com/#auto|fa|" + EntextBox.Text.Replace(Environment.NewLine, "%0A"));
                EntextBox.Focus();
            }
        }

        private void translateCurrentSourceWithGoogleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Subtitle_listView.Items.Count > 0 && EntextBox.Text != "")
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                if (EntextBox.SelectedText != "")
                    System.Diagnostics.Process.Start("http://translate.google.com/#auto|fa|" + EntextBox.SelectedText.Replace(Environment.NewLine, "%0A"));
                else
                    System.Diagnostics.Process.Start("http://translate.google.com/#auto|fa|" + EntextBox.Text.Replace(Environment.NewLine, "%0A"));
                EntextBox.Focus();
            }
        }

        private void TheFreeDic_Click(object sender, EventArgs e)
        {
            if (Subtitle_listView.Items.Count > 0)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                if (EntextBox.SelectedText != "")
                {
                    string text=EntextBox.SelectedText.Trim().Replace(" ", "+");
                    text = text.Replace(Environment.NewLine, "+");
                    System.Diagnostics.Process.Start("http://www.thefreedictionary.com/" +text );
                }
                else
                {
                    if (englishToolStripMenuItem.Checked)
                        MessageBox.Show("Please, select the word(s) and try again!");
                    else
                        MessageBox.Show("!لطفا کلمه(ها) مورد نظرتان را انتخاب کرده و مجددا تلاش نمایید");
                    EntextBox.Focus();
                }
            }
        }

        private void translateSelectedTextViaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Subtitle_listView.Items.Count > 0)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                if (EntextBox.SelectedText != "")
                {
                    string text = EntextBox.SelectedText.Trim().Replace(" ", "+");
                    text = text.Replace(Environment.NewLine, "+");
                    System.Diagnostics.Process.Start("http://www.thefreedictionary.com/" + text);
                }
                else
                {
                    if (englishToolStripMenuItem.Checked)
                        MessageBox.Show("Please, select the word(s) and try again!");
                    else
                        MessageBox.Show("!لطفا کلمه(ها) مورد نظرتان را انتخاب کرده و مجددا تلاش نمایید");
                    EntextBox.Focus();
                }
            }

        }

        public void History(int number, int index)
        {
            HistoryToolStripMenuItem.Enabled = true;

            //Copy All items in the history array
            string listShadow = "";
            foreach (ListViewItem item in Subtitle_listView.Items)
            {
                listShadow += item.SubItems[0].Text + "ʬ";//parts symbol
                listShadow += item.SubItems[1].Text + "ʬ";
                listShadow += item.SubItems[2].Text + "ʬ";
                listShadow += item.SubItems[3].Text + "ʬ";
                listShadow += item.SubItems[4].Text + "ʭ";//new line symbol
            }

            HistoryArray.Add(number + "ƾ" + index + "ƾ" + listShadow);//type and index symbol

            if (HistoryArray.Count > 10)
            {
                HistoryArray.RemoveAt(0);
            }
        }


        public void UndoHistory(int index)//for history form
        {

            string[] splitType = HistoryArray[index].Split('ƾ');//joda kardan kode amaliat (number) va index list va etelaat

            //Undo Delted Items
            if (int.Parse(splitType[0]) > 0)
            {
                for (int i = 0; i < int.Parse(splitType[0]); i++)
                {
                    //add empty lisn(S) to fill theme with previuse backup
                    Subtitle_listView.Items.Insert(0, "");
                    Subtitle_listView.Items[0].SubItems.Add("");
                    Subtitle_listView.Items[0].SubItems.Add("");
                    Subtitle_listView.Items[0].SubItems.Add("");
                    Subtitle_listView.Items[0].SubItems.Add("");
                }
            }

            //fill subtitle list with backup
            string[] split = splitType[2].Split('ʭ');
            for (int i = 0; i < Subtitle_listView.Items.Count; i++)
            {
                if (split[i] != "")
                {
                    string[] splitParts = split[i].Split('ʬ');
                    Subtitle_listView.Items[i].SubItems[0].Text = splitParts[0];
                    Subtitle_listView.Items[i].SubItems[1].Text = splitParts[1];
                    Subtitle_listView.Items[i].SubItems[2].Text = splitParts[2];
                    Subtitle_listView.Items[i].SubItems[3].Text = splitParts[3];
                    Subtitle_listView.Items[i].SubItems[4].Text = splitParts[4];
                }
            }
            //undo inserted item.
            if (int.Parse(splitType[0]) == -1 || int.Parse(splitType[0]) == -2 || int.Parse(splitType[0]) == -5)//-5 insert into translation
            {
                //delete inserted line
                Subtitle_listView.Items.Remove(Subtitle_listView.Items[Subtitle_listView.Items.Count - 1]);
            }
            //go to index
            Subtitle_listView.SelectedItems.Clear();
            int indexNum = int.Parse(splitType[1]);
            Subtitle_listView.Focus();
            Subtitle_listView.Items[indexNum].Selected = true;
            Subtitle_listView.FocusedItem = Subtitle_listView.Items[indexNum];
            Subtitle_listView.EnsureVisible(indexNum);

            if (index < 0)
            {
                HistoryToolStripMenuItem.Enabled = false;
            }
            IndexChange();
            HistoryArray.RemoveAt(index);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Subtrans.HistoryFrm hf = new Subtrans.HistoryFrm(this);
            hf.Show();
            HistoryToolStripMenuItem.Enabled = false;
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (HistoryArray.Count > 0 && Subtitle_listView.Items.Count > 0)
            {

            }
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + "\\Help\\Help.jpg"))
                System.Diagnostics.Process.Start(Application.StartupPath + "\\Help\\Help.jpg");
            else
                MessageBox.Show("Not Found!");
        }

        private void Color_Code_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if (TranslationBox.Text != "")
                {
                    if (TranslationBox.SelectedText != "")
                        TranslationBox.Text = TranslationBox.Text.Replace(TranslationBox.SelectedText, "<font color=" + ColorTranslator.ToHtml(colorDialog1.Color) + ">" + RTLCorrection.Correction(TranslationBox.SelectedText) + "</font>");
                    else
                        TranslationBox.Text = TranslationBox.Text.Replace(TranslationBox.Text, "<font color=" + ColorTranslator.ToHtml(colorDialog1.Color) + ">" + RTLCorrection.Correction(TranslationBox.Text) + "</font>");
                }
            }
        }

        private void playpauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
                axWindowsMediaPlayer1.Ctlcontrols.pause();
            else
                axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void numToolStripMenuItem_Click(object sender, EventArgs e)
        {
            columnHeader_num.AutoResize(System.Windows.Forms.ColumnHeaderAutoResizeStyle.HeaderSize);
            columnHeader_start.AutoResize(System.Windows.Forms.ColumnHeaderAutoResizeStyle.HeaderSize);
            columnHeader_end.AutoResize(System.Windows.Forms.ColumnHeaderAutoResizeStyle.HeaderSize);
            columnHeader_source.Width = 200;
            columnHeader_translation.Width = 200;
            ListAllToolStripMenuItem.Checked = true;
            ListTransToolStripMenuItem.Checked = false;
            ListSourceTransToolStripMenuItem.Checked = false;

        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            columnHeader_source.Width = 0;
            columnHeader_num.Width = 0;
            columnHeader_start.Width = 0;
            columnHeader_end.Width = 0;
            columnHeader_translation.AutoResize(System.Windows.Forms.ColumnHeaderAutoResizeStyle.HeaderSize);
            ListAllToolStripMenuItem.Checked = false;
            ListTransToolStripMenuItem.Checked = true;
            ListSourceTransToolStripMenuItem.Checked = false;
        }

        private void endToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Orientation == Orientation.Horizontal)
            {
                columnHeader_source.Width = 450;
                columnHeader_translation.Width = 450;
                columnHeader_num.Width = 0;
                columnHeader_start.Width = 0;
                columnHeader_end.Width = 0;
                ListAllToolStripMenuItem.Checked = false;
                ListTransToolStripMenuItem.Checked = false;
                ListSourceTransToolStripMenuItem.Checked = true;
            }
            else
            {
                columnHeader_source.Width = 200;
                columnHeader_num.Width = 0;
                columnHeader_start.Width = 0;
                columnHeader_end.Width = 0;
                columnHeader_translation.Width = 200;
                ListAllToolStripMenuItem.Checked = false;
                ListTransToolStripMenuItem.Checked = false;
                ListSourceTransToolStripMenuItem.Checked = true;
            }
        }

        private void switchListNTrasnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Subtitle_listView.Visible)
            {
                if (TranslationBox.Focused)
                    Subtitle_listView.Focus();
                else
                    TranslationBox.Focus();
            }
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Subtrans.Find find = new Subtrans.Find();
            find.Show();
        }

        private void findToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //if (listView1.Items.Count > 0)
            {
                Subtrans.Find find = new Subtrans.Find(this);
                find.Show();
                findToolStripMenuItem.Enabled = false;

            }
        }
        public void getReplaceText(string find, string replace, bool match)
        {
            if (Subtitle_listView.Items.Count > 0)
            {
                History(-3, Subtitle_listView.FocusedItem.Index);//-3 is replace key
                for (int i = 0; i < Subtitle_listView.Items.Count; i++)
                {
                    if (!match)
                    {
                        Subtitle_listView.Items[i].SubItems[3].Text = Subtitle_listView.Items[i].SubItems[3].Text.ToLower().Replace(find.ToLower(), replace.ToLower());
                        Subtitle_listView.Items[i].SubItems[4].Text = Subtitle_listView.Items[i].SubItems[4].Text.ToLower().Replace(find.ToLower(), replace.ToLower());
                    }
                    else
                    {
                        Subtitle_listView.Items[i].SubItems[3].Text = Subtitle_listView.Items[i].SubItems[3].Text.Replace(find, replace);
                        Subtitle_listView.Items[i].SubItems[4].Text = Subtitle_listView.Items[i].SubItems[4].Text.Replace(find, replace);
                    }
                }
                IndexChange();
            }
        }

        public int index, findex;
        public void getFindText(string text, bool match, bool su)
        {
            if (Subtitle_listView.Items.Count > 0)
            {
                History(0, Subtitle_listView.FocusedItem.Index);
                Subtitle_listView.SelectedItems.Clear();
                if (!su)
                {
                    for (int i = index; i < Subtitle_listView.Items.Count; i++)
                    {
                        string source, translation, find_text;
                        if (match)
                        {
                            source = Subtitle_listView.Items[i].SubItems[3].Text;
                            translation = Subtitle_listView.Items[i].SubItems[4].Text;
                            find_text = text;
                        }
                        else
                        {
                            source = Subtitle_listView.Items[i].SubItems[3].Text.ToLower();
                            translation = Subtitle_listView.Items[i].SubItems[4].Text.ToLower();
                            find_text = text.ToLower();
                        }

                        if (source.Contains(find_text) || translation.Contains(find_text))
                        {
                            Subtitle_listView.FocusedItem = Subtitle_listView.Items[i];
                            Subtitle_listView.Items[i].Selected = true;
                            Subtitle_listView.EnsureVisible(i);
                            IndexChange();
                            index = i + 1;
                            break;
                        }
                    }
                }
                else
                {
                    for (int i = index; i >= 0; i--)
                    {
                        string source, translation, find_text;
                        if (match)
                        {
                            source = Subtitle_listView.Items[i].SubItems[3].Text;
                            translation = Subtitle_listView.Items[i].SubItems[4].Text;
                            find_text = text;
                        }
                        else
                        {
                            source = Subtitle_listView.Items[i].SubItems[3].Text.ToLower();
                            translation = Subtitle_listView.Items[i].SubItems[4].Text.ToLower();
                            find_text = text.ToLower();
                        }

                        if (source.Contains(find_text) || translation.Contains(find_text))
                        {
                            Subtitle_listView.FocusedItem = Subtitle_listView.Items[i];
                            Subtitle_listView.Items[i].Selected = true;
                            Subtitle_listView.EnsureVisible(i);
                            IndexChange();
                            if (index > 0)
                                index = i - 1;
                            break;
                        }
                    }
                }
            }
        }

        private void ctrlrReloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimeSpan ConvertTime = new TimeSpan(0, Convert.ToInt32(Time10.Text), Convert.ToInt32(Time11.Text), Convert.ToInt32(Time12.Text), Convert.ToInt32(Time13.Text));
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = ConvertTime.TotalSeconds;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            SubtitlePlayTimer.Start();

        }

        private void delayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Subtrans.Delay dl = new Subtrans.Delay(this);
            dl.Show();
            delayToolStripMenuItem.Enabled = false;
        }
        public void SetDelay(double delaytime, bool type)
        {
            if (Subtitle_listView.Items.Count > 0)
            {
                History(-4, Subtitle_listView.FocusedItem.Index);
                if (type)
                {
                    foreach (ListViewItem item in Subtitle_listView.SelectedItems)
                    {
                        //Start time
                        string[] Startsplit = item.SubItems[1].Text.Split(':', ',');
                        TimeSpan Stime = new TimeSpan(0, Convert.ToInt32(Startsplit[0]), Convert.ToInt32(Startsplit[1]), Convert.ToInt32(Startsplit[2]), Convert.ToInt32(Startsplit[3]));
                        double s = Stime.TotalSeconds;
                        s += delaytime;
                        TimeSpan Start = TimeSpan.FromSeconds(s);
                        item.SubItems[1].Text = String.Format("{0:00}:{1:00}:{2:00},{3:000}", Start.Hours, Start.Minutes, Start.Seconds, Start.Milliseconds);
                        ////////////

                        //End time
                        string[] Endtsplit = item.SubItems[2].Text.Split(':', ',');
                        TimeSpan Etime = new TimeSpan(0, Convert.ToInt32(Endtsplit[0]), Convert.ToInt32(Endtsplit[1]), Convert.ToInt32(Endtsplit[2]), Convert.ToInt32(Endtsplit[3]));
                        double E = Etime.TotalSeconds;
                        E += delaytime;
                        TimeSpan End = TimeSpan.FromSeconds(E);
                        item.SubItems[2].Text = String.Format("{0:00}:{1:00}:{2:00},{3:000}", End.Hours, End.Minutes, End.Seconds, End.Milliseconds);
                        /////////////
                    }
                }

                else
                {
                    foreach (ListViewItem item in Subtitle_listView.Items)
                    {
                        //Start time
                        string[] Startsplit = item.SubItems[1].Text.Split(':', ',');
                        TimeSpan Stime = new TimeSpan(0, Convert.ToInt32(Startsplit[0]), Convert.ToInt32(Startsplit[1]), Convert.ToInt32(Startsplit[2]), Convert.ToInt32(Startsplit[3]));
                        double s = Stime.TotalSeconds;
                        s += delaytime;
                        TimeSpan Start = TimeSpan.FromSeconds(s);
                        item.SubItems[1].Text = String.Format("{0:00}:{1:00}:{2:00},{3:000}", Start.Hours, Start.Minutes, Start.Seconds, Start.Milliseconds);
                        ////////////

                        //End time
                        string[] Endtsplit = item.SubItems[2].Text.Split(':', ',');
                        TimeSpan Etime = new TimeSpan(0, Convert.ToInt32(Endtsplit[0]), Convert.ToInt32(Endtsplit[1]), Convert.ToInt32(Endtsplit[2]), Convert.ToInt32(Endtsplit[3]));
                        double E = Etime.TotalSeconds;
                        E += delaytime;
                        TimeSpan End = TimeSpan.FromSeconds(E);
                        item.SubItems[2].Text = String.Format("{0:00}:{1:00}:{2:00},{3:000}", End.Hours, End.Minutes, End.Seconds, End.Milliseconds);
                        /////////////
                    }
                }
                IndexChange();
            }
        }

        private void shiftPLUS1SeccondToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Subtitle_listView.Items.Count > 0)
            {
                History(-7, Subtitle_listView.FocusedItem.Index);
                if (Subtitle_listView.SelectedItems.Count > 1)
                {
                    foreach (ListViewItem item in Subtitle_listView.SelectedItems)
                    {
                        //Start time
                        string[] Startsplit = item.SubItems[1].Text.Split(':', ',');
                        TimeSpan Stime = new TimeSpan(0, Convert.ToInt32(Startsplit[0]), Convert.ToInt32(Startsplit[1]), Convert.ToInt32(Startsplit[2]), Convert.ToInt32(Startsplit[3]));
                        double s = Stime.TotalSeconds;
                        s += 1;
                        TimeSpan Start = TimeSpan.FromSeconds(s);
                        item.SubItems[1].Text = String.Format("{0:00}:{1:00}:{2:00},{3:000}", Start.Hours, Start.Minutes, Start.Seconds, Start.Milliseconds);
                        ////////////

                        //End time
                        string[] Endtsplit = item.SubItems[2].Text.Split(':', ',');
                        TimeSpan Etime = new TimeSpan(0, Convert.ToInt32(Endtsplit[0]), Convert.ToInt32(Endtsplit[1]), Convert.ToInt32(Endtsplit[2]), Convert.ToInt32(Endtsplit[3]));
                        double E = Etime.TotalSeconds;
                        E += 1;
                        TimeSpan End = TimeSpan.FromSeconds(E);
                        item.SubItems[2].Text = String.Format("{0:00}:{1:00}:{2:00},{3:000}", End.Hours, End.Minutes, End.Seconds, End.Milliseconds);
                        /////////////
                    }
                }
                else
                {
                    foreach (ListViewItem item in Subtitle_listView.Items)
                    {
                        //Start time
                        string[] Startsplit = item.SubItems[1].Text.Split(':', ',');
                        TimeSpan Stime = new TimeSpan(0, Convert.ToInt32(Startsplit[0]), Convert.ToInt32(Startsplit[1]), Convert.ToInt32(Startsplit[2]), Convert.ToInt32(Startsplit[3]));
                        double s = Stime.TotalSeconds;
                        s += 1;
                        TimeSpan Start = TimeSpan.FromSeconds(s);
                        item.SubItems[1].Text = String.Format("{0:00}:{1:00}:{2:00},{3:000}", Start.Hours, Start.Minutes, Start.Seconds, Start.Milliseconds);
                        ////////////

                        //End time
                        string[] Endtsplit = item.SubItems[2].Text.Split(':', ',');
                        TimeSpan Etime = new TimeSpan(0, Convert.ToInt32(Endtsplit[0]), Convert.ToInt32(Endtsplit[1]), Convert.ToInt32(Endtsplit[2]), Convert.ToInt32(Endtsplit[3]));
                        double E = Etime.TotalSeconds;
                        E += 1;
                        TimeSpan End = TimeSpan.FromSeconds(E);
                        item.SubItems[2].Text = String.Format("{0:00}:{1:00}:{2:00},{3:000}", End.Hours, End.Minutes, End.Seconds, End.Milliseconds);
                        /////////////
                    }
                }
                IndexChange();
            }
        }

        private void shiftMINES1SeccondToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Subtitle_listView.Items.Count > 0)
            {
                History(-8, Subtitle_listView.FocusedItem.Index);
                if (Subtitle_listView.SelectedItems.Count > 1)
                {
                    foreach (ListViewItem item in Subtitle_listView.SelectedItems)
                    {
                        //Start time
                        string[] Startsplit = item.SubItems[1].Text.Split(':', ',');
                        TimeSpan Stime = new TimeSpan(0, Convert.ToInt32(Startsplit[0]), Convert.ToInt32(Startsplit[1]), Convert.ToInt32(Startsplit[2]), Convert.ToInt32(Startsplit[3]));
                        double s = Stime.TotalSeconds;
                        s -= 1;
                        TimeSpan Start = TimeSpan.FromSeconds(s);
                        item.SubItems[1].Text = String.Format("{0:00}:{1:00}:{2:00},{3:000}", Start.Hours, Start.Minutes, Start.Seconds, Start.Milliseconds);
                        ////////////

                        //End time
                        string[] Endtsplit = item.SubItems[2].Text.Split(':', ',');
                        TimeSpan Etime = new TimeSpan(0, Convert.ToInt32(Endtsplit[0]), Convert.ToInt32(Endtsplit[1]), Convert.ToInt32(Endtsplit[2]), Convert.ToInt32(Endtsplit[3]));
                        double E = Etime.TotalSeconds;
                        E += 1;
                        TimeSpan End = TimeSpan.FromSeconds(E);
                        item.SubItems[2].Text = String.Format("{0:00}:{1:00}:{2:00},{3:000}", End.Hours, End.Minutes, End.Seconds, End.Milliseconds);
                        /////////////
                    }
                }
                else
                {
                    foreach (ListViewItem item in Subtitle_listView.Items)
                    {
                        //Start time
                        string[] Startsplit = item.SubItems[1].Text.Split(':', ',');
                        TimeSpan Stime = new TimeSpan(0, Convert.ToInt32(Startsplit[0]), Convert.ToInt32(Startsplit[1]), Convert.ToInt32(Startsplit[2]), Convert.ToInt32(Startsplit[3]));
                        double s = Stime.TotalSeconds;
                        s -= 1;
                        TimeSpan Start = TimeSpan.FromSeconds(s);
                        item.SubItems[1].Text = String.Format("{0:00}:{1:00}:{2:00},{3:000}", Start.Hours, Start.Minutes, Start.Seconds, Start.Milliseconds);
                        ////////////

                        //End time
                        string[] Endtsplit = item.SubItems[2].Text.Split(':', ',');
                        TimeSpan Etime = new TimeSpan(0, Convert.ToInt32(Endtsplit[0]), Convert.ToInt32(Endtsplit[1]), Convert.ToInt32(Endtsplit[2]), Convert.ToInt32(Endtsplit[3]));
                        double E = Etime.TotalSeconds;
                        E += 1;
                        TimeSpan End = TimeSpan.FromSeconds(E);
                        item.SubItems[2].Text = String.Format("{0:00}:{1:00}:{2:00},{3:000}", End.Hours, End.Minutes, End.Seconds, End.Milliseconds);
                        /////////////
                    }
                }
                IndexChange();
            }
        }

        private void checkForUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://subtrans.tvshow.ir/forumdisplay.php?f=590");
        }

        private void show_dictionary()
        {
            if (showDicToolStripMenuItem.Checked)
            {
                showDicToolStripMenuItem.Checked = false;
                dictionary_btn.Text = "Dictionary";
            }
            else
            {
                showDicToolStripMenuItem.Checked = true;
                dictionary_btn.Text = "List";
            }

            if (showDicToolStripMenuItem.Checked)
            {
                Subtitle_listView.Visible = false;
                Dictionary_listView.Visible = true;

            }
            if (!showDicToolStripMenuItem.Checked)
            {
                Subtitle_listView.Visible = true;
                Dictionary_listView.Visible = false;
            }
            GenerateDicForDiclistview();

        }
        private void showDicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            show_dictionary();
        }
        private void GenerateDicForDiclistview()
        {
            if (Subtitle_listView.Items.Count > 0)
            {
                Dictionary_listView.Items.Clear();
                string[] words = Subtrans.EnToFaDic.Meanings(EntextBox.Text, Dic_List, false).Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < words.Length; i += 2)
                {
                    ListViewItem item = Dictionary_listView.Items.Add(words[i]);
                    item.SubItems.Add(words[i + 1]);
                }

                foreach (ListViewItem item in Dictionary_listView.Items)
                {
                    item.UseItemStyleForSubItems = false;
                    item.Font = new Font(Dictionary_listView.Font, FontStyle.Bold);
                }
                Col_header_Engilsh.AutoResize(System.Windows.Forms.ColumnHeaderAutoResizeStyle.HeaderSize);
                Col_header_Persian.AutoResize(System.Windows.Forms.ColumnHeaderAutoResizeStyle.HeaderSize);
            }

        }

        private void dictionary_btn_Click(object sender, EventArgs e)
        {
            show_dictionary();
        }

        private void insertAfter_btn_Click(object sender, EventArgs e)
        {
            Add_After_into_ListView();
        }

        private void insertBefore_btn_Click(object sender, EventArgs e)
        {
            Add_Befor_into_ListView();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            PlaySeccond_rdobtn.Checked = true;
        }

        private void EntextBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (Subtitle_listView.Items.Count > 0)
            {
                if (e.KeyCode == Keys.PageDown || e.Shift && e.KeyCode == Keys.Enter || e.KeyCode == Keys.F12)
                {
                    if (Subtitle_listView.FocusedItem.Index + 1 < Subtitle_listView.Items.Count)
                    {
                        int savecurrentindex = Subtitle_listView.FocusedItem.Index + 1;
                        Subtitle_listView.SelectedItems.Clear();
                        Subtitle_listView.Items[savecurrentindex].Selected = true;
                        Subtitle_listView.Items[savecurrentindex].Focused = true;
                        IndexChange();
                        Subtitle_listView.FocusedItem.EnsureVisible();
                    }
                    if (AutoMove_chkBox.Checked && axWindowsMediaPlayer1.URL != "" && !splitContainer1.Panel1Collapsed && !splitContainer1.Panel2Collapsed)//در حالت مووی آف دیگه این کارو نمیکنه
                    {
                        if (!DonotPlay_rdobtn.Checked)
                        {
                            TimeSpan ConvertTime = new TimeSpan(0, Convert.ToInt32(Time10.Text), Convert.ToInt32(Time11.Text), Convert.ToInt32(Time12.Text), Convert.ToInt32(Time13.Text));
                            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = ConvertTime.TotalSeconds;
                            axWindowsMediaPlayer1.Ctlcontrols.play();
                            if (PlaySeccond_rdobtn.Checked)
                                SubtitleSeccondTimer.Start();
                            else if (PlaySubtitle_rdobtn.Checked)
                                SubtitlePlayTimer.Start();
                        }
                        else
                        {
                            TimeSpan ConvertTime = new TimeSpan(0, Convert.ToInt32(Time10.Text), Convert.ToInt32(Time11.Text), Convert.ToInt32(Time12.Text), Convert.ToInt32(Time13.Text));
                            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = ConvertTime.TotalSeconds;
                            time_lbln.Text = Time10.Text + ":" + Time11.Text + ":" + Time12.Text + "," + Time13.Text;
                            axWindowsMediaPlayer1.Ctlcontrols.pause();
                        }
                    }
                    if (SaveTranslation_chkBox.Checked)
                    {
                        if (Auto_save_trans == null)
                        {
                            if (englishToolStripMenuItem.Checked)
                                MessageBox.Show("'Save Translation' is on ,Please choose where you want to save the translation. (You Can Change it From File-> Save As-> Translation As)");
                            else
                                MessageBox.Show("ذخیره ترجمه فعال است، لطفا محل ذخیره سازی ترجمه را مشخص کنید. شما میتوانید از مسیر فایل-> ذخیره در-> ترجمه در، این آدرس را تعویض نمایید");
                            Save_As_Translate();
                        }
                        else
                            Save_Translate();
                    }
                    e.SuppressKeyPress = true;//جلوگیری از اجرای کلید ها بعد از تمام شدن دستورات
                }

                if (e.KeyCode == Keys.PageUp || e.Control && e.KeyCode == Keys.Enter || e.KeyCode == Keys.F1)
                {
                    if (Subtitle_listView.FocusedItem.Index - 1 >= 0)//خط قبلی
                    {
                        int savecurrentindex = Subtitle_listView.FocusedItem.Index - 1;
                        Subtitle_listView.SelectedItems.Clear();
                        Subtitle_listView.Items[savecurrentindex].Selected = true;
                        Subtitle_listView.Items[savecurrentindex].Focused = true;
                        IndexChange();
                        Subtitle_listView.FocusedItem.EnsureVisible();
                    }
                    if (AutoMove_chkBox.Checked && axWindowsMediaPlayer1.URL != "" && !splitContainer1.Panel1Collapsed && !splitContainer1.Panel2Collapsed)//در حالت مووی آف دیگه این کارو نمیکنه
                    {
                        if (!DonotPlay_rdobtn.Checked)
                        {
                            TimeSpan ConvertTime = new TimeSpan(0, Convert.ToInt32(Time10.Text), Convert.ToInt32(Time11.Text), Convert.ToInt32(Time12.Text), Convert.ToInt32(Time13.Text));
                            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = ConvertTime.TotalSeconds;
                            axWindowsMediaPlayer1.Ctlcontrols.play();
                            if (PlaySeccond_rdobtn.Checked)
                                SubtitleSeccondTimer.Start();
                            else if (PlaySubtitle_rdobtn.Checked)
                                SubtitlePlayTimer.Start();
                        }
                        else
                        {
                            TimeSpan ConvertTime = new TimeSpan(0, Convert.ToInt32(Time10.Text), Convert.ToInt32(Time11.Text), Convert.ToInt32(Time12.Text), Convert.ToInt32(Time13.Text));
                            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = ConvertTime.TotalSeconds;

                            time_lbln.Text = Time10.Text + ":" + Time11.Text + ":" + Time12.Text + "," + Time13.Text;
                            axWindowsMediaPlayer1.Ctlcontrols.pause();
                        }
                    }
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.PageDown || e.Shift && e.KeyCode == Keys.Enter || e.KeyCode == Keys.F12)
            {
                keydown();
                SaveTranslationOnKeyDown();
                e.SuppressKeyPress = true;
            }

            if (e.KeyCode == Keys.PageUp || e.Control && e.KeyCode == Keys.Enter || e.KeyCode == Keys.F1)
            {
                keyup();
                SaveTranslationOnKeyDown();
                e.SuppressKeyPress = true;
            }
        }

        private void autoTranslateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Subtrans.AutoTranslateFRM at = new Subtrans.AutoTranslateFRM(this);
            at.Show();
            autoTranslateToolStripMenuItem.Enabled = false;
        }

        
    }

}

