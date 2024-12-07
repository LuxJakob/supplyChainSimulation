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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splitting));
            SwitchSplitterNext = new Button();
            SwitchSplitterBack = new Button();
            Split = new Button();
            deleteSplit = new Button();
            articelListView = new ListView();
            SplitInput = new NumericUpDown();
            PrioHigher = new Button();
            PrioLower = new Button();
            SortSplitingList = new Button();
            ((System.ComponentModel.ISupportInitialize)SplitInput).BeginInit();
            SuspendLayout();
            // 
            // SwitchSplitterNext
            // 
            SwitchSplitterNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SwitchSplitterNext.Location = new Point(1370, 1026);
            SwitchSplitterNext.Name = "SwitchSplitterNext";
            SwitchSplitterNext.Size = new Size(75, 23);
            SwitchSplitterNext.TabIndex = 0;
            SwitchSplitterNext.Text = "Next";
            SwitchSplitterNext.UseVisualStyleBackColor = true;
            SwitchSplitterNext.Click += switchCapacityPlanning_Click;
            // 
            // SwitchSplitterBack
            // 
            SwitchSplitterBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SwitchSplitterBack.Location = new Point(12, 1026);
            SwitchSplitterBack.Name = "SwitchSplitterBack";
            SwitchSplitterBack.Size = new Size(75, 23);
            SwitchSplitterBack.TabIndex = 1;
            SwitchSplitterBack.Text = "Back";
            SwitchSplitterBack.UseVisualStyleBackColor = true;
            SwitchSplitterBack.Click += switchMaterialPlanningP3_Click;
            // 
            // Split
            // 
            resources.ApplyResources(Split, "Split");
            Split.Name = "Split";
            Split.UseVisualStyleBackColor = true;
            Split.Click += Split_Click;
            // 
            // deleteSplit
            // 
            resources.ApplyResources(deleteSplit, "deleteSplit");
            deleteSplit.Name = "deleteSplit";
            deleteSplit.UseVisualStyleBackColor = true;
            deleteSplit.Click += deleteSplit_Click;
            // 
            // articelListView
            // 
            resources.ApplyResources(articelListView, "articelListView");
            articelListView.FullRowSelect = true;
            articelListView.Name = "articelListView";
            articelListView.Sorting = SortOrder.Ascending;
            articelListView.UseCompatibleStateImageBehavior = false;
            articelListView.View = View.Details;
            // 
            // SplitInput
            // 
            resources.ApplyResources(SplitInput, "SplitInput");
            SplitInput.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            SplitInput.Name = "SplitInput";
            // 
            // PrioHigher
            //
            PrioHigher.Font = new Font("Segoe UI", 15.75F);
            PrioHigher.Location = new Point(464, 315);
            PrioHigher.Margin = new Padding(15, 15, 3, 3);
            PrioHigher.Name = "PrioHigher";
            PrioHigher.Size = new Size(112, 42);
            PrioHigher.TabIndex = 10;
            PrioHigher.Text = "\\u25B2";
            PrioHigher.UseVisualStyleBackColor = true;
            PrioHigher.Click += PrioHigher_Click;
            //
            // PrioLower
            //
            PrioLower.Font = new Font("Segoe UI", 15.75F);
            PrioLower.Location = new Point(464, 359);
            PrioLower.Margin = new Padding(15, 15, 3, 3);
            PrioLower.Name = "PrioLower";
            PrioLower.Size = new Size(112, 42);
            PrioLower.TabIndex = 11;
            PrioLower.Text = "\\u25BC";
            PrioLower.UseVisualStyleBackColor = true;
            PrioLower.Click += PrioLower_Click;
            //
            // SortSplitingList
            // 
            SortSplitingList.Location = new Point(464, 413);
            SortSplitingList.Margin = new Padding(15, 45, 3, 3);
            SortSplitingList.Name = "SortSplitingList";
            SortSplitingList.Size = new Size(112, 34);
            SortSplitingList.TabIndex = 12;
            SortSplitingList.Text = "Sort List";
            SortSplitingList.UseVisualStyleBackColor = true;
            SortSplitingList.Click += SortSplitingList_Click;
            //
            // Splitting
            // 
            ClientSize = new Size(1457, 1061);
            Controls.Add(SortSplitingList);
            Controls.Add(PrioLower);
            Controls.Add(PrioHigher);
            Controls.Add(SplitInput);
            Controls.Add(articelListView);
            Controls.Add(deleteSplit);
            Controls.Add(Split);
            Controls.Add(SwitchSplitterBack);
            Controls.Add(SwitchSplitterNext);
            Name = "Splitting";
            VisibleChanged += SortSplitingList_Click;
            ((System.ComponentModel.ISupportInitialize)SplitInput).EndInit();
            ResumeLayout(false);
        }

        private Button SwitchSplitterNext;
        private Button SwitchSplitterBack;
        private Button Split;
        private Button deleteSplit;
        private ListView articelListView;
        private NumericUpDown SplitInput;
        private Button PrioHigher;
        private Button PrioLower;
        private Button SortSplitingList;
    }
}