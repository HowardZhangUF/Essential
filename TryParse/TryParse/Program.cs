using System.IO;
using System;
class Program
{
    static void Main()
    {
        bool res;
        int a;
        int b = 4;
        string myStr = "12";
        res = int.TryParse(myStr, out a);
        Console.WriteLine("String is a numeric representation: " + res);
        Console.WriteLine(a+b);
        Console.ReadLine();
    }
}