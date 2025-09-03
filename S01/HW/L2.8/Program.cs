using System;

class Program
{
    static int ComputeSum(int n)
    {
        // Computes the sum of digits from 1 to n
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        return sum;
    }

    static void Main(string[] args)
    {
        // Create a table from 9 down to 1
        Console.WriteLine("N      ComputeSum(N)");
        Console.WriteLine("---------------------");
        for (int i = 9; i > 0; i--)
        {
            Console.WriteLine($"{i}         {ComputeSum(i)}");
        }
    }

    static 
}
