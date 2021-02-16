using System;
using System.Collections.Generic;
using System.Text;

namespace lab5.Classes
{
    public class GFGIteratively
    {
        public static int Fib(int n)
        {
            int a = 0, b = 1,c = 0;

            // To return the first Fibonacci number  
            if (n == 0) return a;

            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return b;
        }
    }
}

