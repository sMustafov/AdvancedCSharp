using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGravity
{
    class TextGravity
    {
        static void Main(string[] args)
        {
            int lineLenght = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            int rows = text.Length / lineLenght;
            char[,] matrix = new char[rows, lineLenght];

            matrix = FillingTheMatrix(rows, lineLenght, text);

            matrix = TextGravity(rows, lineLenght, matrix);

            PrintingMatrix(rows, lineLenght, matrix);
        }

        static void PrintingMatrix(int rows, int lineLenght, char[,] matrix)
        {
            Console.Write("<table>");
            for (int row = 0; row < rows; row++)
            {
                Console.Write("<tr>");
                for (int col = 0; col < lineLenght; col++)
                {
                    Console.Write("<td>" + matrix[row, col] + "</td>");
                }
                Console.WriteLine("</tr>");
            }
            Console.Write("</table>");
        }

        static char[,] FillingTheMatrix(int rows, int lineLenght, string text)
        {
            int i = 0;
            char[,] matrix = new char[rows, lineLenght];
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < lineLenght; col++)
                {
                    if (i >= text.Length)
                    {
                        matrix[row, col] = ' ';
                    }
                    else
                    {
                        matrix[row, col] = text[i];
                    }
                    i++;
                }
            }
            return matrix;
        }

        static char[,] TextGravity(int rows, int lineLenght, char[,] matrix)
        {
            for (int j = 0; j < rows; j++)
            {
                for (int row = rows - 1; row > 0; row--)
                {
                    for (int col = 0; col < lineLenght; col++)
                    {
                        if (matrix[row, col] == ' ')
                        {
                            matrix[row, col] = matrix[row - 1, col];
                            matrix[row - 1, col] = ' ';
                        }
                    }
                }
            }
            return matrix;
        }
    }
}
