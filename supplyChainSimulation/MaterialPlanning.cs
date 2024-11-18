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

            InventoryP1.Text = warehousestock[1].ToString();
            InventoryE261.Text = warehousestock[26].ToString();
            InventoryE51.Text = warehousestock[51].ToString();
            InventoryE161.Text = warehousestock[16].ToString();
            InventoryE171.Text = warehousestock[17].ToString();
            InventoryE50.Text = warehousestock[50].ToString();
            InventoryE4.Text = warehousestock[4].ToString();
            InventoryE10.Text = warehousestock[10].ToString();
            InventoryE49.Text = warehousestock[49].ToString();
            InventoryE7.Text = warehousestock[7].ToString();
            InventoryE13.Text = warehousestock[13].ToString();
            InventoryE18.Text = warehousestock[18].ToString();

            AssignQueueValue(OrdersQueueP1, waitinglistProducts, 1);
            AssignQueueValue(OrdersQueueE261, waitinglistProducts, 26);
            AssignQueueValue(OrdersQueueE51, waitinglistProducts, 51);
            AssignQueueValue(OrdersQueueE161, waitinglistProducts, 16);
            AssignQueueValue(OrdersQueueE171, waitinglistProducts, 17);
            AssignQueueValue(OrdersQueueE50, waitinglistProducts, 50);
            AssignQueueValue(OrdersQueueE4, waitinglistProducts, 4);
            AssignQueueValue(OrdersQueueE10, waitinglistProducts, 10);
            AssignQueueValue(OrdersQueueE49, waitinglistProducts, 49);
            AssignQueueValue(OrdersQueueE7, waitinglistProducts, 7);
            AssignQueueValue(OrdersQueueE13, waitinglistProducts, 13);
            AssignQueueValue(OrdersQueueE18, waitinglistProducts, 18);

            SellwishP1.Text = production0[1].ToString();
            PlannedP1.Text = (production0[1] - forecast0[1] + warehousestock[1]).ToString();
            ProductionOrdersP1.Text = (production0[1]).ToString();

            CalculateTable();
        }

        private void switchToLieferProdProg_Click(object sender, EventArgs e)
        {
            MainOrchestrator mainOrchestrator = (MainOrchestrator)this.ParentForm;
            mainOrchestrator.ShowForm(new SalesProduction());
        }

        private void CalculateTable(object sender = null, EventArgs e = null)
        {

        }

        private void switchMaterialP1_Click(object sender, EventArgs e)
        {
            MainOrchestrator mainOrchestrator = (MainOrchestrator)this.ParentForm;
        }
    }
}
