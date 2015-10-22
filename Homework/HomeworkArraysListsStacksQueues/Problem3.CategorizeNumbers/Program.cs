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
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');

            List<int> ints = new List<int>();
            List<double> doubles = new List<double>();

            for (int i = 0; i < numbers.Length; i++)
            {
                double num = Convert.ToDouble(numbers[i]);
                if (num % 1 != 0)
                {
                    doubles.Add(num);
                }
                else
                {
                    int numm = Convert.ToInt32(num);
                    ints.Add(numm);
                }
            }
            double dSum = 0.0;

            for (int a = 0; a < doubles.Count; a++)
            {
                dSum += doubles[a];
            }
            Console.Write("[");
            Console.Write(string.Join(", ", doubles));
            Console.WriteLine("]");
            Console.WriteLine("Sum: {0}", dSum);
            Console.WriteLine("Avg: {0:0.00}", dSum / doubles.Count);
            Console.WriteLine("Min: {0}", doubles.Min());
            Console.WriteLine("Max: {0}", doubles.Max());

            int sum = 0;
            Console.WriteLine();
            for (int a = 0; a < ints.Count; a++)
            {
                sum += ints[a];
            }
            Console.Write("[");
            Console.Write(string.Join(", ", ints));
            Console.WriteLine("]");
            Console.WriteLine("Sum: {0}", sum);
            Console.WriteLine("Avg: {0:0.00}", sum / ints.Count);
            Console.WriteLine("Min: {0}", ints.Min());
            Console.WriteLine("Max: {0}", ints.Max());
        }
    }
}