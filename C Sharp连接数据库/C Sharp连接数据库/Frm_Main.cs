using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp连接数据库
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void btn_Link_Click(object sender, EventArgs e)
        {
            MyDBase DB = new MyDBase("dell", "express");
            DataSet Ds = DB.GetRecordset("select*from S");
            dataGridView1.DataSource = Ds.Tables[0];
            

        }
    }
}
