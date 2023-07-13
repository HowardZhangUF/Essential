//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace TestAny
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            var how = new List<string> { "apple", "banana", "babo", "noeq" };
//            string prindex = "b";
//            bool howb = how.Any(f => f.StartsWith(prindex));

//            List<string> fruits = new List<string> { "apple", "banana", "cherry", "pear" };
//            string prefix = "b";
//            bool hasPrefix = fruits.Any(f => f.StartsWith(prefix));
//            Console.WriteLine(hasPrefix); // Output: True


//            var list = new List<string>() { "ASUS", "Acer", "BenQ", "Toshiba", "IBM", "HP", "Dell" };
//            var emptyList = new List<string>() { };
//            Console.WriteLine(list.Any());
//            Console.WriteLine(emptyList.Any());
//            int CountNumberOfSInName(string nam)
//            {
//                _ = nam ?? throw new ArgumentNullException(nameof(nam));

//                return nam.Count(c => char.ToLower(c).Equals('s'));
//            }
//            int  name =  CountNumberOfSInName("howards");
//            Console.WriteLine(name);
//            List<int> controls = new List<int>()
//            {123,4,5,6,7 };

//            Console.WriteLine(controls.ToList());
//            Console.WriteLine(controls);
//            Console.ReadLine();

//        }
//    }
//}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
 namespace std
{
    class program
    {
        public static void Main()
        {
            const int _max = 1000000;
            int[] array = new int[] { 10, 20, 30, 40, int.MaxValue, int.MinValue };

            var s1 = Stopwatch.StartNew();
            for (int i = 0; i < _max; i++)
            {
                // Version 1: use ToList.
                var list = array.ToList();
                if (list.Count != 6)
                {
                    return;
                }
            }
            s1.Stop();
            var s2 = Stopwatch.StartNew();
            for (int i = 0; i < _max; i++)
            {
                // Version 2: use List constructor.
                var list = new List<int>(array);
                if (list.Count != 6)
                {
                    return;
                }
            }
            s2.Stop();
            Console.WriteLine(((double)(s1.Elapsed.TotalMilliseconds * 1000000) / _max).ToString("0.00 ns"));
            Console.WriteLine(((double)(s2.Elapsed.TotalMilliseconds * 1000000) / _max).ToString("0.00 ns"));
            Console.ReadLine();
        }

    }
}





