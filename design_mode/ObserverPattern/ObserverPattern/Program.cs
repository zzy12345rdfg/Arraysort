using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//观察者模式
namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("实例化目标");
            Subject subject = new ConcreteSubject();
            Console.WriteLine("实例化两个观察者：Observer1、Observer2");
            Observer obs1 = new ConcreteObserver1();
            Observer obs2 = new ConcreteObserver2();
            subject.add(obs1);
            subject.add(obs2);
            subject.Radio();

            Console.ReadKey();
        }
    }
    //抽象目标
      public abstract class Subject
      {
        protected List<Observer> observers = new List<Observer>();
        //增加观察者方法
        public void add(Observer observer)
        {
            observers.Add(observer);
        }
        //删除观察者方法
        public void remove(Observer observer)
        {
            observers.Remove(observer);
        }
        public abstract void Radio(); //通知观察者方法
      }
      //具体目标
      public class ConcreteSubject : Subject
      {
        public override void Radio()
        {
           Console.WriteLine("通知观察者目标发生改变...");
          
           foreach (Object obs in observers)
           {
              ((Observer)obs).response();
           }
        }

        
    }
     //抽象观察者
     public  interface Observer
     {
         void response(); //反应
     }
     //具体观察者1
     public class ConcreteObserver1 : Observer
     {         
         public void response()
         {           
            Console.WriteLine("观察者1已接受到消息，作出反应！");
         }
     }
     //具体观察者1
     public class ConcreteObserver2 : Observer
     {
         public void response()
         {
            Console.WriteLine("观察者2已接受到消息，作出反应！");
         }
     }
}