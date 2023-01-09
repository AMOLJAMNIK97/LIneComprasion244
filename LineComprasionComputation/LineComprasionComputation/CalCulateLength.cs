using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComprasionComputation
{
    public class CalCulateLength
    {
        public void calcalulatelength()
        {
            double x1, x2, y1, y2;
            double len, length;
            double point1, point2;

            Console.WriteLine("Enter value of x1");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value of y1:");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value of x2:");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value of y2");
            y2 = Convert.ToDouble(Console.ReadLine());

            // formula of length = sqrt[(x2 -x1)^2 + (y2-y1)^2]
            point1 = Math.Pow((x2 - x1), 2);
            point2 = Math.Pow((y2 - y1), 2);
            len = point1 + point2;
            length = Math.Sqrt(len);

            Console.WriteLine("The length of line is: " + length);
            Console.ReadLine();

        }
        public void CheckPostionTill100()
        {
            const int NO_PLAY = 1;
            const int LADDER = 2;
            const int SNAKE_BITE = 3;
            int position = 0;

            while (position <= 100)
            {
                Random random = new Random();
                int dice = random.Next(0, 7);
                int checkOption = random.Next(1, 4);
                switch (checkOption)
                {
                    case NO_PLAY:
                        position = 0;
                        break;
                    case LADDER:
                        position = position + dice;
                        break;
                    case SNAKE_BITE:
                        position = position - dice;
                        break;
                    default:
                        position = 0;
                        break;
                }
                if (position < 0)
                {
                    Console.WriteLine("Player restarts from 0");
                }
                else
                {
                    Console.WriteLine("Player stays in same postion");
                }
            }
        }
    }
}
