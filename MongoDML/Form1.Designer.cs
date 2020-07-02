namespace MongoDML
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
            this.ucVField1 = new MongoDML.Components.UcVField();
            this.ucVField2 = new MongoDML.Components.UcVField();
            this.ucVField3 = new MongoDML.Components.UcVField();
            this.ucVField4 = new MongoDML.Components.UcVField();
            this.xTextBox1 = new MongoDML.Components.XTextBox();
            this.btnAdicionar = new MongoDML.Components.XButton();
            this.xCheckBox1 = new MongoDML.Components.XCheckBox();
            this.SuspendLayout();
            // 
            // ucVField1
            // 
            this.ucVField1.FieldContent = "";
            this.ucVField1.LabelText = "HOST";
            this.ucVField1.Location = new System.Drawing.Point(13, 13);
            this.ucVField1.Name = "ucVField1";
            this.ucVField1.Size = new System.Drawing.Size(153, 46);
            this.ucVField1.TabIndex = 0;
            // 
            // ucVField2
            // 
            this.ucVField2.FieldContent = "";
            this.ucVField2.LabelText = "PORT";
            this.ucVField2.Location = new System.Drawing.Point(172, 13);
            this.ucVField2.Name = "ucVField2";
            this.ucVField2.Size = new System.Drawing.Size(77, 46);
            this.ucVField2.TabIndex = 1;
            // 
            // ucVField3
            // 
            this.ucVField3.FieldContent = "";
            this.ucVField3.LabelText = "DATABASE";
            this.ucVField3.Location = new System.Drawing.Point(255, 12);
            this.ucVField3.Name = "ucVField3";
            this.ucVField3.Size = new System.Drawing.Size(153, 46);
            this.ucVField3.TabIndex = 2;
            // 
            // ucVField4
            // 
            this.ucVField4.FieldContent = "";
            this.ucVField4.LabelText = "COLLECTION";
            this.ucVField4.Location = new System.Drawing.Point(414, 12);
            this.ucVField4.Name = "ucVField4";
            this.ucVField4.Size = new System.Drawing.Size(153, 46);
            this.ucVField4.TabIndex = 3;
            // 
            // xTextBox1
            // 
            this.xTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xTextBox1.Location = new System.Drawing.Point(26, 66);
            this.xTextBox1.Multiline = true;
            this.xTextBox1.Name = "xTextBox1";
            this.xTextBox1.Size = new System.Drawing.Size(534, 146);
            this.xTextBox1.TabIndex = 4;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionar.Location = new System.Drawing.Point(485, 218);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 5;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // xCheckBox1
            // 
            this.xCheckBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.xCheckBox1.AutoSize = true;
            this.xCheckBox1.Checked = true;
            this.xCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.xCheckBox1.Location = new System.Drawing.Point(259, 222);
            this.xCheckBox1.Name = "xCheckBox1";
            this.xCheckBox1.Size = new System.Drawing.Size(220, 17);
            this.xCheckBox1.TabIndex = 20;
            this.xCheckBox1.Text = "Solicitar confirmação antes de adicionar?";
            this.xCheckBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 251);
            this.Controls.Add(this.xCheckBox1);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.xTextBox1);
            this.Controls.Add(this.ucVField4);
            this.Controls.Add(this.ucVField3);
            this.Controls.Add(this.ucVField2);
            this.Controls.Add(this.ucVField1);
            this.Name = "Form1";
            this.Text = "MongoDML";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.UcVField ucVField1;
        private Components.UcVField ucVField2;
        private Components.UcVField ucVField3;
        private Components.UcVField ucVField4;
        private Components.XTextBox xTextBox1;
        private Components.XButton btnAdicionar;
        private Components.XCheckBox xCheckBox1;
    }
}

