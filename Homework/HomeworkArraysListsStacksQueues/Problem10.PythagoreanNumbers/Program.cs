using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            bool hasPNumbs = false;
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int f = 0; f < n; f++)
            {
                for (int s = 0; s < n; s++)
                {
                    for (int res = 0; res < n; res++)
                    {
                        if (arr[f] * arr[f] + arr[s] * arr[s] == arr[res] * arr[res] && arr[f] <= arr[s] && arr[f] <= arr[res] && arr[s] <= arr[res])
                        {
                            Console.WriteLine("{0}*{0} + {1}*{1} = {2}*{2}", arr[f], arr[s], arr[res]);
                            hasPNumbs = true;
                        }
                    }
                }
            }
            if (!hasPNumbs)
            {
                Console.WriteLine("No");
            }
        }
    }
}
