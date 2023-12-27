namespace FlexiNEAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SumNode sumNode = new SumNode(1, ActivationFunctions.Sigmoid);

            sumNode.AddInputValue(1.5);
            sumNode.ComputeValue();

            Console.WriteLine(sumNode.Value);
        }
    }
}