﻿using System;

namespace mySecondApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;
            int num3, num4, num5;
            int sum = num1 + num2;
            double d1 = 3.5;
            double d2 = 1.5;
            double sum2 = d1 / d2;
            // when dividing use double cant convert floats to int or use Casting

            Console.WriteLine("the sum of " + d1 + " and " + d2 + " = " + sum2);
        }
    }
}
