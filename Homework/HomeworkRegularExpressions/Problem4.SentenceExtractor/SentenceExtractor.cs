using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SentenceExtractor
{
    class SentenceExtractor
    {
        static void Main(string[] args)
        {
            string searchedWord = Console.ReadLine();
            string text = Console.ReadLine();
            string pattern = String.Format(@"(?<=\s|^)[^!.?]*\b{0}\b[^!.?]*[!.?]",searchedWord);
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);
            foreach(Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
