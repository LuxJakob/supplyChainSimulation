namespace supplyChainSimulation
{
    partial class BuildXML
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuildXML));
            label1 = new Label();
            p1_uploadXML = new Button();
            p1_desc = new Label();
            switchPurchasePartDisposition = new Button();
            panel1 = new Panel();
            hack_lol = new RadioButton();
            hack_ram = new RadioButton();
            hack_script = new RadioButton();
            warningText = new Label();
            hack_nope = new RadioButton();
            label2 = new Label();
            warningLabel = new LinkLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // p1_uploadXML
            // 
            resources.ApplyResources(p1_uploadXML, "p1_uploadXML");
            p1_uploadXML.Name = "p1_uploadXML";
            p1_uploadXML.UseVisualStyleBackColor = true;
            p1_uploadXML.Click += p1_uploadXML_Click;
            // 
            // p1_desc
            // 
            resources.ApplyResources(p1_desc, "p1_desc");
            p1_desc.Name = "p1_desc";
            p1_desc.Click += p1_desc_Click;
            // 
            // switchPurchasePartDisposition
            // 
            switchPurchasePartDisposition.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            switchPurchasePartDisposition.Location = new Point(12, 415);
            switchPurchasePartDisposition.Name = "switchPurchasePartDisposition";
            switchPurchasePartDisposition.Size = new Size(75, 23);
            switchPurchasePartDisposition.TabIndex = 11;
            switchPurchasePartDisposition.Text = "Back";
            switchPurchasePartDisposition.UseVisualStyleBackColor = true;
            switchPurchasePartDisposition.Click += switchPurchasePartDisposition_Click;
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.Controls.Add(warningLabel);
            panel1.Controls.Add(hack_nope);
            panel1.Controls.Add(warningText);
            panel1.Controls.Add(hack_script);
            panel1.Controls.Add(hack_ram);
            panel1.Controls.Add(hack_lol);
            panel1.Name = "panel1";
            // 
            // hack_lol
            // 
            warningLabel.Anchor = AnchorStyles.Right;
            warningLabel.Location = new Point(521, 72);
            warningLabel.Name = "warningLabel";
            warningLabel.Size = new Size(252, 55);
            warningLabel.TabIndex = 4;
            warningLabel.TabStop = true;
            warningLabel.Text = "WARNING!";
            warningLabel.TextAlign = ContentAlignment.MiddleCenter;
            warningLabel.Visible = false;
            warningLabel.LinkClicked += warningLabel_LinkClicked;
            // 
            // hack_nope
            // 
            // hack_ram
            // 
            hack_ram.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            hack_ram.AutoSize = true;
            hack_ram.Location = new Point(327, 28);
            hack_ram.Margin = new Padding(250, 3, 3, 3);
            hack_ram.Name = "hack_ram";
            hack_ram.Size = new Size(134, 19);
            hack_ram.TabIndex = 1;
            hack_ram.Text = "Resource Exhaustion";
            hack_ram.UseVisualStyleBackColor = true;
            hack_ram.CheckedChanged += considerHacking;
            hack_ram.Click += considerHacking;
            hack_ram.KeyPress += considerHacking;
            hack_ram.MouseClick += considerHacking;
            // 
            // hack_script
            // 
            resources.ApplyResources(hack_script, "hack_script");
            hack_script.Name = "hack_script";
            hack_script.UseVisualStyleBackColor = true;
            hack_script.CheckedChanged += considerHacking;
            hack_script.Click += considerHacking;
            hack_script.KeyPress += considerHacking;
            hack_script.MouseClick += considerHacking;
            // 
            // warningText
            // 
            warningText.Anchor = AnchorStyles.Right;
            warningText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            warningText.ForeColor = Color.Red;
            warningText.Location = new Point(521, 0);
            warningText.Name = "warningText";
            warningText.Size = new Size(252, 72);
            warningText.TabIndex = 5;
            warningText.Text = "label3";
            warningText.TextAlign = ContentAlignment.MiddleCenter;
            warningText.Visible = false;
            // 
            // hack_nope
            // 
            hack_nope.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            hack_nope.AutoSize = true;
            hack_nope.Checked = true;
            hack_nope.Location = new Point(327, 78);
            hack_nope.Margin = new Padding(250, 3, 3, 3);
            hack_nope.Name = "hack_nope";
            hack_nope.Size = new Size(115, 19);
            hack_nope.TabIndex = 3;
            hack_nope.TabStop = true;
            hack_nope.Text = "Maybe not today";
            hack_nope.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            label2.Size = new Size(776, 25);
            label2.TabIndex = 10;
            label2.Text = "Wanna include something malicious?";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Visible = false;
            // 
            // warningLabel
            // 
            warningLabel.Anchor = AnchorStyles.Right;
            warningLabel.Location = new Point(521, 72);
            warningLabel.Name = "warningLabel";
            warningLabel.Size = new Size(252, 55);
            warningLabel.TabIndex = 4;
            warningLabel.TabStop = true;
            warningLabel.Text = "WARNING!";
            warningLabel.TextAlign = ContentAlignment.MiddleCenter;
            warningLabel.Visible = false;
            warningLabel.LinkClicked += warningLabel_LinkClicked;
            // 
            // BuildXML
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(switchPurchasePartDisposition);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(p1_uploadXML);
            Controls.Add(p1_desc);
            Name = "BuildXML";
            Load += BuildXML_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button p1_uploadXML;
        private Label p1_desc;
        private Button switchPurchasePartDisposition;
        private Panel panel1;
        private LinkLabel warningLabel;
        private RadioButton hack_nope;
        private Label warningText;
        private RadioButton hack_script;
        private RadioButton hack_ram;
        private RadioButton hack_lol;
        private Label label2;
    }
}