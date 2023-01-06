using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComprasionComputation
{

    class Program
    {
 
        static void Main(string[] args)
        {
             
            Console.WriteLine("Welcome to Line Comparison Computation");
            Console.WriteLine("Choose option\n 1.Calculate Length\n2.Check Two Line Equal\n3.Compare Two Line");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    CalCulateLength CalCulate = new CalCulateLength();
                    CalCulate.calcalulatelength();
                    break;
                case 2:
                    CheckLength EqualTwoLine = new CheckLength();
                    EqualTwoLine.LengthOfLine1();
                    break;
                case 3:
                    CompareTwoLine compare = new CompareTwoLine();
                    compare.CheckBothLine();
                    break;
                default:
                    Console.WriteLine("Wrong choice");
                    break;
            }
        }
    }
}