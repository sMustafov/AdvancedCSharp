using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityTracker
{
    class ActivityTracker
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = null;
            string[] line = null;
            DateTime date;
            string user = null;
            float distance = 0f;

            Dictionary<int, SortedDictionary<string, HashSet<float>>> dateUserDistance =
                new Dictionary<int, SortedDictionary<string, HashSet<float>>>();

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                line = input.Split(' ');
                date = DateTime.Parse(line[0]);
                int month = date.Month;
                user = line[1];
                distance = float.Parse(line[2]);

                if (!dateUserDistance.ContainsKey(month))
                {
                    dateUserDistance[month] = new SortedDictionary<string, HashSet<float>>();

                }
                if (!dateUserDistance[month].ContainsKey(user))
                {
                    dateUserDistance[month][user] = new HashSet<float>();
                }
                dateUserDistance[month][user].Add(distance);
            }
            float sum = 0;
            foreach (var datee in dateUserDistance)
            {
                Console.Write("{0}: ", datee.Key);
                foreach (var userr in datee.Value)
                {
                    Console.Write("{0}", userr.Key);
                    foreach (var distancee in userr.Value)
                    {

                        sum += distancee;
                    }
                    Console.Write("({0}), ", sum);
                    sum = 0;
                }
                Console.WriteLine("\b\b ");
            }
        }
    }
}

