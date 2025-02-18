namespace W01._1._2O02;

class Program
{
    static void Main(string[] args)
    {
        double discount = 0.1;
        int price = 55;
        double discountPrice = price * (1 - discount);

        string message = $"The discount price is {discountPrice}";
        Console.WriteLine(message);
    }
}
