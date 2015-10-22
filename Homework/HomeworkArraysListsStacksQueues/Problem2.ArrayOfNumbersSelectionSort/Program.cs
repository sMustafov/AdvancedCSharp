using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.ArrayOfNumbersSelectionSort
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
            for (int i = 0; i < array.Length; i++)
            {
                for (int k = i + 1; k < array.Length; k++)
                {
                    if (array[k] < array[i])
                    {
                        int tmp = array[i];
                        array[i] = array[k];
                        array[k] = tmp;
                    }
                }
            }
            for (int j = 0; j < array.Length; j++)
            {
                Console.Write(array[j] + " ");
            }
            Console.WriteLine();
        }
    }
}
