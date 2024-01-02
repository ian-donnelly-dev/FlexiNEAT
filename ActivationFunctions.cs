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
}