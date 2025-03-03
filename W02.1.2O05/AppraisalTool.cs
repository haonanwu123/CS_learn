static class AppraisalTool
{
    public static Dictionary<string, double> Catalogue = new() {
        { "The Hope Diamond", 250_000_000 },
        { "The Mona Lisa", 50_000_000 },
        { "Tutankhamun's Mask", 5_000_000 },
        { "The Dead Sea Scrolls (Fragment)", 1_500_000 },
        { "A Roman Gladiator's Helmet", 1_000_000 },
        { "The Gutenberg Bible (Single Page)", 500_000 },
        { "A Viking Longship Fragment", 300_000 },
        { "An Ancient Greek Amphora", 200_000 },
        { "Rare stamp (1851 10c green)", 1_000 },
        { "A Samurai Katana from the Edo Period", 150_000 },
        { "A Pre-Columbian Gold Figurine", 100_000 },
    };

    static void Main()
    {
        Console.WriteLine("Appraising listed artifacts...");
        List<Artifact> listedArtifacts = [
            new("The Hope Diamond", 1),
            new("A Pre-Columbian Gold Figurine", 0),
            new("The Dead Sea Scrolls (Fragment)", 0.5),
            new("An Ancient Greek Amphora", 0.75),
        ];

        foreach (var artifact in listedArtifacts)
        {
            Appraise(artifact);
        }

        Console.WriteLine("\nAppraising unlisted artifacts...");
        List<Artifact> unlistedArtifacts = [
            new("Gom Jabbar", 1),
            new("Invisibility Cloak", 0.9),
            new("The Praetor Suit", 1),
            new("The Master Sword", 0),
        ];

        foreach (var artifact in unlistedArtifacts)
        {
            Appraise(artifact);
        }

        Console.WriteLine("\nAdding artifacts...");
        AddArtifact("Orb of Dragonkind", 2_000_000);
        AddArtifact("The Hope Diamond", 250_000_000);
        AddArtifact(" Leoric's Crown  ", 1_000_000);
        AddArtifact("  The Gutenberg Bible (Single Page) ", 500_000);

        Console.WriteLine("\nPrinting Catalogue...");
        PrintCatalogue();
    }

    public static void Appraise(Artifact artifact)
    {
        if (Catalogue.ContainsKey(artifact.Name))
        {
            double value = Catalogue[artifact.Name] * artifact.ConditionRate;
            Console.WriteLine($"Value of artifact '{artifact.Name}': {FormatValue(value)}");
        }
        else
        {
            Console.WriteLine($"Artifact '{artifact.Name}' not in catalogue");
        }
    }

    public static void AddArtifact(string name, double value)
    {
        string trimmedName = name.Trim();
        if (Catalogue.ContainsKey(trimmedName))
        {
            Console.WriteLine($"Artifact '{trimmedName}' already in catalogue");
        }
        else
        {
            Catalogue[trimmedName] = value;
            Console.WriteLine($"Added artifact '{trimmedName}'");
        }
    }

    public static void PrintCatalogue()
    {
        Console.WriteLine("Catalogue:");
        foreach (var entry in Catalogue)
        {
            Console.WriteLine($" - Artifact: '{entry.Key}', Perfect Condition Value: {FormatValue(entry.Value)}");
        }
    }

    private static string FormatValue(double value)
    {
        if (value >= 1_000_000)
        {
            return $"{(value / 1_000_000):0.#}M";
        }
        else if (value >= 1_000)
        {
            return $"{(value / 1_000):0.#}k";
        }
        else
        {
            return value.ToString();
        }
    }
}
