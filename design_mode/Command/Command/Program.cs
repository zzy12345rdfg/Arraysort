using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Command command = new ConcreteCommand();
            Console.WriteLine("用户发送命令给调用者。。。");
            Invoker invoker = new Invoker(command);
            Console.WriteLine("调用者接受command命令，并执行InvokerCommand()方法");
            invoker.InvokerCommand();
            Console.ReadKey();
        }
    }
       
    //抽象命令
     public  abstract class Command
     {
        public abstract void execute();
     }
    //具体命令
    public  class ConcreteCommand : Command
    {
       private Receiver receiver;
       public  ConcreteCommand()
       {
          receiver = new Receiver();//实例化一个接收者
       }
       public override void execute()//实现抽象命令的虚方法
       {
          receiver.ReceiverCommand();//执行接收者ReceiverCommand()行为方法
        }
    }
    //调用者
    class Invoker
    {
        private Command command;
        public Invoker(Command command)//接受命令
        {
            this.command = command;
        }
        public void setCommand(Command command)
        {
            this.command = command;
        }
        public void InvokerCommand()
        {
            Console.WriteLine("调用者执行命令command.execute()方法");
            command.execute();//实现命令
        }
    }
    //接收者
   class Receiver
   {
      public void ReceiverCommand()
      {
         Console.WriteLine("调用者向接收者传递命令，接收者的ReceiverCommand()方法被调用");
      }
   }
}
