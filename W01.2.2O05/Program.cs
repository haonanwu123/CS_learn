namespace W01._2._2O05;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the initial balance in whole Euros?");
        double balance = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What is the interest rate in percent?");
        double interestPct = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Calculate over how many years?");
        int years = Convert.ToInt32(Console.ReadLine());

        double taxesPaid = 0;

        for (int i = 0; i < years; i++)
        {
            balance += balance * (interestPct / 100);

            double yearlyTax = 0;
            if (balance > 100000)
            {
                yearlyTax += (balance - 100000) * 0.03;
                yearlyTax += 50000 * 0.015;
            }
            else if (balance > 50000)
            {
                yearlyTax += (balance - 50000) * 0.015;
            }
            else
            {
                yearlyTax = 0;
            }

            balance -= yearlyTax;
            taxesPaid += yearlyTax;
        }

        balance = (int)balance;
        taxesPaid = (int)taxesPaid;
        Console.WriteLine($"Balance after {years} years: {balance}");
        Console.WriteLine($"Amount of taxes paid: {taxesPaid}");
    }
}
