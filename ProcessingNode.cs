namespace FlexiNEAT
{
    public abstract class ProcessingNode : BaseNode
    {
        protected List<Synapse> incomingSynapses;
        protected Func<double, double> activationFunction;

        protected ProcessingNode(Func<double, double> activationFunc = null, float? depth = null) : base(depth ?? 1.0f)
        {
            activationFunction = activationFunc ?? ActivationFunctions.LinearIdentity;
            incomingSynapses = new List<Synapse>();
        }

        public void AddSynapse(Synapse synapse)
        {
            incomingSynapses.Add(synapse);
        }

        protected override double ComputeValue()
        {
            return activationFunction(AggregateInput(incomingSynapses));
        }

        protected abstract double AggregateInput(List<Synapse> inputs);
    }
}