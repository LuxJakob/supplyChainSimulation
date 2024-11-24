using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static supplyChainSimulation.SharedData;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace supplyChainSimulation
{
    public partial class Splitting : Form
    {
        public Splitting()
        {
            InitializeComponent();
            showArticles();
        }

        private void showArticles(object sender = null, EventArgs e = null)
        {
            articelListView.Columns.Add("Articel");
            articelListView.Columns.Add("Amount");
            articelListView.Items.Clear();

            foreach (var articel in productionOrders)
            {
                int id = articel.Key;
                int menge = articel.Value;
                string name;
                if (!splittingArticelList.Contains(id))
                { continue; }
                if (menge < 0) { menge = 0; }
                if (id == 1 || id == 2 || id == 3)
                {
                    name = "P" + id.ToString();
                }
                else
                {
                    name = "E" + id.ToString();
                }

                ListViewItem listViewItem = new ListViewItem(name);

                listViewItem.SubItems.Add(menge.ToString());

                articelListView.Items.Add(listViewItem);
            }
        }




        private void switchCapacityPlanning_Click(object sender, EventArgs e)
        {
            MainOrchestrator mainOrchestrator = (MainOrchestrator)this.ParentForm;
            mainOrchestrator.ShowForm(new CapacityPlanning());
        }

        private void switchMaterialPlanningP3_Click(object sender, EventArgs e)
        {
            MainOrchestrator mainOrchestrator = (MainOrchestrator)this.ParentForm;
            mainOrchestrator.ShowForm(new MaterialPlanning_P3());
        }

        private void Split_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = articelListView.SelectedItems[0];
            int inputSplitTextBox = Int32.Parse(SplitInput.Text);
            int selectedAmount = Int32.Parse(selectedItem.SubItems[1].Text);
            string newAmountSelectedItem = (selectedAmount - inputSplitTextBox).ToString();
            selectedItem.SubItems[1].Text = newAmountSelectedItem;

            int idOfSelectedItem = ExtractNumberFromString(selectedItem.Text);

            splittedArticels.Add((idOfSelectedItem, inputSplitTextBox));

            ListViewItem listViewItem = new ListViewItem(selectedItem.Text);

            listViewItem.SubItems.Add(inputSplitTextBox.ToString());

            articelListView.Items.Add(listViewItem);
        }

        private int ExtractNumberFromString(string str)
        {
            string numberPart = new string(str.SkipWhile(c => !char.IsDigit(c)).ToArray());
            return int.TryParse(numberPart, out int result) ? result : 0;
        }

        private void Splitting_Load(object sender, EventArgs e)
        {

        }
    }
}
