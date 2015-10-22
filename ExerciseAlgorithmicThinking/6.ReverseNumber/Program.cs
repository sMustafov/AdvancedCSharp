using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int remNum = num;
            int length = num.ToString().Length;
            int pow = (int)Math.Pow(10, length);
            for (int i = 10; i <= pow; i *= 10)
            {
                num %= i;
                num /= i/10;
                Console.Write(num);
                num = remNum;
            }
            Console.WriteLine();
        }
    }
}
