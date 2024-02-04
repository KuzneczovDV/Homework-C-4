using System;

class Program
{
    static void PrintNaturalNumbers(int m, int n)
    {
        if (m <= n)
        {
            Console.WriteLine(m);
            PrintNaturalNumbers(m + 1, n);
        }
    }

    static void Main()
    {
        int m = 1;
        int n = 10;

        PrintNaturalNumbers(m, n);
    }
}
