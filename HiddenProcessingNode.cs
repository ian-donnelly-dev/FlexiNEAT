namespace FlexiNEAT
{
    public abstract class HiddenProcessingNode : BaseNode
    {
        protected List<Synapse> incomingSynapses;
        protected Func<double, double> activationFunction;

        protected HiddenProcessingNode(float depth, Func<double, double> activationFunc) : base(depth)
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