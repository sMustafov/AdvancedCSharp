using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QueryMess
{
    class QueryMess
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> QueryMess = new Dictionary<string, List<string>>();

            string text = Console.ReadLine();
            string pattern = @"([^=&]+)=([^&=]+)";
            Regex regex = new Regex(pattern);
            MatchCollection matches;

            while (text != "END")
            {
                text = text.Replace("%20", " ").Replace("+", " ").Replace("?", "&");
                matches = regex.Matches(text);

                foreach (Match match in matches)
                {
                    string key = match.Groups[1].ToString().Trim();
                    string values = match.Groups[2].ToString().Trim();

                    if (!QueryMess.ContainsKey(key))
                    {
                        QueryMess.Add(key, new List<string>());
                    }

                    QueryMess[key].Add(values);
                }

                text = Console.ReadLine();
            }

            foreach (string key in QueryMess.Keys)
            {
                Console.Write("{0}=[{1}]\n", key, string.Join(", ", QueryMess[key]));
            }
            Console.WriteLine();
        }
    }
}
