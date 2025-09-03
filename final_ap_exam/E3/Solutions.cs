using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace E3;


public class Animal
{
    public virtual string MakeSound()
    {
        return "Some generic animal sound";
    }
}

public class Dog : Animal
{
    public override string MakeSound()
    {
        return "Woof";
    }
}


public static class LinqProblems
{
    public static IEnumerable<int> FilterAndDouble(IEnumerable<int> num)
    {
        return num
        .Where(n => n % 2 == 0 && n > 5)
        .Select(n => n * 2);

    }
   
 }
 

public static class LambdaProblems
{
    public static Func<string, int> GetStringLengthCalculator()
    {
        return (s => s.Length);
    }
}

    public class MyPointType1
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    public struct MyPointType2
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

public class ResourceManager : IDisposable
{

    public bool IsDisposed;
    public void Dispose()
    {
        IsDisposed = true;

    }
}

public class Comparer<_T> where _T : IComparable<_T>
    {
        private readonly _T x;
        private readonly _T y;

        public Comparer(_T a, _T b)
        {
            x = a;
            y = b;
        }

        public _T GetLarger()
        {
            return x.CompareTo(y) >= 0 ? x : y;
        }
    }
    public class Product : IComparable<Product>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int CompareTo(Product other)
        {
            if (other == null) return 1;
            return this.Price.CompareTo(other.Price);
        }
    }

    
//  public class Sale
//   {
//         public string Category;
//     public int Amount;
//         public  Sale(string category, int amount)
//         {
//             Category = category;
//             Amount = amount;
//         }
//   };
//     public static Dictionary<string, int> GetTotalAmountByCategory()
//     {
//     Dictionary<string, int> sales = new Dictionary<string,int>() ;
//     return sales
//     .GroupBy(s => s.Key)
//     .Select(s => s.Sum(s=> s.Value)).ToDictionary(out string Key,out int value);
  //  }
    