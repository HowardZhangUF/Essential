using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateOperation
{

    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            Func<int, int, int> f;

            //   依照輸入的運算符號選擇要存的方法
            //   記得!!Func<>是可以存方法的變數，
            //   所以+我存了一個加法的方法
            //   -是用delegate存匿名方法
            //   *、/ 是用lambda存方法
            switch (s)
            {
                case "+":
                    f = 加法;
                    break;
                case "-":
                    f = delegate (int x, int y) { return x - y; };
                    break;
                case "*":
                    f = (int x, int y) => x * y;
                    break;
                case "/":
                    f = (x, y) => y != 0 ? x / y : 0;
                    break;
                default:
                    f = 加法;
                    break;
            }
            //使用MyFunc方法
            int answer = MyFunc(f, 5, 2);


            //也可以這樣寫喔，傳入匿名的Func
            //int answer = MyFunc((x, y) => x + y, 5, 5);


            Console.WriteLine(answer);
            Console.ReadKey();
        }
        
        public static int MyFunc(Func<int, int, int> fun, int x, int y)
        {
            return fun(x, y);
        }

        public static int 加法(int x, int y)
        {
            return (x + y);
        }
    }
    /* class Program
     {
         static void Main(string[] args)
         {
             //讀進要做的動作" + , - , * , / "
             string s = Console.ReadLine();

             //建立一個委派
             MyDelegate d;

             //依照傳入的動作，選擇要傳入委派的方法
             switch (s)
             {
                 case "+":
                     d = new MyDelegate(加法);
                     //依據new 記憶體空間來看，delegate是一個類別
                     break;
                 case "-":
                     d = new MyDelegate(減法);
                     break;
                 case "*":
                     d = new MyDelegate(乘法);
                     break;
                 case "/":
                     d = new MyDelegate(除法);
                     break;
                 default:
                     d = new MyDelegate(加法);
                     break;
             }

             //使用該委派
             int Answer = d(5, 2);

             Console.WriteLine(Answer);
             Console.ReadKey();
         }

         //用static是因為我懶的new出物件，但要視情況用
         public static int 加法(int x, int y)
         {
             return (x + y);
         }

         public static int 減法(int x, int y)
         {
             return (x - y);
         }

         public static int 乘法(int x, int y)
         {
             return (x * y);
         }

         public static int 除法(int x, int y)
         {
             if (y != 0)
                 return (x / y);
             return 0;
         }

         public delegate int MyDelegate(int x, int y);

     }*/
}
