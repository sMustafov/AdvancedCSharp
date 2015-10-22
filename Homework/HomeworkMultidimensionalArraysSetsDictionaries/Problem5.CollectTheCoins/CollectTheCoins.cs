using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectTheCoins
{
    class CollectTheCoins
    {
        static void Main(string[] args)
        {
            string[][] jaggedMatrix = new string[4][];
            int[] columnsArr = new int[4];
            for (int roww = 0; roww < 4; roww++)
            {
                string input = Console.ReadLine();
                string[] inputt = new string[input.Length];
                jaggedMatrix[roww] = new string[input.Length];
                columnsArr[roww] = input.Length;
                for (int coll = 0; coll < input.Length; coll++)
                {
                    jaggedMatrix[roww][coll] = Convert.ToString(input[coll]);
                }
            }

            string command = Console.ReadLine();
            int row = 0;
            int col = 0;
            int coinCounter = 0;
            int wallHitsCounter = 0;
            for (int i = 0; i < command.Length; i++)
            {
                if (jaggedMatrix[0][0] == "$")
                {
                    coinCounter++;
                }
                if (command[i] == 'V')
                {
                    row++;
                    if (columnsArr[row] < col)
                    {
                        wallHitsCounter++;
                        row--;
                    }
                    else if (jaggedMatrix[row][col] == "$")
                    {
                        coinCounter++;
                    }
                }
                else if (command[i] == '^')
                {
                    row--;
                    if (row < 0)
                    {
                        wallHitsCounter++;
                        row++;
                    }
                    else if (jaggedMatrix[row][col] == "$")
                    {
                        coinCounter++;
                    }
                }
                else if (command[i] == '>')
                {
                    col++;
                    if (col > columnsArr[row])
                    {
                        wallHitsCounter++;
                        col--;
                    }
                    if (jaggedMatrix[row][col] == "$")
                    {
                        coinCounter++;
                    }
                }
                else if (command[i] == '<')
                {
                    col--;
                    if (col < 0)
                    {
                        wallHitsCounter++;
                        col++;
                    }
                    if (jaggedMatrix[row][col] == "$")
                    {
                        coinCounter++;
                    }
                }
            }
            Console.WriteLine("Coins collected: {0}", coinCounter);
            Console.WriteLine("Walls hit: {0}", wallHitsCounter);
        }
    }
}

