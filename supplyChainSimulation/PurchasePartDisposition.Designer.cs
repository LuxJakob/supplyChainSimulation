namespace supplyChainSimulation
{
    partial class PurchasePartDisposition
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
            switchCapacityPlanning = new Button();
            switchBuildXML = new Button();
            SuspendLayout();
            // 
            // switchCapacityPlanning
            // 
            switchCapacityPlanning.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            switchCapacityPlanning.Location = new Point(12, 415);
            switchCapacityPlanning.Name = "switchCapacityPlanning";
            switchCapacityPlanning.Size = new Size(75, 23);
            switchCapacityPlanning.TabIndex = 12;
            switchCapacityPlanning.Text = "Back";
            switchCapacityPlanning.UseVisualStyleBackColor = true;
            switchCapacityPlanning.Click += switchCapacityPlanning_Click;
            // 
            // switchBuildXML
            // 
            switchBuildXML.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            switchBuildXML.Location = new Point(713, 415);
            switchBuildXML.Name = "switchBuildXML";
            switchBuildXML.Size = new Size(75, 23);
            switchBuildXML.TabIndex = 13;
            switchBuildXML.Text = "Next";
            switchBuildXML.UseVisualStyleBackColor = true;
            switchBuildXML.Click += switchBuildXML_Click;
            // 
            // PurchasePartDisposition
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(switchBuildXML);
            Controls.Add(switchCapacityPlanning);
            Name = "PurchasePartDisposition";
            Text = "Supply Chain Simulator - Purchase Part Disposition";
            ResumeLayout(false);
        }

        #endregion

        private Button switchCapacityPlanning;
        private Button switchBuildXML;
    }
}