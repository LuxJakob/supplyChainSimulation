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

            SellwishP2.Text = production0[2].ToString();
            PlannedP2.Text = (production0[2] - forecast0[2] + warehousestock[2]).ToString();
            productionOrders[2] = production0[2] - ordersinwork[2] - waitinglistProducts[2];
            ProductionOrdersP2.Text = productionOrders[2].ToString();

            CalculateTable();
        }

        private void CalculateTable(object sender = null, EventArgs e = null)
        {

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
