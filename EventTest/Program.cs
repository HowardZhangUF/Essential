using System;

public class Program
{
    public static void Main()
    {
        ProcessBusinessLogic bl = new ProcessBusinessLogic();
        bl.ProcessCompleted += bl_ProcessCompleted; // register with an event
        bl.StartProcess();
    }

    // event handler
    public static void bl_ProcessCompleted()
    {
        Console.WriteLine("Process Completed!");
        Console.ReadKey();
    }
}

public delegate void Notify();  //declared a delegate Notify

public class ProcessBusinessLogic
{
    public event Notify ProcessCompleted; //  declared an event ProcessCompleted of delegate type Notify using "event" keyword

    public void StartProcess()
    {
        Console.WriteLine("Process Started!");
        // some code here..
        OnProcessCompleted();
    }


    protected virtual void OnProcessCompleted()
    ////Protected and virtual enable derived classes to override the logic for raising the event
    {
        ProcessCompleted?.Invoke();
    }
}

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTest
{

    public delegate void Notify();//declared a delegate Notify
    public class ProcessB
    {
        public  event Notify Completed;
        //and then declared an event ProcessCompleted of delegate type Notify using "event" keyword
        public void StartProcess()
        {
            Console.WriteLine("Process Started!");
            // some code here..
            OnCompleted();
        }

        protected virtual void OnCompleted() //protected virtual method
            //Protected and virtual enable derived classes to override the logic for raising the event
        {
            //if ProcessCompleted is not null then call delegate
            Completed?.Invoke();//invokes the delegate using Completed?.Invoke();
        }
    }

    class Program
    {

        static void Main(string[] args)
        {

        }
    }
}*/
