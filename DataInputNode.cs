namespace FlexiNEAT
{
    public class DataInputNode : BaseNode
    {
        private double inputValue;

        public DataInputNode(byte depth) : base(depth) { }

        public void SetInputValue(double inputValue)
        {
            this.inputValue = inputValue;
        }

        protected override double ComputeValue()
        {
            return inputValue;
        }
    }
}