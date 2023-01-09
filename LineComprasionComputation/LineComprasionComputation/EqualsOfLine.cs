using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComprasionComputation
{
    public class EqualsOfLine
    {
        public void EqualsLine()
        {
            Console.WriteLine("Enter start and end point of 1st st line");
            double x1 = Convert.ToInt32(Console.ReadLine());
            double y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter start and end point of 2nd st line");
            double x2 = Convert.ToInt32(Console.ReadLine());
            double y2 = Convert.ToInt32(Console.ReadLine());

            double length1, length2;
            if (x1 == x2)//start point equal
            {
                Console.WriteLine("Both Lines are Equal - " + y1.Equals(y2));//check end points are equal
            }
            else
            {
                length1 = x1 - x2;
                length2 = y1 - y2;
                Console.WriteLine("Both Lines are Equal - " + length1.Equals(length2));
                Console.ReadLine();
            }
        }
    }
}
