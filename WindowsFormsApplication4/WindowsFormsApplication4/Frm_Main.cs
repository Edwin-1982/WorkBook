using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            if(rbtn_school.Checked)
            {
                MessageBox.Show("向左走","提示！");
            }
            else
            {
                MessageBox.Show("向右走","提示！");
            }
        }
    }
}
