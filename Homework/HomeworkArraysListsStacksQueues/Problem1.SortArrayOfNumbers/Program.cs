using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.SortArrayOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arr = input.Split(' ');
            int[] array = new int[arr.Length];
            for (int j = 0; j < arr.Length; j++)
            {
                array[j] = Convert.ToInt32(arr[j]);
            }
            Array.Sort(array);
            foreach (var num in array)
            {
                Console.Write(num  + " ");
            }
            Console.WriteLine();
        }
    }
}
