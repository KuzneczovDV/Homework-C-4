﻿using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };

        PrintArrayReversed(array, array.Length - 1);

        Console.ReadLine();
    }
    static void PrintArrayReversed(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.Write(array[index] + " ");
            PrintArrayReversed(array, index - 1);
        }
    }
}
