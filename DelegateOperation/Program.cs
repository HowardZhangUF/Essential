using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateOperation
{
    class program
    {
        /*
* delegate (回傳型別) [委派類別] (參數型別..)
* 宣告一個委派類別 - arithmeticexpr
* 傳入方法(method)的回傳型別為void，參數型別為兩個int
*/
        public delegate void arithmeticexpr(int a, int b);

        public delegate void del(string str);
        

        // 顯示出該方法的名稱與 a + b 的結果
        public static void add(int a, int b)
        {
            Console.WriteLine("method:[add] has been called.\nthe answer is: " + (a + b).ToString() + "\n");
        }

        // 顯示出該方法的名稱與 a - b 的結果
        public static void sub(int a, int b)
        {
            Console.WriteLine("method:[sub] has been called.\nthe answer is: " + (a - b).ToString() + "\n");
        }

        // 顯示出該方法的名稱與 a * b 的結果
        public static void multiply(int a, int b)
        {
            Console.WriteLine("method:[multiply] has been called.\nthe answer is: " + (a * b).ToString() + "\n");
        }

        public static void Notify(string name)
        {
            Console.WriteLine($"the name is {name}");
        }

        static void Main(string[] args)
        {
            // 宣告三個委派
            arithmeticexpr ar1, ar2, ar3;
           
            del del1 = Notify;
            del1.ToString();
            del del2 = new del(Notify);
            del del3 = delegate (string name)//宣告匿名方法
            {
                Console.WriteLine($"The name is {name}");
            };

            del1.Invoke("howard");

            
            Console.WriteLine(del1);
            /*******************section 1*******************/
            //ar1 = add;          // 起始將add指派給ar1
            //ar1(10, 7);         // invoke委派，呼叫add並顯示出答案: 17
            ar1 = sub;          // ar1指派為sub
                                //ar1(10, 7);         // invoke委派，呼叫sub並顯示出答案: 3
            ar1.Invoke(10, 7);  // 或是可以使用invoke方法

            /*******************section 2*******************/
            ar2 = add;  // 起始將add指派給ar2
            ar2(3, 41); // invoke委派，呼叫add並顯示出答案: 44
            ar2 += sub; // 將sub方法加入ar2的方法清單中
                        // 現在方法清單中有add和sub (順序為: add -> sub)
            ar2(3, 41); // invoke委派，首先呼叫add，答案為44;而後呼叫sub，答案為-38

            /*******************section 3*******************/
            ar3 = multiply; // 起始將multiply指派給ar3
            ar3 += add;     // 將add方法加入ar3的方法清單中
                            // 現在方法清單中有multiply和add (順序為: multiply -> add)
            ar3 += sub;     // 將sub方法加入ar3的方法清單中
                            // 現在方法清單中有multiply、add和sub (順序為: multiply -> add -> sub)
            ar3(67, 19);    // invoke委派，依序呼叫 multiply、add和sub
            ar3 -= ar2;     // 將add、sub移出方法清單
            ar3(67, 19);    // 再次invoke委派，這次只有ar3被呼叫
            /*ar3 = null;     // 清空整個方法清單
            ar3(18, 0);     // error ==> 方法清單已經被清空了，拋出例外*/
            ar3 = null;     // 清空整個方法清單
            ar3?.Invoke(18, 2);     // safe! 呼叫invoke前，已經先檢查是否為null

            Console.ReadKey();
        }


    }
    //class program
    //{ 
    //    static void Main(string[] args)
    //    {
    //        del del1 = Noitfy("howard");
    //    }
    //    delegate void del(string str);
    //    static void Noitfy(string name)
    //    {
    //        Console.WriteLine($"the name is {name}");
    //    }
    

    

    
             

    
        

    
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        ObjectA objectA = new ObjectA("Kawaii", 5);
    //        ObjectB objectB = new ObjectB();
    //        ObjectC objectC = new ObjectC();

    //        objectA.ObjAnounceEvent += objectB.ObjBGreeting;
    //        objectA.ObjAnounceEvent += objectC.ObjCGreeting;

    //        while (Console.ReadKey().Key == ConsoleKey.Spacebar)
    //        {
    //            objectA.OnObjAEventBeenCalled();
    //        }
    //    }
    //}
    //class ObjectA
    //{
    //    public string Name { get; set; }
    //    public int CallCountThreshold { get; set; }

    //    private int _callCount;

    //    public delegate void ObjADelegate(ObjectA objectA);
    //    public event ObjADelegate ObjAnounceEvent;

    //    public ObjectA(string name, int callCountThreshold)
    //    {
    //        Name = name;
    //        CallCountThreshold = callCountThreshold;
    //        _callCount = 0;
    //    }

    //    public void OnObjAEventBeenCalled()
    //    {
    //        _callCount += 1;

    //        if (_callCount > CallCountThreshold)
    //        {
    //            ObjAnounceEvent = null;
    //            Console.WriteLine("Clear the invocation list.");
    //            Environment.Exit(0);
    //        }

    //        ObjAnounceEvent?.Invoke(this);
    //    }
    //}
    //class ObjectB
    //{
    //    public void ObjBGreeting(ObjectA objectA)
    //    {
    //        Console.WriteLine("Hello, " + objectA.Name + ". This is Object B.");
    //    }
    //}
    //class ObjectC
    //{
    //    public void ObjCGreeting(ObjectA objectA)
    //    {
    //        Console.WriteLine("I love you, " + objectA.Name + ". This is Object C.");
    //    }
    //}

   
    /* static void Main(string[] args)
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
     }*/
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

