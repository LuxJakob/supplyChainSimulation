namespace supplyChainSimulation
{
    partial class Upload
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
            p1_desc = new Label();
            p1_uploadXML = new Button();
            switchToLieferProdProg = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // p1_desc
            // 
            p1_desc.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            p1_desc.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            p1_desc.Location = new Point(17, 417);
            p1_desc.Margin = new Padding(4, 0, 4, 0);
            p1_desc.Name = "p1_desc";
            p1_desc.Size = new Size(1109, 42);
            p1_desc.TabIndex = 2;
            p1_desc.Text = "Please upload your last result file:";
            p1_desc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // p1_uploadXML
            // 
            p1_uploadXML.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            p1_uploadXML.Location = new Point(469, 505);
            p1_uploadXML.Margin = new Padding(4, 5, 4, 5);
            p1_uploadXML.Name = "p1_uploadXML";
            p1_uploadXML.Size = new Size(184, 58);
            p1_uploadXML.TabIndex = 3;
            p1_uploadXML.Text = "Upload XML file";
            p1_uploadXML.UseVisualStyleBackColor = true;
            p1_uploadXML.Click += p1_uploadXML_Click;
            // 
            // switchToLieferProdProg
            // 
            switchToLieferProdProg.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            switchToLieferProdProg.Enabled = false;
            switchToLieferProdProg.Location = new Point(1019, 692);
            switchToLieferProdProg.Margin = new Padding(4, 5, 4, 5);
            switchToLieferProdProg.Name = "switchToLieferProdProg";
            switchToLieferProdProg.Size = new Size(107, 38);
            switchToLieferProdProg.TabIndex = 4;
            switchToLieferProdProg.Text = "Next";
            switchToLieferProdProg.UseVisualStyleBackColor = true;
            switchToLieferProdProg.Click += switchToLieferProdProg_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 63);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1109, 67);
            label1.TabIndex = 5;
            label1.Text = "SCS - Supply Chain Simulator";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Upload
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1143, 750);
            Controls.Add(label1);
            Controls.Add(switchToLieferProdProg);
            Controls.Add(p1_uploadXML);
            Controls.Add(p1_desc);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Upload";
            Text = "Supply Chain Simulator - Upload";
            Load += Upload_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label p1_desc;
        private Button p1_uploadXML;
        private Button switchToLieferProdProg;
        private Label label1;
    }
}