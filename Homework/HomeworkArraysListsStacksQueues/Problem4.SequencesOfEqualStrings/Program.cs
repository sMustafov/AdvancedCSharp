using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] text = input.Split(' ');
            if (text.Length < 2)
            {
                Console.WriteLine(text[0]);
            }
            else
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (i < text.Length - 1)
                    {
                        if (text[i] == text[i + 1])
                        {
                            Console.Write(text[i] + " ");
                        }
                        else if (text[i] != text[i + 1])
                        {
                            Console.Write(text[i] + " ");
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        if (text[i - 1] == text[i])
                        {
                            Console.Write(text[i]);
                        }
                        else if (text[i - 1] != text[i])
                        {
                            Console.WriteLine(text[i]);
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
