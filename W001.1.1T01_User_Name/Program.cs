namespace W001._1._1T01_User_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. Please enter your last name.");
            string? lastName = Console.ReadLine();
            if (string.IsNullOrEmpty(lastName))
            {
                Console.WriteLine("Invalid input. Last name cannot be empty.");
                return;
            }

            Console.WriteLine("What is the initial of your first name?");
            string? firstNameInput = Console.ReadLine();
            if (string.IsNullOrEmpty(firstNameInput) || firstNameInput.Length != 1)
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            char firstInitial = Convert.ToChar(firstNameInput);

            Console.WriteLine($"Welcome to the course, {firstInitial} {lastName}. We will watch your career with great interest.");
        }
    }
}