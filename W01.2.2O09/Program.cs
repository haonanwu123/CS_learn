namespace W01._2._2O09;

static class Program
{
    static void Main()
    {
        Random rand = new(0);
        int howManyTimes = 500;
        int dieSides = 6;

        List<List<int>> results = [];
        for (int i = 0; i < howManyTimes; i++)
        {
            List<int> rollResults = [];
            for (int j = 0; j < 2; j++)
            {
                rollResults.Add(rand.Next(1, dieSides + 1));
            }
            results.Add(rollResults);
        }

        List<string> freqs = [
            " 2: ",
            " 3: ",
            " 4: ",
            " 5: ",
            " 6: ",
            " 7: ",
            " 8: ",
            " 9: ",
            "10: ",
            "11: ",
            "12: ",
        ];

        foreach (var roll in results)
        {
            int sum = roll[0] + roll[1];

            if (sum >= 2 && sum <= 12)
            {
                freqs[sum - 2] += "|";
            }
        }

        foreach (var freq in freqs)
        {
            Console.WriteLine(freq);
        }
    }
}

