using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointTest
{
    class Program
    {
        public string[] mParameter;
        public string p
        {
            get
            {
                    // 參數有多個，可能為 X + Y 或是 X + Y + Toward
                    return $"({string.Join(",", mParameter)})";
            }
        }
        static void Main(string[] args)
        {

            string[] p= { "(1,2)","(7,24)","(11,23)","(11,22)" };
            Console.WriteLine($"({string.Join("、", p)})");
            Point2D point2D = new Point2D(1, 2);
            List<Point2D> result = null;
            result = new List<Point2D> { };
            string ip = " IPv4 位址 . . . . . . . . . . . . : 172.30.3.227";
            int seperatorIndex = ip.IndexOf(":");
            string ipp = ip.Substring(0, seperatorIndex);
            Console.WriteLine(seperatorIndex);
            Console.WriteLine(ipp);

            bool nullTest =(bool)ip?.Contains("2");
            Console.WriteLine(nullTest);


            point2D.mX = 2;
            string x = point2D.ToString();
            Console.WriteLine(result.ToString());
            Console.WriteLine(x);
            Console.ReadLine();

        }
    }
}
