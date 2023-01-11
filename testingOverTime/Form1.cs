using System;
using System.Windows.Forms;
using testingOverTime.Controls;
using testingOverTime.GraphLibraries;
using testingOverTime.Models;

namespace testingOverTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GraphSelectorControl graphSelectorControl = new GraphSelectorControl();
            graphSelectorControl.Name = textBox1.Text;
            graphSelectorControl.Controls.Find("graphNameLabel", false)[0].Text = textBox1.Text;
            sidePanel.Controls.Add(graphSelectorControl);

            Panel graphPanelContainer = new Panel();
            graphPanelContainer.BorderStyle = BorderStyle.FixedSingle;
            graphPanelContainer.Size = new System.Drawing.Size(250, 180);

            GraphMetaData graphMetaData = new GraphMetaData(textBox1.Text, "Wavelength (nm)","Counts");
            
            // Type of IGraphLib could be set based on function chosen by user in UI or something
            IGraphLib graphLib = new ZedGraphGraphLib();
            GraphControlObject.GraphControlObject graphControlObject = new GraphControlObject.GraphControlObject(graphPanelContainer, graphMetaData, graphLib);
            
            graphControlObject.Init();

            graphPanel.Controls.Add(graphPanelContainer);
        }
    }
}