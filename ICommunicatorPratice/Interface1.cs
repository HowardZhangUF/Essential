using System;

namespace L
{
    public interface ICommunicatorServe
    {

        //EventHandler<double> he { get; set; }
        //如果沒有event關鍵字，加了get set把he 作為變數編譯能過;
        //he理解為以函數指標宣告的變數。可以在實做出此介面的類別中為此事件變數加入方法


        int mLocalPort { get; }
        bool mIsListened { get; }
        string[] mClientIpPorts { get; }

        void StartListen();
        void StopListen();
        void SendData(string IpPort, object Data);
    }
}
