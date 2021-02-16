﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lab5.Classes
{
    public class Hanoitowers
    {
       public  static void TowerOfHanoi(int n, char from_rod,
                             char to_rod, char aux_rod)
        {
            if (n == 1)
            {
                Console.WriteLine("Move disk 1 from rod " + from_rod
                                               + " to rod " + to_rod);
                return;
            }
            TowerOfHanoi(n - 1, from_rod, aux_rod, to_rod);
            Console.WriteLine("Move disk " + n + " from rod "
                              + from_rod + " to rod " + to_rod);
            TowerOfHanoi(n - 1, aux_rod, to_rod, from_rod);
        }

        // Driver method
       
    }
}
