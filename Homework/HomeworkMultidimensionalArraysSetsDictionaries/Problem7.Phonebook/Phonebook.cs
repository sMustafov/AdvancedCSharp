using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> phonebook = new Dictionary<string, List<string>>();
            List<string> numbers = new List<string>();
            string name = null;
            string telephone = null;
            while (input != "search")
            {

                string[] nameAndTel = input.Split('-');
                name = nameAndTel[0];
                telephone = nameAndTel[1];
                if (!phonebook.TryGetValue(name, out numbers))
                {
                    numbers = new List<string>();
                    numbers.Add(telephone);
                    phonebook[name] = numbers;
                }
                else
                {
                    numbers.Add(telephone);
                    phonebook[name] = numbers;
                }
                input = Console.ReadLine();
            }
            if (input == "search")
            {
                input = Console.ReadLine();
                while (input != "")
                {
                    if (phonebook.ContainsKey(input))
                    {
                        Console.Write("{0} -> ", input);
                        for (int i = 0; i < phonebook[input].Count; i++)
                        {
                            Console.Write("{0}; ", phonebook[input][i]);
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist", input);
                    }
                    input = Console.ReadLine();
                }
            }
        }
    }
}