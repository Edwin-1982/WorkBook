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

namespace UseDelete
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

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            InsertData();//插入多条数据记录
            dgv_Message.DataSource = GetMessage();//设置数据源
        }
        ///<summary>
        ///查询数据记录
        ///</summary>
        ///<returns>方法返回</returns>
        private void InsertData()
        {
            string P_Str_ConnectionStr = string.Format(//创建数据库连接字符串
                @"server=dell;database=New;uid=sa;pwd=sa");
            string P_Str_SqlStr = string.Format(//创建SQL查询字符串
                @"Insert into Sheet1$_Copy(学生编号,学生姓名,学生年龄,性别,出生日期,家庭住址)select 学生编号,学生姓名,年龄,性别,出生日期,家庭住址 from Sheet1$");
            SqlConnection P_con = new SqlConnection(//创建SQL连接对象
                P_Str_ConnectionStr);
            try
            {
                P_con.Open();//打开数据库连接
                SqlCommand P_cmd = new SqlCommand(//创建命令对象
                    P_Str_SqlStr, P_con);
                if(P_cmd.ExecuteNonQuery() !=0)//写入数据并判断是否成功
                {
                    MessageBox.Show("成功写入数据", "提示");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "提示！");
            }
            finally
            {
                P_con.Close();//关闭数据连接
                dgv_Message.DataSource = GetMessage();//设置数据源
            }
        }

        ///<summary>
        ///查询数据库信息
        ///</summary>
        ///<retruns>方法返回DataTable对象</retruns>
        private DataTable GetMessage()
        {
            string P_Str_ConnectionStr = string.Format(//创建数据库连接字符串
                @"server=dell;database=New;uid=sa;pwd=sa");
            string P_Str_SqlStr = string.Format(//创建SQL查询字符串
                "select * from Sheet1$_Copy");
            SqlDataAdapter P_SqlDataAdapter = new SqlDataAdapter(//创建数据适配器
                P_Str_SqlStr, P_Str_ConnectionStr);
            DataTable P_dt = new DataTable();//创建数据表
            P_SqlDataAdapter.Fill(P_dt);//填充数据表
            return P_dt;//返回数据表
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            string P_Str_ConnectionStr = string.Format(//创建数据库连接字符串
                @"server=dell;database=New;uid=sa;pwd=sa");
            string P_Str_SqlStr = string.Format(//创建SQL查询字符串
                @"delete from Sheet1$_Copy");
            SqlConnection P_con = new SqlConnection(//创建SQL连接对象
                P_Str_ConnectionStr);
            try
            {
                P_con.Open();//打开数据库连接
                SqlCommand P_cmd = new SqlCommand(//创建命令对象
                    P_Str_SqlStr, P_con);
                if (P_cmd.ExecuteNonQuery() != 0)//写入数据并判断是否成功
                {
                    MessageBox.Show("成功清空数据", "提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示！");
            }
            finally
            {
                P_con.Close();//关闭数据连接
                dgv_Message.DataSource = GetMessage();//设置数据源
            }
        }
    }
}
