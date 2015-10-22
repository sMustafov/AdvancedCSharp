using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SeriesOfLetters
{
    class SeriesOfLetters
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string patter = "(\\w)\\1*";
            Regex regex = new Regex(patter);
            MatchCollection matches = regex.Matches(word);

            foreach (Match match in matches)
            {
                Console.Write(match.Value[0] + "");
            }
            Console.WriteLine();
        }
    }
}