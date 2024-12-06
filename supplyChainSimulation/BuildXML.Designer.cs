﻿namespace supplyChainSimulation
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
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(776, 40);
            label1.TabIndex = 8;
            label1.Text = "PPS - Production Planning System";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // p1_uploadXML
            // 
            p1_uploadXML.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            p1_uploadXML.Location = new Point(328, 340);
            p1_uploadXML.Name = "p1_uploadXML";
            p1_uploadXML.Size = new Size(129, 35);
            p1_uploadXML.TabIndex = 7;
            p1_uploadXML.Text = "Download XML file";
            p1_uploadXML.UseVisualStyleBackColor = true;
            p1_uploadXML.Click += p1_uploadXML_Click;
            // 
            // p1_desc
            // 
            p1_desc.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            p1_desc.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            p1_desc.Location = new Point(12, 287);
            p1_desc.Name = "p1_desc";
            p1_desc.Size = new Size(776, 25);
            p1_desc.TabIndex = 6;
            p1_desc.Text = "Get your finished XML file:";
            p1_desc.TextAlign = ContentAlignment.MiddleCenter;
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
            panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(warningLabel);
            panel1.Controls.Add(hack_nope);
            panel1.Controls.Add(warningText);
            panel1.Controls.Add(hack_script);
            panel1.Controls.Add(hack_ram);
            panel1.Controls.Add(hack_lol);
            panel1.Location = new Point(12, 134);
            panel1.Margin = new Padding(3, 3, 20, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(759, 150);
            panel1.TabIndex = 9;
            panel1.Visible = false;
            // 
            // warningLabel
            // 
            warningLabel.Anchor = AnchorStyles.Right;
            warningLabel.Location = new Point(504, 83);
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
            hack_nope.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            hack_nope.AutoSize = true;
            hack_nope.Checked = true;
            hack_nope.Location = new Point(327, 89);
            hack_nope.Margin = new Padding(250, 3, 3, 3);
            hack_nope.Name = "hack_nope";
            hack_nope.Size = new Size(115, 19);
            hack_nope.TabIndex = 3;
            hack_nope.TabStop = true;
            hack_nope.Text = "Maybe not today";
            hack_nope.UseVisualStyleBackColor = true;
            // 
            // warningText
            // 
            warningText.Anchor = AnchorStyles.Right;
            warningText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            warningText.ForeColor = Color.Red;
            warningText.Location = new Point(504, 11);
            warningText.Name = "warningText";
            warningText.Size = new Size(252, 72);
            warningText.TabIndex = 5;
            warningText.Text = "label3";
            warningText.TextAlign = ContentAlignment.MiddleCenter;
            warningText.Visible = false;
            // 
            // hack_script
            // 
            hack_script.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            hack_script.AutoSize = true;
            hack_script.Location = new Point(327, 64);
            hack_script.Margin = new Padding(250, 3, 3, 3);
            hack_script.Name = "hack_script";
            hack_script.Size = new Size(102, 19);
            hack_script.TabIndex = 2;
            hack_script.Text = "Code Injection";
            hack_script.UseVisualStyleBackColor = true;
            hack_script.CheckedChanged += considerHacking;
            hack_script.Click += considerHacking;
            hack_script.KeyPress += considerHacking;
            hack_script.MouseClick += considerHacking;
            // 
            // hack_ram
            // 
            hack_ram.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            hack_ram.AutoSize = true;
            hack_ram.Location = new Point(327, 39);
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
            // hack_lol
            // 
            hack_lol.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            hack_lol.AutoSize = true;
            hack_lol.Location = new Point(327, 14);
            hack_lol.Margin = new Padding(250, 3, 3, 3);
            hack_lol.Name = "hack_lol";
            hack_lol.Size = new Size(136, 19);
            hack_lol.TabIndex = 0;
            hack_lol.Text = "Billion Laughs Attack";
            hack_lol.UseVisualStyleBackColor = true;
            hack_lol.CheckedChanged += considerHacking;
            hack_lol.Click += considerHacking;
            hack_lol.KeyPress += considerHacking;
            hack_lol.MouseClick += considerHacking;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 106);
            label2.Name = "label2";
            label2.Size = new Size(776, 25);
            label2.TabIndex = 10;
            label2.Text = "Wanna include something malicious?";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Visible = false;
            // 
            // BuildXML
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(switchPurchasePartDisposition);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(p1_uploadXML);
            Controls.Add(p1_desc);
            Name = "BuildXML";
            Text = "Production Planning System - Build XML";
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