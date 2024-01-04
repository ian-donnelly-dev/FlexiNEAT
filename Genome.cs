using System.Text.Json;

namespace FlexiNEAT
{
    public class Genome
    {
        public List<BaseNode> sortedNodes; // revert to private after further testing
        private readonly int numSensorNodes;
        private readonly int numOutputNodes;

        public Genome(InputNode[] inputNodes, ProcessingNode[] outputNodes)
        {
            sortedNodes = new List<BaseNode>();
            numSensorNodes = 0;

            foreach (InputNode inputNode in inputNodes)
            {
                if (inputNode.depth != 0)
                {
                    throw new ArgumentException("Input node must have a depth of 0.");
                }

                sortedNodes.Add(inputNode);

                if (inputNode is SensorNode)
                {
                    numSensorNodes++;
                }
            }

            foreach (ProcessingNode outputNode in outputNodes)
            {
                if (outputNode.depth != 1)
                {
                    throw new ArgumentException("Output node must have a depth of 1.");
                }

                sortedNodes.Add(outputNode);
            }
        }

        public Genome(string jsonState)
        {
            InitializeFromJson(jsonState); // todo
        }

        public void SetInputs(double[] inputs)
        {
            if (inputs.Length != numSensorNodes)
            {
                throw new ArgumentException("The number of inputs must match the number of sensor nodes.");
            }

            int sensorIndex = 0;
            foreach (BaseNode node in sortedNodes)
            {
                if (node is SensorNode)
                {
                    ((SensorNode)node).UpdateSensorValue(inputs[sensorIndex]);
                    sensorIndex++;
                    if (sensorIndex == numSensorNodes) break;
                }
            }
        }

        public void ResetNetwork()
        {
            foreach (BaseNode node in sortedNodes)
            {
                node.Reset();
            }
        }

        public double[] GetOutputs()
        {
            double[] outputs = new double[numOutputNodes];

            for (int i = 0; i < numOutputNodes; i++)
            {
                outputs[i] = sortedNodes[sortedNodes.Count - numOutputNodes + i].GetValue();
            }

            ResetNetwork();

            return outputs;
        }

        public string ExportState()
        {
            var nodeToIdMap = new Dictionary<BaseNode, int>();
            var jsonNodes = new List<object>();
            int idCounter = 1;

            foreach (var node in sortedNodes)
            {
                nodeToIdMap[node] = idCounter++;
            }

            foreach (var node in sortedNodes)
            {
                var nodeData = new Dictionary<string, object>
                {
                    ["id"] = nodeToIdMap[node],
                    ["type"] = node.GetType().Name,
                    ["depth"] = node.depth
                };

                if (node is ProcessingNode processingNode)
                {
                    nodeData["activationFunction"] = ActivationFunctions.GetFunctionName(processingNode.activationFunction);

                    if (processingNode.incomingSynapses.Count > 0)
                    {
                        nodeData["synapses"] = processingNode.incomingSynapses.Select(s => new { inputNodeId = nodeToIdMap[s.InputNode], weight = s.Weight });
                    }
                }
                else if (node is RandomNode randomNode)
                {
                    nodeData["min"] = randomNode.min;
                    nodeData["max"] = randomNode.max;
                }

                jsonNodes.Add(nodeData);
            }

            return JsonSerializer.Serialize(new { sortedNodes = jsonNodes }, new JsonSerializerOptions { WriteIndented = true });
        }
    }
}