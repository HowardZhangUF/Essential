using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p
{
    /*public class Circle
    {
        private static float PI = 0.0f;
        private float radius = 0.0f;

        
        static Circle()
        {
            Console.WriteLine("靜態建構函式-啟動");
            PI = 3.141592653f;
        }
        public Circle(float radius)
        {
            Console.WriteLine("建構函式-啟動");
            this.radius = radius;
        }
        public float getArea() { return PI * this.radius * this.radius; }
    }*/

    /*class Me
    {
       public string Mastb()
        {
            return "releave";
        }
    }

    class Je
    {

    
    }
    class Exercise
    {
        
       
    }*/


    





    class Program
    {

        public static void Main(string[] args)
        {
            /* Circle circle1 = new Circle(3.0f);//輸出: 靜態建構函式-啟動   建構函式-啟動
             Circle circle2 = new Circle(5);//輸出:  建構函式-啟動
             Console.WriteLine(circle2.getArea());
             Console.WriteLine(circle1.getArea());
             Console.WriteLine(circle2.getArea());*/
            var je = new Account();
            var me = new Account();

            var how = new List<string> {"apple","banana","babo","noeq" };
            string prindex = "b";
            bool howb = how.Any(f=>f.StartsWith(prindex));

            List<string> fruits = new List<string> { "apple", "banana", "cherry", "pear" };
            string prefix = "b";
            bool hasPrefix = fruits.Any(f => f.StartsWith(prefix));
            Console.WriteLine(hasPrefix); // Output: True


            var list = new List<string>() { "ASUS", "Acer", "BenQ", "Toshiba", "IBM", "HP", "Dell" };
            var emptyList = new List<string>() { };
            Console.WriteLine(list.Any());
            Console.WriteLine(emptyList.Any());

            je.Money += 10;
            me.Money -= 10;
            je.Age = 18;
            me.Age = 20;
            Console.WriteLine(je.Money);
            Console.WriteLine(je.Age);
            Console.ReadLine();




        }
    }

    class Account
    {
        private static int Scount;
        public int Money
        {
            get => Money;
            set => Money = value;
        }
        public int Age { get; set;}

    }
}
   

