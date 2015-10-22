using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightLife
{
    class NightLife
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] word = null;
            string city = null;
            string place = null;
            string name = null;

            Dictionary<string, SortedDictionary<string, SortedSet<string>>> cityPlaceName =
                new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();

            while (input != "END")
            {
                word = input.Split(';');
                city = word[0];
                place = word[1];
                name = word[2];

                if (!cityPlaceName.ContainsKey(city))
                {
                    cityPlaceName[city] = new SortedDictionary<string, SortedSet<string>>();

                }
                if (!cityPlaceName[city].ContainsKey(place))
                {
                    cityPlaceName[city][place] = new SortedSet<string>();
                }
                cityPlaceName[city][place].Add(name);
                input = Console.ReadLine();
            }

            foreach (var cityy in cityPlaceName)
            {
                Console.WriteLine(cityy.Key);
                foreach (var placee in cityy.Value)
                {
                    Console.Write("->{0}: ", placee.Key);
                    foreach (var namee in placee.Value)
                    {
                        Console.Write(namee + ", ");
                    }
                    Console.WriteLine("\b\b ");
                }
            }
        }
    }
}