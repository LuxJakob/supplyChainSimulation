namespace supplyChainSimulation
{
    partial class SalesProduction
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
            switchMaterialP1 = new Button();
            switchToUpload = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // switchMaterialP1
            // 
            switchMaterialP1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            switchMaterialP1.Location = new Point(1365, 594);
            switchMaterialP1.Name = "switchMaterialP1";
            switchMaterialP1.Size = new Size(75, 23);
            switchMaterialP1.TabIndex = 5;
            switchMaterialP1.Text = "Next";
            switchMaterialP1.UseVisualStyleBackColor = true;
            switchMaterialP1.Click += switchMaterialP1_Click;
            // 
            // switchToUpload
            // 
            switchToUpload.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            switchToUpload.Location = new Point(12, 594);
            switchToUpload.Name = "switchToUpload";
            switchToUpload.Size = new Size(75, 23);
            switchToUpload.TabIndex = 6;
            switchToUpload.Text = "Back";
            switchToUpload.UseVisualStyleBackColor = true;
            switchToUpload.Click += switchToUpload_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(1428, 576);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 7;
            label1.Text = "Sales";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 192);
            label2.Name = "label2";
            label2.Size = new Size(113, 25);
            label2.TabIndex = 8;
            label2.Text = "Production";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 384);
            label3.Name = "label3";
            label3.Size = new Size(114, 25);
            label3.TabIndex = 9;
            label3.Text = "Direct Sales";
            // 
            // SalesProduction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1452, 629);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(switchToUpload);
            Controls.Add(switchMaterialP1);
            Name = "SalesProduction";
            Text = "Supply Chain Simulator - Sales & Production Program";
            Load += SalesProduction_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button switchMaterialP1;
        private Button switchToUpload;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}