using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;    //数据库命名空间             
using System.Data;              //表的命名空间

namespace SQL_连接
{
    class Program
    {
        static void Main(string[] args)
        {
            //连接数据库 using
            //声明一个连接的对象
            //方法一
            //SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            //scsb.DataSource = "Dell";
            //scsb.UserID = "sa";
            //scsb.Password = "sa";
            //scsb.InitialCatalog = "New";

            ////创建连接
            //SqlConnection conn = new SqlConnection(scsb.ToString());
            //方法二
            string connStr = "Data Source = Dell;Initial Catalog = New;User ID = sa;Password = sa;";

            // 创建连接
            SqlConnection conn = new SqlConnection(connStr);
            while (true)
            {
                Console.WriteLine("请输入学生编号：");
                //string stu_no = Console.ReadLine();
                
                ////根据用户输入的学号，去查询学生的信息，比如：姓名，性别，年龄，班级
                ////打印到控制台窗口上
                //Console.WriteLine();
                //Console.ReadLine();
               
                //打开连接
                //判断 是否已经有连接
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string stu_no = Console.ReadLine();
                //创建要执行的SQL语句
                //字符串的拼接 string+
                string sqlStr = "SELECT * FROM Sheet1$ WHERE 学生编号 = '" + stu_no + " '";

                //创建用于执行SQL语句的对象
                SqlCommand comm = new SqlCommand(sqlStr, conn);    //参数1:SQL语句字符串。
                                                                   //执行comm对象
                                                                   //SqlDataReader sdr = comm.ExecuteReader();
                                                                   //接收查询到的SQL结果                                                  
                SqlDataReader sdr = null;
                try
                {
                    sdr = comm.ExecuteReader();
                    //读取数据
                    while (sdr.Read())
                    {
                        Console.WriteLine("学生姓名：" + sdr["学生姓名"].ToString());
                        Console.WriteLine("性别：" + sdr["性别"].ToString());
                        Console.WriteLine("年龄：" + sdr["年龄"].ToString());
                        Console.WriteLine("家庭住址：" + sdr["家庭住址"].ToString());
                        Console.WriteLine("---------------------------------------");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                 //SqlDataReader sdr = comm.ExecuteReader();


                //Console.WriteLine(sqlStr);
                //Console.ReadLine();
            }
        }
    }
}
