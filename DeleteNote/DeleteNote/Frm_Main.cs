﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeleteNote
{
  
    public partial class Frm_Main : Form
    {
        public static string str = "";
        public Frm_Main()
        {
            InitializeComponent();
        }
        private void showinf()
        {
            using (SqlConnection con = new SqlConnection(//创建数据库连接对象
                @"server=dell;database=db_TomeTwo;uid=sa;pwd=sa"))
            {
                DataTable dt = new DataTable();//创建数据表
                SqlDataAdapter da = new SqlDataAdapter(//创建数据适配器对象
                    "select * from tb_Image", con);
                da.Fill(dt);//填充数据表
                this.dgv_Message.DataSource = dt.DefaultView;//设置数据源
            }
        }
        private void Frm_Main_Load(object sender, EventArgs e)
        {
            showinf();//显示员工信息
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("您确定要删除本条信息吗?","提示",//判断是否删除员工信息
                MessageBoxButtons.YesNo,MessageBoxIcon.Warning)== DialogResult.Yes)
            {
                if(str !="")
                {
                    using (SqlConnection con = new SqlConnection(//创建数据库连接对象
                        @"server=dell;database=db_TomeTwo;uid=sa;pwd=sa"))
                    {
                        con.Open();//打开数据库连接
                        SqlCommand cmd = new SqlCommand(//创建命令对象
                            "delete from tb_Image where name='" + str + "'", con);
                        cmd.Connection = con;//设置连接属性
                        cmd.ExecuteNonQuery();//执行SQL语句
                        con.Close();//关闭数据可连接
                        showinf();//显示员工信息
                        MessageBox.Show("删除成功");//弹出消息对话框
                    }
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();//关闭窗体
        }
        private void dgv_Message_Click(object ssender,EventArgs e)
        {
            str = this.dgv_Message.SelectedCells[0].Value.ToString();//得到员工编号
        }
    }
}
