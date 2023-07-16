using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Line Comparison Computation");

            //LINE ONE co-ordinates are X1,X2,Y1,Y2
            //For X co-ordinates,
            Console.WriteLine(" Provide X coordinates of the Line1");
            Console.WriteLine(" X2");
            double X2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" X1");
            double X1 = Convert.ToDouble(Console.ReadLine());
            //For Y co-ordinates,
            Console.WriteLine("Provide Y coordinates of the Line1");
            Console.WriteLine(" Y2");
            double Y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Y1");
            double Y1 = Convert.ToDouble(Console.ReadLine());
            //Calculation,
            double result1 = Math.Pow(X2 - X1, 2);
            double result2 = Math.Pow(Y2 - Y1, 2);
            double length1 = Math.Sqrt(result1 + result2);
            //Final result,
            Console.WriteLine("length of Line1: " + length1);


            //LINE TWO co-ordinates are x1,x2,y1,y2
            //For x co-ordinates,
            Console.WriteLine(" Provide x coordinates of the Line2");
            Console.WriteLine(" x2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" x1");
            double x1 = Convert.ToDouble(Console.ReadLine());
            //For y co-ordinates,
            Console.WriteLine("Provide y coordinates of the Line2");
            Console.WriteLine(" y2");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" y1");
            double y1 = Convert.ToDouble(Console.ReadLine());
            //Calculation,
            double result3 = Math.Pow(x2 - x1, 2);
            double result4 = Math.Pow(y2 - y1, 2);
            double length2 = Math.Sqrt(result3 + result4);
            //Final result,
            Console.WriteLine("length of Line2: " + length2);

            if (length1 == length2)
            {
                Console.WriteLine("Given Two Lines Are Equal");
            }
            else if (length1 > length2)
            {
                Console.WriteLine("Line1 is greater than Line2");
            }
            else
            {
                Console.WriteLine("Line1 is less than Line2");
            }
        }

    }
}

