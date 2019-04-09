using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Title = "循环想控制台中输入内容";
            System.Console.WindowWidth = 60;
            System.Console.WindowHeight=2;
            for(;;)
            {
                System.Console.WriteLine("当前系统时间是：{0}",
                    System.DateTime.Now.ToString("yyyy 年 MM 月 dd 日 dddd HH:mm:sss"));
                System.Threading.Thread.Sleep(1000);
                System.Console.Clear();
            }

        }
    }
}
