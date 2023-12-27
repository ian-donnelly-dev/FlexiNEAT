namespace FlexiNEAT
{
    public class SumNode : ProcessingNode
    {
        public SumNode(ushort identifier, Func<double, double> activationFunc) : base(identifier, activationFunc) { }

        protected override double EvaluateNode(List<double> inputs)
        {
            return inputs.Sum();
        }
    }
}