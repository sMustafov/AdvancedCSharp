using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMatrixRotation
{
    class StringMatrixRotation
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] command = input.Split('(');
            string rotate = command[0];
            int degree = Convert.ToInt32(command[1].Trim(')'));
            if (degree >= 360)
            {
                degree %= 360;
            }
            List<string> almostMatrix = new List<string>();
            int col = 0;
            int row = 0;

            input = Console.ReadLine();
            while (input != "END")
            {
                if (input.Length > col)
                {
                    col = input.Length;
                }
                row++;
                almostMatrix.Add(input);
                input = Console.ReadLine();
            }

            string[,] matrix = new string[row, col];

            for (int i = 0; i < row; i++)
            {
                char[] arr = almostMatrix[i].ToArray();
                for (int j = 0; j < col; j++)
                {
                    if (arr.Length > j)
                    {
                        matrix[i, j] = arr[j].ToString();
                    }
                    else
                    {
                        matrix[i, j] = " ";
                    }
                }
            }

            if (degree == 180)
            {
                for (int i = row - 1; i >= 0; i--)
                {
                    for (int j = col - 1; j >= 0; j--)
                    {
                        Console.Write("{0}", matrix[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            else if (degree == 90)
            {
                for (int i = 0; i < col; i++)
                {
                    for (int j = row - 1; j >= 0; j--)
                    {
                        Console.Write("{0}", matrix[j, i]);
                    }
                    Console.WriteLine();
                }
            }
            else if (degree == 270)
            {
                for (int i = col - 1; i >= 0; i--)
                {
                    for (int j = 0; j < row; j++)
                    {
                        Console.Write("{0}", matrix[j, i]);
                    }
                    Console.WriteLine();
                }
            }
            else if (degree == 0)
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        Console.Write("{0}", matrix[i, j]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
