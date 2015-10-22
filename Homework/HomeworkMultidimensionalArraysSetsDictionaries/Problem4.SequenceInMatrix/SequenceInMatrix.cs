using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceInMatrix
{
    class SequenceInMatrix
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            string[,] matrix = new string[n, m];
            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine();
                string[] words = input.Split(' ');
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = words[col];
                }
            }
            int count = 1;
            int maxCount = 1;
            string rem = null;
            string remembered = null;
            // LINE 
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    if (col < m - 1)
                    {
                        if (matrix[row, col] == matrix[row, col + 1])
                        {
                            count++;
                            rem = matrix[row, col];
                        }
                        else
                        {
                            count = 1;
                        }
                    }
                    if (maxCount < count)
                    {
                        maxCount = count;
                        remembered = rem;
                    }
                }
                count = 1;
            }
            // COLUMN 
            for (int col = 0; col < m; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    if (row < n - 1)
                    {
                        if (matrix[row, col] == matrix[row + 1, col])
                        {
                            count++;
                            rem = matrix[row, col];
                        }
                        else
                        {
                            count = 1;
                        }
                    }
                    if (maxCount < count)
                    {
                        maxCount = count;
                        remembered = rem;
                    }
                }
                count = 1;
            }

            //Diagonal
            for (int row = 0; row <= m - n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (col < n - 1)
                    {
                        if (matrix[col, col + row] == matrix[col + 1, col + row + 1])
                        {
                            count++;
                            rem = matrix[col, col + row];
                        }
                        else
                        {
                            count = 1;
                        }
                    }
                    if (maxCount < count)
                    {
                        maxCount = count;
                        remembered = rem;
                    }
                }
                count = 1;
            }

            //Other Diagonal
            for (int row = 0; row <= m - n; row++)
            {
                for (int col = n - 1, coll = 0; col >= 0; col--, coll++)
                {
                    if (col > 0)
                    {
                        if (matrix[coll, col - row] == matrix[coll + 1, col - row - 1])
                        {
                            count++;
                            rem = matrix[coll, col - row];
                        }
                        else
                        {
                            count = 1;
                        }
                    }
                    if (maxCount < count)
                    {
                        maxCount = count;
                        remembered = rem;
                    }
                }
                count = 1;
            }
            // Final Print 
            for (int i = 0; i < maxCount; i++)
            {
                Console.Write(remembered + " ");
            }
            Console.WriteLine();
        }
    }
}
