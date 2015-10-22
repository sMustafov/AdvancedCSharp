using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] numbs = input.Split(' ');
            List<int> longestSequence = new List<int>();
            int num = 0;
            int nextNum = 0;
            int count = 0;
            int maxCount = 0;
            int end = 0;

            for (int i = 0; i < numbs.Length; i++)
            {

                if (i < numbs.Length - 1)
                {
                    num = Convert.ToInt32(numbs[i]);
                    nextNum = Convert.ToInt32(numbs[i + 1]);
                    if (num < nextNum)
                    {
                        Console.Write(num + " ");
                        count++;
                        if (maxCount < count)
                        {
                            maxCount = count;
                            end = i;
                        }
                    }
                    else if (num > nextNum)
                    {
                        count++;
                        if (maxCount < count)
                        {
                            maxCount = count;
                            end = i;
                        }
                        Console.Write(num + " ");
                        Console.WriteLine();
                        count = 0;
                    }
                    else
                    {
                        count++;
                        if (maxCount < count)
                        {
                            maxCount = count;
                            end = i;
                        }
                        Console.WriteLine(num);
                        count = 0;
                    }
                }
                else
                {
                    if (num < nextNum)
                    {
                        Console.Write(nextNum + " ");
                        count++;
                        if (maxCount < count)
                        {
                            maxCount = count;
                            end = i;
                        }
                    }
                    else
                    {
                        count = 1;
                        Console.Write(nextNum + " ");
                        count = 0;
                    }
                }
            }
            Console.WriteLine();
            Console.Write("Longest: ");
            for (int j = end - maxCount + 1; j <= end; j++)
            {
                Console.Write(numbs[j] + " ");
            }
            Console.WriteLine();
        }
    }
}
