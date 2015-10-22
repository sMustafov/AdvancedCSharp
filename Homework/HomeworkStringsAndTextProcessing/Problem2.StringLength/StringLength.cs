using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLength
{
    class StringLength
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input.Length > 20)
            {
                for (int i = 0; i < 20; i++)
                {
                    Console.Write(input[i]);
                }
            }
            else if (input.Length <= 20)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    Console.Write(input[j]);
                }
                for (int j = input.Length; j < 20; j++)
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
        }
    }
}
