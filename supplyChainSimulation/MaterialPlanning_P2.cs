using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static supplyChainSimulation.SharedData;

namespace supplyChainSimulation
{
    public partial class MaterialPlanning_P2 : Form
    {
        public MaterialPlanning_P2()
        {
            InitializeComponent();

            // customized for P2

            inventoryE262Value = (int)Math.Round((decimal)(warehousestock[26] / 3));
            inventoryE162Value = (int)Math.Round((decimal)(warehousestock[16] / 3));
            inventoryE172Value = (int)Math.Round((decimal)(warehousestock[17] / 3));

            InventoryP2.Text = warehousestock[2].ToString();
            InventoryE262.Text = inventoryE262Value.ToString(); // shared component
            InventoryE56.Text = warehousestock[56].ToString();
            InventoryE162.Text = inventoryE162Value.ToString(); // shared component
            InventoryE172.Text = inventoryE172Value.ToString(); // shared component
            InventoryE55.Text = warehousestock[55].ToString();
            InventoryE5.Text = warehousestock[5].ToString();
            InventoryE11.Text = warehousestock[11].ToString();
            InventoryE54.Text = warehousestock[54].ToString();
            InventoryE8.Text = warehousestock[8].ToString();
            InventoryE14.Text = warehousestock[14].ToString();
            InventoryE19.Text = warehousestock[19].ToString();

            AssignValue(OrdersQueueP2, waitinglistProducts, 2);
            orderqueue262 = AssignSharedValue(OrdersQueueE262, waitinglistProducts, 26);
            AssignValue(OrdersQueueE56, waitinglistProducts, 56);
            orderqueue162 = AssignSharedValue(OrdersQueueE162, waitinglistProducts, 16);
            orderqueue172 = AssignSharedValue(OrdersQueueE172, waitinglistProducts, 17);
            AssignValue(OrdersQueueE55, waitinglistProducts, 55);
            AssignValue(OrdersQueueE5, waitinglistProducts, 5);
            AssignValue(OrdersQueueE11, waitinglistProducts, 11);
            AssignValue(OrdersQueueE54, waitinglistProducts, 54);
            AssignValue(OrdersQueueE8, waitinglistProducts, 8);
            AssignValue(OrdersQueueE14, waitinglistProducts, 14);
            AssignValue(OrdersQueueE19, waitinglistProducts, 19);

            AssignValue(OrdersProgressP2, ordersinwork, 2);
            ordersinwork262 = AssignSharedValue(OrdersProgressE262, ordersinwork, 26);
            AssignValue(OrdersProgressE56, ordersinwork, 56);
            ordersinwork162 = AssignSharedValue(OrdersProgressE162, ordersinwork, 16);
            ordersinwork172 = AssignSharedValue(OrdersProgressE172, ordersinwork, 17);
            AssignValue(OrdersProgressE55, ordersinwork, 55);
            AssignValue(OrdersProgressE5, ordersinwork, 5);
            AssignValue(OrdersProgressE11, ordersinwork, 11);
            AssignValue(OrdersProgressE54, ordersinwork, 54);
            AssignValue(OrdersProgressE8, ordersinwork, 8);
            AssignValue(OrdersProgressE14, ordersinwork, 14);
            AssignValue(OrdersProgressE19, ordersinwork, 19);

            SellwishP2.Text = forecast0[2].ToString();
            PlannedP2.Text = (production0[2] - forecast0[2] + warehousestock[2]).ToString();
            productionOrders[2] = production0[2] - ordersinwork[2] - waitinglistProducts[2];
            ProductionOrdersP2.Text = productionOrders[2].ToString();

            CalculateTable();
        }

        private void UpdateLabelValue(Label label, int value)
        {
            if (value < 0)
            {
                value = 0;

                string pattern = @"[EP]\d{1,3}";
                string labelNumber = label.Name;
                Match match = Regex.Match(labelNumber, pattern);

                string labelSellwish = "Sellwish" + match.Value;
                string labelSuccessorQueue = "SuccessorQueue" + match.Value;
                string labelInventory = "Inventory" + match.Value;
                string labelOrdersQueue = "OrdersQueue" + match.Value;
                string labelOrdersProgress = "OrdersProgress" + match.Value;

                string labelPlanned = "Planned" + match.Value;

                Label labelSellwishL = this.Controls.Find(labelSellwish, true).FirstOrDefault() as Label;
                Label labelSuccessorQueueL = this.Controls.Find(labelSuccessorQueue, true).FirstOrDefault() as Label;
                Label labelInventoryL = this.Controls.Find(labelInventory, true).FirstOrDefault() as Label;
                Label labelOrdersQueueL = this.Controls.Find(labelOrdersQueue, true).FirstOrDefault() as Label;
                Label labelOrdersProgressL = this.Controls.Find(labelOrdersProgress, true).FirstOrDefault() as Label;

                NumericUpDown labelPlannedL = this.Controls.Find(labelPlanned, true).FirstOrDefault() as NumericUpDown;

                labelPlannedL.Value = Math.Abs((Convert.ToInt32(labelSellwishL.Text) + Convert.ToInt32(labelSuccessorQueueL.Text))
                    - (Convert.ToInt32(labelInventoryL.Text) + Convert.ToInt32(labelOrdersQueueL.Text) + Convert.ToInt32(labelOrdersProgressL.Text)));
            }

            label.Text = value.ToString();
        }

        private void CalculateTable(object sender = null, EventArgs e = null)
        {
            SellwishE262.Text = ProductionOrdersP2.Text;
            SellwishE56.Text = ProductionOrdersP2.Text;
            SuccessorQueueE262.Text = OrdersQueueP2.Text;
            SuccessorQueueE56.Text = OrdersQueueP2.Text;
            productionOrders[262] = ((productionOrders[2] + ordersinwork[2] + (int)PlannedE262.Value) - (inventoryE262Value + orderqueue262 + ordersinwork262));
            productionOrders[56] = (productionOrders[2] + ordersinwork[2] + (int)PlannedE56.Value) - (warehousestock[56] + waitinglistProducts[56] + ordersinwork[56]);
            UpdateLabelValue(ProductionOrdersE262, productionOrders[262]);
            UpdateLabelValue(ProductionOrdersE56, productionOrders[56]);

            SellwishE162.Text = ProductionOrdersE56.Text;
            SellwishE172.Text = ProductionOrdersE56.Text;
            SellwishE55.Text = ProductionOrdersE56.Text;
            SuccessorQueueE162.Text = OrdersQueueE56.Text;
            SuccessorQueueE172.Text = OrdersQueueE56.Text;
            SuccessorQueueE55.Text = OrdersQueueE56.Text;
            productionOrders[162] = ((productionOrders[56] + ordersinwork[56] + (int)PlannedE162.Value) - (inventoryE162Value + orderqueue162 + ordersinwork162));
            productionOrders[172] = ((productionOrders[56] + ordersinwork[56] + (int)PlannedE172.Value) - (inventoryE172Value + orderqueue172 + ordersinwork172));
            productionOrders[55] = (productionOrders[56] + ordersinwork[56] + (int)PlannedE55.Value) - (warehousestock[55] + waitinglistProducts[55] + ordersinwork[55]);
            UpdateLabelValue(ProductionOrdersE162, productionOrders[162]);
            UpdateLabelValue(ProductionOrdersE172, productionOrders[172]);
            UpdateLabelValue(ProductionOrdersE55, productionOrders[55]);

            SellwishE5.Text = ProductionOrdersE55.Text;
            SellwishE11.Text = ProductionOrdersE55.Text;
            SellwishE54.Text = ProductionOrdersE55.Text;
            SuccessorQueueE5.Text = OrdersQueueE55.Text;
            SuccessorQueueE11.Text = OrdersQueueE55.Text;
            SuccessorQueueE54.Text = OrdersQueueE55.Text;
            productionOrders[5] = ((productionOrders[55] + ordersinwork[55] + (int)PlannedE5.Value) - (warehousestock[5] + waitinglistProducts[5] + ordersinwork[5]));
            productionOrders[11] = ((productionOrders[55] + ordersinwork[55] + (int)PlannedE11.Value) - (warehousestock[11] + waitinglistProducts[11] + ordersinwork[11]));
            productionOrders[54] = (productionOrders[55] + ordersinwork[55] + (int)PlannedE54.Value) - (warehousestock[54] + waitinglistProducts[54] + ordersinwork[54]);
            UpdateLabelValue(ProductionOrdersE5, productionOrders[5]);
            UpdateLabelValue(ProductionOrdersE11, productionOrders[11]);
            UpdateLabelValue(ProductionOrdersE54, productionOrders[54]);

            SellwishE8.Text = ProductionOrdersE54.Text;
            SellwishE14.Text = ProductionOrdersE54.Text;
            SellwishE19.Text = ProductionOrdersE54.Text;
            SuccessorQueueE8.Text = OrdersQueueE54.Text;
            SuccessorQueueE14.Text = OrdersQueueE54.Text;
            SuccessorQueueE19.Text = OrdersQueueE54.Text;
            productionOrders[8] = ((productionOrders[54] + ordersinwork[54] + (int)PlannedE8.Value) - (warehousestock[8] + waitinglistProducts[8] + ordersinwork[8]));
            productionOrders[14] = ((productionOrders[54] + ordersinwork[54] + (int)PlannedE14.Value) - (warehousestock[14] + waitinglistProducts[14] + ordersinwork[14]));
            productionOrders[19] = (productionOrders[54] + ordersinwork[54] + (int)PlannedE19.Value) - (warehousestock[19] + waitinglistProducts[19] + ordersinwork[19]);
            UpdateLabelValue(ProductionOrdersE8, productionOrders[8]);
            UpdateLabelValue(ProductionOrdersE14, productionOrders[14]);
            UpdateLabelValue(ProductionOrdersE19, productionOrders[19]);
        }

        private void switchMaterialP1_Click(object sender, EventArgs e)
        {
            MainOrchestrator mainOrchestrator = (MainOrchestrator)this.ParentForm;
            mainOrchestrator.ShowForm(new MaterialPlanning());
        }

        private void switchMaterialP3_Click(object sender, EventArgs e)
        {
            MainOrchestrator mainOrchestrator = (MainOrchestrator)this.ParentForm;
            mainOrchestrator.ShowForm(new MaterialPlanning_P3());
        }
    }
}
