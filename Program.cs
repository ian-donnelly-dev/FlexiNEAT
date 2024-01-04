namespace FlexiNEAT
{
    internal class Program
    {
        static void Main()
        {
            Genome genome = new Genome (
                [ 
                    new SensorNode(),
                    new BiasNode(),
                    new RandomNode(-1.0, 1.0)
                ],
                [
                    new SumNode(ActivationFunctions.Sigmoid),
                    new SumNode(ActivationFunctions.LeakyRectifiedLinearUnit)
                ]
            );

            ((ProcessingNode)genome.sortedNodes[3]).incomingSynapses.Add(new Synapse(genome.sortedNodes[2]));
            ((ProcessingNode)genome.sortedNodes[3]).incomingSynapses[0].SetWeight(2.0);

            ((ProcessingNode)genome.sortedNodes[4]).incomingSynapses.Add(new Synapse(genome.sortedNodes[0]));
            ((ProcessingNode)genome.sortedNodes[4]).incomingSynapses[0].SetWeight(-1.45);

            ((ProcessingNode)genome.sortedNodes[3]).incomingSynapses.Add(new Synapse(genome.sortedNodes[0]));
            ((ProcessingNode)genome.sortedNodes[3]).incomingSynapses[0].SetWeight(3.0);

            Console.WriteLine(genome.ExportState());
        }
    }
}