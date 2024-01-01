namespace FlexiNEAT
{
    public class SumNode : ProcessingNode
    {
        public SumNode(byte depth, Func<double, double> activationFunc) : base(depth, activationFunc) { }

        protected override double EvaluateNode(List<double> inputs)
        {
            return inputs.Sum();
        }
    }
}