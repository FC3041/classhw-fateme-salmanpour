namespace L2._9;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(factorial(3));  
        IsPrime(3);
    
    }

    static int factorial(int n)
    {
        if(n<0) throw new ArgumentException("n must be posetive");
        int result =1;
        
        for(int i = 1; i < n+1; i++)
        {
            if(result<0) throw new InvalidOperationException("result must be posetive");
            result*=i;
        }

        if(result<0) throw new InvalidOperationException("result must be posetive");

        return result;


    }



    static bool IsPrime(int n)
    {
        if (n <= 1)
        {
            return false;
        }
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}
