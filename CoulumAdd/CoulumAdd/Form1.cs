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

namespace CoulumAdd
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            dgv_Message.DataSource = GetMessage();//设置数据源
        }
        /// <summary>
        /// 查询数据库信息
        /// </summary>
        /// <returns>方法返回DataTable对象</returns>
        private DataTable GetMessage()
        {
            string P_Str_ConnectionStr = string.Format(@"server=dell;database=New;uid=sa;pwd=sa");//创建数据库连接字符串
            string P_Str_SqlStr = string.Format( //创建SQL查询字符
                @"SELECT 学生编号,学生姓名,性别,年龄,家庭住址,英语分数,高数分数,英语分数+高数分数 高数加外语的分数 FROM Sheet1$");
            SqlDataAdapter P_SqlDataAdapter = new SqlDataAdapter(P_Str_SqlStr, P_Str_ConnectionStr);//创建数据适配器
            DataTable P_dt = new DataTable();//创建数据表
            P_SqlDataAdapter.Fill(P_dt);//填充数据表
            return P_dt;//返回数据表
        }
    }
}
