using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insertionSort
{
    class Program
    {
        //插入排序
        static void Main(string[] args)
        {
            int[] array = { 12, 5, 26, 18, 35, 27, 6 };
            Console.WriteLine("插入排序");
            Console.Write("待排序数组：");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            for (int i = 1; i < array.Length; i++)
            {
                int temp = array[i];
                for (int j = i - 1; j >= 0; j--)
                {
                    if (array[j] > temp)
                    {
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                    else
                        break;
                }
            }
            Console.Write("已排序数组：");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            //Carry arry = new Carry(10);//初始化一个10个数据元素的数组
            //Random rnd = new Random(100);//在1到100中随机产生10个数作为数组成员
            //for (int i = 0; i < 10; i++)
            //{
            //    arry.insert(rnd.Next(0, 100));
            //}
            //arry.insertsort();//调用插入排序
            //arry.display();//打印数组
            Console.ReadKey();
        }
        //class Carry
        //{
        //    private int[] arr;
        //    private int numitems;
        //    private int upper;
        //    public Carry(int size) //构建数组
        //    {
        //        arr = new int[size];
        //        upper = size - 1;
        //        numitems = 0;
        //    }
        //    public void insert(int items)//向数组中添加数据
        //    {
        //        for (int i = 0; i < upper; i++)
        //        {
        //            arr[numitems] = items;
        //        }                  
        //        numitems++;
        //    }
        //    public void display()//打印数组
        //    {
        //        for (int i = 0; i < upper; i++)
        //        {
        //            Console.Write(arr[i] + " ");
        //        }                   

        //    }
        //    public void insertsort()//插入排序
        //    {
        //        for (int outer = 1; outer <= upper; outer++)
        //        {
        //            int temp = arr[outer];
        //            int inner = outer;
        //            while (inner > 0 && (int)arr[inner - 1] >= temp)
        //            {
        //                arr[inner] = arr[inner - 1];
        //                inner--;
        //            }
        //            arr[inner] = temp;
        //        }

        //    }

        //}
    }
}
