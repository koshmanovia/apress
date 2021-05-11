using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearch(20, 2);
            Console.ReadLine();
        }
        static void BinarySearch(int high, int item)
        {
            Console.WriteLine("=> Binary Search: \n");
            var low = 0;
            var mid = 0;
            var guess = 0;
            
            List<int> list = new List<int>();
            for (int i = 0; i < high; i++)
            {
                list.Add(i);               
            }
            while (low <= high)
            {
                mid = (low + high) / 2;
                guess = list[mid];
                if (guess == item)
                {
                    Console.WriteLine(mid);
                    break;
                }
                if (guess > item)
                {
                    high = mid - 1;
                }
                else 
                {
                    low = mid + 1;
                }              
            }
            Console.WriteLine();
        }
    }
}
