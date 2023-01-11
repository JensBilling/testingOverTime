using System.Windows.Forms;

namespace testingOverTime.GraphLibraries
{
    public interface IGraphLib
    {
        UserControl GetGraphLibImplementation(string graphName, string yAxisName, string xAxisName);
    }
}