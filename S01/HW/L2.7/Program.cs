namespace L2._7;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("absolute value of 100 is " + absolute_value(100 ));
        Console.WriteLine("absolute value of -100 is " + absolute_value(-100 ));
        Console.WriteLine("absolute value of 1 is " + absolute_value(1));
        Console.WriteLine("absolute value of -1 is " + absolute_value(-1));
        Console.WriteLine("factorail 1 to 20 : " + factorial_table());
        Console.WriteLine("is 2 divisible to 3? " + is_divisible(2,3));
        Console.WriteLine("is 13 aprim number? " + is_prime(13));
        Console.WriteLine(fibonacci(6));
        Console.WriteLine(date(2));
        Console.WriteLine(date(2) + year(1233));
        Console.WriteLine(days_before_date(2014, 1,1));
        day_of_the_week(2014, 12, 31);

    
        
    }

    // part1
    static int absolute_value(int x )
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
    // part2
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

    //part3
    static bool  is_divisible(int a, int b)
    {
        if(a%b==0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    // part4
    static bool is_prime(int a)
    {
        for (int i = 2; i < a; i++)
        {
            if (a%i==0)
            {
                return false;
            }
            
        }
        return true;
    }
    // part5 
    static int fibonacci(int n)
    {
        if ((n==1)|(n==2))
        {
            return 1;
        }
       else
      {return (fibonacci(n-1) + fibonacci(n-2));}
    }

    // part6
    static string date(int monthNumber)
    {
    if (monthNumber==1)
     {return"31";}
   if (monthNumber==2)
      {return"28";}
   if (monthNumber==3)
      {return "31";}
   if (monthNumber==4)
      {return"30";}
   if (monthNumber==5)
      {return"31";}
   if (monthNumber==6)
      {return"30";}
   if (monthNumber==7)
      {return"31";}
   if (monthNumber==8)
      {return"31";}
   if (monthNumber==9)
      {return"30";}
   if (monthNumber==10)
      {return "31";}
   if (monthNumber==11)
      {return "30";}
   if (monthNumber==12)
     {return "31";}

    else{ return "none";}
    }

    // Part7
    static bool year(int year)
    {
     if ((year%4==0) & (year%100==0))
        {
            return true;
        }
        
        else
        {
            return false;
        }
    }   

    // Part8

    static int days_before_date(int Year,int  monthNumber,int dayNumber)
    {
        int sum =0;
        sum += ( dayNumber-1);
      
        
            for (int i = 2; i <= monthNumber; i++)
{
    if ((i + 1) == 1 || (i + 1) == 3 || (i + 1) == 5 || (i + 1) == 7 || (i + 1) == 8 || (i + 1) == 10 || (i + 1) == 12)
    {
        sum += 31;
    }
    else if ((i + 1) == 4 || (i + 1) == 6 || (i + 1) == 9 || (i + 1) == 11)
    {
        sum += 30;
    }
    else if (year(Year)== true && (i + 1) == 2)
    {
        sum += 28;
    }
    else if (year( Year)== false && (i + 1) == 2)
    {
        sum += 29;
    }
}   return sum;

        }

    // Part 9


    static void day_of_the_week(int year, int monthNumber, int dayNumber)
    {
        int sum = 0;
        sum += (dayNumber - 1);

        for (int i = 1; i < monthNumber; i++)
        {
            if (i == 1 || i == 3 || i == 5 || i == 7 || i == 8 || i == 10 || i == 12)
            {
                sum += 31;
            }
            else if (i == 4 || i == 6 || i == 9 || i == 11)
            {
                sum += 30;
            }
            else if (i == 2)
            {
                sum += 28;
            }
        }

        if (sum % 7 == 0)
        {
            Console.WriteLine("Wednesday");
        }
        else if (sum % 7 == 1)
        {
            Console.WriteLine("Thursday");
        }
        else if (sum % 7 == 2)
        {
            Console.WriteLine("Friday");
        }
        else if (sum % 7 == 3)
        {
            Console.WriteLine("Saturday");
        }
        else if (sum % 7 == 4)
        {
            Console.WriteLine("Sunday");
        }
        else if (sum % 7 == 5)
        {
            Console.WriteLine("Monday");
        }
        else if (sum % 7 == 6)
        {
            Console.WriteLine("Tuesday");
        }
    }

   
}

        

    


