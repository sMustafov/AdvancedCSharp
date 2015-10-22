using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbersOne;
            int[] numbersTwo;
            int[][] firstJaggedArray = new int[n][];
            int[][] secondJaggedArray = new int[n][];
            int[] firstLengths = new int[n];
            int[] secondLengths = new int[n];
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                numbersOne = input.Split(new char[0], StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                firstJaggedArray[i] = new int[numbersOne.Length];
                firstLengths[i] = numbersOne.Length;

                for (int k = 0; k < numbersOne.Length; k++)
                {
                    firstJaggedArray[i][k] = numbersOne[k];
                }
            }

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                numbersTwo = input.Split(new char[0], StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                secondJaggedArray[i] = new int[numbersTwo.Length];
                secondLengths[i] = numbersTwo.Length;

                for (int k = 0; k < numbersTwo.Length; k++)
                {
                    secondJaggedArray[i][k] = numbersTwo[k];
                }
            }
            int[] num = new int[n];
            int count = 1;
            for (int i = 0; i < n; i++)
            {
                num[i] = firstLengths[i] + secondLengths[i];
            }

            for (int i = 0; i < n; i++)
            {
                if (i < n - 1)
                {
                    if (num[i] == num[i + 1])
                    {
                        count++;
                    }
                }
            }
            if (count != n)
            {
                int sum = 0;
                for (int i = 0; i < n; i++)
                {
                    sum += num[i];
                }
                Console.WriteLine("The total number of cells is: {0}", sum);
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write("[");
                    for (int j = 0; j < firstLengths[i]; j++)
                    {
                        Console.Write(firstJaggedArray[i][j] + ", ");
                    }
                    for (int k = secondLengths[i] - 1; k >= 0; k--)
                    {
                        if (k != 0)
                        {
                            Console.Write(secondJaggedArray[i][k] + ", ");
                        }
                        else
                        {
                            Console.Write(secondJaggedArray[i][k]);
                        }
                    }
                    Console.WriteLine("]");
                }
            }
        }
    }
}