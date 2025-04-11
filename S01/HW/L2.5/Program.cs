namespace L2._5;

class Program
{
    static void Main(string[] args)
    {
       
        double celsius = Celsius(0);
        double fahrenheit =Fahrenheit(0);
        Console.WriteLine(celsius.ToString("F2")+" Celsius");
        Console.WriteLine(fahrenheit.ToString("F2")+" Fahrenheit");
        Console.WriteLine("factorial"+ " 5 " +": " +Factorial(5));
        Console.WriteLine("factorail 1 to 20 : " + factorial_table());
        Console.WriteLine(" 2POWER3= " + power(2,3));
        Console.WriteLine( quadradic(2,3,1));
    }
    static double Celsius(double f)
    {
       double c =(f - 32) * 5/9;
       return c;

    }

     static double Fahrenheit(double C)
    {
       double F = (C / 1.8)+32;
       return F;

    }


    static double Factorial(double n)
    {
        double result = 1;
        for (int i = 1; i <n+1; i++)
        {
            result = result*i;
        }
        return result;
    }
    static string factorial_table()
    {   string list = "";
        for (int j = 1; j < 20; j++)
        {
            double result = 1;
        for (int i = 1; i <j+1; i++)
        {
            result *= i;
        }  
         list += result.ToString() + ", ";
        }
        return list;

    }

    static double power(double a , double b)
    {   double result = 1;
       for (int i = 0; i < b; i++)
       {
         result *= a;
       }
        return result;
    }

    static string quadradic(int a, int b, int c)
    {   
        double delta = (b*b)-(4*a*c);

        if (delta < 0)
        {
            return "no root";
        }
        if (delta > 0)
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            return $"roots: {x1} and {x2}";
        }
        else
        {
            
        double x = -b/(2*a);
        return $"root ; {x}" ;
        }
        
    }
}

