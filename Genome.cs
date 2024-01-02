namespace FlexiNEAT
{
    public class Genome
    {
        private InputNode[] inputNodes;
        private OutputProcessingNode[] outputNodes;

        private List<HiddenProcessingNode> hiddenNodes;

        private List<Synapse> synapses;

        public Genome(InputNode[] inputNodes, OutputProcessingNode[] outputNodes)
        {
            this.inputNodes = inputNodes;
            this.outputNodes = outputNodes;

            hiddenNodes = new List<HiddenProcessingNode>();
            synapses = new List<Synapse>();
        }

        public void ResetNetwork()
        {
            foreach (BaseNode node in inputNodes)  { node.Reset(); }
            foreach (BaseNode node in outputNodes) { node.Reset(); }
            foreach (BaseNode node in hiddenNodes) { node.Reset(); }
        }
    }
}