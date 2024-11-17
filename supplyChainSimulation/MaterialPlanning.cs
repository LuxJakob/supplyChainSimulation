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
        }

        private void switchToLieferProdProg_Click(object sender, EventArgs e)
        {
            MainOrchestrator mainOrchestrator = (MainOrchestrator)this.ParentForm;
            mainOrchestrator.ShowForm(new SalesProduction());
        }
    }
}
