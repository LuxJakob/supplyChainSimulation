namespace supplyChainSimulation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            p1_uploadXML = new Button();
            p1_desc = new Label();
            SuspendLayout();
            // 
            // p1_uploadXML
            // 
            p1_uploadXML.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            p1_uploadXML.Location = new Point(392, 358);
            p1_uploadXML.Name = "p1_uploadXML";
            p1_uploadXML.Size = new Size(129, 35);
            p1_uploadXML.TabIndex = 0;
            p1_uploadXML.Text = "Upload XML file";
            p1_uploadXML.UseVisualStyleBackColor = true;
            p1_uploadXML.Click += p1_uploadXML_Click;
            // 
            // p1_desc
            // 
            p1_desc.AutoSize = true;
            p1_desc.Location = new Point(374, 281);
            p1_desc.Name = "p1_desc";
            p1_desc.Size = new Size(179, 15);
            p1_desc.TabIndex = 1;
            p1_desc.Text = "Please upload your last result file";
            p1_desc.Click += p1_desc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 488);
            Controls.Add(p1_desc);
            Controls.Add(p1_uploadXML);
            Name = "Form1";
            Text = "Supply Chain Simulator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button p1_uploadXML;
        private Label p1_desc;
    }
}
