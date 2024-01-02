namespace FlexiNEAT
{
    public class OutputSumNode : OutputProcessingNode
    {
        public OutputSumNode(Func<double, double> activationFunc) : base(activationFunc) { }

        protected override double AggregateInput(List<Synapse> inputs)
        {
            return inputs.Sum(synapse => synapse.InputNode.GetValue() * synapse.Weight);
        }
    }
}