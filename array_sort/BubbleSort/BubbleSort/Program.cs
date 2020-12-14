using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 23, 45, 16, 7, 42 };            
            int length = array.Length - 1;
            bool isExchanged = false;
            //冒泡排序
            for (int i = 0; i < length; i++)
            {
                isExchanged = false;
                //由小到大排序
                for (int j = 0; j < length - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                        isExchanged = true;
                    }

                }
                ////由大到小排序
                //for (int j = length; j > i; j--)
                //{
                //    if (array[j] > array[j - 1])
                //    {
                //        int temp = array[j];
                //        array[j] = array[j - 1];
                //        array[j - 1] = temp;

                //        isExchanged = true;
                //    }
                //}
                if (!isExchanged)
                { //一遍比较过后如果没有进行交换则退出循环
                    break;
                }
            }
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            Console.Read();//


            Console.ReadKey();//暂停
        }

    }
}
