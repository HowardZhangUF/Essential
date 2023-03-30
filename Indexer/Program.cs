using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{

    class hey<T>
        {
       
        private T[] arr = new T[100];
        public T this[int i]//設定一個型別為T的array
                            // Define the indexer to allow client code to use [] notation.
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var stringCollection = new hey<string>();
            stringCollection[0] = "Hello, World";
            stringCollection[1] = "howard";
            Console.WriteLine(stringCollection[0]+stringCollection[1]);
            Console.ReadKey();
        }
    }
}
