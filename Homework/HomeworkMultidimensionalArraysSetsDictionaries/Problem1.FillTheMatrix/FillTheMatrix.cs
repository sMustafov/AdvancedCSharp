using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillTheMatrix
{
    class FillTheMatrix
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            Console.WriteLine("Pattern A: ");
            PatternOne(matrix, n);
            Console.WriteLine("Pattern B: ");
            PatternTwo(matrix, n);
        }
        public static void PatternOne(int[,] matrix, int n)
        {
            int a = 0;
            for (int row = 0; row < n; row++)
            {
                a = row + 1;
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = a;
                    Console.Write(matrix[row, col] + " ");
                    a += n;
                }
                Console.WriteLine();
            }
        }
        public static void PatternTwo(int[,] matrix, int n)
        {
            int a = 1;
            for (int col = 0; col < n; col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < n; row++)
                    {
                        matrix[row, col] = a;
                        a++;
                    }
                }
                else
                {
                    for (int row = n - 1; row >= 0; row--)
                    {
                        matrix[row, col] = a;
                        a++;
                    }
                }
            }
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
