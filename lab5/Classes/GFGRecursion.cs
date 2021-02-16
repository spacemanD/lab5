using System;
using System.Collections.Generic;
using System.Text;

namespace lab5.Classes
{
    public class GFGRecursion
    {
        
            public static int Fib(int n)
            {
                if (n <= 1)
                {
                    return n;
                }
                else
                {
                    return Fib(n - 1) + Fib(n - 2);
                }
            }
        
    }
}
