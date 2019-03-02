using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void bnt_Get_Click(object sender, EventArgs e)
        {
            Type type = typeof(System.Int32);                                                       //获得string类型的Type对象
            foreach (MethodInfo method in type.GetMethods())                                         //遍历string类中导尿管以的所有公共方法
            {
                rtBox_text.AppendText(
                    "方法名称：" + method.Name + Environment.NewLine);                              //输出方法名称
                foreach (ParameterInfo parameter in method.GetParameters())                          //遍历公共方法中的所有参数
                {
                    rtBox_text.AppendText(
                        "参数：" + parameter.Name + Environment.NewLine);                          //输出参数名称
                }
            }
        }
    }
}
