using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryContain
{
    class Program
    {
       
        
        static void Main(string[] args)
        {
            IDictionary<int,int> delt = new Dictionary<int, int>();
            
            delt.Add(1, 13);
            delt.Add(2,14);
            delt.Add(3,15);
            delt.Add(4,16);
            int ind = 5;
            Console.WriteLine(delt.ContainsKey(ind)?delt[4]:default);

            IDictionary<string, string> sdelt = new Dictionary<string, string>();
            sdelt.Add("1", "a");
            sdelt.Add("2", "b");
            sdelt.Add("3", "c");
            sdelt.Add("4", "d");
            sdelt.Add("5", "e");

            Console.WriteLine(sdelt.ContainsKey("4") ? sdelt["2"] : default);


            IDictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("1", "a");
            dic.Add("2", "b");
            dic.Add("3", "c");
            dic.Add("4", "d");
            dic.Add("5", "e");
            //if(!dic.Contains("8"))
            string x = "howard";
            if (!dic.ContainsKey("8"))
            {
                dic.Add("8", "g");
                Console.WriteLine("vaule for \"8\"is :{0}", dic["8"]);
            }
            dic.TryGetValue("1",out x);
            
            
            
            Console.WriteLine(x);
            Console.ReadLine();
            
            

           
        }
    }
}
