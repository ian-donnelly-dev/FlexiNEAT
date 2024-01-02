namespace FlexiNEAT
{
    public abstract class OutputProcessingNode : BaseNode
    {
        protected List<Synapse> incomingSynapses;
        protected Func<double, double> activationFunction;

        protected OutputProcessingNode(Func<double, double> activationFunc) : base(1)
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