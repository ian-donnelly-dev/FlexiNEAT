namespace FlexiNEAT
{
    public abstract class ProcessingNode : BaseNode
    {
        protected List<double> inputValues;
        protected Func<double, double> ActivationFunction;

        protected ProcessingNode(ushort identifier, Func<double, double> activationFunc) : base(identifier)
        {
            ActivationFunction = activationFunc;
            inputValues = new List<double>();
        }

        public void AddInputValue(double inputValue)
        {
            inputValues.Add(inputValue);
        }

        public override void ComputeValue()
        {
            Value = ActivationFunction(EvaluateNode(inputValues));
        }

        protected abstract double EvaluateNode(List<double> inputs);
    }
}