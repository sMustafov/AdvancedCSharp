using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSubstringOccurrences
{
    class CountSubstringOccurrences
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string searchedWord = Console.ReadLine();
            string substring = null;
            int count = 0;
            for (int i = 0; i < text.Length - searchedWord.Length + 1; i++)
            {
                substring = text.Substring(i, searchedWord.Length).ToLower();
                if (substring == searchedWord)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
