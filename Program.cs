namespace FlexiNEAT
{
    internal class Program
    {
        static void Main()
        {
            Genome genome = new Genome (
                    new BaseNode[2] { 
                        new DataInputNode(0),
                        new DataInputNode(0) 
                    },
                    new SumNode[2] { 
                        new SumNode(255, ActivationFunctions.Sigmoid),
                        new SumNode(255, ActivationFunctions.Sigmoid)
                    }
                );

            // dedicated output node? remove depth passes here? (make a new input and output parent type that has set depth and other info) add synapse? split synapse?
        }
    }
}