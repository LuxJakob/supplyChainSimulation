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

            toDumbForRecursive();

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

        private void toDumbForRecursive()
        {
            workstation1_49_6.Text = (productionOrders[49] * 6).ToString();
            workstation1_29_6.Text = (productionOrders[29] * 6).ToString();
            workstation1_54_6.Text = (productionOrders[54] * 6).ToString();
            workstation2_50_5.Text = (productionOrders[50] * 5).ToString();
            workstation2_55_5.Text = (productionOrders[55] * 5).ToString();
            workstation2_30_5.Text = (productionOrders[30] * 5).ToString();
            workstation3_51_5.Text = (productionOrders[51] * 5).ToString();
            workstation3_56_6.Text = (productionOrders[56] * 6).ToString();
            workstation3_31_6.Text = (productionOrders[31] * 6).ToString();
            workstation4_1_6.Text = (productionOrders[1] * 6).ToString();
            workstation4_2_7.Text = (productionOrders[2] * 7).ToString();
            workstation4_3_7.Text = (productionOrders[3] * 7).ToString();
            workstation6_16_2.Text = (productionOrders[16] * 2).ToString();
            workstation6_18_3.Text = (productionOrders[18] * 3).ToString();
            workstation6_19_3.Text = (productionOrders[19] * 3).ToString();
            workstation6_20_3.Text = (productionOrders[20] * 3).ToString();
            workstation7_10_2.Text = (productionOrders[10] * 2).ToString();
            workstation7_11_2.Text = (productionOrders[11] * 2).ToString();
            workstation7_12_2.Text = (productionOrders[12] * 2).ToString();
            workstation7_13_2.Text = (productionOrders[13] * 2).ToString();
            workstation7_14_2.Text = (productionOrders[14] * 2).ToString();
            workstation7_15_2.Text = (productionOrders[15] * 2).ToString();
            workstation7_18_2.Text = (productionOrders[18] * 2).ToString();
            workstation7_19_2.Text = (productionOrders[19] * 2).ToString();
            workstation7_20_2.Text = (productionOrders[20] * 2).ToString();
            workstation7_26_2.Text = (productionOrders[26] * 2).ToString();
            workstation8_10_2.Text = (productionOrders[10] * 2).ToString();
            workstation8_11_2.Text = (productionOrders[11] * 2).ToString();
            workstation8_12_2.Text = (productionOrders[12] * 2).ToString();
            workstation8_13_2.Text = (productionOrders[13] * 2).ToString();
            workstation8_14_1.Text = (productionOrders[14] * 1).ToString();
            workstation8_15_2.Text = (productionOrders[15] * 2).ToString();
            workstation8_18_3.Text = (productionOrders[18] * 3).ToString();
            workstation8_19_3.Text = (productionOrders[19] * 3).ToString();
            workstation8_20_3.Text = (productionOrders[20] * 3).ToString();
            workstation9_10_3.Text = (productionOrders[10] * 3).ToString();
            workstation9_11_3.Text = (productionOrders[11] * 3).ToString();
            workstation9_12_3.Text = (productionOrders[12] * 3).ToString();
            workstation9_13_3.Text = (productionOrders[13] * 3).ToString();
            workstation9_14_3.Text = (productionOrders[14] * 3).ToString();
            workstation9_15_3.Text = (productionOrders[15] * 3).ToString();
            workstation9_18_2.Text = (productionOrders[18] * 2).ToString();
            workstation9_19_2.Text = (productionOrders[19] * 2).ToString();
            workstation9_20_2.Text = (productionOrders[20] * 2).ToString();
            workstation10_1_4.Text = (productionOrders[1] * 4).ToString();
            workstation10_2_4.Text = (productionOrders[2] * 4).ToString();
            workstation10_3_4.Text = (productionOrders[3] * 4).ToString();
            workstation10_4_4.Text = (productionOrders[4] * 4).ToString();
            workstation10_5_4.Text = (productionOrders[5] * 4).ToString();
            workstation10_6_4.Text = (productionOrders[6] * 4).ToString();
            workstation11_1_3.Text = (productionOrders[1] * 3).ToString();
            workstation11_2_3.Text = (productionOrders[2] * 3).ToString();
            workstation11_3_3.Text = (productionOrders[3] * 3).ToString();
            workstation11_4_3.Text = (productionOrders[4] * 3).ToString();
            workstation11_5_3.Text = (productionOrders[5] * 3).ToString();
            workstation11_6_3.Text = (productionOrders[6] * 3).ToString();
            workstation12_10_3.Text = (productionOrders[10] * 3).ToString();
            workstation12_11_3.Text = (productionOrders[11] * 3).ToString();
            workstation12_12_3.Text = (productionOrders[12] * 3).ToString();
            workstation12_13_3.Text = (productionOrders[13] * 3).ToString();
            workstation12_14_3.Text = (productionOrders[14] * 3).ToString();
            workstation12_15_3.Text = (productionOrders[15] * 3).ToString();
            workstation13_10_2.Text = (productionOrders[10] * 2).ToString();
            workstation13_11_2.Text = (productionOrders[11] * 2).ToString();
            workstation13_12_2.Text = (productionOrders[12] * 2).ToString();
            workstation13_13_2.Text = (productionOrders[13] * 2).ToString();
            workstation13_14_2.Text = (productionOrders[14] * 2).ToString();
            workstation13_15_2.Text = (productionOrders[15] * 2).ToString();
            workstation14_16_3.Text = (productionOrders[16] * 3).ToString();
            workstation15_17_3.Text = (productionOrders[17] * 3).ToString();
            workstation15_26_3.Text = (productionOrders[26] * 3).ToString();
        }
    }
}
