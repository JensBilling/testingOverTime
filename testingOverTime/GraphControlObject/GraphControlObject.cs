using System.Collections.Generic;
using System.Windows.Forms;
using testingOverTime.GraphLibraries;
using testingOverTime.Models;
using ZedGraph;

namespace testingOverTime.GraphControlObject
{
    public class GraphControlObject
    {
        private Panel container;
        private Dictionary<double, double> data;
        private IGraphLib graphLib;
        private string graphName;
        private string yAxisName;
        private string xAxisName;

        public GraphControlObject(Panel container, GraphMetaData graphMetaData, IGraphLib graphLib)
        {
            this.container = container;
            graphName = graphMetaData.GraphName;
            yAxisName = graphMetaData.YAxisName;
            xAxisName = graphMetaData.XAxisName;
            this.graphLib = graphLib;
        }

        public void SetData(Dictionary<double, double> data)
        {
            this.data = data;
        }

        public void Init()
        {
            UserControl userControl =  graphLib.GetGraphLibImplementation(graphName, yAxisName, xAxisName);
            container.Controls.Add(userControl);
        }
    }
}