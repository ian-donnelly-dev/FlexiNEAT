namespace FlexiNEAT
{
    public abstract class BaseNode
    {
        private double value;
        private bool computed;

        protected BaseNode()
        {
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
    }
}