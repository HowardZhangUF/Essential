using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L
{
    
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class PraticalI: ICommunicatorServe
    {
        
        EventHandler<double> he ;
        //如果沒有event關鍵字，加了get set把he 作為變數編譯能過;
        //he理解為以函數指標宣告的變數。可以在實做出此介面的類別中為此事件變數加入方法


        int mLocalPort = 1;
        bool mIsListened = false;
        string[] mClientIpPorts = { "hiward","hoem"};
        void StartListen()
        {
             Console.WriteLine("Listen");
        }
        void StopListen()
        {
            Console.WriteLine("hi");
        }

        void SendData(string IpPort, object Data)
        {
            Console.WriteLine(IpPort, Data);
        }
    }

}
