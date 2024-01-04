public static class ActivationFunctions
{
    public static double Sigmoid(double input)
    {
        return 1.0 / (1.0 + Math.Exp(-input));
    }

    public static double HyperbolicTangent(double input)
    {
        return Math.Tanh(input);
    }

    public static double LeakyRectifiedLinearUnit(double input)
    {
        return input > 0 ? input : 0.01 * input;
    }

    public static double LinearIdentity(double input)
    {
        return input;
    }

    private static readonly Dictionary<string, Func<double, double>> FunctionMap = new Dictionary<string, Func<double, double>>
    {
        { "Sigmoid", Sigmoid },
        { "HyperbolicTangent", HyperbolicTangent },
        { "LeakyRectifiedLinearUnit", LeakyRectifiedLinearUnit },
        { "LinearIdentity", LinearIdentity }
    };

    public static string GetFunctionName(Func<double, double> function)
    {
        var result = FunctionMap.FirstOrDefault(pair => pair.Value == function);
        return result.Key ?? "Unknown";
    }

    public static Func<double, double> GetFunctionByName(string name)
    {
        if (FunctionMap.TryGetValue(name, out var function))
        {
            return function;
        }

        throw new ArgumentException($"No activation function found with name: {name}");
    }
}