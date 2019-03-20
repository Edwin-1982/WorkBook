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
    public partial class SelectGoodsFrom : Form
    {
        public SelectGoodsFrom()
        {
            InitializeComponent();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            if(txt_select.Text=="")
            {
                MessageBox.Show("查询商品名不能为空!");
                return;
            }
            //连接数据库字符串
            string sqlconn = "server=dell;database=mallDB;uid=sa;pwd=sa";
            //创建数据库连接对象
            SqlConnection conn = new SqlConnection(sqlconn);
            //打开数据库
            conn.Open();
            //查询sql
            string strsql = string.Format(@"select goodsName,buyPrice,salePrice,unit,isSale,remark from goodsTb1 where goodsName='{0}'", txt_select.Text);
            //定义查询对象
            SqlCommand cmd=new SqlCommand(strsql, conn);

            //取数据对象
            SqlDataReader sdr = cmd.ExecuteReader();

            if(sdr.Read())
            {
                txt_goodsName.Text = sdr["goodsName"].ToString();
                txt_buyPrice.Text = sdr["buyPrice"].ToString();
                txt_salePrice.Text = sdr["salePrice"].ToString();
                
                txt_remark.Text = sdr["remark"].ToString();
                if(sdr["isSale"].ToString()=="1")
                {
                    checkBox_isSale.Checked = true;
                }
                else
                {
                    checkBox_isSale.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("没有该商品信息");
            }
            sdr.Close();
            conn.Close();
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
