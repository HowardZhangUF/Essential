using System;
namespace ThisKeyword
{

    class Student
    {

        private string[] name = new string[3];

        // declaring an indexer
        public string this[int index]
        {

            // returns value of array element
            get
            {
               //公開方法
                return name[index];
            }

            // sets value of array element
            set
            {
                //指派姓名
                name[index] = value;
            }
        }
    }

    class Program
    {

        public static void Main()
        {
            Student s1 = new Student();
            s1[0] = "Ram";
            s1[1] = "Shyam";
            s1[2] = "Gopal";

            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine(s1[i] + " ");
                
            }
            Console.ReadLine();
        }
    }
}
//以this 作為參數傳入方法
/*using System;

namespace ThisKeyword
{
    class Test
    {
        int num1;
        int num2;

        Test()
        {
            num1 = 22;
            num2 = 33;
        }

        // method that accepts this as argument   
        void passParameter(Test t1)
        {
            Console.WriteLine("num1: " + num1);
            Console.WriteLine("num2: " + num2);
        }

        void display()
        {
            // passing this as a parameter
            passParameter(this);
        }

        public static void Main(String[] args)
        {
            Test t1 = new Test();
            t1.display();
            Console.ReadLine();
        }
    }
}*/
// constructor chaining
/*using System;

namespace ThisKeyword
{
    class Test
    {

        Test(int num1, int num2)
        {

            Console.WriteLine("Constructor with two parameter");
        }

        // invokes the constructor with 2 parameters
        Test(int num) : this(33, 22)
        {

            Console.WriteLine("Constructor with one parameter");
        }

        public static void Main(String[] args)
        {

            Test t1 = new Test(11);
            Console.ReadLine();
        }
    }
}*/
//有THIS表示num是屬於當下的類別 ，C#不會被同樣的變數名稱搞混
/*using System;

namespace ThisKeyword
{
    class Test
    {

        int num;
        Test(int num)
        {

            // this.num refers to the instance field
            this.num = num;
        }

        static void Main(string[] args)
        {

            Test t1 = new Test(4);
            Console.WriteLine("value of num: " + t1.num);
            Console.ReadLine();
        }
    }
}*/
//沒有THIS(無法得知目前類別)
/*using System;

namespace ThisKeyword
{
    class Test
    {

        int num;
        Test(int num)
        {

            num = num;
        }

        static void Main(string[] args)
        {

            Test t1 = new Test(4);
            Console.WriteLine("value of num: " + t1.num);
            Console.ReadLine();
        }
    }
}*/
/*using System;

namespace ThisKeyword
{
    class Test
    {

        int num;
        Test(int num)
        {
            // this.num refers to the instance field
            this.num = num;
            Console.WriteLine("object of this: " + this);
            //this 回傳當下所在的namespace和 class
        }

        static void Main(string[] args)
        {

            Test t1 = new Test(4);
            Console.WriteLine("object of t1: " + t1);
            Console.ReadLine();
        }
    }
}*/
