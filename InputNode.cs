namespace FlexiNEAT
{
    public abstract class InputNode : BaseNode
    {
        protected InputNode() : base(0) { }

        protected abstract override double ComputeValue();
    }
}