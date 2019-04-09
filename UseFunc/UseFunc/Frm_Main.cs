using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseFunc
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            cbox_Count.SelectedIndex = 0;//设置选项索引
        }
        /// <summary>
        /// 查询数据库信息
        /// </summary>
        /// <returns>方法返回DataTable对象</returns>
        private DataTable GetMessage(string count)
        {
            string P_Str_ConnectionStr = string.Format(@"server=dell;database=New;uid=sa;pwd=sa");//创建数据库连接字符串
            string P_Str_SqlStr = string.Format(//创建SQL查询字符
               @"SELECT 学生编号,学生姓名,性别,年龄,家庭住址,英语分数,高数分数 FROM Sheet1$ WHERE LEN(学生姓名) = {0}",count);
            SqlDataAdapter P_SqlDataAdapter = new SqlDataAdapter(P_Str_SqlStr,P_Str_ConnectionStr);//
            DataTable P_dt = new DataTable();//创建数据表
            P_SqlDataAdapter.Fill(P_dt);//填充数据表
            return P_dt;//返回数据表
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            dgv_Message.DataSource = GetMessage(cbox_Count.Text);//绑定到DataTable对象
        }
        class Student//定义Student类
        {
            public string Name { get; set; }//创建属性
            public override string ToString()//重写ToString方法
            {
                return Name;
            }
        }
    }
}
