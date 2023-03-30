using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter c = new Counter(5);
            c.ThresholdReached += c_ThresholdReached;
            c.ThresholdReached += C_ThresholdReached;
            //方法加入事件
            //以publisher: Counter 建置的c物件
            //事件(函數指標)

            Console.WriteLine("press 'a' key to increase total");
            while (Console.ReadKey(true).KeyChar == 'a')
            {
                Console.WriteLine("adding one");
                c.Add(1);
            }

        }

        private static void C_ThresholdReached(object sender, ThresholdReachedEventArgs e)
        {
            throw new NotImplementedException();//匿名函數
        }

        static void c_ThresholdReached(object sender, ThresholdReachedEventArgs e)//此為要加入事件之方法
        {
            
            Console.WriteLine("The threshold of {0} was reached at {1}.", e.Threshold, e.TimeReached);
            Console.ReadKey();
            //Environment.Exit(0);//指令結束後會把主控台關掉
        }
    }

    class Counter//主要擔任publish的calss
    {
        private int threshold;
        private int total;

        public Counter(int passedThreshold)//傳入參數的建構子
        {
            threshold = passedThreshold;
        }

        public void Add(int x)
        {
            total += x;
            if (total >= threshold)
            {
                ThresholdReachedEventArgs args = new ThresholdReachedEventArgs();
                //上面指令是其他類別在publish內增加實體args

                args.Threshold = threshold;
                //依造ThresholdReachedEventArgs類別藍圖建造的實體args
                //可以呼叫該藍圖內宣告的屬性Threshold(get;set;),並指派當前藍圖內的private變數(threshold)
                args.TimeReached = DateTime.Now;
                OnThresholdReached(args);//args的宣告到publisher內派值完後，丟進函數指標包
                //等等主程式呼叫Add時，會自動帶入args參數
            }
        }

        protected virtual void OnThresholdReached(ThresholdReachedEventArgs e)
        {
            EventHandler<ThresholdReachedEventArgs> handler = ThresholdReached;
            //函數指標:EventHandler  = event delegate; 變數:handler; 事件: ThreadholdReached;
            //執行完後變數即可代理事件ThresholdReached去做事;
            //原本沒宣告上面指令，事件需要自己做事情
            //if (ThresholdReached != null)
            //{
            //    ThresholdReached(this, e);
            //}
            //執行完後handler可以幫忙事件做事
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public event EventHandler<ThresholdReachedEventArgs> ThresholdReached;
    }

    public class ThresholdReachedEventArgs : EventArgs
    {
        public int Threshold { get; set; }
        public DateTime TimeReached { get; set; }
    }
}

//using System;

//class program
//{
//    static void Gtest<T>(T x)
//    {
//        Console.WriteLine("the type is" + x.GetType() + ",value is: " + x);
//    }
//    public class Gclass<T>
//    {
//        T[] innerarray = new T[0];
//        //add get all
//        public void Add(T value)
//        {
//            // innerarray[innerarray.Length + 1] = value; 報錯 索引在陣列的界線外
//            Array.Resize(ref innerarray, innerarray.Length + 1);
//            innerarray[innerarray.Length-1] = value;
//        }

//        public T Get(int ind)
//        {
//            return innerarray[ind];
//        }

//        public T[] All()
//        {
//            return innerarray;
//        }



//    }


//    static void Main()
//    {
//        Gtest<int>(5);
//        Gtest<string>("howard");
//        Gtest<double>(50.50);
//        Gclass<int> myGtest = new Gclass<int>();
//        myGtest.Add(12);
//        myGtest.Add(44);
//        foreach(int i  in myGtest.All())
//        {
//            Console.WriteLine(i);
//        }

//        Console.ReadLine();
//    }
//}