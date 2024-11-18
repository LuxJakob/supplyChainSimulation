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
    public partial class CapacityPlanning : Form
    {
        public CapacityPlanning()
        {
            InitializeComponent();


            productionOrders[26] = (productionOrders[261] + productionOrders[262] + productionOrders[263]);
            productionOrders[16] = (productionOrders[161] + productionOrders[162] + productionOrders[163]);
            productionOrders[17] = (productionOrders[171] + productionOrders[172] + productionOrders[173]);

            foreach (var order in productionOrders)
            {
                int key = order.Key;
                int value = order.Value;
                string labelName = $"ProductionOrdersE{key}";

                var label = this.Controls.Find(labelName, true).FirstOrDefault() as Label;

                if (label != null)
                {
                    label.Text = value.ToString();
                }
            }

            ProductionOrdersP1.Text = productionOrders[1].ToString();
            ProductionOrdersP2.Text = productionOrders[2].ToString();
            ProductionOrdersP3.Text = productionOrders[3].ToString();

            CalculateTable();
        }

        private void CalculateTable(object sender = null, EventArgs e = null)
        {

        }

        private void switchMaterialP3_Click(object sender, EventArgs e)
        {
            MainOrchestrator mainOrchestrator = (MainOrchestrator)this.ParentForm;
            mainOrchestrator.ShowForm(new MaterialPlanning_P3());
        }

        private void switchPurchasePartDisposition_Click(object sender, EventArgs e)
        {
            MainOrchestrator mainOrchestrator = (MainOrchestrator)this.ParentForm;
            mainOrchestrator.ShowForm(new PurchasePartDisposition());
        }
    }
}
