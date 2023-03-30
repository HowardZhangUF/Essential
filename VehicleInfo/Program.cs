using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInfo
{
    class Program
    {
        

        static void Main(string[] args)
        {
            IA a = new All();
           
            
        }
    }
    interface IA
    {
        int point { get; set; }
        int score { get; set; }

    }
    interface IB
    {
        int teacher { get; set; }
        int student { get; set; }
    }
    public class All : IA, IB
    {

        public int point { get; set; }
        public int score { get; set; }
        public int teacher { get; set; }
        public int student { get; set; }
    }


}
