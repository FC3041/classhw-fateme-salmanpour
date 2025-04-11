namespace L2._10;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine(Exp(1, 0.000001)); 
        double y = 0.000001;
        double exp1 = Exp(1, y);
        double exp2 = Exp2(1, y); 
        Console.WriteLine(exp1);  
        Console.WriteLine(exp2);  
    }
    //part2
    static int Factorial(int n)
    {
        int result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

    static double Power(double x, int n)
    {
        double result = 1.0;
        for (int i = 0; i < n; i++)
        {
            result *= x;
        }
        return result;
    }

    static double Exp(double x, double y)
    {
        double sum = 0.0;
        int n = 0;
        while (true)
        {
            double term = Power(x, n) / Factorial(n);
            if (term < y)
                break;
            sum += term;
            n++;
        }
        return sum;
    }

    //part 3



    static double Exp(double x, double y)
    {
        double sum = 0.0;
        int n = 0;
        while (true)
        {
            double term = Power(x, n) / Factorial(n);
            if (term < y)
                break;
            sum += term;
            n++;
        }
        return sum;
    }

    static double Exp2(double x, doubley)
    {
        double sum = 1.0;
        double term = 1.0;
        int n = 1;
        while (true)
        {
            term *= x / n;
            if (term < y)
                break;
            sum += term;
            n++;
        }
        return sum;
    }

    static double Abs(double x)
    {
       if (x<0)
       {
         return -x;
       }
       else
       {
        return x;
       }
    }

    static bool Near(double x, double y, double closeness = 0.001)
    {
        return Abs(x - y) <= closeness * Math.Max(Abs(x), Abs(y));
    }

    //part4
    

   
    


   


}
