namespace W001._1._1T04;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your age ?");
        int myAge = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("What is the age of the student next to you ?");
        int studentAge = Convert.ToInt32(Console.ReadLine());

        // if (myAge == studentAge)
        // {
        //     Console.WriteLine("Your ages are equal");
        // }
        // else if (myAge > studentAge)
        // {
        //     Console.WriteLine("You are older");
        // }
        // else
        // {
        //     Console.WriteLine("You are younger");
        // }

        string result = (myAge == studentAge) ? "Your ages are equal" :
                        (myAge > studentAge) ? "You are older" :
                        "You are younger";

        Console.WriteLine(result);
    }
}
