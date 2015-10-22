using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilter
{
    class TextFilter
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] searchedWords = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            input = Console.ReadLine();
            string[] text = input.Split(new char[] { ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            string newText = null;
            
            for (int i = 0; i < searchedWords.Length; i++)
            {
                string stars = new string('*', searchedWords[i].Length);
                input = input.Replace(searchedWords[i], stars);
            }
            Console.WriteLine(input);
        }
    }
}