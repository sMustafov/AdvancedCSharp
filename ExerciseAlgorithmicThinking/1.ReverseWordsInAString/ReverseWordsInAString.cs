using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ReverseWordsInAString
{
    class ReverseWordsInAString
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = input.ToLower();
            string [] words = input.Split(' ');
            StringBuilder helper = new StringBuilder();
            for (int i = words.Length - 1; i >= 0; i--)
            {
                if (i == words.Length - 1)
                {
                    char[] arr = words[i].ToCharArray();
                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (j == 0)
                        {
                            if (arr[j] >= 'a' && arr[j] <= 'z')
                            {
                                arr[j] = (char) (arr[j] - 32);
                            }
                        }
                        helper.Append(arr[j]);
                    }
                    input = helper.ToString();
                    Console.Write(input + " ");
                }
                else
                {
                    Console.Write(words[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
 