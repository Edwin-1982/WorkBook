﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SelectColumn
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“newDataSet1._Sheet1_”中。您可以根据需要移动或删除它。
            this.sheet1_TableAdapter1.Fill(this.newDataSet1._Sheet1_);
            string P_Str_ConnectionStr = string.Format(                           //创建数据库连接字符串
                @"server=dell;database=New;uid=sa;pwd=sa");                
            string P_Str_SqlStr = string.Format(                                  //创建SQL查询字符串                            
                "SELECT 学生编号,学生姓名,性别,年龄,家庭住址 FROM Sheet1$"); 
             SqlDataAdapter P_SqlDataAdapter = new SqlDataAdapter(               //创建数据适配器
                P_Str_SqlStr, P_Str_ConnectionStr);
            DataTable P_dt = new DataTable();                                    //创建数据表
            P_SqlDataAdapter.Fill(P_dt);                                         //填充数据表
            //return P_dt;                                                         //返回数据表
        }
    }
}