﻿using System;

namespace ReverseIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[numbers.Length - 1 - i]} ");
            }
        }

    }
}
