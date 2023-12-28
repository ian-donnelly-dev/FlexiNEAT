namespace FlexiNEAT
{
    public abstract class ProcessingNode : BaseNode
    {
        protected List<double> inputValues;
        protected Func<double, double> activationFunction;

        protected ProcessingNode(Func<double, double> activationFunc)
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
    }
}