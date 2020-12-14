using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selection_sort
{
    class Program
    {
        //选择排序
        static void Main(string[] args)
        {
            int[] array = { 23, 7, 11, 6, 8, 29, 4, 45, 20 };
            Console.WriteLine();
            foreach (int a in array)
            {
                Console.Write(a + " ");
            }
            int length = array.Length;
            int temp;
            for (int i = 0; i < length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < length; j++)
                {
                    if (array[min].CompareTo(array[j]) > 0)
                    {
                        min = j;
                    }
                    
                }                
                temp = array[min];
                array[min] = array[i];
                array[i] = temp;
                Console.WriteLine();
                foreach (int a in array)
                {
                    Console.Write(a + " ");
                }
                //Console.WriteLine(arr[i]);
            }
            
            foreach(int a in array)
            {
                Console.Write(a+" ");
            }
            Console.ReadKey();
        }
    }
}
