using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LittleJohn
{
    class LittleJohn
    {
        static void Main(string[] args)
        {
            int small = 0;
            int medium = 0;
            int large = 0;
            string pattern = @"(>>>----->>)|(>>----->)|(>----->)";
            Regex regex = new Regex(pattern);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {
                sb.AppendFormat(" {0}", Console.ReadLine());
            }
            var matches = regex.Matches(sb.ToString());

            foreach (Match match in matches)
            {
                if (!string.IsNullOrEmpty(match.Groups[1].Value))
                {
                    large++;
                }
                else if (!string.IsNullOrEmpty(match.Groups[2].Value))
                {
                    medium++;
                }
                else
                {
                    small++;
                }
            }

            string numberAsString = String.Format("{0}{1}{2}", small, medium, large);

            int decNumb = int.Parse(numberAsString);

            string binNumber = Convert.ToString(decNumb, 2);
            string reversedBin = new string(binNumber.Reverse().ToArray());
            string totalBin = binNumber + reversedBin;

            int result = Convert.ToInt32(totalBin, 2);

            Console.WriteLine(result);
        }
    }
}

