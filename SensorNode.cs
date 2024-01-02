namespace FlexiNEAT
{
    public class SensorNode : InputNode
    {
        private double sensorValue;

        public SensorNode() : base()
        {
            sensorValue = 0;
        }

        public void UpdateSensorValue(double newValue)
        {
            sensorValue = newValue;
        }

        protected override double ComputeValue()
        {
            return sensorValue;
        }
    }
}