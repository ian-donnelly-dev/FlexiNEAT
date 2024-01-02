namespace FlexiNEAT
{
    public class HiddenSumNode : HiddenProcessingNode
    {
        public HiddenSumNode(float depth, Func<double, double> activationFunc) : base(depth, activationFunc) { }

        protected override double AggregateInput(List<Synapse> inputs)
        {
            return inputs.Sum(synapse => synapse.InputNode.GetValue() * synapse.Weight);
        }
    }
}