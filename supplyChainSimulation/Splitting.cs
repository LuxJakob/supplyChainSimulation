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

            PrioHigher.Text = Char.ConvertFromUtf32(0x25B2);
            PrioLower.Text = Char.ConvertFromUtf32(0x25BC);

            foreach (var prod in productionOrders)
            {
                int id = prod.Key;
                if (prod.Value < 0)
                {
                    productionOrders[id] = 0;
                }
            }

            productionOrders[26] = (productionOrders[261] + productionOrders[262] + productionOrders[263]);
            productionOrders[16] = (productionOrders[161] + productionOrders[162] + productionOrders[163]);
            productionOrders[17] = (productionOrders[171] + productionOrders[172] + productionOrders[173]);

            ShowArticles();

            articelListView.ListViewItemSorter = null;
            articelListView.AutoArrange = false;
            articelListView.Sorting = SortOrder.None;
        }

        private void ShowArticles()
        {
            articelListView.Columns.Add("Articel", 100);
            articelListView.Columns.Add("Amount", 150);
            articelListView.Items.Clear();

            foreach (var articel in productionOrders)
            {
                int id = articel.Key;
                int amount = articel.Value;
                string name;
                if (!splittingArticelList.Contains(id))
                { continue; }
                if (id < 4)
                {
                    name = "P" + id.ToString();
                }
                else
                {
                    name = "E" + id.ToString();
                }

                articelListView.Items.Add(new ListViewItem(new[] { name, amount.ToString() }));
            }
        }

        private void Split_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = articelListView.SelectedItems[0];
            decimal inputSplit = SplitInput.Value;
            int inputSplitAsInt = Convert.ToInt32(inputSplit);
            int selectedAmount = Int32.Parse(selectedItem.SubItems[1].Text);

            if ((inputSplit < (decimal)selectedAmount) && (inputSplit > 0))
            {
                try
                {
                    if (inputSplit % 10 > 0)
                    {
                        throw new Exception();
                    }
                    var newAmountSelectedItem = selectedAmount - inputSplitAsInt;
                    selectedItem.SubItems[1].Text = newAmountSelectedItem.ToString();

                    int idOfSelectedItem = ExtractNumberFromString(selectedItem.Text);

                    splittedArticels.Add(idOfSelectedItem);

                    articelListView.Items.Add(new ListViewItem(new[] { selectedItem.Text, inputSplitAsInt.ToString() }));
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Your input cannot be divided by 10!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private int ExtractNumberFromString(string str)
        {
            string numberPart = new string(str.SkipWhile(c => !char.IsDigit(c)).ToArray());
            return int.TryParse(numberPart, out int result) ? result : 0;
        }


        private void deleteSplit_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = articelListView.SelectedItems[0];

            int idOfSelectedItem = ExtractNumberFromString(selectedItem.Text);
            int amountOfSelectedItem = Int32.Parse(selectedItem.SubItems[1].Text);

            try
            {
                if (!splittedArticels.Contains(idOfSelectedItem))
                {
                    throw new Exception();
                }
                splittedArticels.Remove(idOfSelectedItem);

                selectedItem.Remove();

                MergeItems(selectedItem.Text, amountOfSelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"You can't delete this position!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MergeItems(string itemName, int amountToAdd)
        {
            foreach (ListViewItem item in articelListView.Items)
            {
                if (item.SubItems[0].Text == itemName)
                {
                    int quantity = int.Parse(item.SubItems[1].Text);

                    quantity += amountToAdd;

                    item.SubItems[1].Text = quantity.ToString();

                    break;
                }
            }
        }

        private void switchCapacityPlanning_Click(object sender, EventArgs e)
        {
            modifiedArticelsfinalized.Clear();

            foreach (ListViewItem item in articelListView.Items)
            {
                modifiedArticelsfinalized.Add((ExtractNumberFromString(item.SubItems[0].Text), Int32.Parse(item.SubItems[1].Text)));
            }

            MainOrchestrator mainOrchestrator = (MainOrchestrator)this.ParentForm;
            mainOrchestrator.ShowForm(new CapacityPlanning());
        }

        private void switchMaterialPlanningP3_Click(object sender, EventArgs e)
        {
            MainOrchestrator mainOrchestrator = (MainOrchestrator)this.ParentForm;
            mainOrchestrator.ShowForm(new MaterialPlanning_P3());
        }

        private void PrioHigher_Click(object sender, EventArgs e)
        {
            if (articelListView.SelectedItems.Count == 0)
                return;

            List<int> selectedIndices = articelListView.SelectedIndices.Cast<int>().ToList();

            if (selectedIndices[0] == 0)
                return;

            List<ListViewItem> allItems = articelListView.Items.Cast<ListViewItem>().ToList();

            List<ListViewItem> selectedItems = new List<ListViewItem>();
            foreach (int index in selectedIndices)
            {
                selectedItems.Add(allItems[index]);
            }
            foreach (var item in selectedItems)
            {
                allItems.Remove(item);
            }

            int insertIndex = selectedIndices[0] - 1;
            allItems.InsertRange(insertIndex, selectedItems);

            articelListView.BeginUpdate();
            articelListView.Items.Clear();
            articelListView.Items.AddRange(allItems.ToArray());
            articelListView.EndUpdate();

            foreach (var item in selectedItems)
            {
                item.Selected = true;
            }
        }

        private void PrioLower_Click(object sender, EventArgs e)
        {
            if (articelListView.SelectedItems.Count == 0)
                return;

            List<int> selectedIndices = articelListView.SelectedIndices.Cast<int>().ToList();

            List<ListViewItem> allItems = articelListView.Items.Cast<ListViewItem>().ToList();

            if ((allItems.Count) <= (selectedIndices.Last() + 1))
                return;

            List<ListViewItem> selectedItems = new List<ListViewItem>();
            foreach (int index in selectedIndices)
            {
                selectedItems.Add(allItems[index]);
            }
            foreach (var item in selectedItems)
            {
                allItems.Remove(item);
            }

            int insertIndex = selectedIndices[0] + 1;
            allItems.InsertRange(insertIndex, selectedItems);

            articelListView.BeginUpdate();
            articelListView.Items.Clear();
            articelListView.Items.AddRange(allItems.ToArray());
            articelListView.EndUpdate();

            foreach (var item in selectedItems)
            {
                item.Selected = true;
            }
        }

        private void SortSplitingList_Click(object sender, EventArgs e)
        {
            BasicSort();
        }

        private void BasicSort()
        {
            ListViewItemComparer comparer = new ListViewItemComparer();

            articelListView.ListViewItemSorter = comparer;

            articelListView.Sort();

            articelListView.ListViewItemSorter = null;
        }
    }
}
