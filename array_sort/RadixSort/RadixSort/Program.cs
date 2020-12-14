using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//基数排序
namespace RadixSort
{
    class Program
    {        
        static void Main(string[] args)
        {
            int[] array = {230,73,22,93,43,55,14,28,65,39,8,100 };
            List<int> list = new List<int>(array);
            int maxValue = list.Max();//*list.Max()返回最大值
            int train = 0;
            //需要几趟
            //maxvalue 9-1 99-2 999-3
            //*Math.Pow(10, it)返回指定数字的指定次幂
            //10^0<=9 10^1>9 it=1
            //10^0<99 10^1<99 10^2>99 it=2
            while (Math.Pow(10, train) <= maxValue)
            {
                List<List<int>> buckets = new List<List<int>>(10);//分10个桶对应0-9
                for (int i = 0; i < 10; i++)
                {
                    buckets.Add(new List<int>());
                }//列表初始化大小
                for (int i = 0; i < list.Count; i++)//入桶
                {
                    //989 it=0 989/10^it=989 989%10=9;
                    int intobarrel = (int)((list[i]) / (Math.Pow(10, train)) % 10);//得到对应桶
                    buckets[intobarrel].Add(list[i]);
                }//全部入桶
                list.Clear();//依次取出来
                for (int i = 0; i < buckets.Count; i++)
                {
                    list.AddRange(buckets[i]);
                }
                train += 1;//继续下一次循环入桶出桶
            }
            foreach(int l in list)
            {
                Console.Write(l + " ");
            }
            Console.ReadKey();
        }
    }
}
