using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Subtrans
{
    public partial class HistoryFrm : Form
    {
        public HistoryFrm()
        {
            InitializeComponent();
        }
        Form MyMainForm;
        public HistoryFrm(SubTrans.MainForm pad)
        {
            MyMainForm = pad;
            InitializeComponent();
        }

        private void HistoryFrm_Load(object sender, EventArgs e)
        {
            SubTrans.MainForm mf = (SubTrans.MainForm)(MyMainForm);
            for (int i = 0; i < mf.HistoryArray.Count; i++)
            {
                string[] splitType = mf.HistoryArray[i].Split('ƾ');
                if (splitType[0] == "-3")
                    History_lstbox.Items.Add("Before Replace");
                else if(splitType[0] == "-4")
                    History_lstbox.Items.Add("Before Manual Timing");
                else if (splitType[0] == "-5")
                    History_lstbox.Items.Add("Before insert into translation");
                else if (splitType[0] == "-6")
                    History_lstbox.Items.Add("Before Delete from translation");
                else if (splitType[0] == "-7")
                    History_lstbox.Items.Add("Before Shift +1 Seccond");
                else if (splitType[0] == "-8")
                    History_lstbox.Items.Add("Before Shift -1 Seccond");
                else if (splitType[0] == "-9")
                    History_lstbox.Items.Add("Before Auto Translate");
                else if (splitType[0] == "-1")
                {
                    int count = int.Parse(splitType[1]) + 2;
                    History_lstbox.Items.Add("Before insert(after) line number " + count);
                }
                else if (splitType[0] == "-2")//insert befor
                {
                    int count = int.Parse(splitType[1]) + 1;
                    History_lstbox.Items.Add("Before insert(before) line number " + count);
                }
                else
                {
                    if (splitType[0] == "1")
                    {
                        int count = int.Parse(splitType[1]) + 1;
                        History_lstbox.Items.Add("Before Delete line number " + count);
                    }
                    else
                        History_lstbox.Items.Add("Before Delete " + splitType[0] + " item");
                }
            }
            apply_btn.Focus();
        }

        private void apply_btn_Click(object sender, EventArgs e)
        {
            SubTrans.MainForm mf = (SubTrans.MainForm)(MyMainForm);
            if (History_lstbox.Items.Count > 0)
            {
                mf.UndoHistory(History_lstbox.Items.Count - 1);
                History_lstbox.Items.RemoveAt(History_lstbox.Items.Count - 1);
            }
            if(History_lstbox.Items.Count <= 0)
            {
                this.Close();
                mf.HistoryToolStripMenuItem.Enabled = false;
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HistoryFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SubTrans.MainForm mf = (SubTrans.MainForm)(MyMainForm);
            if (History_lstbox.Items.Count > 0)
                mf.HistoryToolStripMenuItem.Enabled = true;
        }
    }
}
