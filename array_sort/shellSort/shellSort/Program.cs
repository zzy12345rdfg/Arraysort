using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shellSort
{
    class Program
    {
        //希尔排序
        static void Main(string[] args)
        {                      
            int[] array = { 7, 6, 14, 8, 22, 30, 2, 51, 4 };
            Console.WriteLine("希尔排序");
            Console.Write("待排序数组：");
            foreach (int a in array)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();

            int length = array.Length;
            int temp;            
            Console.WriteLine("数组长度："+length ); //9           
            for (int gap = length / 2; gap >= 1; gap /= 2)
            {
                
                Console.WriteLine("增量："+ gap);//4 2 1
                for (int i = gap; i < length; i++)
                {
                    
                    temp = array[i];                    
                    int j = i - gap;
                    while (j >= 0 && array[j] > temp)
                    {
                        array[j + gap] = array[j];
                        j -= gap;                        
                    }
                    array[j + gap] = temp;
                    
                }
                
            }
            
            Console.Write("已排序数组：");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
