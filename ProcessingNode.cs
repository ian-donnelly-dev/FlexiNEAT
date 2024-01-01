namespace FlexiNEAT
{
    public abstract class ProcessingNode : BaseNode
    {
        protected List<double> inputValues;
        protected Func<double, double> activationFunction;

        protected ProcessingNode(byte depth, Func<double, double> activationFunc) : base(depth)
        {
            activationFunction = activationFunc;
            inputValues = new List<double>();
        }

        public void AddInputValue(double inputValue)
        {
            inputValues.Add(inputValue);
        }

        protected override double ComputeValue()
        {
            return activationFunction(EvaluateNode(inputValues));
        }

        protected abstract double EvaluateNode(List<double> inputs);

        public override void Reset()
        {
            base.Reset();
            inputValues.Clear();
        }
    }
}