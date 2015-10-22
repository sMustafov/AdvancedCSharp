using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SemanticHTML
{
    class SemanticHTML
    {
        static void Main(string[] args)
        {
            List<string> finalResults = new List<string>();
            string input = Console.ReadLine();
            while (input != "END")
            {
                string firstPattern = @"(?:id|class)\s{0,}=\s{0,}""(?<res>[^\s]+)""";
                string lastPattern = @"<\/div>\s{0,}?<!--\s{0,}?(\w{0,})\s{0,}?-->";
                string replacePattern = @"</$1>";
                if (input.Contains("<div"))
                {
                    string result = Regex.Match(input, firstPattern).Groups["res"].Value;
                    input = Regex.Replace(input, firstPattern, "");
                    input = Regex.Replace(input, "div", result);
                    input = Regex.Replace(input, @"(?<=<.*)\s+", " ");
                    input = Regex.Replace(input, @"\s{1,}>", ">");
                }
                else if (input.Contains("/div"))
                {

                    input = Regex.Replace(input, lastPattern, replacePattern);
                }
                finalResults.Add(input);
                input = Console.ReadLine();
            }
            finalResults.ToArray();
            Console.WriteLine(string.Join("\r\n", finalResults));
        }
    }
}
