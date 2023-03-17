using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //prperty get set test
            Person hi = new Person();
            hi.name = "howard";
            Console.WriteLine($"{hi.name}");
            Console.ReadLine();



            //field get set test
            /*Person myObj = new Person();
            //myObj.Name = "Liam";
            //myObj.test = "cde";
            //Console.WriteLine(myObj.Name);
            myObj.test = 5001;
            Console.WriteLine($"{myObj.test}");
            Console.ReadLine();*/
        }
    }
}
