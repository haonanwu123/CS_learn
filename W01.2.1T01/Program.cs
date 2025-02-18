﻿namespace W01._2._1T01;

class Program
{
    static void Main(string[] args)
    {
        int money = 4;

        while (money > 0)
        {
            Console.WriteLine($"Money left: {money}");
            Console.WriteLine("Look around (1) or go in a ride (2)?");
            string choice = Console.ReadLine()!;

            if (choice == "2")
            {
                Console.WriteLine("Wheee!");
                money--;
            }
            else if (choice == "1")
            {
                Console.WriteLine("Yay!");
            }
        }

        Console.WriteLine("Time to go home.");
    }
}
