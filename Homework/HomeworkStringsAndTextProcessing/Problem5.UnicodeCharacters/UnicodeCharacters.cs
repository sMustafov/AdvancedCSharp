using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++)
            {
                Console.Write("\\u" + (((int)word[i]).ToString("X4")));
            }
            Console.WriteLine();
        }
    }
}