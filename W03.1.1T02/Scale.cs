class Scale
{
    public bool UseKg = true;

    public static double ConvertKgToLbs(double kg)
    {
        return kg * 2.2;
    }

    public string GetWeight(double weight)
    {
        if (UseKg)
        {
            return $"{weight} kg";
        }
        else
        {
            double weightInLbs = ConvertKgToLbs(weight);
            return $"{weightInLbs} lbs";
        }
    }
}