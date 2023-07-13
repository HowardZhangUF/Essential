using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationExceptionTest
{
    class Program
    {

        public static decimal Add(decimal firstNumber, decimal secondNumber)
        {
            try
            {
                //DO...
                return firstNumber + secondNumber;
            }
            catch (Exception e)
            {
                throw new Exception("加法錯誤", e);
            }
        }
        //internal static decimal Add(decimal firstNumber, decimal secondNumber)
        //{
        //    try
        //    {
        //        //DO...
        //        return firstNumber + secondNumber;
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception("加法錯計算錯誤");
        //    }
        //}
        static void Main(string[] args)
        {

            decimal i = Add(10, 11);
            Console.WriteLine(i);
            Console.ReadLine();

        }
    }
    
}


/**/
