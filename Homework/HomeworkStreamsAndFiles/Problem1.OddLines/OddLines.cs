using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddLines
{
    internal class OddLines
    {
        private static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../text.txt");
            using (reader)
            {
                string text = reader.ReadLine();
                int countLines = 0;
                while (text != null)
                {
                    if (countLines % 2 != 0)
                    {
                        Console.WriteLine(text);
                    }
                    countLines++;
                    text = reader.ReadLine();
                }
            }
        }
    }
}
