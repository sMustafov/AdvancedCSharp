using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidUsername
{
    class ValidUsername
    {
        static void Main(string[] args)
        {
            string usernames = Console.ReadLine();
            string pattern = @"(?<=\s|\\|\/|^|\(|\))\b[a-zA-Z]\w{2,24}\b";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(usernames);
            int sumOfMatches = 0;
            int maxSumOfMatches = 0;
            int index = 0;
            for (int i = 0; i < matches.Count - 1; i++ )
            {
                sumOfMatches = matches[i].Length + matches[i + 1].Length;
                if (maxSumOfMatches < sumOfMatches)
                {
                    maxSumOfMatches = sumOfMatches;
                    index = i;
                }
            }
            for (int j = index; j < index + 2; j++)
            {
                Console.WriteLine(matches[j].Value);
            }
        }
    }
}
