using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1、字符串连接运算符+
            //    将两个字符串连在一起组成一个新的字符串
            //2、is运算符
            //    用于动态检查对象的运行时类型是否与给定类型兼容
            //    bool = a is string
            //int INT = 123;
            //char CHAR = 'a';
            //string STRING = "我要自学网";
            //object OBJECT = 1024;
            //Console.WriteLine(INT);
            //Console.WriteLine(CHAR);
            //Console.WriteLine(STRING);
            //Console.WriteLine(OBJECT);
            //Console.ReadKey();
            //int a = 10;
            //double b = 3.14;
            //string c = "我要自学网";
            //bool mybool = false;
            //mybool = a is int;
            //Console.WriteLine("a is int\t"+mybool);// \t跳到下一个制表符
            //Console.ReadKey();
            Console.WriteLine("请你输入需要比较的数");
            int num = Convert.ToInt32(Console.ReadLine());
            string str=num>=5?"大于等于":"小于";
            Console.WriteLine("你输入的数字{0}5",str);
            Console.ReadLine();
        }
    }
}
