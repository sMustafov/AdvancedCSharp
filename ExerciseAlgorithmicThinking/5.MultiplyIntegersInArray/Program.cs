using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.MultiplyIntegersInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                int prod = 1;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (i != j)
                    {
                        prod *= numbers[j];
                    }
                }
                Console.Write(prod + " ");
            }
            Console.WriteLine();
        }
    }
}
