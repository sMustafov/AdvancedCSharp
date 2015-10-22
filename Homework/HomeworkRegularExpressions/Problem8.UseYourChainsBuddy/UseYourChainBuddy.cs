using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UseYourChainBuddy
{
    class UseYourChainBuddy
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"([\<\w\>\/][\/\w][\w\>\<]\w{0,}[\>])|([\<]\w{1}[\>])|([\w][\>])|([\w\s\,]*[\!][\<])|((?<=\>)[\w]+[\<])";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);
            foreach (Match match in matches)
            {
                string matchh = match.ToString();
                text = text.Replace(matchh, "");
            }
            text = text.ToLower();
            StringBuilder textt = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= 'n' && text[i] <= 'z')
                {
                    char a = (char)(text[i] - 13);
                    textt.Append(a);
                }
                else if (text[i] >= 'a' && text[i] <= 'm')
                {
                    char a = (char)(text[i] + 13);
                    textt.Append(a);
                }
                else if (text[i] >= '0' && text[i] <= '9')
                {
                    textt.Append(text[i]);
                }
                else
                {
                    textt.Append(" ");
                }
            }
            string final = textt.ToString();
            string repl = @"\s{1,}";
            Regex replReg = new Regex(repl);
            MatchCollection replMatch = replReg.Matches(final);
            final = Regex.Replace(final, repl, " ");
            Console.WriteLine(final);
        }
    }
}