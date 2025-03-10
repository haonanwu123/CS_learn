public static class DnaStrand
{
    // Method to return the complementary strand of a DNA string.
    public static string ComplementaryStrand(string dnaStrand)
    {
        // Initialize a result string that will hold the complementary strand
        char[] complementaryStrand = new char[dnaStrand.Length];

        for (int i = 0; i < dnaStrand.Length; i++)
        {
            complementaryStrand[i] = dnaStrand[i] switch
            {
                'A' => 'T',
                'T' => 'A',
                'C' => 'G',
                'G' => 'C',
                _ => throw new ArgumentException($"Invalid nucleotide {dnaStrand[i]} in DNA strand.")
            };
        }

        // Return the complementary strand as a new string.
        return new string(complementaryStrand.Reverse().ToArray());
    }

    // Method to check if a given DNA strand is valid.
    public static bool IsValidDnaStrand(string dnaStrand)
    {
        // A valid DNA strand consists only of 'A', 'C', 'G', 'T'
        return dnaStrand.All(c => "ACGT".Contains(c));
    }

    // Method to transcribe a DNA strand into RNA.
    public static string Transcribe(string dnaStrand)
    {
        // Replace all 'T' with 'U' to transcribe into RNA
        return dnaStrand.Replace('T', 'U');
    }

    // Method to calculate the Hamming distance between two DNA strands.
    public static int HammingDistance(string dnaStrand1, string dnaStrand2)
    {
        // If the DNA strands are not of the same length, return -1
        if (dnaStrand1.Length != dnaStrand2.Length)
        {
            return -1;
        }

        // Calculate Hamming distance by comparing nucleotides at the same positions
        int distance = 0;
        for (int i = 0; i < dnaStrand1.Length; i++)
        {
            if (dnaStrand1[i] != dnaStrand2[i])
            {
                distance++;
            }
        }

        // Return the calculated Hamming distance
        return distance;
    }
}