using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectToExcel
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            try
            {
                string strOdbcCon =//创建连接字符串
                    @"Provider=Microsoft.ACE.OLEDB.12.0;Persist Security Info=False;
Data Source=E:\迅雷下载\Git版本库\例程\ConnectToExcel\ConnectToExcel\bin\Debug\Excel\北京出差住宿清单.xlsx;Extended Properties=Excel 12.0";
                OleDbConnection OleDB = new OleDbConnection(strOdbcCon);//创建数据连接对象
                OleDbDataAdapter OleDat = new OleDbDataAdapter(//创建数据适配器
                    "select * from [Sheet1$]", OleDB);
                DataTable dt = new DataTable();//创建数据表
                OleDat.Fill(dt);//填充数据集
                this.dataGridView1.DataSource =//设置数据源
                    dt.DefaultView;
            }
            catch(Exception ey)//捕获异常
            {
                MessageBox.Show(ey.Message);//弹出消息对话框
            }
        }
    }
}
