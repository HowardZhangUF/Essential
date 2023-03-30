using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointTest
{
    class Program
    {
        static void Main(string[] args)
        {
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
