using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = Convert.ToInt32(input[0]);
            n = n - '0';
            int m = Convert.ToInt32(input[2]);
            m = m - '0';
            int[,] matrix = new int[n, m];
            for (int row = 0; row < n; row++)
            {
                string numbs = Console.ReadLine();
                int[] numbers = numbs.Split(' ').Select(int.Parse).ToArray();
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }
            int newStartRow = 0;
            int newEndRow = 0;
            int newStartCol = 0;
            int newEndCol = 0;
            int startRow = 0;
            int endRow = 3;
            int startCol = 0;
            int endCol = 3;
            int sum = 0;
            int maxSum = int.MinValue;
            do
            {
                for (int i = startRow; i < endRow; i++)
                {
                    for (int j = startCol; j < endCol; j++)
                    {
                        sum += matrix[i, j];
                    }
                }
                if (maxSum < sum)
                {
                    maxSum = sum;
                    newStartRow = startRow;
                    newStartCol = startCol;
                    newEndRow = endRow;
                    newEndCol = endCol;
                }
                if (endRow == n)
                {
                    startRow = 0;
                    endRow = 3;
                    startCol++;
                    endCol++;
                }
                else
                {
                    startRow++;
                    endRow++;
                }
                sum = 0;
            } while (endRow != n + 1 && endCol != m + 1);

            Console.WriteLine(maxSum);
            for (int i = newStartRow; i < newEndRow; i++)
            {
                for (int j = newStartCol; j < newEndCol; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
