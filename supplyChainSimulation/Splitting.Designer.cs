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
            SplitInput = new TextBox();
            SuspendLayout();
            // 
            // SwitchSplitterNext
            // 
            SwitchSplitterNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SwitchSplitterNext.Location = new Point(1536, 1284);
            SwitchSplitterNext.Name = "SwitchSplitterNext";
            SwitchSplitterNext.Size = new Size(112, 34);
            SwitchSplitterNext.TabIndex = 0;
            SwitchSplitterNext.Text = "Next";
            SwitchSplitterNext.UseVisualStyleBackColor = true;
            SwitchSplitterNext.Click += switchCapacityPlanning_Click;
            // 
            // SwitchSplitterBack
            // 
            SwitchSplitterBack.Location = new Point(12, 1284);
            SwitchSplitterBack.Name = "SwitchSplitterBack";
            SwitchSplitterBack.Size = new Size(112, 34);
            SwitchSplitterBack.TabIndex = 1;
            SwitchSplitterBack.Text = "Back";
            SwitchSplitterBack.UseVisualStyleBackColor = true;
            SwitchSplitterBack.Click += switchMaterialPlanningP3_Click;
            // 
            // Split
            // 
            Split.Location = new Point(1165, 346);
            Split.Name = "Split";
            Split.Size = new Size(112, 34);
            Split.TabIndex = 3;
            Split.Text = "Split";
            Split.UseVisualStyleBackColor = true;
            Split.Click += Split_Click;
            // 
            // deleteSplit
            // 
            deleteSplit.Location = new Point(1165, 402);
            deleteSplit.Name = "deleteSplit";
            deleteSplit.Size = new Size(112, 34);
            deleteSplit.TabIndex = 5;
            deleteSplit.Text = "Delete";
            deleteSplit.UseVisualStyleBackColor = true;
            // 
            // articelListView
            // 
            articelListView.FullRowSelect = true;
            articelListView.Location = new Point(27, 28);
            articelListView.Name = "articelListView";
            articelListView.Size = new Size(979, 1203);
            articelListView.Sorting = SortOrder.Ascending;
            articelListView.TabIndex = 7;
            articelListView.UseCompatibleStateImageBehavior = false;
            articelListView.View = View.Details;
            // 
            // SplitInput
            // 
            SplitInput.Location = new Point(1165, 290);
            SplitInput.Name = "SplitInput";
            SplitInput.Size = new Size(112, 31);
            SplitInput.TabIndex = 8;
            // 
            // Splitting
            // 
            ClientSize = new Size(2308, 1431);
            Controls.Add(SplitInput);
            Controls.Add(articelListView);
            Controls.Add(deleteSplit);
            Controls.Add(Split);
            Controls.Add(SwitchSplitterBack);
            Controls.Add(SwitchSplitterNext);
            Name = "Splitting";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button SwitchSplitterNext;
        private Button SwitchSplitterBack;
        private Button Split;
        private Button deleteSplit;
        private ListView articelListView;
        private TextBox SplitInput;
    }
}