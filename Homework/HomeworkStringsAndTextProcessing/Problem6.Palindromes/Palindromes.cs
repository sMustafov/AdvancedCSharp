using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] words = input.Split(new char[] { ' ', ',', '.', '!', '?' });
            List<string> palindromes = new List<string>();
            int count = 0;
            bool havePalindromes = false;
            for (int i = 0; i < words.Length; i++)
            {
                count = 0;
                char[] array = words[i].ToArray();
                for (int j = 0, k = array.Length - 1; j < array.Length / 2; j++, k--)
                {
                    if (array[j] == array[k])
                    {
                        count++;
                    }
                }
                if (count == words[i].Length / 2 && words[i] != "")
                {
                    palindromes.Add(words[i]);
                    havePalindromes = true;
                }
            }
            palindromes.Sort();
            if (havePalindromes)
            {
                for (int i = 0; i < palindromes.Count; i++)
                {
                    Console.Write("{0}, ", palindromes[i]);
                }
                Console.WriteLine("\b\b ");
            }
        }
    }
}