namespace supplyChainSimulation
{
    partial class Splitting
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


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SwitchSplitterNext = new Button();
            SwitchSplitterBack = new Button();
            Split = new Button();
            deleteSplit = new Button();
            articelListView = new ListView();
            SplitInput = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)SplitInput).BeginInit();
            SuspendLayout();
            // 
            // SwitchSplitterNext
            // 
            SwitchSplitterNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SwitchSplitterNext.Location = new Point(1800, 1015);
            SwitchSplitterNext.Name = "SwitchSplitterNext";
            SwitchSplitterNext.Size = new Size(112, 34);
            SwitchSplitterNext.TabIndex = 0;
            SwitchSplitterNext.Text = "Next";
            SwitchSplitterNext.UseVisualStyleBackColor = true;
            SwitchSplitterNext.Click += switchCapacityPlanning_Click;
            // 
            // SwitchSplitterBack
            // 
            SwitchSplitterBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SwitchSplitterBack.Location = new Point(12, 1015);
            SwitchSplitterBack.Name = "SwitchSplitterBack";
            SwitchSplitterBack.Size = new Size(112, 34);
            SwitchSplitterBack.TabIndex = 1;
            SwitchSplitterBack.Text = "Back";
            SwitchSplitterBack.UseVisualStyleBackColor = true;
            SwitchSplitterBack.Click += switchMaterialPlanningP3_Click;
            // 
            // Split
            // 
            Split.Location = new Point(464, 199);
            Split.Margin = new Padding(15, 15, 3, 3);
            Split.Name = "Split";
            Split.Size = new Size(112, 34);
            Split.TabIndex = 3;
            Split.Text = "Split";
            Split.UseVisualStyleBackColor = true;
            Split.Click += Split_Click;
            // 
            // deleteSplit
            // 
            deleteSplit.Location = new Point(464, 251);
            deleteSplit.Margin = new Padding(15, 15, 3, 3);
            deleteSplit.Name = "deleteSplit";
            deleteSplit.Size = new Size(112, 34);
            deleteSplit.TabIndex = 5;
            deleteSplit.Text = "Delete";
            deleteSplit.UseVisualStyleBackColor = true;
            deleteSplit.Click += deleteSplit_Click;
            // 
            // articelListView
            // 
            articelListView.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            articelListView.FullRowSelect = true;
            articelListView.Location = new Point(27, 28);
            articelListView.Name = "articelListView";
            articelListView.Size = new Size(419, 882);
            articelListView.Sorting = SortOrder.Ascending;
            articelListView.TabIndex = 7;
            articelListView.UseCompatibleStateImageBehavior = false;
            articelListView.View = View.Details;
            // 
            // SplitInput
            // 
            SplitInput.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            SplitInput.Location = new Point(464, 158);
            SplitInput.Margin = new Padding(15, 3, 3, 3);
            SplitInput.Name = "SplitInput";
            SplitInput.Size = new Size(112, 23);
            SplitInput.TabIndex = 9;
            // 
            // Splitting
            // 
            ClientSize = new Size(1924, 1061);
            Controls.Add(SplitInput);
            Controls.Add(articelListView);
            Controls.Add(deleteSplit);
            Controls.Add(Split);
            Controls.Add(SwitchSplitterBack);
            Controls.Add(SwitchSplitterNext);
            Name = "Splitting";
            ((System.ComponentModel.ISupportInitialize)SplitInput).EndInit();
            ResumeLayout(false);
        }

        private Button SwitchSplitterNext;
        private Button SwitchSplitterBack;
        private Button Split;
        private Button deleteSplit;
        private ListView articelListView;
        private NumericUpDown SplitInput;
    }
}