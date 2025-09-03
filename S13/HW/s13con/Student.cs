namespace s13con
{
interface IPerson<_Type>: IComparable<IPerson<_Type>>
{
    _Type id {get; set;}
    string FirstName {get; set;}
    string LastName {get; set;}

    string FullName {get;}
}


class Student: IPerson<int>
{
    public string FirstName {get; set;}
    public string LastName { get; set;}
    public string FullName => FirstName + " " + LastName;

    public double GPA {get; set;}
    public int id { get; set; }


    public int CompareTo(IPerson<int> other)  => FirstName.CompareTo(other.FirstName);

    public override string ToString() => $"{FullName}\t{GPA}\t{id}";
}

class Teacher: IPerson<string>
{
    public string FirstName {get; set;}
    public string LastName { get; set;}
    public string FullName => FirstName + LastName;
    public double Rating {get; set;}
    public string id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public int CompareTo(IPerson<string> other)
    {
        return this.FirstName.CompareTo(other.FirstName);
    }
}

    

class PersonFirstNameComparer : IComparer<IPerson<int>>
{
    public int Compare(IPerson<int> x, IPerson<int> y)
    {
        return x.FirstName.CompareTo(y.FirstName);
    }
}

class PersonLastNameComparer : IComparer<IPerson<int>>
{
    public int Compare(IPerson<int> x, IPerson<int> y)
    {
        return x.LastName.CompareTo(y.LastName);
    }
}

class PersonidComparer : IComparer<IPerson<int>>
{
    public int Compare(IPerson<int> x, IPerson<int> y)
    {
        return x.id.CompareTo(y.id);
    }
}
class PersonComparers
{
    public static PersonFirstNameComparer PersonFirstNameComparer = new PersonFirstNameComparer();
    public static PersonLastNameComparer PersonLastNameComparer = new PersonLastNameComparer();
    public static PersonidComparer PersonidComparer = new PersonidComparer();
}
}

