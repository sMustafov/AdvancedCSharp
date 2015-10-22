using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixShuffling
{
    class MatrixShuffling
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            string[,] matrix = new string[n, m];
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = Console.ReadLine();
                }
            }
            string input = Console.ReadLine();
            string[] command = input.Split(' ');
            while (input != "END")
            {
                if (command[0] != "swap")
                {
                    Console.WriteLine("Invalid input!");
                }
                else if (command.Length < 5)
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    int rowFirstNum = Convert.ToInt32(command[1]);
                    int colFirstNum = Convert.ToInt32(command[2]);
                    int rowSecondNum = Convert.ToInt32(command[3]);
                    int colSecondNum = Convert.ToInt32(command[4]);
                    if ((rowFirstNum < n && colFirstNum < m) && (rowSecondNum < n && colSecondNum < m))
                    {
                        string tmp = matrix[rowFirstNum, colFirstNum];
                        matrix[rowFirstNum, colFirstNum] = matrix[rowSecondNum, colSecondNum];
                        matrix[rowSecondNum, colSecondNum] = tmp;
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < m; j++)
                            {
                                Console.Write(matrix[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                input = Console.ReadLine();
                command = input.Split(' ');
            }
        }
    }
}
