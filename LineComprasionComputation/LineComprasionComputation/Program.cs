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
            CalCulateLength CalCulate = new CalCulateLength(); 
            Console.WriteLine("Welcome to Line Comparison Computation");
            Console.WriteLine("Choose option\n 1.Calculate Length");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    CalCulate.calcalulatelength();
                    break;
                default:
                    Console.WriteLine("Wrong choice");
                    break;
            }
        }
    }
}