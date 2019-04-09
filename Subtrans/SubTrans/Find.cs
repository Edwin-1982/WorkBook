using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Subtrans
{
    public partial class Find : Form
    {
        private System.Windows.Forms.Form formPad;
        public Find()
        {
            InitializeComponent();
        }

        public Find(SubTrans.MainForm pad)
		{
			formPad = pad; 
			InitializeComponent();
			
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Find_btn_Click(object sender, EventArgs e)
        {
            SubTrans.MainForm mf = (SubTrans.MainForm)(formPad);

            bool match,su;

            if(MatchCase.Checked)
                match=true;
            else
                match=false;

            if (Search_up.Checked)
                su = true;
            else
                su = false;

            mf.getFindText(Find_txtbox.Text,match,su);
        }

        private void Find_txtbox_TextChanged(object sender, EventArgs e)
        {
            SubTrans.MainForm mf = (SubTrans.MainForm)(formPad);
            mf.index = 0;//وقتی کلمه رو عوض کرد دوباره برگرده از اول لیست بگرده
        }

        private void Find_Load(object sender, EventArgs e)
        {

            Find_txtbox.Focus();
        }

        private void ReplaceALLbtn_Click(object sender, EventArgs e)
        {
            if (ReplaceFIND_txtbox.Text != "")
            {
                SubTrans.MainForm mf = (SubTrans.MainForm)(formPad);
                bool match;
                if (ReplaceMATCHcasechkbox.Checked)
                    match = true;
                else
                    match = false;

                mf.getReplaceText(ReplaceFIND_txtbox.Text, Replace_REPLACE_txtbox.Text, match);
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Find_txtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SubTrans.MainForm mf = (SubTrans.MainForm)(formPad);

                bool match, su;

                if (MatchCase.Checked)
                    match = true;
                else
                    match = false;

                if (Search_up.Checked)
                    su = true;
                else
                    su = false;

                mf.getFindText(Find_txtbox.Text, match, su);
            }
        }

        private void Find_FormClosing(object sender, FormClosingEventArgs e)
        {
            SubTrans.MainForm mf = (SubTrans.MainForm)(formPad);
            mf.findToolStripMenuItem.Enabled = true;
        }

        private void Find_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
