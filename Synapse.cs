namespace FlexiNEAT
{
    public class Synapse
    {
        public readonly BaseNode InputNode;
        public double Weight { get; private set; }

        public Synapse(BaseNode inputNode)
        {
            InputNode = inputNode;
            Weight = 1.0;
        }

        public void SetWeight(double weight)
        {
            Weight = weight;
        }
    }
}