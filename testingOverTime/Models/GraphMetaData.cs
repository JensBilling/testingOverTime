namespace testingOverTime.Models
{
    public class GraphMetaData
    {
        public string  GraphName { get; set; }
        public string  XAxisName { get; set; }
        public string  YAxisName { get; set; }

        public GraphMetaData(string graphName, string xAxisName, string yAxisName)
        {
            GraphName = graphName;
            XAxisName = xAxisName;
            YAxisName = yAxisName;
        }
    }
}