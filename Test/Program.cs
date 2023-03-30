using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{

    class person
    {
        public string Name;
        public int Age;
        public person()
        {
            this.Name = "how";
            this.Age = 18;
        }

        public override string ToString()
        {
            return "hi your name is "+Name +" and age is " + Age;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //System.Console.Write("Enter text: ");
            //var text = System.Console.ReadLine();
            //// Return a new string in uppercase
            //var uppercase = text.ToUpper();

            //System.Console.WriteLine(uppercase);
            //Console.ReadLine();
            //
            person howard = new person();
            Console.WriteLine(howard);
            //string.join方法測試
            string[] arr = {"a","b","c","d"};
            //array 方法測試
            string[] stg = new string[2] { "0", "2" };
            int[] i = new int[2] { 1, 2 };
            Array.Reverse(stg);
            Console.WriteLine(stg[0]+stg[1]);
            //-----------------------------
            Console.WriteLine(arr[0]+arr[1]+arr[2]+arr[3]);
            //string .join 方法測試
            Console.WriteLine($"({string.Join(",", arr)})");
            //------------------
            //jagg arr test
            int[][] mdims = new int[2][];
            mdims[0] = new int[3] {0,1,2};
            mdims[1] = new int[4] { 3, 4, 5, 6 };

            int[][] mdim = new int[2][]
            {
              new int[3]{0,1,2},
              new int[4]{4,5,6,7}
            };
            
           


            Console.ReadLine();
         }
    }
}
