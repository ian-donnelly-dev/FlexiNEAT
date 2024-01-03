namespace FlexiNEAT
{
    public class MeanNode : ProcessingNode
    {
        public MeanNode(Func<double, double> activationFunc = null, double? depth = null) : base(activationFunc, depth) { }

        protected override double AggregateInput(List<Synapse> inputs)
        {
            return inputs.Sum(synapse => synapse.InputNode.GetValue() * synapse.Weight) / inputs.Count;
        }
    }
}