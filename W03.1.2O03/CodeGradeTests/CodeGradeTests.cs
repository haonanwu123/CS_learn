static class CodeGradeTests
{
    static void Main(string[] args)
    {
        switch (args[1])
        {
            case "Readonly": TestReadonly.Start(); return;
            case "Constant": TestConstant.Start(); return;
            case "10Rolls": TestFunctionality.TestFrequencies(10); return;
            case "100Rolls": TestFunctionality.TestFrequencies(100); return;
            case "Advantage": TestFunctionality.TestD20WithAdvantage(); return;
            case "Disadvantage": TestFunctionality.TestD20WithDisadvantage(); return;
            default: throw new ArgumentOutOfRangeException($"{args[1]}", $"Unexpected args value: {args[1]}");
        }
    }
}
