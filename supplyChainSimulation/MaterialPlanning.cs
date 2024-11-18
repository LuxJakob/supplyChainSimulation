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

namespace supplyChainSimulation
{
    public partial class MaterialPlanning : Form
    {
        public MaterialPlanning()
        {
            InitializeComponent();

            warehousestockX = rootElement.Element("warehousestock");
            waitinglistworkstationsX = rootElement.Element("waitinglistworkstations");
            ordersinworkX = rootElement.Element("ordersinwork");

            foreach (var article in warehousestockX.Elements("article"))
            {
                int id = int.Parse(article.Attribute("id").Value);
                int amount = int.Parse(article.Attribute("amount").Value);
                warehousestock[id] = amount;
            }

            foreach (var workplace in waitinglistworkstationsX.Elements("waitinglistworkstations"))
            {
                int id = int.Parse(workplace.Attribute("id").Value);
                int timeneed = int.Parse(workplace.Attribute("timeneed").Value);
                waitinglistworkstations[id] = timeneed;
            }

            waitinglistProductsX = waitinglistworkstationsX.Descendants("waitinglist");
            foreach (var element in waitinglistProductsX)
            {
                int item = int.Parse(element.Attribute("item").Value);
                int timeneed = int.Parse(element.Attribute("timeneed").Value);

                // Add or update the dictionary
                if (waitinglistProducts.ContainsKey(item))
                {
                    waitinglistProducts[item] += timeneed;
                }
                else
                {
                    waitinglistProducts[item] = timeneed;
                }
            }

            foreach (var workplace in ordersinworkX.Elements("workplace"))
            {
                // Parse 'item' and 'timeneed' attributes
                int item = int.Parse(workplace.Attribute("item").Value);
                int timeneed = int.Parse(workplace.Attribute("timeneed").Value);

                // Add or update the dictionary
                if (ordersinwork.ContainsKey(item))
                {
                    ordersinwork[item] += timeneed;
                }
                else
                {
                    ordersinwork[item] = timeneed;
                }
            }

            inventoryE261Value =(int)Math.Round((decimal)(warehousestock[26] / 3));
            inventoryE161Value = (int)Math.Round((decimal)(warehousestock[16] / 3));
            inventoryE171Value = (int)Math.Round((decimal)(warehousestock[17] / 3));

            InventoryP1.Text = warehousestock[1].ToString();
            InventoryE261.Text = inventoryE261Value.ToString(); // shared component
            InventoryE51.Text = warehousestock[51].ToString();
            InventoryE161.Text = inventoryE161Value.ToString(); // shared component
            InventoryE171.Text = inventoryE171Value.ToString(); // shared component
            InventoryE50.Text = warehousestock[50].ToString();
            InventoryE4.Text = warehousestock[4].ToString();
            InventoryE10.Text = warehousestock[10].ToString();
            InventoryE49.Text = warehousestock[49].ToString();
            InventoryE7.Text = warehousestock[7].ToString();
            InventoryE13.Text = warehousestock[13].ToString();
            InventoryE18.Text = warehousestock[18].ToString();

            AssignValue(OrdersQueueP1, waitinglistProducts, 1);
            int orderqueue261 = AssignSharedValue(OrdersQueueE261, waitinglistProducts, 26);
            AssignValue(OrdersQueueE51, waitinglistProducts, 51);
            int orderqueue161 = AssignSharedValue(OrdersQueueE161, waitinglistProducts, 16);
            int orderqueue171 = AssignSharedValue(OrdersQueueE171, waitinglistProducts, 17);
            AssignValue(OrdersQueueE50, waitinglistProducts, 50);
            AssignValue(OrdersQueueE4, waitinglistProducts, 4);
            AssignValue(OrdersQueueE10, waitinglistProducts, 10);
            AssignValue(OrdersQueueE49, waitinglistProducts, 49);
            AssignValue(OrdersQueueE7, waitinglistProducts, 7);
            AssignValue(OrdersQueueE13, waitinglistProducts, 13);
            AssignValue(OrdersQueueE18, waitinglistProducts, 18);

            AssignValue(OrdersProgressP1, ordersinwork, 1);
            int ordersinwork261 = AssignSharedValue(OrdersProgressE261, ordersinwork, 26);
            AssignValue(OrdersProgressE51, ordersinwork, 51);
            int ordersinwork161 = AssignSharedValue(OrdersProgressE161, ordersinwork, 16);
            int ordersinwork171 = AssignSharedValue(OrdersProgressE171, ordersinwork, 17);
            AssignValue(OrdersProgressE50, ordersinwork, 50);
            AssignValue(OrdersProgressE4, ordersinwork, 4);
            AssignValue(OrdersProgressE10, ordersinwork, 10);
            AssignValue(OrdersProgressE49, ordersinwork, 49);
            AssignValue(OrdersProgressE7, ordersinwork, 7);
            AssignValue(OrdersProgressE13, ordersinwork, 13);
            AssignValue(OrdersProgressE18, ordersinwork, 18);

            SellwishP1.Text = production0[1].ToString();
            PlannedP1.Text = (production0[1] - forecast0[1] + warehousestock[1]).ToString();
            productionOrders[1] = production0[1] - ordersinwork[1] - waitinglistProducts[1];
            ProductionOrdersP1.Text = productionOrders[1].ToString();

            CalculateTable();
        }

        private void switchToLieferProdProg_Click(object sender, EventArgs e)
        {
            MainOrchestrator mainOrchestrator = (MainOrchestrator)this.ParentForm;
            mainOrchestrator.ShowForm(new SalesProduction());
        }

        private void CalculateTable(object sender = null, EventArgs e = null)
        {
            SellwishE261.Text = ProductionOrdersP1.Text;
            SellwishE51.Text = ProductionOrdersP1.Text;
            SuccessorQueueE261.Text = OrdersProgressP1.Text;
            SuccessorQueueE51.Text = OrdersProgressP1.Text;
            productionOrders[261] = (productionOrders[1] + ordersinwork[1] + (int)PlannedE261.Value) - (inventoryE261Value + orderqueue261 + ordersinwork161);
            productionOrders[51] = (productionOrders[1] + ordersinwork[1] + (int)PlannedE261.Value) - (warehousestock[51] + waitinglistProducts[51] + ordersinwork[51]);
            ProductionOrdersE261.Text = productionOrders[261].ToString();
            ProductionOrdersE51.Text = productionOrders[51].ToString();

        }

        private void switchMaterialP1_Click(object sender, EventArgs e)
        {
            MainOrchestrator mainOrchestrator = (MainOrchestrator)this.ParentForm;
        }
    }
}
