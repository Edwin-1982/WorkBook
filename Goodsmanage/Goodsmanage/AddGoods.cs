using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Goodsmanage
{
    public partial class AddGoods : Form
    {
        public AddGoods()
        {
            InitializeComponent();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_goodsName.Text = "";
            txt_buyPrice.Text = "";
            txt_salePrice.Text = "";
            txt_unit.Text = "";
            txt_remark.Text= "";
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(txt_goodsName.Text =="" || txt_buyPrice.Text == "" || txt_salePrice.Text==""||txt_unit.Text=="")
            {
                MessageBox.Show("带*的项不能为空");
                return;
            }

            //连接数据库字符串
            string sqlconn = "server=dell;database=mallDB;uid=sa;pwd=sa";
            //创建数据库连接对象
            SqlConnection conn = new SqlConnection(sqlconn);
            //打开数据库
            conn.Open();
            //添加数据的sql语法
            int issale = 0;
            if(checkBox_isSale.Checked==true)
            {
                issale = 1;
            }
            string strsql = string.Format(@"insert into goodsTb1(goodsName,buyPrice,salePrice,unit,isSale,remark)
                           values('{0}',{1},{2},'{3}',{4},'{5}')",
                           txt_goodsName.Text,
                           txt_buyPrice.Text,
            txt_salePrice.Text,
            txt_unit.Text,
            issale,
            txt_remark.Text);

            //创建执行sql语法的对象
            SqlCommand cmd = new SqlCommand(strsql,conn);

            //直接运行sql
            int nCount = cmd.ExecuteNonQuery();//sql:insert updata delete
            //ExecuteReader();select
            if(nCount>0)
            {
                MessageBox.Show("恭喜，添加成功");
            }
            else
            {
                MessageBox.Show("添加失败");
            }
            //关闭数据库
            conn.Close();
        }
    }
}
