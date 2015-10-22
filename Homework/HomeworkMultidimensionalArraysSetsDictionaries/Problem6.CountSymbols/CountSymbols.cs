using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSymbols
{
    class CountSymbols
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] lettersAscii = new int[input.Length];
            Dictionary<int, int> letters = new Dictionary<int, int>();

            for (int i = 0; i < input.Length; i++)
            {
                lettersAscii[i] = (int)input[i];
            }

            SortByAsciiCode(lettersAscii);

            CountingEqualSymbols(lettersAscii, letters);

            foreach (var element in letters)
            {
                Console.WriteLine("{0}: {1} time/s", (char)element.Key, element.Value);
            }
        }

        static int[] SortByAsciiCode(int[] lettersAscii)
        {
            int firstLetter = 0;
            int secondLetter = 0;
            for (int i = 0; i < lettersAscii.Length; i++)
            {
                firstLetter = lettersAscii[i];
                for (int j = i + 1; j < lettersAscii.Length; j++)
                {
                    secondLetter = lettersAscii[j];
                    if (lettersAscii[i] > lettersAscii[j])
                    {
                        int tmp = lettersAscii[i];
                        lettersAscii[i] = lettersAscii[j];
                        lettersAscii[j] = tmp;
                    }
                }
            }
            return lettersAscii;
        }
        static Dictionary<int, int> CountingEqualSymbols(int[] lettersAscii, Dictionary<int, int> letters)
        {
            int count = 1;

            for (int i = 0; i < lettersAscii.Length; i++)
            {
                for (int j = i + 1; j < lettersAscii.Length; j++)
                {
                    if (lettersAscii[i] == lettersAscii[j])
                    {
                        count++;
                        i++;
                    }
                }
                if (i < lettersAscii.Length)
                {
                    letters[lettersAscii[i]] = count;
                    count = 1;
                }
            }
            return letters;
        }
    }
}