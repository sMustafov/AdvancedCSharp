using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractHyperlinks
{
    class ExtractHyperlinks
    {
        static void Main(string[] args)
        {
            List<string> finalResult = new List<string>();
            string text = Console.ReadLine();
            while (text != "END")
            {
                string pattern = @"((<a)([\w|\s|\\|\=|\"" |\(|\/|\)|\'])+((href=)|(href =)))+(\s{0,})+([\""|\s{0,}|\'|\/])+([\s{0,}|\w|\:|\\|\/\.\,\#|\(|\)\'])+([\""|\'|\s{0,}|\>])";
                Regex regex = new Regex(pattern);
                MatchCollection matches = regex.Matches(text);
                foreach (Match match in matches)
                {
                    string textTwo = match.ToString();
                    string patternTwo = @"((?<=href=)|(?<=href =)|(?<=href= ))([\w|\s|\""|\'\/\:\.\#])+";
                    Regex regexTwo = new Regex(patternTwo);
                    MatchCollection matchesTwo = regexTwo.Matches(textTwo);
                    {
                        foreach (Match finalMatch in matchesTwo)
                        {
                            string repl = finalMatch.ToString();
                            string replPattern = @"[\""\'\s{0,}]+";
                            string fin = Regex.Replace(repl, replPattern, "");
                            finalResult.Add(fin);
                        }
                    }
                }
                text = Console.ReadLine();
            }
            finalResult.ToArray();
            Console.WriteLine(string.Join("\r\n", finalResult));
        }
    }
}
