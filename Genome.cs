namespace FlexiNEAT
{
    public class Genome
    {
        private BaseNode[] inputNodes;
        private BaseNode[] outputNodes;
        private List<BaseNode> hiddenNodes;
        private List<Synapse> synapses;

        public Genome(BaseNode[] inputNodes, BaseNode[] outputNodes)
        {
            this.inputNodes = inputNodes;
            this.outputNodes = outputNodes;
            hiddenNodes = new List<BaseNode>();
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