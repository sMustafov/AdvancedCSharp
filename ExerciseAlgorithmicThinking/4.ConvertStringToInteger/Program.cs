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
            string number = Console.ReadLine();
            StringBuilder theNum = new StringBuilder();
            if (number.Length == 0)
            {
                Console.WriteLine("FormatException");
            }
            else if (number.Length > 10)
            {
                Console.WriteLine("OverflowException");
            }
            else
            {
                for (int i = 0; i < number.Length; i++)
                {
                    if (number[i] >= 48 && number[i] <= 57)
                    {
                        theNum.Append(number[i]);
                    }
                    else
                    {
                        return;
                    }
                }
                Console.WriteLine(theNum);
            }
        }
    }
}