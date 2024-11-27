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
            warningLabel = new LinkLabel();
            hack_nope = new RadioButton();
            warningText = new Label();
            hack_script = new RadioButton();
            hack_ram = new RadioButton();
            hack_lol = new RadioButton();
            label2 = new Label();
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
            resources.ApplyResources(switchPurchasePartDisposition, "switchPurchasePartDisposition");
            switchPurchasePartDisposition.Name = "switchPurchasePartDisposition";
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
            // warningLabel
            // 
            resources.ApplyResources(warningLabel, "warningLabel");
            warningLabel.Name = "warningLabel";
            warningLabel.TabStop = true;
            warningLabel.LinkClicked += warningLabel_LinkClicked;
            // 
            // hack_nope
            // 
            resources.ApplyResources(hack_nope, "hack_nope");
            hack_nope.Checked = true;
            hack_nope.Name = "hack_nope";
            hack_nope.TabStop = true;
            hack_nope.UseVisualStyleBackColor = true;
            // 
            // warningText
            // 
            resources.ApplyResources(warningText, "warningText");
            warningText.ForeColor = Color.Red;
            warningText.Name = "warningText";
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
            // hack_ram
            // 
            resources.ApplyResources(hack_ram, "hack_ram");
            hack_ram.Name = "hack_ram";
            hack_ram.UseVisualStyleBackColor = true;
            hack_ram.CheckedChanged += considerHacking;
            hack_ram.Click += considerHacking;
            hack_ram.KeyPress += considerHacking;
            hack_ram.MouseClick += considerHacking;
            // 
            // hack_lol
            // 
            resources.ApplyResources(hack_lol, "hack_lol");
            hack_lol.Name = "hack_lol";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
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