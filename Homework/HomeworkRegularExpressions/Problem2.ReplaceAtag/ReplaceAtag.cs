using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReplaceAtag
{
    class ReplaceAtag
    {
        static void Main(string[] args)
        {
            string tag = Console.ReadLine();
            string pattern = @"<a.*href=((?:.|\n)*?(?=>))>((?:.|\n)*?(?=<))<\/a>";
            string patternForReplace = @"[URL href=$1$2[/URL]";
            string output = Regex.Replace(tag,pattern,patternForReplace);
            Console.WriteLine(output);

        }
    }
}
