using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersChangeNumbers
{
    class LettersChangeNumbers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] words = words = input.Split(new char[0], StringSplitOptions.RemoveEmptyEntries); ;
            char firstLetter = ' ';
            char secondLetter = ' ';
            double num = 0;
            double sum = 0;
            double allSum = 0;

            for (int i = 0; i < words.Length; i++)
            {
                firstLetter = char.Parse(words[i].ToString().Substring(0, 1));
                secondLetter = char.Parse(words[i].ToString().Substring(words[i].Length - 1, 1));
                num = double.Parse(words[i].ToString().Substring(1, words[i].Length - 2));

                sum = 0;
                if (firstLetter >= 'A' && firstLetter <= 'Z')
                {
                    num /= firstLetter - '@';
                    if (secondLetter >= 'a' && secondLetter <= 'z')
                    {
                        num += secondLetter - '`';
                    }
                    else if (secondLetter >= 'A' && secondLetter <= 'Z')
                    {
                        num -= secondLetter - '@';
                    }
                    sum += num;
                }
                else if (firstLetter >= 'a' && firstLetter <= 'z')
                {
                    num *= firstLetter - '`';
                    if (secondLetter >= 'a' && secondLetter <= 'z')
                    {
                        num += secondLetter - '`';
                    }
                    else if (secondLetter >= 'A' && secondLetter <= 'Z')
                    {
                        num -= secondLetter - '@';
                    }
                    sum += num;
                }

                allSum += sum;
            }

            Console.WriteLine("{0:0.00}", allSum);
        }
    }
}