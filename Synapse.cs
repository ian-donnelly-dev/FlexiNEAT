namespace FlexiNEAT
{
    public class Synapse
    {
        public BaseNode InputNode { get; private set; }
        public ProcessingNode OutputNode { get; private set; }
        public double Weight { get; set; }

        public Synapse(BaseNode inputNode, ProcessingNode outputNode, double weight)
        {
            InputNode = inputNode;
            OutputNode = outputNode;
            Weight = weight;
        }
    }
}