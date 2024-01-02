namespace FlexiNEAT
{
    public class BiasNode : InputNode
    {
        public BiasNode() : base() { }

        protected override double ComputeValue()
        {
            return 1;
        }
    }
}