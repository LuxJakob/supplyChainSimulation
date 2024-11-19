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

            // general settings - will only be executed once

            if (initialInitMaterial == 0)
            {
                initialInitMaterial = 1;
            
                warehousestockX = rootElement.Element("warehousestock");
                waitinglistworkstationsX = rootElement.Element("waitinglistworkstations");
                ordersinworkX = rootElement.Element("ordersinwork");

                foreach (var article in warehousestockX.Elements("article"))
                {
                    int id = int.Parse(article.Attribute("id").Value);
                    int amount = int.Parse(article.Attribute("amount").Value);
                    warehousestock[id] = amount;
                }

                foreach (var workplace in waitinglistworkstationsX.Elements("workplace"))
                {
                    int id = int.Parse(workplace.Attribute("id")?.Value ?? "0");
                    int timeneed = int.Parse(workplace.Attribute("timeneed")?.Value ?? "0");
                    waitinglistworkstations[id] = timeneed;
                }

                waitinglistProductsX = waitinglistworkstationsX.Descendants("waitinglist");
                foreach (var element in waitinglistProductsX)
                {
                    int item = int.Parse(element.Attribute("item").Value);
                    int amount = int.Parse(element.Attribute("amount").Value);

                    // Add or update the dictionary
                    if (waitinglistProducts.ContainsKey(item))
                    {
                        waitinglistProducts[item] += amount;
                    }
                    else
                    {
                        waitinglistProducts[item] = amount;
                    }
                }

                foreach (var workplace in ordersinworkX.Elements("workplace"))
                {
                    int item = int.Parse(workplace.Attribute("item").Value);
                    int amount = int.Parse(workplace.Attribute("amount").Value);

                    if (ordersinwork.ContainsKey(item))
                    {
                        ordersinwork[item] += amount;
                    }
                    else
                    {
                        ordersinwork[item] = amount;
                    }
                }

            }

            // customized for P1
            
            inventoryE261Value = (int)Math.Round((decimal)(warehousestock[26] / 3));
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
            orderqueue261 = AssignSharedValue(OrdersQueueE261, waitinglistProducts, 26);
            AssignValue(OrdersQueueE51, waitinglistProducts, 51);
            orderqueue161 = AssignSharedValue(OrdersQueueE161, waitinglistProducts, 16);
            orderqueue171 = AssignSharedValue(OrdersQueueE171, waitinglistProducts, 17);
            AssignValue(OrdersQueueE50, waitinglistProducts, 50);
            AssignValue(OrdersQueueE4, waitinglistProducts, 4);
            AssignValue(OrdersQueueE10, waitinglistProducts, 10);
            AssignValue(OrdersQueueE49, waitinglistProducts, 49);
            AssignValue(OrdersQueueE7, waitinglistProducts, 7);
            AssignValue(OrdersQueueE13, waitinglistProducts, 13);
            AssignValue(OrdersQueueE18, waitinglistProducts, 18);

            AssignValue(OrdersProgressP1, ordersinwork, 1);
            ordersinwork261 = AssignSharedValue(OrdersProgressE261, ordersinwork, 26);
            AssignValue(OrdersProgressE51, ordersinwork, 51);
            ordersinwork161 = AssignSharedValue(OrdersProgressE161, ordersinwork, 16);
            ordersinwork171 = AssignSharedValue(OrdersProgressE171, ordersinwork, 17);
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

        private void CalculateTable(object sender = null, EventArgs e = null)
        {
            SellwishE261.Text = ProductionOrdersP1.Text;
            SellwishE51.Text = ProductionOrdersP1.Text;
            SuccessorQueueE261.Text = OrdersQueueP1.Text;
            SuccessorQueueE51.Text = OrdersQueueP1.Text;
            productionOrders[261] = ((productionOrders[1] + ordersinwork[1] + (int)PlannedE261.Value) - (inventoryE261Value + orderqueue261 + ordersinwork261));
            productionOrders[51] = (productionOrders[1] + ordersinwork[1] + (int)PlannedE51.Value) - (warehousestock[51] + waitinglistProducts[51] + ordersinwork[51]);
            UpdateLabelValue(ProductionOrdersE261, productionOrders[261]);
            UpdateLabelValue(ProductionOrdersE51, productionOrders[51]);

            SellwishE161.Text = ProductionOrdersE51.Text;
            SellwishE171.Text = ProductionOrdersE51.Text;
            SellwishE50.Text = ProductionOrdersE51.Text;
            SuccessorQueueE161.Text = OrdersQueueE51.Text;
            SuccessorQueueE171.Text = OrdersQueueE51.Text;
            SuccessorQueueE50.Text = OrdersQueueE51.Text;
            productionOrders[161] = ((productionOrders[51] + ordersinwork[51] + (int)PlannedE161.Value) - (inventoryE161Value + orderqueue161 + ordersinwork161));
            productionOrders[171] = ((productionOrders[51] + ordersinwork[51] + (int)PlannedE171.Value) - (inventoryE171Value + orderqueue171 + ordersinwork171));
            productionOrders[50] = (productionOrders[51] + ordersinwork[51] + (int)PlannedE50.Value) - (warehousestock[50] + waitinglistProducts[50] + ordersinwork[50]);
            UpdateLabelValue(ProductionOrdersE161, productionOrders[161]);
            UpdateLabelValue(ProductionOrdersE171, productionOrders[171]);
            UpdateLabelValue(ProductionOrdersE50, productionOrders[50]);

            SellwishE4.Text = ProductionOrdersE50.Text;
            SellwishE10.Text = ProductionOrdersE50.Text;
            SellwishE49.Text = ProductionOrdersE50.Text;
            SuccessorQueueE4.Text = OrdersQueueE50.Text;
            SuccessorQueueE10.Text = OrdersQueueE50.Text;
            SuccessorQueueE49.Text = OrdersQueueE50.Text;
            productionOrders[4] = ((productionOrders[50] + ordersinwork[50] + (int)PlannedE4.Value) - (warehousestock[4] + waitinglistProducts[4] + ordersinwork[4]));
            productionOrders[10] = ((productionOrders[50] + ordersinwork[50] + (int)PlannedE10.Value) - (warehousestock[10] + waitinglistProducts[10] + ordersinwork[10]));
            productionOrders[49] = (productionOrders[50] + ordersinwork[50] + (int)PlannedE49.Value) - (warehousestock[49] + waitinglistProducts[49] + ordersinwork[49]);
            UpdateLabelValue(ProductionOrdersE4, productionOrders[4]);
            UpdateLabelValue(ProductionOrdersE10, productionOrders[10]);
            UpdateLabelValue(ProductionOrdersE49, productionOrders[49]);

            SellwishE7.Text = ProductionOrdersE49.Text;
            SellwishE13.Text = ProductionOrdersE49.Text;
            SellwishE18.Text = ProductionOrdersE49.Text;
            SuccessorQueueE7.Text = OrdersQueueE49.Text;
            SuccessorQueueE13.Text = OrdersQueueE49.Text;
            SuccessorQueueE18.Text = OrdersQueueE49.Text;
            productionOrders[7] = ((productionOrders[49] + ordersinwork[49] + (int)PlannedE7.Value) - (warehousestock[7] + waitinglistProducts[7] + ordersinwork[7]));
            productionOrders[13] = ((productionOrders[49] + ordersinwork[49] + (int)PlannedE13.Value) - (warehousestock[13] + waitinglistProducts[13] + ordersinwork[13]));
            productionOrders[18] = (productionOrders[49] + ordersinwork[49] + (int)PlannedE18.Value) - (warehousestock[18] + waitinglistProducts[18] + ordersinwork[18]);
            UpdateLabelValue(ProductionOrdersE7, productionOrders[7]);
            UpdateLabelValue(ProductionOrdersE13, productionOrders[13]);
            UpdateLabelValue(ProductionOrdersE18, productionOrders[18]);
        }

        private void switchToLieferProdProg_Click(object sender, EventArgs e)
        {
            MainOrchestrator mainOrchestrator = (MainOrchestrator)this.ParentForm;
            mainOrchestrator.ShowForm(new SalesProduction());
        }

        private void switchMaterialP2_Click(object sender, EventArgs e)
        {
            MainOrchestrator mainOrchestrator = (MainOrchestrator)this.ParentForm;
            mainOrchestrator.ShowForm(new MaterialPlanning_P2());
        }
    }
}
