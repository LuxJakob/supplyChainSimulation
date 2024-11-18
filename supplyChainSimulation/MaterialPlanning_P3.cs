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
            
        }

        private void switchMaterialP2_Click(object sender, EventArgs e)
        {
            MainOrchestrator mainOrchestrator = (MainOrchestrator)this.ParentForm;
            mainOrchestrator.ShowForm(new MaterialPlanning_P2());
        }

        private void switchCapacityPlanning_Click(object sender, EventArgs e)
        {
            MainOrchestrator mainOrchestrator = (MainOrchestrator)this.ParentForm;
            mainOrchestrator.ShowForm(new CapacityPlanning());
        }
    }
}
