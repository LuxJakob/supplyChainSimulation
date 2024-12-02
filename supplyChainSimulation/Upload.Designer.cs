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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Upload));
            p1_desc = new Label();
            p1_uploadXML = new Button();
            switchToLieferProdProg = new Button();
            label1 = new Label();
            cmbLanguageChange = new ComboBox();
            SuspendLayout();
            // 
            // p1_desc
            // 
            resources.ApplyResources(p1_desc, "p1_desc");
            p1_desc.Name = "p1_desc";
            // 
            // p1_uploadXML
            // 
            resources.ApplyResources(p1_uploadXML, "p1_uploadXML");
            p1_uploadXML.Name = "p1_uploadXML";
            p1_uploadXML.UseVisualStyleBackColor = true;
            p1_uploadXML.Click += p1_uploadXML_Click;
            // 
            // switchToLieferProdProg
            // 
            resources.ApplyResources(switchToLieferProdProg, "switchToLieferProdProg");
            switchToLieferProdProg.Name = "switchToLieferProdProg";
            switchToLieferProdProg.UseVisualStyleBackColor = true;
            switchToLieferProdProg.Click += switchToLieferProdProg_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // cmbLanguageChange
            // 
            resources.ApplyResources(cmbLanguageChange, "cmbLanguageChange");
            cmbLanguageChange.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLanguageChange.FormattingEnabled = true;
            cmbLanguageChange.Items.AddRange(new object[] { resources.GetString("cmbLanguageChange.Items"), resources.GetString("cmbLanguageChange.Items1") });
            cmbLanguageChange.Name = "cmbLanguageChange";
            cmbLanguageChange.SelectedIndexChanged += cmbLanguageChange_SelectedIndexChanged;
            // 
            // Upload
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbLanguageChange);
            Controls.Add(label1);
            Controls.Add(switchToLieferProdProg);
            Controls.Add(p1_uploadXML);
            Controls.Add(p1_desc);
            Name = "Upload";
            Load += Upload_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label p1_desc;
        private Button p1_uploadXML;
        private Button switchToLieferProdProg;
        private Label label1;
        private ComboBox cmbLanguageChange;
    }
}