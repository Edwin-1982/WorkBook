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

namespace FindDate
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }
        private void btn_Select_Click(object sender, EventArgs e)
        {
            dgv_Message.DataSource = GetStudent(//设置数据源
                dtPicker_BirthDay.Value);
        }


        /// <summary>
        /// 查询数据库信息
        /// </summary>
        /// <returns>方法返回DataTable对象</returns>
        private DataTable GetStudent(DateTime dt)
        {
            string P_Str_ConnectionStr = string.Format(//创建数据库连接字符串
               @"server=dell;database=New;uid=sa;pwd=sa");
            string P_Str_SqlStr = string.Format(//创建SQL查询字符串
               "SELECT 学生编号,学生姓名,年龄,性别,出生日期,家庭住址 FROM Sheet1$ WHERE 出生日期 ='{0}'", dt.ToShortDateString());
            SqlDataAdapter P_SqlDataAdapter = new SqlDataAdapter(//创建数据适配器
                P_Str_SqlStr, P_Str_ConnectionStr);
            DataTable P_dt = new DataTable(); //创建数据表
            P_SqlDataAdapter.Fill(P_dt);        //填充数据表
            return P_dt;                      //返回数据表

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
            string P_Str_ConnectionStr = string.Format(//创建数据库连接字符串
                @"server=dell;database=New;uid=sa;pwd=sa");
            string P_Str_SqlStr = string.Format(//创建SQL查询字符串
                "SELECT 学生编号,学生姓名,年龄,性别,出生日期,家庭住址 FROM Sheet1$");
            SqlDataAdapter P_SqlDataAdapter = new SqlDataAdapter(//创建数据适配器
                P_Str_SqlStr, P_Str_ConnectionStr);
            DataTable P_dt = new DataTable(); //创建数据表
            P_SqlDataAdapter.Fill(P_dt);      //填充数据表
            return P_dt;   //返回数据表
        }
    }
}
