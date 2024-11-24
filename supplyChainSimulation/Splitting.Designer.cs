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
            ((System.ComponentModel.ISupportInitialize)SplitInput).BeginInit();
            SuspendLayout();
            // 
            // SwitchSplitterNext
            // 
            resources.ApplyResources(SwitchSplitterNext, "SwitchSplitterNext");
            SwitchSplitterNext.Name = "SwitchSplitterNext";
            SwitchSplitterNext.UseVisualStyleBackColor = true;
            SwitchSplitterNext.Click += switchCapacityPlanning_Click;
            // 
            // SwitchSplitterBack
            // 
            resources.ApplyResources(SwitchSplitterBack, "SwitchSplitterBack");
            SwitchSplitterBack.Name = "SwitchSplitterBack";
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
            // Splitting
            // 
            resources.ApplyResources(this, "$this");
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