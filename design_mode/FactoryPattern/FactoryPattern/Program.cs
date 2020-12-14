using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//工厂方法模式
namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory1 Factory1 = new AbstractFactory1();
            AbstractFactory2 Factory2 = new AbstractFactory2();
            AbstractFactory3 Factory3 = new AbstractFactory3();
            Product product1= Factory1.newProduct();
            product1.showProduct();
            Product product2 = Factory2.newProduct();
            product2.showProduct();
            Product product3 = Factory3.newProduct();
            product3.showProduct();
            Console.ReadKey();
        }
    }
    //抽象产品类
    public abstract class Product
    {
        public abstract void showProduct(); 
    }
    //具体产品类
    class ProductA: Product
    {
        public override void showProduct()
        {
            Console.WriteLine("ProductA被生产。");
        }
    }
    class ProductB : Product
    {
        public override void showProduct()
        {
            Console.WriteLine("ProductB被生产。");
        }
    }
    class ProductC : Product
    {
        public override void showProduct()
        {
            Console.WriteLine("ProductC被生产。");
        }
    }
    //抽象工厂类
    class AbstractFactory
    {
        public Product newProduct;
    }
    //具体工厂类
    class AbstractFactory1: AbstractFactory
    {
        public Product newProduct()
        {
            Console.WriteLine("工厂1生产产品A");
            return new ProductA();
        }
    }
    class AbstractFactory2 : AbstractFactory
    {
        public Product newProduct()
        {
            Console.WriteLine("工厂2生产产品B");
            return new ProductB();
        }
    }
    class AbstractFactory3 : AbstractFactory
    {
        public Product newProduct()
        {
            Console.WriteLine("工厂3生产产品C");
            return new ProductC();
        }
    }

}
