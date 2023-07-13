using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutCovarience
{
    interface IObject<out T>
    {
        string typeOf();
    }

    class samlpeA<T> : IObject<T>
    {
        public string typeOf()
        {
            return typeof(T).ToString();
        }
    }

    class samlpe<T> : samlpeA<T>, IObject<T>
    {
        public string typeOf()
        {
            return typeof(T).ToString();
        }
    }


    class samlpeB<T> : samlpeA<T>, IObject<T>
    {
        public string typeOf()
        {
            return typeof(T).ToString();
        }
    }
    class Program
    {
       

        static void Main(string[] args)
        {
            samlpe<Object> _object = new samlpe<Object>();
            IObject<string> _string = new samlpeB<String>();
            samlpeA<string> hi = new samlpe<string>();
            samlpe<Object> obj = new samlpe<Object>();
            IObject<string> str = new samlpe<String>();
            _object = _string;
            _string = str;
            obj = _object;
            Console.ReadLine();
        }
    }
}
