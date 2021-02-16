using System;
using System.Collections.Generic;
using System.Text;

namespace lab5.Classes
{
    public class GFGFormula
    {
        public static int Fib(int n)
        {
            double phi = (1 + Math.Sqrt(5)) / 2;
            return (int)Math.Round(Math.Pow(phi, n)/ Math.Sqrt(5));
        }
    }
}
