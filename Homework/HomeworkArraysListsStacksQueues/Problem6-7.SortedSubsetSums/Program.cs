using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int[] arr = input.Split(' ').Select(int.Parse).ToArray();
            arr = arr.Distinct().ToArray();
            int subsets = 1 << arr.Length;

            List<int> array = new List<int>();
            List<List<int>> sums = new List<List<int>>();

            bool subsetss = false;

            for (int i = 1; i < subsets; i++)
            {
                int sum = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    int mask = i & (1 << j);

                    if (mask != 0)
                    {
                        sum += arr[arr.Length - j - 1];
                        array.Add(arr[arr.Length - j - 1]);
                    }
                }
                if (sum == n)
                {
                    sums.Add(array);
                    subsetss = true;
                }
                array = new List<int>();
            }
            if (!subsetss)
            {
                Console.WriteLine("No matching subsets!");
            }
            else
            {
                List<List<int>> final = new List<List<int>>(sums.OrderBy(x => x.Count));
                foreach (var item in final)
                {
                    item.Sort();
                }

                for (int i = 0; i < final.Count - 1; i++)
                {
                    int first = final[i].First();
                    for (int j = i + 1; j < final.Count; j++)
                    {
                        int second = final[j].First();
                        if (final[i].Count == final[j].Count && first > second)
                        {
                            List<int> temp = final[i];
                            final[i] = final[j];
                            final[j] = temp;
                        }
                    }
                }
                foreach (var item in final)
                {
                    PrintSums(item, n);
                }
            }
        }
        static void PrintSums(List<int> nums, int sum)
        {

            foreach (var item in nums)
            {
                Console.Write(item + " + ");
            }
            Console.WriteLine("\b\b\b = " + sum);
        }
    }
}
