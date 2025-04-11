namespace s13con;

class Program
{
  
    public static void PrintPersons(IPerson<int>[] ps)
    {
        foreach(var p in ps)
            Console.WriteLine(p);
    }    
    public static void Main(string[] args)
    {
        Student [] students = new Student[] { 
            new Student() {
                FirstName="zahra",
                LastName="Hamedi",
                GPA = 18.5,
                id = 12
            },
            new Student() {
                FirstName="ali",
                LastName="Zamedi",
                GPA = 16.5,
                id = 5
            },
         
        };

        PrintPersons(students);

        MySort(students, PersonComparers.PersonFirstNameComparer);
        System.Console.WriteLine("----------------");
        PrintPersons(students);
         MySort(students, PersonComparers.PersonLastNameComparer);
        System.Console.WriteLine("----------------");
                PrintPersons(students);

         MySort(students, PersonComparers.PersonidComparer);
        System.Console.WriteLine("----------------");
                PrintPersons(students);



    

     

    }

    private static void MySort(IPerson<int>[] persons, IComparer<IPerson<int>> cmp)
    {
        for(int i=0; i<persons.Length; i++)
            for(int j=i+1; j<persons.Length;j++)
                if (cmp.Compare(persons[i], persons[j]) > 0)
                    swap<IPerson<int>>(persons, i, j);
    }

    private static void swap<T>(T[] items, int i, int j)
    {
        T tmp = items[i];
        items[i] = items[j];
        items[j] = tmp;
    }

    
}
