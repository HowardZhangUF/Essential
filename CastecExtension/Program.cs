using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastecExtension
{
    static class Ext
    {
        public static int Add(this int a, int b)//a是呼叫Add擴充方法變數自身的值
        {
            return a + b;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int ExtTest = 65;

            Console.WriteLine(ExtTest.Add(4));
            Console.ReadLine();
        }
    }
}
