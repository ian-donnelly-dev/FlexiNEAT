namespace FlexiNEAT
{
    public class Synapse
    {
        public BaseNode InputNode { get; private set; }
        public HiddenProcessingNode OutputNode { get; private set; }
        public double Weight { get; private set; }

        public Synapse(BaseNode inputNode, HiddenProcessingNode outputNode)
        {
            InputNode = inputNode;
            OutputNode = outputNode;
        }

        public void SetWeight(double weight)
        {
            Weight = weight;
        }
    }
}