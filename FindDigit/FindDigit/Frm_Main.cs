using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FindDigit
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            int Age = 0;//定义整形变量
            try
            {
                Age = int.Parse(txt_Age.Text);//得到用户输入数值
                dgv_Message.DataSource = GetMessage(Age);//设置数据源
            }
            catch (Exception ex)//捕获异常
            {
                MessageBox.Show(ex.Message, "提示！");//弹出消息对话框
            }
        }
        ///<summary>
        ///查询数据库信息
        ///</summary>
        ///<returns>方法返回DataTable对象</returns>
        private DataTable GetMessage(int Age)
        {
            string P_Str_ConnectionStr = string.Format(//创建数据库连接字符串
                @"server=dell;database=New;uid=sa;pwd=sa");
            string P_Str_SqlStr = string.Format(//创建SQL查询字符串
                "SELECT 学生编号,学生姓名,性别,年龄,家庭住址,英语分数,高数分数 FROM Sheet1$ WHERE 年龄={0}", Age);
            SqlDataAdapter P_SqlDataAdapter = new SqlDataAdapter(//创建数据适配器
                P_Str_SqlStr, P_Str_ConnectionStr);
            DataTable P_dt = new DataTable();//创建数据表
            P_SqlDataAdapter.Fill(P_dt);     //填充数据表
            return P_dt;//返回数据表

        }
        
    }
}
