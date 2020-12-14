using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //获取唯一可用的对象
            Singleton myobject = Singleton.getInstance();

            //显示消息
            myobject.output();
        }
        
    }
    public class Singleton
    {

        //创建 Singleton的一个对象
        private static Singleton instance = new Singleton();

        //让构造函数为 private，这样该类就不会被实例化
        private Singleton() { }

        //获取唯一可用的对象
        public static Singleton getInstance()
        {
            return instance;
        }

        public void output()
        {
            Console.Write("Hello，我是单例模式!");
            Console.ReadKey();
        }
    }
}
