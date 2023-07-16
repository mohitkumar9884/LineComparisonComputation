using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonComputation.Line
{
    public class Line
    {
        private double X1, X2, Y1, Y2;

        public Line(double x1, double x2, double y1, double y2)
        {
            X1 = x1;
            X2 = x2;
            Y1 = y1;
            Y2 = y2;
        }

        public double CalculateLength()
        {
            double result1 = Math.Pow(X2 - X1, 2);
            double result2 = Math.Pow(Y2 - Y1, 2);
            return Math.Sqrt(result1 + result2);
        }
    }
}
