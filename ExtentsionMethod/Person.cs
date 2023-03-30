using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentsionMethod
{
    public  class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public string country { get; set; }

      public Person()//建構子須為public
        {
             this.name = "howard";//需用this才能指定為上面的name
            //string name ;沒有用this等於另外宣告了個相同名稱的變數
            this.age = 23;
            string country = "TW";

        }

    }
}
