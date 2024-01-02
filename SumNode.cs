namespace FlexiNEAT
{
    public class SumNode : ProcessingNode
    {
        public SumNode(Func<double, double> activationFunc = null, float? depth = null) : base(activationFunc, depth) { }

        protected override double AggregateInput(List<Synapse> inputs)
        {
            return inputs.Sum(synapse => synapse.InputNode.GetValue() * synapse.Weight);
        }
    }
}