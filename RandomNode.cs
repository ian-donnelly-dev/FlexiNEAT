namespace FlexiNEAT
{
    public class RandomNode : InputNode
    {
        public readonly double min;
        public readonly double max;

        public RandomNode(double min, double max) : base()
        {
            this.min = min;
            this.max = max;
        }

        protected override double ComputeValue()
        {
            return StatRandom.RandomRange(min, max);
        }
    }
}