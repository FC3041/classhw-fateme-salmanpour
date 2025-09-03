namespace L2._6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("leap year :");
        Console.WriteLine(leap_yaer(1792));
        Console.WriteLine("left triangle:");
        MoreAsciiiArtint(10);
        Console.WriteLine("print cone:");
        print_cone(10);
        compute_change(8);
        
    }

    static string leap_yaer(int year)
    {
        if ((year%4==0) & (year%100==0))
        {
            return "true";
        }
        
        else
        {
            return "false";
        }
    }

    static void MoreAsciiiArtint(int size)
    {
        for (int i = 0; i < size ; i++)
        {
            if (i%2==0)
            {
                Console.WriteLine(new string('*', i));
            }
           else 
            {
                Console.WriteLine(new string('%', i));
            }
        }
    }

    static void print_cone(int baseSize)
    {
        int k = (baseSize/2) + 1;
        Console.WriteLine(new string(' ',k)+"^");
        for (int i = 1; i < baseSize; i++)
        {
            Console.WriteLine(new string(' ',k-i)+new string('/',i)+"|"+new string('\\',i));
        }
    }

    static void compute_change(int dollar)
    {
        if (dollar<=100)
        {   
        int change = 100 - dollar;
        int quarters = change / 25;
        change %= 25;
        int dimes = change / 10;
        change %= 10;
        int nickels = change / 5;
        int pennies = change % 5;
        
        Console.WriteLine( $"quarters = {quarters}");
        Console.WriteLine( $"dimes = {dimes}");
        Console.WriteLine( $"nickels = {nickels }");
        Console.WriteLine( $"pennies = {pennies }");
        

        }
        
    }
}
