namespace supplyChainSimulation
{
    partial class MaterialPlanning
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
            switchToLieferProdProg = new Button();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            labelcalc01 = new Label();
            label2 = new Label();
            label3 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // switchToLieferProdProg
            // 
            switchToLieferProdProg.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            switchToLieferProdProg.Location = new Point(12, 616);
            switchToLieferProdProg.Name = "switchToLieferProdProg";
            switchToLieferProdProg.Size = new Size(75, 23);
            switchToLieferProdProg.TabIndex = 5;
            switchToLieferProdProg.Text = "Back";
            switchToLieferProdProg.UseVisualStyleBackColor = true;
            switchToLieferProdProg.Click += switchToLieferProdProg_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(35, 25);
            label1.TabIndex = 6;
            label1.Text = "P1";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 14;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.Controls.Add(labelcalc01, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 1, 2);
            tableLayoutPanel1.Location = new Point(12, 37);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 12;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1400, 514);
            tableLayoutPanel1.TabIndex = 7;
            tableLayoutPanel1.Visible = false;
            // 
            // labelcalc01
            // 
            labelcalc01.AutoSize = true;
            labelcalc01.Location = new Point(103, 0);
            labelcalc01.Name = "labelcalc01";
            labelcalc01.Size = new Size(15, 15);
            labelcalc01.TabIndex = 0;
            labelcalc01.Text = "+";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 157);
            label2.Name = "label2";
            label2.Size = new Size(15, 15);
            label2.TabIndex = 1;
            label2.Text = "+";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 314);
            label3.Name = "label3";
            label3.Size = new Size(15, 15);
            label3.TabIndex = 2;
            label3.Text = "+";
            // 
            // MaterialPlanning
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1457, 651);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(switchToLieferProdProg);
            Name = "MaterialPlanning";
            Text = "Supply Chain Simulator - Material Planning";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button switchToLieferProdProg;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private Label labelcalc01;
        private Label label2;
    }
}