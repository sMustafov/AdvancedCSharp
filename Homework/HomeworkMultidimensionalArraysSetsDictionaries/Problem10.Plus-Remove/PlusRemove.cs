using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusRemove
{
    class PlusRemove
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> lines = new List<string>();
            int count = 0;
            int max = 0;
            while (input != "END")
            {
                lines.Add(input);
                if (max < input.Length)
                {
                    max = input.Length;
                }
                count++;
                input = Console.ReadLine();
            }
            string[,] matrix = new string[count, max];
            for (int row = 0; row < count; row++)
            {
                char[] arr = lines[row].ToCharArray();
                for (int col = 0; col < max; col++)
                {
                    if (col < lines[row].Length)
                    {
                        matrix[row, col] = arr[col].ToString();
                    }
                    else
                    {
                        matrix[row, col] = " ";
                    }
                }
            }
            List<int> rememberedRows = new List<int>();
            List<int> rememberedCols = new List<int>();

            RememberingRowsAndCols(count, max, matrix, rememberedRows, rememberedCols);
            RemoveSymbols(count, max, matrix, rememberedRows, rememberedCols);
            Print(count, max, matrix);
        }
        static void Print(int rowEnd, int colEnd, string[,] matrix)
        {
            for (int row = 0; row < rowEnd; row++)
            {
                for (int col = 0; col < colEnd; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
        static void RemoveSymbols(int endRow, int endCol, string[,] matrix, List<int> rememberedRows, List<int> rememberedCols)
        {
            for (int row = 0; row < endRow; row++)
            {
                for (int col = 0; col < endCol; col++)
                {
                    for (int i = 0; i < rememberedRows.Count; i++)
                    {
                        if (row == rememberedRows[i] && col == rememberedCols[i])
                        {
                            matrix[row, col] = "";
                        }
                    }
                }
            }
        }
        static void RememberingRowsAndCols(int endRow, int endCol, string[,] matrix, List<int> rememberedRows, List<int> rememberedCols)
        {
            for (int row = 0; row < endRow - 2; row++)
            {
                for (int col = 1; col < endCol - 1; col++)
                {
                    if (matrix[row, col].ToLower() == matrix[row + 1, col - 1].ToLower() &&
                        matrix[row, col].ToLower() == matrix[row + 1, col + 1].ToLower() &&
                        matrix[row, col].ToLower() == matrix[row + 1, col].ToLower() &&
                        matrix[row, col].ToLower() == matrix[row + 2, col].ToLower())
                    {
                        rememberedRows.Add(row);
                        rememberedCols.Add(col);

                        rememberedRows.Add(row + 1);
                        rememberedCols.Add(col - 1);

                        rememberedRows.Add(row + 1);
                        rememberedCols.Add(col + 1);

                        rememberedRows.Add(row + 1);
                        rememberedCols.Add(col);

                        rememberedRows.Add(row + 2);
                        rememberedCols.Add(col);
                    }
                }
            }
        }
    }
}
