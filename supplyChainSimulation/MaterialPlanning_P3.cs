using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static supplyChainSimulation.SharedData;

namespace supplyChainSimulation
{
    public partial class MaterialPlanning_P3 : Form
    {
        public MaterialPlanning_P3()
        {
            InitializeComponent();

            // customized for P3

            inventoryE263Value = (int)Math.Round((decimal)(warehousestock[26] / 3));
            inventoryE163Value = (int)Math.Round((decimal)(warehousestock[16] / 3));
            inventoryE173Value = (int)Math.Round((decimal)(warehousestock[17] / 3));

            InventoryP3.Text = warehousestock[3].ToString();
            InventoryE263.Text = inventoryE263Value.ToString(); // shared component
            InventoryE31.Text = warehousestock[31].ToString();
            InventoryE163.Text = inventoryE163Value.ToString(); // shared component
            InventoryE173.Text = inventoryE173Value.ToString(); // shared component
            InventoryE30.Text = warehousestock[30].ToString();
            InventoryE6.Text = warehousestock[6].ToString();
            InventoryE12.Text = warehousestock[12].ToString();
            InventoryE29.Text = warehousestock[29].ToString();
            InventoryE9.Text = warehousestock[9].ToString();
            InventoryE15.Text = warehousestock[15].ToString();
            InventoryE20.Text = warehousestock[20].ToString();

            AssignValue(OrdersQueueP3, waitinglistProducts, 3);
            orderqueue263 = AssignSharedValue(OrdersQueueE263, waitinglistProducts, 26);
            AssignValue(OrdersQueueE31, waitinglistProducts, 31);
            orderqueue163 = AssignSharedValue(OrdersQueueE163, waitinglistProducts, 16);
            orderqueue173 = AssignSharedValue(OrdersQueueE173, waitinglistProducts, 17);
            AssignValue(OrdersQueueE30, waitinglistProducts, 30);
            AssignValue(OrdersQueueE6, waitinglistProducts, 6);
            AssignValue(OrdersQueueE12, waitinglistProducts, 12);
            AssignValue(OrdersQueueE29, waitinglistProducts, 29);
            AssignValue(OrdersQueueE9, waitinglistProducts, 9);
            AssignValue(OrdersQueueE15, waitinglistProducts, 15);
            AssignValue(OrdersQueueE20, waitinglistProducts, 20);

            AssignValue(OrdersProgressP3, ordersinwork, 3);
            ordersinwork263 = AssignSharedValue(OrdersProgressE263, ordersinwork, 26);
            AssignValue(OrdersProgressE31, ordersinwork, 31);
            ordersinwork163 = AssignSharedValue(OrdersProgressE163, ordersinwork, 16);
            ordersinwork173 = AssignSharedValue(OrdersProgressE173, ordersinwork, 17);
            AssignValue(OrdersProgressE30, ordersinwork, 30);
            AssignValue(OrdersProgressE6, ordersinwork, 6);
            AssignValue(OrdersProgressE12, ordersinwork, 12);
            AssignValue(OrdersProgressE29, ordersinwork, 29);
            AssignValue(OrdersProgressE9, ordersinwork, 9);
            AssignValue(OrdersProgressE15, ordersinwork, 15);
            AssignValue(OrdersProgressE20, ordersinwork, 20);

            SellwishP3.Text = production0[3].ToString();
            PlannedP3.Text = (production0[3] - forecast0[3] + warehousestock[3]).ToString();
            productionOrders[3] = production0[3] - ordersinwork[3] - waitinglistProducts[3];
            ProductionOrdersP3.Text = productionOrders[3].ToString();

            CalculateTable();
        }

        private void CalculateTable(object sender = null, EventArgs e = null)
        {
            SellwishE263.Text = ProductionOrdersP3.Text;
            SellwishE31.Text = ProductionOrdersP3.Text;
            SuccessorQueueE263.Text = OrdersQueueP3.Text;
            SuccessorQueueE31.Text = OrdersQueueP3.Text;
            productionOrders[263] = ((productionOrders[3] + ordersinwork[3] + (int)PlannedE263.Value) - (inventoryE263Value + orderqueue263 + ordersinwork263));
            productionOrders[31] = (productionOrders[3] + ordersinwork[3] + (int)PlannedE31.Value) - (warehousestock[31] + waitinglistProducts[31] + ordersinwork[31]);
            UpdateLabelValue(ProductionOrdersE263, productionOrders[263]);
            UpdateLabelValue(ProductionOrdersE31, productionOrders[31]);

            SellwishE163.Text = ProductionOrdersE31.Text;
            SellwishE173.Text = ProductionOrdersE31.Text;
            SellwishE30.Text = ProductionOrdersE31.Text;
            SuccessorQueueE163.Text = OrdersQueueE31.Text;
            SuccessorQueueE173.Text = OrdersQueueE31.Text;
            SuccessorQueueE30.Text = OrdersQueueE31.Text;
            productionOrders[163] = ((productionOrders[31] + ordersinwork[31] + (int)PlannedE163.Value) - (inventoryE163Value + orderqueue163 + ordersinwork163));
            productionOrders[173] = ((productionOrders[31] + ordersinwork[31] + (int)PlannedE173.Value) - (inventoryE173Value + orderqueue173 + ordersinwork173));
            productionOrders[30] = (productionOrders[31] + ordersinwork[31] + (int)PlannedE30.Value) - (warehousestock[30] + waitinglistProducts[30] + ordersinwork[30]);
            UpdateLabelValue(ProductionOrdersE163, productionOrders[163]);
            UpdateLabelValue(ProductionOrdersE173, productionOrders[173]);
            UpdateLabelValue(ProductionOrdersE30, productionOrders[30]);

            SellwishE6.Text = ProductionOrdersE30.Text;
            SellwishE12.Text = ProductionOrdersE30.Text;
            SellwishE29.Text = ProductionOrdersE30.Text;
            SuccessorQueueE6.Text = OrdersQueueE30.Text;
            SuccessorQueueE12.Text = OrdersQueueE30.Text;
            SuccessorQueueE29.Text = OrdersQueueE30.Text;
            productionOrders[6] = ((productionOrders[30] + ordersinwork[30] + (int)PlannedE6.Value) - (warehousestock[6] + waitinglistProducts[6] + ordersinwork[6]));
            productionOrders[12] = ((productionOrders[30] + ordersinwork[30] + (int)PlannedE12.Value) - (warehousestock[12] + waitinglistProducts[12] + ordersinwork[12]));
            productionOrders[29] = (productionOrders[30] + ordersinwork[30] + (int)PlannedE29.Value) - (warehousestock[29] + waitinglistProducts[29] + ordersinwork[29]);
            UpdateLabelValue(ProductionOrdersE6, productionOrders[6]);
            UpdateLabelValue(ProductionOrdersE12, productionOrders[12]);
            UpdateLabelValue(ProductionOrdersE29, productionOrders[29]);

            SellwishE9.Text = ProductionOrdersE29.Text;
            SellwishE15.Text = ProductionOrdersE29.Text;
            SellwishE20.Text = ProductionOrdersE29.Text;
            SuccessorQueueE9.Text = OrdersQueueE29.Text;
            SuccessorQueueE15.Text = OrdersQueueE29.Text;
            SuccessorQueueE20.Text = OrdersQueueE29.Text;
            productionOrders[9] = ((productionOrders[29] + ordersinwork[29] + (int)PlannedE9.Value) - (warehousestock[9] + waitinglistProducts[9] + ordersinwork[9]));
            productionOrders[15] = ((productionOrders[29] + ordersinwork[29] + (int)PlannedE15.Value) - (warehousestock[15] + waitinglistProducts[15] + ordersinwork[15]));
            productionOrders[20] = (productionOrders[29] + ordersinwork[29] + (int)PlannedE20.Value) - (warehousestock[20] + waitinglistProducts[20] + ordersinwork[20]);
            UpdateLabelValue(ProductionOrdersE9, productionOrders[9]);
            UpdateLabelValue(ProductionOrdersE15, productionOrders[15]);
            UpdateLabelValue(ProductionOrdersE20, productionOrders[20]);
        }

        private void switchMaterialP2_Click(object sender, EventArgs e)
        {
            MainOrchestrator mainOrchestrator = (MainOrchestrator)this.ParentForm;
            mainOrchestrator.ShowForm(new MaterialPlanning_P2());
        }

        private void switchCapacityPlanning_Click(object sender, EventArgs e)
        {
            MainOrchestrator mainOrchestrator = (MainOrchestrator)this.ParentForm;
            mainOrchestrator.ShowForm(new Splitting());
        }
    }
}
