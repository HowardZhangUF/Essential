using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p

{
    public class Circle
    {
        private static float PI = 0.0f;
        private float radius = 0.0f;
        static Circle()
        {
            Console.WriteLine("靜態建構函式-啟動");
            PI = 3.141592653f;
        }
        public Circle(float radius)
        {
            Console.WriteLine("建構函式-啟動");
            this.radius = radius;
        }
        public float getArea() { return PI * this.radius * this.radius; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(3.0f);
            Circle circle2 = new Circle(5.0f);
            Console.WriteLine(circle1.getArea());
            Console.WriteLine(circle2.getArea());

            Console.ReadKey();
        }
    }
}
