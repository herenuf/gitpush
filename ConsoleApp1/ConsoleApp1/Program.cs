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
            //int INT = 123;
            //char CHAR = 'a';
            //string STRING = "我要自学网";
            //object OBJECT = 1024;
            //Console.WriteLine(INT);
            //Console.WriteLine(CHAR);
            //Console.WriteLine(STRING);
            //Console.WriteLine(OBJECT);
            //Console.ReadKey();
            int a = 10;
            double b = 3.14;
            string c = "我要自学网";
            bool mybool = false;
            mybool = a is int;
            Console.WriteLine("a is int\t"+mybool);// \t跳到下一个制表符
            Console.ReadKey();
        }
    }
}
