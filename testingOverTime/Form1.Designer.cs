namespace testingOverTime
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.graphPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.sidePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.graphPanel.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // graphPanel
            // 
            this.graphPanel.Location = new System.Drawing.Point(12, 12);
            this.graphPanel.Name = "graphPanel";
            this.graphPanel.Size = new System.Drawing.Size(720, 537);
            this.graphPanel.TabIndex = 0;
            // 
            // sidePanel
            // 
            this.sidePanel.Controls.Add(this.textBox1);
            this.sidePanel.Controls.Add(this.button1);
            this.sidePanel.Location = new System.Drawing.Point(738, 12);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(234, 537);
            this.sidePanel.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 26);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 74);
            this.button1.TabIndex = 0;
            this.button1.Text = "New graph";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.graphPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.graphPanel.ResumeLayout(false);
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.FlowLayoutPanel graphPanel;
        private System.Windows.Forms.FlowLayoutPanel sidePanel;

        #endregion
    }
}