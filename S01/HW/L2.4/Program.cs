namespace L2._4;

class Program
{
    static void Main(string[] args)
    {
       right_triangle('*', 5);
       left_triangle('*', 5);
    }


    static void left_triangle(char args, int n)
    {
        for (int i = 0; i < n+1; i++)
        {
            Console.WriteLine(new string(args, i));
        }
    }
    static void right_triangle(char args, int  n)
    {
       
        for (int i = 0; i < n+1 ; i++)
        {
            int k = n*2 - i;
            Console.WriteLine(new string(' ', k) + new string(args, i));
        }
    }
}
