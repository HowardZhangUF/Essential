using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentsionMethod
{
   



    public static class ExtensionMethod//需加 public static modify
    {
        static string GetName(Person person)
        {
            Console.WriteLine(person.name);
            return person.name;
        }

        static string GetThisName(this Person person)
        {
            Console.WriteLine(person.name);
            return person.name;
        }
        static int  GetAge(Person person)
        {
            Console.WriteLine(person.age);
            return person.age;
        }
        static string GetCountry()
        {
            Console.WriteLine(this Person name);

        }
    }
}
