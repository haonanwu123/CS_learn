namespace W06._2._1T03;

class Program
{
    static void Main(string[] args)
    {
        List<Bill> bills = new List<Bill>
        {
            new ElectricityBill(50, "John Smith"),
                new ElectricityBill(75, "Jane Doe"),
                new GasBill(100, "Bob Johnson", false),
                new GasBill(125, "John Doe", true)
        };

        foreach (var bill in bills)
        {
            Console.WriteLine(bill.GetDescription());
        }

        double total = bills.Sum(bill => bill.Amount);
        Console.WriteLine($"Total amount: {(int)total}");
    }
}
