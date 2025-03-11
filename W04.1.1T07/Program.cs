namespace W04._1._1T07;

class Program
{
    static void Main(string[] args)
    {
        Person john = new Person("John Doe");
        Console.WriteLine(john.Introduce());

        Student jane = new Student("Jane Doe");
        Console.WriteLine(jane.Introduce());
        Console.WriteLine(jane.Status());
        jane.Graduate();
        Console.WriteLine(jane.Status());
    }
}
