using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Subtrans
{
    public partial class Delay : Form
    {
        public Delay()
        {
            InitializeComponent();
        }

        private System.Windows.Forms.Form formPad;

        public Delay(SubTrans.MainForm pad)
        {
            formPad = pad;
            InitializeComponent();
        }

        private void Delay_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            DurationTimetxtbox.Focus();
        }

        private void DurationTimetxtbox_TextChanged(object sender, EventArgs e)
        {
            DurationTimetxtbox.BackColor = Color.White;
            if (DurationTimetxtbox.Text != "" && !DurationTimetxtbox.Text.Contains("!") && !DurationTimetxtbox.Text.Contains("@") && !DurationTimetxtbox.Text.Contains("#") && !DurationTimetxtbox.Text.Contains("%") && !DurationTimetxtbox.Text.Contains("&") && !DurationTimetxtbox.Text.Contains("*") && !DurationTimetxtbox.Text.Contains("(") && !DurationTimetxtbox.Text.Contains(")") && !DurationTimetxtbox.Text.Contains("-") && !DurationTimetxtbox.Text.Substring(0, 1).Contains("."))
            {
                int q = 0;
                foreach (char c in DurationTimetxtbox.Text)
                {
                    if (c == '.')
                    {
                        q++;//اگه بیشتر از 1دونه بزنه عمل نمیکنه
                    }
                }
                if (q == 2)
                {
                    DurationTimetxtbox.Text = DurationTimetxtbox.Text.Substring(0, DurationTimetxtbox.Text.Length - 1);
                }
            }
        }

        private void DurationTimetxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }

        private void setbtn_Click(object sender, EventArgs e)
        {
            SubTrans.MainForm mf = (SubTrans.MainForm)(formPad);
            bool type;
            if(allrdobtn.Checked)
                type=false;
            else
                type=true;

            int q = 0;
            foreach (char c in DurationTimetxtbox.Text)
            {
                if (c == '.')
                {
                    q++;//اگه بیشتر از 1دونه بزنه عمل نمیکنه
                }
            }
            string time;
            if (comboBox1.SelectedIndex == 1)
                time = "-" + DurationTimetxtbox.Text;
            else
                time = DurationTimetxtbox.Text;
            if (q <= 1 && DurationTimetxtbox.Text != "" && !DurationTimetxtbox.Text.Contains("!") && !DurationTimetxtbox.Text.Contains("@") && !DurationTimetxtbox.Text.Contains("#") && !DurationTimetxtbox.Text.Contains("%") && !DurationTimetxtbox.Text.Contains("&") && !DurationTimetxtbox.Text.Contains("*") && !DurationTimetxtbox.Text.Contains("(") && !DurationTimetxtbox.Text.Contains(")") && !DurationTimetxtbox.Text.Contains("-") && !DurationTimetxtbox.Text.Substring(0, 1).Contains("."))
            {
                mf.SetDelay(Convert.ToDouble(time), type);
            }
            else
            {
                DurationTimetxtbox.BackColor = Color.Red;
                DurationTimetxtbox.Focus();
                DurationTimetxtbox.SelectAll();
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delay_FormClosing(object sender, FormClosingEventArgs e)
        {
            SubTrans.MainForm mf = (SubTrans.MainForm)(formPad);
            mf.delayToolStripMenuItem.Enabled = true;
        }
    }
}
