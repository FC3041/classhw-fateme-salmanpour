namespace L2._2;

class Program
{
    static void Main(string[] args)
    {
        head(args);
        line(args);
        body(args);
        line(args);
        body(args);
        line(args);
        head(args);
    }

    static void head(string[] args)
    {
        Console.WriteLine("     ^      ");
        Console.WriteLine("    /|\\     ");
        Console.WriteLine("   //|\\\\   ");
        Console.WriteLine("  ///|\\\\\\   ");
    }

    static void body(string[] args)
    {
        Console.WriteLine(" +*******+  ");
        Console.WriteLine(" +*******+  ");
        Console.WriteLine(" +*******+  ");
        Console.WriteLine(" +*******+  ");
    }    

    static void line(string[] args)
    {
         Console.WriteLine(" +-------+  ");
    }
}



