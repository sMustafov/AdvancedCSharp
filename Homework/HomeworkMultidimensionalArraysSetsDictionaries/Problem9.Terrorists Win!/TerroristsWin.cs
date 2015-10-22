using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerroristsWin
{
    class TerroristsWin
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<int> bombPower = new List<int>();
            List<int> startIndexes = new List<int>();
            List<int> endIndexes = new List<int>();

            int sum = 0;
            int startIndex = 0;
            int endIndex = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '|')
                {
                    startIndex = i;
                    i++;
                    do
                    {
                        sum += input[i];
                        i++;

                    } while (input[i] != '|');
                    endIndex = i;
                    sum %= 10;

                    bombPower.Add(sum);
                    startIndexes.Add(startIndex);
                    endIndexes.Add(endIndex);
                }
                sum = 0;
            }

            for (int i = 0; i < bombPower.Count; i++)
            {
                for (int a = startIndexes[i]; a <= endIndexes[i]; a++)
                {
                    char aa = input[a];
                    input = input.ToString().Remove(a, 1);
                    input = input.ToString().Insert(a, ".");
                }

                int start = startIndexes[i] - bombPower[i];
                int end = endIndexes[i] + bombPower[i];

                if (start < 0)
                {
                    start = 0;
                }
                if (end > input.Length)
                {
                    end = input.Length;
                }
                for (int b = start; b <= startIndexes[i]; b++)
                {
                    input = input.ToString().Remove(b, 1);
                    input = input.ToString().Insert(b, ".");
                }
                for (int c = endIndexes[i]; c <= end; c++)
                {
                    input = input.ToString().Remove(c, 1);
                    input = input.ToString().Insert(c, ".");
                }
            }
            Console.WriteLine(input);
        }
    }
}