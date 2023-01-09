using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComprasionComputation
{
    public class CompareMethod
    {
        public void CompareLine()
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
                double compare = y1.CompareTo(y2);
                if (compare == 0)
                {
                    Console.WriteLine("Both Lines are Equals");
                }
                else if (compare >= 0)
                {
                    Console.WriteLine("2nd line is smaller than 1 st");
                }
                else
                {
                    Console.WriteLine("1st line is smaller than 2nd");
                }
            }
            else
            {
                length1 = x1 - x2;
                length2 = y1 - y2;
                double compare = length1.CompareTo(length2);
                if (compare == 0)
                {
                    Console.WriteLine("Both Lines are Equals");
                }
                else if (compare >= 0)
                {
                    Console.WriteLine("2nd line is smaller than 1 st");
                }
                else
                {
                    Console.WriteLine("1st line is smaller than 2nd");
                }
            }
        }
    }
}
