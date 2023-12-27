namespace FlexiNEAT
{
    public class Synapse
    {
        public BaseNode InputNode { get; private set; }
        public BaseNode OutputNode { get; private set; }
        public double Weight { get; set; }

        public Synapse(BaseNode inputNode, BaseNode outputNode, double weight)
        {
            InputNode = inputNode;
            OutputNode = outputNode;
            Weight = weight;
        }
    }
}