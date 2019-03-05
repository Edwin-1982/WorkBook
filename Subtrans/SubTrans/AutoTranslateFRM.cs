using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace Subtrans
{
    public partial class AutoTranslateFRM : Form
    {
        Form myMainform;
        public AutoTranslateFRM()
        {
            InitializeComponent();
        }
        public AutoTranslateFRM(SubTrans.MainForm pad)
        {
            myMainform = pad;
            InitializeComponent();
        }

        private bool CheckInternetConnection()
        {
            try
            {
                IPHostEntry chkConnection = System.Net.Dns.GetHostByName("translate.google.com");
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void StartTranslate_Click(object sender, EventArgs e)
        {
            i = 0;
            Cancel_btn.Enabled = false;

            if (Translate_listView.Items.Count > 0)
                if (CheckInternetConnection())
                {
                    StartTranslate.Enabled = false;
                    Translate_timer.Start();
                }
                else
                    MessageBox.Show("The remote host could not be resolved...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            

        }
        private void AutoTranslateFRM_Load(object sender, EventArgs e)
        {
            _comboFrom.SelectedIndex = 11;
            _comboTo.SelectedIndex = 34;
            SubTrans.MainForm mf = (SubTrans.MainForm)(myMainform);
            foreach (ListViewItem item in mf.Subtitle_listView.Items)
            {
                ListViewItem x = new ListViewItem(item.SubItems[3].Text);
                x.SubItems.Add(item.SubItems[4].Text);
                Translate_listView.Items.Add(x);
            }
            AT_progressBar.Maximum = Translate_listView.Items.Count;
        }

        int i;
        private void Translate_timer_Tick(object sender, EventArgs e)
        {
            if (Translate_listView.Items[i].SubItems[1].Text == "- ترجمه نشده -")
            {
                try
                {
                    Cancel_btn.Enabled = true;
                    SubTrans.Translator t = new SubTrans.Translator();
                    t.SourceLanguage = (string)this._comboFrom.SelectedItem;
                    t.TargetLanguage = (string)this._comboTo.SelectedItem;
                    t.SourceText = Translate_listView.Items[i].SubItems[0].Text.Replace(Environment.NewLine, " ");
                    // Translate the text
                    t.Translate();
                    Translate_listView.FocusedItem = Translate_listView.Items[i];
                    Translate_listView.EnsureVisible(i);
                    Translate_listView.Items[i].SubItems[1].Text = t.Translation;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
                Translate_listView.Items[i].SubItems[1].Text = SubTrans.RTLCorrection.Correction(Translate_listView.Items[i].SubItems[1].Text);

            if (AT_progressBar.Value < AT_progressBar.Maximum)
                AT_progressBar.Value++;
            if (i < Translate_listView.Items.Count - 1 && Cancel_btn.Enabled)
                i++;
            else
            {
                Translate_timer.Stop();
                AddToList_btn.Enabled = true;
                Cancel_btn.Enabled = false;
                StartTranslate.Enabled = true;
                MessageBox.Show("Translation is Down!","Completed",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }

        private void AutoTranslateFRM_FormClosing(object sender, FormClosingEventArgs e)
        {
            SubTrans.MainForm mf = (SubTrans.MainForm)(myMainform);
            mf.autoTranslateToolStripMenuItem.Enabled = true;
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            Translate_timer.Stop();
            StartTranslate.Enabled = true;
            Cancel_btn.Enabled = false;
            AT_progressBar.Value = 0;
        }

        private void AddToList_btn_Click(object sender, EventArgs e)
        {
            SubTrans.MainForm mf = (SubTrans.MainForm)(myMainform);
            mf.History(-9, mf.Subtitle_listView.FocusedItem.Index);
            for(int i=0;i<Translate_listView.Items.Count;i++)
            {
                    mf.Subtitle_listView.Items[i].SubItems[4].Text = SubTrans.RTLCorrection.Correction(Translate_listView.Items[i].SubItems[1].Text);
            }
            mf.IndexChange();
            this.Close();
        }

    }
}
