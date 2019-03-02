using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserDLine
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen blackPen=new Pen(Color.Black,3);                                        //创建Pen对象
            Point point1 = new Point(50, 50);                                           //创建一个Point对象
            Point point2 = new Point(130, 50);                                          //在创建一个Point对象
            Graphics g = this.CreateGraphics();                                         //创建一个Graphics对象
            g.DrawLine(blackPen, point1, point2);                                       //调用一个DrawLine方法绘制直线
        }
        private void button2_Click(object sender,EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();                                  //创建Graphics对象
            Pen myPen = new Pen(Color.Black, 3);                                        //创建Pen对象
            graphics.DrawLine(myPen, 200, 30, 200, 100);                                //调用DrawLine方法绘制直线
        }
    }
}
