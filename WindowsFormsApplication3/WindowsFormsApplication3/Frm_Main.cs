using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void btn_Get_Click(object sender, EventArgs e)
        {
            if(rbtn_object.Checked)                                                                            //如果选择转换为object类型
            {
                using (FileStream P_filestream =                                                               //创建文件流对象
                    new FileStream(@"d:\log.txt", System.IO.FileMode.Create))
                {
                    object P_object =                                                                          //使用as关键字转换类型
                        P_filestream as object;
                    if(P_object!=null)
                    {                                                                                          //判断转换是否成功
                        MessageBox.Show("转换为Object成功！", "提示！");
                    }
                    else
                    {
                        MessageBox.Show("转换为Object不成功！", "提示！");
                    }
                }
            }
            if (rbtn_stream.Checked)                                                                          //如果选择转换为Stream类型
            {
                using (FileStream P_filestream =                                                              //创建文件流对象
                    new FileStream(@"d:\log.txt", System.IO.FileMode.Create))
                {
                    object P_obj = P_filestream;                                                              //使用as关键字转换类型
                    Stream P_stream =
                        P_obj as Stream;
                    if(P_stream!=null)
                    {                                                                                         //判断转换是否成功
                        MessageBox.Show("转换为Stream成功！", "提示！");
                    }
                    else
                    {
                        MessageBox.Show("转换为Stream不成功！", "提示！");
                    }
                }
            }
            if (rbtn_string.Checked)                                                                        //如果选择转换为String类型
            {
                using (FileStream P_filestream =                                                            //创建文件流对象
                    new FileStream(@"d:\log.txt", System.IO.FileMode.Create))
                {
                    object P_obj =                                                                          //使用as关键字转换类型
                        P_filestream as object;
                    string P_string =
                    P_obj as String;
                    if (P_string != null)
                    {                                                                                       //判断转换是否成功
                        MessageBox.Show("转换为Stream成功！", "提示！");
                    }
                    else
                    {
                        MessageBox.Show("转换为Stream不成功！", "提示！");
                    }
                }
            }
        }
    }
}
