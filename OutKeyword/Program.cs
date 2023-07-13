using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutKeyword
{
    /****************************************************/
    public class Animal
    { }
    public class Monkey:Animal
    { }
    public class Dophin:Animal { }

    public interface IataSource<out T>
    {
        T GetItem(int index);
    }
    public class MyDataSource : IDataSource<Dophin>
    {
        public Dophin GetItem(int index)
        {
            if (index == 0)
            {
                return new Dophin();
            }
            else if (index == 1)
            {
                return new Monkey();
            }
            else
            {
                return new Animal();
            }
        }
    }


    /****************************************************/
    public interface IEnumerable<out T> : IEnumerable
    {
        IEnumerator<T> GetEnumerator();
    }
    public interface IDataSource<T>
    {
        T GetItem(int index);
    }
    public interface iDataSource< T>
    {
         T GetT(int s);
    }
    public class MyDS : iDataSource< Dog>
    {
      
        public Dog GetT(int s)
        {
            if (s == 0)
            {
                return new Dog();
            }
            else if (s == 1)
            {
                return new cat();
            }
            else {
                return new biter();
            }

            
        }
        public Dog GeT(int s)
        {
            if (s == 0)
            {
                return new Dog();
            }
            else if (s == 1)
            {
                return new cat();
            }
            else
            {
                return new biter();
            }


        }
    }

    public class MyDataSource:IDataSource<Dog>
        {
        public Dog GetItem(int index)
        {
            
            if(index ==0)
            {
                return new Dog();
            }
            else if(index == 1)
            {
                return new cat();

            }else { return new biter(); }

        }

        }




    interface IAnimal
    {
     string color { get; set; }
     string type { get; set; }
     void sound();
     
     

    }

    

    public class Dog : IAnimal
    {
        public string type { get; set; }
        public string color { get; set; }
        string action = "sprint";
        public void sound()
        {
            Console.WriteLine("wanwan");
        }

    }

    public class cat : IAnimal
    {
        public string type { get; set; }
        public string color { get; set; }
        string action = "jump";
        public void sound()
        {
            Console.WriteLine("mewmew");
        }

    }
    class biter : Dog
    {
        string type = "dog";
        string color = "yellow";
        string action = "sprint";
        string bite = "hard";
        void sound()
        {
            Console.WriteLine("wanwan");
        }
    }





    class Program
    {
        static void Main(string[] args)
        {
            cat kettiy = new cat();
            Dog snooby = new Dog();
            IAnimal partical = new Dog();
            //biter bi = new Dog();


        }
    }
}
