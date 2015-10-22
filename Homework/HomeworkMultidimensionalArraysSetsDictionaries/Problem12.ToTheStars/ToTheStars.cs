using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToTheStars
{
    class ToTheStars
    {
        static void Main(string[] args)
        {
            string input = null;
            string[] starName = new string[3];
            double[] starX = new double[3];
            double[] starY = new double[3];

            for (int i = 0; i < 3; i++)
            {
                input = Console.ReadLine();
                string[] starInfo = input.Split(' ');
                starName[i] = starInfo[0];
                starX[i] = double.Parse(starInfo[1]);
                starY[i] = double.Parse(starInfo[2]);
            }

            input = Console.ReadLine();
            double[] coordinates = input.Split(' ').Select(double.Parse).ToArray();
            double x = coordinates[0];
            double y = coordinates[1];
            double moves = double.Parse(Console.ReadLine());

            for (double move = y; move <= y + moves; move++)
            {
                if ((starX[0] + 1 >= x && starX[0] - 1 <= x) && (starY[0] + 1 >= move && starY[0] - 1 <= move))
                {
                    Console.WriteLine(starName[0].ToLower());
                }
                else if ((starX[1] + 1 >= x && starX[1] - 1 <= x) && (starY[1] + 1 >= move && starY[1] - 1 <= move))
                {
                    Console.WriteLine(starName[1].ToLower());
                }
                else if ((starX[2] + 1 >= x && starX[2] - 1 <= x) && (starY[2] + 1 >= move && starY[2] - 1 <= move))
                {
                    Console.WriteLine(starName[2].ToLower());
                }
                else
                {
                    Console.WriteLine("space");
                }
            }
        }
    }
}
