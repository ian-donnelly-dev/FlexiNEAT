public static class StatRandom
{
    private static Random _random = new Random();

    public static double Normal(double mean, double stdDev)
    {
        double u1 = 1.0 - _random.NextDouble();
        double u2 = 1.0 - _random.NextDouble();
        double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2);

        return mean + stdDev * randStdNormal;
    }

    public static double RandomRange(double min, double max)
    {
        if (max < min)
        {
            throw new ArgumentException("Max must be greater than or equal to min.");
        }

        return _random.NextDouble() * (max - min) + min;
    }

    public static bool Chance(double probability)
    {
        if (probability < 0.0 || probability > 1.0)
        {
            throw new ArgumentOutOfRangeException(nameof(probability), "Probability must be between 0 and 1.");
        }

        return _random.NextDouble() < probability;
    }
}