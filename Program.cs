namespace FlexiNEAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SumNode node0 = new SumNode(ActivationFunctions.Sigmoid);
            SumNode node1 = new SumNode(ActivationFunctions.Sigmoid);

            Synapse synapse0 = new Synapse(node0, node1, 2.0);

            node0.AddInputValue(0);

            synapse0.OutputNode.AddInputValue(synapse0.InputNode.GetValue() * synapse0.Weight);

            Console.WriteLine(node1.GetValue());
        }
    }
}