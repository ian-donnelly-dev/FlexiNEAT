namespace FlexiNEAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SumNode node0 = new SumNode(0, ActivationFunctions.Sigmoid);
            SumNode node1 = new SumNode(1, ActivationFunctions.Sigmoid);

            Synapse synapse0 = new Synapse(node0, node1, 2.0);

            node0.AddInputValue(0);
            node0.ComputeValue();

            synapse0.OutputNode.AddInputValue(synapse0.InputNode.Value * synapse0.Weight);

            node1.ComputeValue();

            Console.WriteLine(node1.Value);
        }
    }
}