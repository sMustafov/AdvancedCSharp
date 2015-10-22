using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace officeStuff
{
    class officeStuff
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, SortedDictionary<string, HashSet<int>>> officeStaff =
                new SortedDictionary<string, SortedDictionary<string, HashSet<int>>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string pattern = @"[\|]";
                string patternTwo = @"\s*";
                input = Regex.Replace(input, pattern, "");
                input = Regex.Replace(input, patternTwo, "");
                string[] line = input.Split('-');
                string company = line[0];
                int amount = int.Parse(line[1]);
                string product = line[2];
                if (!officeStaff.ContainsKey(company))
                {
                    officeStaff[company] = new SortedDictionary<string, HashSet<int>>();
                }
                if (!officeStaff[company].ContainsKey(product))
                {
                    officeStaff[company][product] = new HashSet<int>();
                }
                officeStaff[company][product].Add(amount);
            }
            int sum = 0;
            foreach (var company in officeStaff)
            {
                Console.Write("{0}: ", company.Key);
                foreach (var product in company.Value)
                {
                    Console.Write("{0}", product.Key);
                    foreach (var amonth in product.Value)
                    {
                        sum += amonth;
                    }
                    Console.Write("-{0}, ", sum);
                    sum = 0;
                }
                Console.WriteLine("\b\b ");
            }
        }
    }
}