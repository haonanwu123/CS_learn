namespace W01._2._2O01;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the amount to pay?");
        int amountToPay = Convert.ToInt32(Console.ReadLine());

        if (amountToPay <= 0)
        {
            Console.WriteLine("Invalid input");
        }

        Dictionary<int, int> validPayments = new() {
            {1,5},
            {2,10},
            {3,20},
            {4,50},
        };

        int totalPaid = 0;

        while (totalPaid < amountToPay)
        {
            Console.WriteLine($"{amountToPay - totalPaid} left to pay");
            Console.WriteLine("Pay how much?");

            foreach (var payment in validPayments)
            {
                Console.WriteLine($"{payment.Key}: {payment.Value}");
            }

            int choice;

            while (!int.TryParse(Console.ReadLine(), out choice) || !validPayments.ContainsKey(choice))
            {
                Console.WriteLine("Invalid choice. Please select:");
                foreach (var payment in validPayments)
                {
                    Console.WriteLine($"{payment.Key}: {payment.Value}");
                }
            }
            totalPaid += validPayments[choice];
        }

        int extraPaid = totalPaid - amountToPay;

        if (extraPaid > 0)
        {
            Console.WriteLine($"You paid {extraPaid} too munch. Give a tip? y or n:");

            string tipResponse;

            while (true)
            {
                tipResponse = Console.ReadLine()!.Trim().ToLower();

                if (tipResponse == "y" || tipResponse == "n")
                    break;
                Console.WriteLine("Invalid input. Please enter y or n:");
            }

            if (tipResponse == "n")
            {
                totalPaid -= extraPaid;
            }
        }

        Console.WriteLine($"You have paid {totalPaid}");
    }
}