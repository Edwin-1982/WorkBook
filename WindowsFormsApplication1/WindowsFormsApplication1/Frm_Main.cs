﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void btn_true_Click(object sender, EventArgs e)
        {
            using (new test())                      //在using关键字中创建test对象
            {
            }                                      //using关键字块执行完成后会自动调用test对象的Dispose方法
        }
        class test:IDisposable                     //定义test类实现IDisposable接口
        {
            public void  Dispose()                //实现接口方法
            {
                MessageBox.Show(                  //实现消息对话框
                    "已经执行test对象的Dispose方法","提示！");
            }
        }
    }
}
