using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordCount
{
    internal class WordCount
    {
        private static void Main(string[] args)
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            using (var wordReader = new StreamReader("../../words.txt"))
            {
                using (var textReader = new StreamReader("../../text.txt"))
                {
                    string word = wordReader.ReadLine();
                    string text = textReader.ReadToEnd();
                    int i = 1;
                    while (word != null)
                    {
                        while (word != null)
                        {
                            string pattern = @"[\-|\,|\.|\?|\!]";
                            text = Regex.Replace(text, pattern, String.Empty);
                            text = text.ToLower();
                            string[] textt = text.Split(' ');

                            for (int j = 0; j < textt.Length; j++)
                            {
                                if (textt[j] == word)
                                {
                                    i++;
                                }
                            }
                            wordCount[word] = i;
                            word = wordReader.ReadLine();
                            i = 1;
                            textReader.BaseStream.Seek(0, SeekOrigin.Begin);
                            text = textReader.ReadToEnd();
                        }
                    }
                    using (var writer = new StreamWriter("../../results.txt"))
                    {
                        foreach (var item in wordCount.OrderByDescending(key => key.Value))
                        {
                            string line = item.Key.ToString() + "-" + item.Value.ToString();
                            writer.WriteLine(line);
                        }
                    }
                }
            }
        }
    }
}