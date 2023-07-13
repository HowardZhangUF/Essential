using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectMethod
{
    class Program
    {
       

        static void Main(string[] args)
        {
            IEnumerable<int> numbers = new List<int> { 1, 2, 3 };
            IEnumerable<string> stringNumbers = numbers.Select(o => $"{o}-");
            foreach (string i in stringNumbers)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }
    }
}
