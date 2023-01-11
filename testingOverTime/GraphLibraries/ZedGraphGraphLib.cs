using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace testingOverTime.GraphLibraries
{
    public class ZedGraphGraphLib : IGraphLib
    {
        public UserControl GetGraphLibImplementation(string graphName, string yAxisName, string xAxisName)
        {
            ZedGraph.ZedGraphControl zedGraphControl = new ZedGraphControl();
            
            zedGraphControl.Location = new System.Drawing.Point(3, 3);
            zedGraphControl.Name = "graphName";
            zedGraphControl.ScrollGrace = 0D;
            zedGraphControl.ScrollMaxX = 0D;
            zedGraphControl.ScrollMaxY = 0D;
            zedGraphControl.ScrollMaxY2 = 0D;
            zedGraphControl.ScrollMinX = 0D;
            zedGraphControl.ScrollMinY = 0D;
            zedGraphControl.ScrollMinY2 = 0D;
            zedGraphControl.Size = new System.Drawing.Size(405, 299);
            zedGraphControl.TabIndex = 0;
            zedGraphControl.UseExtendedPrintDialog = true;
            zedGraphControl.Size = new System.Drawing.Size(250, 180);
            zedGraphControl.Location = new Point(0, 0);
            zedGraphControl.GraphPane.Title.Text = graphName;
            zedGraphControl.GraphPane.YAxis.Title.Text = yAxisName;
            zedGraphControl.GraphPane.XAxis.Title.Text = xAxisName;

            return zedGraphControl;
        }
    }
}