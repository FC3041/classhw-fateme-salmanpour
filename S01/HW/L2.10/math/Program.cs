namespace math;

using System;

class Program
{

     static void Main(string[] args)
    {
        
        Console.WriteLine(EulersConstant(0.0001)); 
    }
    static int Factorial(int n)
    {
        int result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

    static double EulersConstant(double x)
    {
        double sum = 0.0;
        int n = 0;
        while (true)
        {
            double term = 1.0 / Factorial(n);
            if (term <x)
                break;
            sum += term;
            n++;
        }
        return sum;
    }

   
}
