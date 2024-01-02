namespace FlexiNEAT
{
    public class Genome
    {
        public List<BaseNode> sortedNodes;

        public Genome(InputNode[] inputNodes, ProcessingNode[] outputNodes)
        {
            sortedNodes = new List<BaseNode>();

            foreach (InputNode inputNode in inputNodes)
            {
                if (inputNode.depth != 0)
                {
                    throw new ArgumentException("Input node must have a depth of 0.");
                }

                sortedNodes.Add(inputNode);
            }

            foreach (ProcessingNode outputNode in outputNodes)
            {
                if (outputNode.depth != 1)
                {
                    throw new ArgumentException("Output node must have a depth of 1.");
                }

                sortedNodes.Add(outputNode);
            }
        }

        public void ResetNetwork()
        {
            foreach (BaseNode node in sortedNodes)
            {
                node.Reset();
            }
        }
    }
}