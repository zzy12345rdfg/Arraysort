using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//状态模式
namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {            
            Context context = new Context();    //创建环境      
            State state_A = new ConcreteStateA();
            State state_B=  new ConcreteStateB();
           
            state_A.Action(context);
            Console.WriteLine(context.getState().ToString());
            state_B.Action(context);
            Console.Write(context.getState().ToString());


            Console.ReadKey();
        }
        
    }
    //抽象状态类
    public abstract class State
    {
        public abstract void Action(Context context);
    }

    //具体状态A类
    public class ConcreteStateA : State
    {
        public override void Action(Context context)
        {
            Console.WriteLine("当前状态是 A.");
            context.setState(this);            
        }        
    }
    //具体状态B类
    public class ConcreteStateB : State
    {
        public override void Action(Context context)
        {
            Console.WriteLine("当前状态是 B.");
            context.setState(this);
        }
    }
    //环境类
    public class Context
    {
        private State state;
        //定义环境类的初始状态
        public Context()
        {
            state = null;
        }
        //读取状态
        public void setState(State state)
        {
            this.state = state;
        }

        public State getState()
        {
            return state;
        }   
         
       
    }
    
    

}
