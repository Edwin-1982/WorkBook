using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            if(cbox_select.SelectedItem.ToString()=="admin")        //判断用户登陆信息
            {
                MessageBox.Show("管理员登录", "提示！");            //如果是admin登陆则提示管理员登陆
            }
            else
            {
                MessageBox.Show("普通用户登录", "提示！");          //如果是user登陆则提示普通用户登陆
            }
        }
        private void Frm_Main_Load(object sender, EventArgs e)
        {
            cbox_select.SelectedIndex = 0;                         //默认选择combobox中的第一项
        }
    }
}
