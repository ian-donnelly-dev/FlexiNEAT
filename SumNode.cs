namespace FlexiNEAT
{
    public class SumNode : ProcessingNode
    {
        public SumNode(Func<double, double> activationFunc) : base(activationFunc) { }

        protected override double EvaluateNode(List<double> inputs)
        {
            return inputs.Sum();
        }
    }
}