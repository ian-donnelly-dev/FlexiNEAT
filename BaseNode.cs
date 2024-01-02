namespace FlexiNEAT
{
    public abstract class BaseNode
    {
        private double value;
        private bool computed;

        public readonly float depth;

        protected BaseNode(float depth)
        {
            this.depth = depth;
            computed = false;
        }

        protected abstract double ComputeValue();

        public double GetValue()
        {
            if (!computed)
            {
                value = ComputeValue();
                computed = true;
            }
            return value;
        }

        public virtual void Reset()
        {
            computed = false;
        }
    }
}