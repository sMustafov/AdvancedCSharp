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

            string input = Console.ReadLine();
            string[] nums = input.Split(' ');
            int[] numbs = new int[n];
            List<string> array = new List<string>();
            bool stuckNums = false;

            string strOne = null;
            string revStrOne = null;
            string strTwo = null;
            string revStrTwo = null;
            for (int a = 0; a < nums.Length; a++)
            {
                for (int b = 0; b < nums.Length; b++)
                {
                    strOne = nums[a] + nums[b];
                    revStrOne = nums[b] + nums[a];
                    for (int c = 0; c < nums.Length; c++)
                    {
                        for (int d = 0; d < nums.Length; d++)
                        {
                            if (c != a && c != b && c != d && d != a && d != b && a != b)
                            {
                                strTwo = nums[c] + nums[d];
                                revStrTwo = nums[d] + nums[c];
                                if (strOne == strTwo)
                                {
                                    string res = nums[a] + "|" + nums[b] + "==" + nums[c] + "|" + nums[d];
                                    array.Add(res);
                                    stuckNums = true;
                                }
                                else if (strOne == revStrTwo)
                                {
                                    string res = nums[a] + "|" + nums[b] + "==" + nums[d] + "|" + nums[c];
                                    array.Add(res);
                                    stuckNums = true;
                                }
                                else if (revStrOne == strTwo)
                                {
                                    string res = nums[b] + "|" + nums[a] + "==" + nums[c] + "|" + nums[d];
                                    array.Add(res);
                                    stuckNums = true;
                                }
                                else if (revStrOne == revStrTwo)
                                {
                                    string res = nums[b] + "|" + nums[a] + "==" + nums[d] + "|" + nums[c];
                                    array.Add(res);
                                    stuckNums = true;
                                }


                                if (strTwo == strOne)
                                {
                                    string res = nums[c] + "|" + nums[d] + "==" + nums[a] + "|" + nums[b];
                                    array.Add(res);
                                    stuckNums = true;
                                }
                                if (revStrTwo == strOne)
                                {
                                    string res = nums[d] + "|" + nums[c] + "==" + nums[a] + "|" + nums[b];
                                    array.Add(res);
                                    stuckNums = true;
                                }
                                if (strTwo == revStrOne)
                                {
                                    string res = nums[c] + "|" + nums[d] + "==" + nums[b] + "|" + nums[a];
                                    array.Add(res);
                                    stuckNums = true;
                                }
                                if (revStrTwo == revStrOne)
                                {
                                    string res = nums[d] + "|" + nums[c] + "==" + nums[b] + "|" + nums[a];
                                    array.Add(res);
                                    stuckNums = true;
                                }
                            }
                        }
                    }
                }
            }
            if (stuckNums)
            {
                List<string> arr = array.Distinct().ToList();
                for (int h = 0; h < arr.Count; h++)
                {
                    Console.WriteLine(arr[h]);
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
