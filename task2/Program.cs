using System;

class Program
{
    static void Main()
    {
        int M = 1;
        int N = 10;

        PrintEvenNumbers(M, N);
    }
    static void PrintEvenNumbers(int current, int end)
    {
        if (current > end)
            return;

        if (current % 2 == 0)
            Console.WriteLine(current);

        PrintEvenNumbers(current + 1, end);
    }
}
