namespace MongoDML.Components
{
    partial class UcVField
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.xTextBox1 = new MongoDML.Components.XTextBox();
            this.xLabel1 = new MongoDML.Components.XLabel();
            this.SuspendLayout();
            // 
            // xTextBox1
            // 
            this.xTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xTextBox1.Location = new System.Drawing.Point(12, 21);
            this.xTextBox1.Name = "xTextBox1";
            this.xTextBox1.Size = new System.Drawing.Size(133, 20);
            this.xTextBox1.TabIndex = 3;
            // 
            // xLabel1
            // 
            this.xLabel1.AutoSize = true;
            this.xLabel1.Location = new System.Drawing.Point(9, 5);
            this.xLabel1.Name = "xLabel1";
            this.xLabel1.Size = new System.Drawing.Size(44, 13);
            this.xLabel1.TabIndex = 2;
            this.xLabel1.Text = "xLabel1";
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xTextBox1);
            this.Controls.Add(this.xLabel1);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(153, 46);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XTextBox xTextBox1;
        private XLabel xLabel1;
    }
}
