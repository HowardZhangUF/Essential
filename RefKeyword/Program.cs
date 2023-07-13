using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace RefKeyword
//{
  
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string b = "howard";
//            int a = 123;
//            Program instance = new Program();
//            instance.fun_c(b, ref a);
//            Console.ReadLine();
//        }

//        void fun_c(string x,ref int t)
//        {
            
//        }
//    }
//}

namespace ParameterModifier
{
    class Program
    {
        class testClass
        {
            public string x = "2";
        }

        static void Main(string[] args)
        {
            testClass obj = new testClass();//ref 參數使用時，需初始化

            string b = "444";
            Fun_out(b, ref obj);
            Console.WriteLine(obj.x);
            Console.ReadLine();
        }

        static void Fun_out(string y, ref testClass otherobj)
        {
            //方法內不強迫要重新實作ref 參數
        }
    }
}