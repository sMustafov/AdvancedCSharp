using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.CountConsecutiveDigits
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            int counter = 1;
            if (numbers.Length == 1)
            {
                Console.Write("{0}{1}", counter, numbers[0]);
            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (i < numbers.Length - 1)
                    {
                        if (numbers[i] == numbers[i + 1])
                        {
                            counter++;
                        }
                        else
                        {
                            Console.Write("{0}{1}", counter, numbers[i]);
                            counter = 1;
                        }
                    }
                    else if (i == numbers.Length - 1)
                    {
                        if (numbers[i - 1] == numbers[i])
                        {
                            Console.Write("{0}{1}", counter, numbers[i]);
                        }
                        else
                        {
                            Console.Write("{0}{1}", counter, numbers[i]);
                            counter = 1;
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}