namespace L2._3;

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
       for (int i = 0; i < 4; i++)
       {
        Console.WriteLine(" " +"+" +  new string('-',7) + "+");
       }
    }    

    static void line(string[] args)
    {
         Console.WriteLine( " " +"+" + new string('*',7) + "+");
    }
}
