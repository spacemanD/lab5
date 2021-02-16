using lab5.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab5
{
    public class Startmanager
    {
        public static string Programename = "Fibonacci number ";
        public static void Start()
        {
            Console.WriteLine("Enter your number ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(GFGIteratively.Fib(n));
            Console.WriteLine(GFGRecursion.Fib(n));
            Console.WriteLine(GFGFormula.Fib(n));
            Hanoitowers.TowerOfHanoi(n, 'A', 'C', 'B');
        }
    }
}
