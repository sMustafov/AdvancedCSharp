using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineNumbers
{
    internal class LineNumbers
    {
        private static void Main(string[] args)
        {
            using (var reader = new StreamReader("../../textForSecondEx.txt"))
            {
                using (var writer = new StreamWriter("../../newText.txt"))
                {
                    string text = reader.ReadLine();
                    int i = 1;
                    while (text != null)
                    {
                        writer.WriteLine("The Number Of Line is {0} ---> {1}", i, text);
                        text = reader.ReadLine();
                        i++;
                    }
                }
            }
        }
    }
}
