namespace FlexiNEAT
{
    internal class Program
    {
        static void Main()
        {
            Genome genome = new Genome (
                [ 
                    new SensorNode(),
                    new SensorNode(),
                    new BiasNode(),
                    new RandomNode(0.0, 1.0),
                ],
                [
                    new SumNode(ActivationFunctions.Sigmoid),
                    new SumNode(ActivationFunctions.Sigmoid)
                ]
            );
        }
    }
}