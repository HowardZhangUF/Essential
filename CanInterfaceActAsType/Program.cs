using System;
using System.Collections.Generic;

namespace ParameterModifier
{
    class testClass
        {
            public string x = "";
        }
    class Program
    {
        
        static void Main(string[] args)
        {
            testClass obj;//out 參數使用時，僅需宣告，不需初始化
            string b = "444";
            Fun_out(b, out obj);
            Console.WriteLine(obj.x);//方法結束後便可使用被設定為out 的入參 
            Console.WriteLine(obj);
            Console.ReadLine();
        }

        static void Fun_out(string a, out testClass otherobj)
        {
            otherobj = new testClass();//out 參數不論傳入時是否已經實作，必定要在方法內重新實作
            otherobj.x = "1234";
        }
    }
}
//using System.IO;
//using System;
//public class Program
//{
//    public  void update(out int a)
//    {
//        a = 10;
//    }
//    public static void change(ref int d)
//    {
//        d = 11;
//    }
//    public static void Main()
//    {
//        int b;
//        int c = 9;
//        Program p1 = new Program();
//        p1.update(out b);
//        change(ref c);
//        Console.WriteLine("Updated value is: {0}", b);
//        Console.WriteLine("Changed value is: {0}", c);
//        Console.ReadLine();
//    }
//}
//using System;
//using System.Collections.Generic;
//using System.Collections;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
///*In this example, we use the IAnimal interface as a type for the dog and cat variables,
// * as well as the animal parameter of the MakeAnimalSound() method.*/
//namespace CanInterfaceActAsType
//{

//    interface IAnimal
//    {
//        void makeSound();

//    }
//    class dog : IAnimal
//    {
//        string type = "giwawa";
//        string color = "yellow";
//        void IAnimal.makeSound()
//        {
//            Console.WriteLine("wonwon");
//        }
//    }

//    class cat : IAnimal
//    {
//        public string type;
//        string color = "buebue";
//        void IAnimal.makeSound()
//        {
//            Console.WriteLine("meow");
//        }
//    }

//    class GernericMethod
//    {
//        public void genericTest<T>(T x)
//        {
//            Console.WriteLine("the type is:{0},value is:{1} ", x.GetType(), x);
//        }
//    }

//    public interface IFruit { }

//    public class Apple : IFruit{ }
//    public class Mango : IFruit { }






//    class Program
//    {
//        static IEnumerable GetFruit()
//        {
//            yield return new Apple();
//            yield return new Mango();
//        }
//        static IEnumerable<IFruit> GetFruit2()
//        {
//            yield return new Apple();
//            yield return new Mango();
//        }
//        static void genericTest<T>(T x)
//        {
//            Console.WriteLine("the type is:{0},value is:{1} ", x.GetType(), x);
//        }
//        static void Main(string[] args)
//        {
//            IAnimal HelloKitty = new cat();
//            cat helloKitty = new cat();
//            IAnimal snooby = new dog();
//            HelloKitty.makeSound();
//            helloKitty.type = "japan cat";
//            snooby.makeSound();
//            int[] arr1 = { 9, 7, 5, 6 };
//            int[] arr2 = { 0 };
//            int[] member = { 8, 5, 6, 4, 7, 9, 2, 1 };
//            //int maxVal = Math.Max(member);
//            member.Max();
//            decimal max = Math.Max(arr1.Max(), arr2.Max());
//            Console.WriteLine(max);

//            genericTest<int>(32);
//            GernericMethod gernericMethod = new GernericMethod();
//            gernericMethod.genericTest<int>(13);
//            DateTime now = new DateTime();//extension method practice
//            Console.WriteLine(now.getShortDatatime());
//            IEnumerable fruits = GetFruit();
//            IEnumerable<IFruit> fruits1 = GetFruit2();

//            Console.ReadLine();



//        }


//    }
//    public static class GetShortDatatime
//    {
//        public static string getShortDatatime(this DateTime c)
//        {
//            return c.ToShortDateString() + " " + c.ToShortDateString();
//        }



//    }


//}
