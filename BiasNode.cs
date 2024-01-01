namespace FlexiNEAT
{
    public class BiasNode : BaseNode
    {
        public BiasNode(byte depth) : base(depth) { }

        protected override double ComputeValue()
        {
            return 1;
        }
    }
}