using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Line Comparison Computation");
            //For X co-ordinates,
            Console.WriteLine("Provide X coordinates of the line");
            Console.WriteLine(" X2");
            double X2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" X1");
            double X1 = Convert.ToDouble(Console.ReadLine());
            //For Y co-ordinates,
            Console.WriteLine("Provide Y coordinates of the line");
            Console.WriteLine(" Y2");
            double Y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Y1");
            double Y1 = Convert.ToDouble(Console.ReadLine());
            //Calculation,
            double result1 = Math.Pow(X2 - X1, 2);
            double result2 = Math.Pow(Y2 - Y1, 2);
            double length1 = Math.Sqrt(result1 + result2);
            //Final result,
            Console.WriteLine("length of line: " + length1);
        }
             
    }    

}
