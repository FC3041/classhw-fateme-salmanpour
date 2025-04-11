namespace S8con;

public class Program
{

    //todo1
      public static void reverse_sentece(string s, out string srev)
      {
        srev ="";
        string[] words = s.Split(' ');
        int len = words.Length;

     for (int i = len - 1; i>=0; i--)
        {
            srev += words[i] + " ";
        }
      }


//     public static int add( int a , int b)

// {
//     return a+b;
// }

//   public static void prepend_user(string s, out string sout)
//   {
//     sout = "user:";
//   }

//   public static void reverse(string s, out string srev)
// {
//     srev = "";
//     foreach(char c in s)
//         srev = c+srev;
// }


  static void Main(string[] args)
  {
    // string name = "fateme";
    string srev;
    // reverse(name, out srev);
    // System.Console.WriteLine((srev));
    string sen = "salam donya farsi sth";
    reverse_sentece(sen, out srev);
    System.Console.WriteLine((srev));


  }

//   static void Main1(string[] args)
//     {
//         int sum = 0;
//         while(true)
//         {
//         System.Console.Write("NUMS?");
//         String s = Console.ReadLine();
//         if(string.IsNullOrEmpty(s))
//          break;

//         int n;
//         if(! int.TryParse(s, out n))
//         {
//             System.Console.WriteLine(" wrong! try again.");
//             continue;
//         }
//         string sout;
//         prepend_user(s, out sout);

//         sum+=n;
//         //  sum+= int.Parse(s); //Parsing, in this context, refers to converting a string (text) into a number (integer). Since the user inputs a string (via Console.ReadLine()), we need to convert it into an integer so that we can perform arithmetic operations (like addition) on it
//         }
//         System.Console.WriteLine(sum);
//         // for(int i=0;i<args.Length;i++)
//         // {
//         //     System.Console.WriteLine($"args{i}:{args[i]}");
//         // }
//         // Console.WriteLine("Hello, World!");
//     }

}
