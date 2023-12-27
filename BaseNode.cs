namespace FlexiNEAT
{
    public abstract class BaseNode
    {
        public ushort Identifier { get; protected set; }
        public double Value { get; protected set; }

        protected BaseNode(ushort identifier)
        {
            Identifier = identifier;
        }

        public abstract void ComputeValue();
    }
}