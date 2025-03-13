namespace W05._1._1T01;

class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>
        {
            new Person("John Doe"),
            new Student("Jane Doe")
        };

        foreach (var person in people)
        {
            Console.WriteLine(person.Introduce());

            if (person is Student student)
            {
                Console.WriteLine(student.Status());
            }

        }
    }
}
