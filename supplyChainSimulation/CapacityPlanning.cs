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
            int workstation1_49_6Value = (productionOrders[49] * 6);
            int workstation1_29_6Value = (productionOrders[29] * 6);
            int workstation1_54_6Value = (productionOrders[54] * 6);
            int workstation2_50_5Value = (productionOrders[50] * 5);
            int workstation2_55_5Value = (productionOrders[55] * 5);
            int workstation2_30_5Value = (productionOrders[30] * 5);
            int workstation3_51_5Value = (productionOrders[51] * 5);
            int workstation3_56_6Value = (productionOrders[56] * 6);
            int workstation3_31_6Value = (productionOrders[31] * 6);
            int workstation4_1_6Value = (productionOrders[1] * 6);
            int workstation4_2_7Value = (productionOrders[2] * 7);
            int workstation4_3_7Value = (productionOrders[3] * 7);
            int workstation6_16_2Value = (productionOrders[16] * 2);
            int workstation6_18_3Value = (productionOrders[18] * 3);
            int workstation6_19_3Value = (productionOrders[19] * 3);
            int workstation6_20_3Value = (productionOrders[20] * 3);
            int workstation7_10_2Value = (productionOrders[10] * 2);
            int workstation7_11_2Value = (productionOrders[11] * 2);
            int workstation7_12_2Value = (productionOrders[12] * 2);
            int workstation7_13_2Value = (productionOrders[13] * 2);
            int workstation7_14_2Value = (productionOrders[14] * 2);
            int workstation7_15_2Value = (productionOrders[15] * 2);
            int workstation7_18_2Value = (productionOrders[18] * 2);
            int workstation7_19_2Value = (productionOrders[19] * 2);
            int workstation7_20_2Value = (productionOrders[20] * 2);
            int workstation7_26_2Value = (productionOrders[26] * 2);
            int workstation8_10_2Value = (productionOrders[10] * 2);
            int workstation8_11_2Value = (productionOrders[11] * 2);
            int workstation8_12_2Value = (productionOrders[12] * 2);
            int workstation8_13_2Value = (productionOrders[13] * 2);
            int workstation8_14_1Value = (productionOrders[14] * 1);
            int workstation8_15_2Value = (productionOrders[15] * 2);
            int workstation8_18_3Value = (productionOrders[18] * 3);
            int workstation8_19_3Value = (productionOrders[19] * 3);
            int workstation8_20_3Value = (productionOrders[20] * 3);
            int workstation9_10_3Value = (productionOrders[10] * 3);
            int workstation9_11_3Value = (productionOrders[11] * 3);
            int workstation9_12_3Value = (productionOrders[12] * 3);
            int workstation9_13_3Value = (productionOrders[13] * 3);
            int workstation9_14_3Value = (productionOrders[14] * 3);
            int workstation9_15_3Value = (productionOrders[15] * 3);
            int workstation9_18_2Value = (productionOrders[18] * 2);
            int workstation9_19_2Value = (productionOrders[19] * 2);
            int workstation9_20_2Value = (productionOrders[20] * 2);
            int workstation10_1_4Value = (productionOrders[1] * 4);
            int workstation10_2_4Value = (productionOrders[2] * 4);
            int workstation10_3_4Value = (productionOrders[3] * 4);
            int workstation10_4_4Value = (productionOrders[4] * 4);
            int workstation10_5_4Value = (productionOrders[5] * 4);
            int workstation10_6_4Value = (productionOrders[6] * 4);
            int workstation11_1_3Value = (productionOrders[1] * 3);
            int workstation11_2_3Value = (productionOrders[2] * 3);
            int workstation11_3_3Value = (productionOrders[3] * 3);
            int workstation11_4_3Value = (productionOrders[4] * 3);
            int workstation11_5_3Value = (productionOrders[5] * 3);
            int workstation11_6_3Value = (productionOrders[6] * 3);
            int workstation12_10_3Value = (productionOrders[10] * 3);
            int workstation12_11_3Value = (productionOrders[11] * 3);
            int workstation12_12_3Value = (productionOrders[12] * 3);
            int workstation12_13_3Value = (productionOrders[13] * 3);
            int workstation12_14_3Value = (productionOrders[14] * 3);
            int workstation12_15_3Value = (productionOrders[15] * 3);
            int workstation13_10_2Value = (productionOrders[10] * 2);
            int workstation13_11_2Value = (productionOrders[11] * 2);
            int workstation13_12_2Value = (productionOrders[12] * 2);
            int workstation13_13_2Value = (productionOrders[13] * 2);
            int workstation13_14_2Value = (productionOrders[14] * 2);
            int workstation13_15_2Value = (productionOrders[15] * 2);
            int workstation14_16_3Value = (productionOrders[16] * 3);
            int workstation15_17_3Value = (productionOrders[17] * 3);
            int workstation15_26_3Value = (productionOrders[26] * 3);

            workstation1_29_6.Text = workstation1_29_6Value.ToString();
            workstation1_49_6.Text = workstation1_49_6Value.ToString();
            workstation1_54_6.Text = workstation1_54_6Value.ToString();
            workstation2_30_5.Text = workstation2_30_5Value.ToString();
            workstation2_50_5.Text = workstation2_50_5Value.ToString();
            workstation2_55_5.Text = workstation2_55_5Value.ToString();
            workstation3_31_6.Text = workstation3_31_6Value.ToString();
            workstation3_51_5.Text = workstation3_51_5Value.ToString();
            workstation3_56_6.Text = workstation3_56_6Value.ToString();
            workstation4_1_6.Text = workstation4_1_6Value.ToString();
            workstation4_2_7.Text = workstation4_2_7Value.ToString();
            workstation4_3_7.Text = workstation4_3_7Value.ToString();
            workstation6_16_2.Text = workstation6_16_2Value.ToString();
            workstation6_18_3.Text = workstation6_18_3Value.ToString();
            workstation6_19_3.Text = workstation6_19_3Value.ToString();
            workstation6_20_3.Text = workstation6_20_3Value.ToString();
            workstation7_10_2.Text = workstation7_10_2Value.ToString();
            workstation7_11_2.Text = workstation7_11_2Value.ToString();
            workstation7_12_2.Text = workstation7_12_2Value.ToString();
            workstation7_13_2.Text = workstation7_13_2Value.ToString();
            workstation7_14_2.Text = workstation7_14_2Value.ToString();
            workstation7_15_2.Text = workstation7_15_2Value.ToString();
            workstation7_18_2.Text = workstation7_18_2Value.ToString();
            workstation7_19_2.Text = workstation7_19_2Value.ToString();
            workstation7_20_2.Text = workstation7_20_2Value.ToString();
            workstation7_26_2.Text = workstation7_26_2Value.ToString();
            workstation8_10_2.Text = workstation8_10_2Value.ToString();
            workstation8_11_2.Text = workstation8_11_2Value.ToString();
            workstation8_12_2.Text = workstation8_12_2Value.ToString();
            workstation8_13_2.Text = workstation8_13_2Value.ToString();
            workstation8_14_1.Text = workstation8_14_1Value.ToString();
            workstation8_15_2.Text = workstation8_15_2Value.ToString();
            workstation8_18_3.Text = workstation8_18_3Value.ToString();
            workstation8_19_3.Text = workstation8_19_3Value.ToString();
            workstation8_20_3.Text = workstation8_20_3Value.ToString();
            workstation9_10_3.Text = workstation9_10_3Value.ToString();
            workstation9_11_3.Text = workstation9_11_3Value.ToString();
            workstation9_12_3.Text = workstation9_12_3Value.ToString();
            workstation9_13_3.Text = workstation9_13_3Value.ToString();
            workstation9_14_3.Text = workstation9_14_3Value.ToString();
            workstation9_15_3.Text = workstation9_15_3Value.ToString();
            workstation9_18_2.Text = workstation9_18_2Value.ToString();
            workstation9_19_2.Text = workstation9_19_2Value.ToString();
            workstation9_20_2.Text = workstation9_20_2Value.ToString();
            workstation10_1_4.Text = workstation10_1_4Value.ToString();
            workstation10_2_4.Text = workstation10_2_4Value.ToString();
            workstation10_3_4.Text = workstation10_3_4Value.ToString();
            workstation10_4_4.Text = workstation10_4_4Value.ToString();
            workstation10_5_4.Text = workstation10_5_4Value.ToString();
            workstation10_6_4.Text = workstation10_6_4Value.ToString();
            workstation11_1_3.Text = workstation11_1_3Value.ToString();
            workstation11_2_3.Text = workstation11_2_3Value.ToString();
            workstation11_3_3.Text = workstation11_3_3Value.ToString();
            workstation11_4_3.Text = workstation11_4_3Value.ToString();
            workstation11_5_3.Text = workstation11_5_3Value.ToString();
            workstation11_6_3.Text = workstation11_6_3Value.ToString();
            workstation12_10_3.Text = workstation12_10_3Value.ToString();
            workstation12_11_3.Text = workstation12_11_3Value.ToString();
            workstation12_12_3.Text = workstation12_12_3Value.ToString();
            workstation12_13_3.Text = workstation12_13_3Value.ToString();
            workstation12_14_3.Text = workstation12_14_3Value.ToString();
            workstation12_15_3.Text = workstation12_15_3Value.ToString();
            workstation13_10_2.Text = workstation13_10_2Value.ToString();
            workstation13_11_2.Text = workstation13_11_2Value.ToString();
            workstation13_12_2.Text = workstation13_12_2Value.ToString();
            workstation13_13_2.Text = workstation13_13_2Value.ToString();
            workstation13_14_2.Text = workstation13_14_2Value.ToString();
            workstation13_15_2.Text = workstation13_15_2Value.ToString();
            workstation14_16_3.Text = workstation14_16_3Value.ToString();
            workstation15_17_3.Text = workstation15_17_3Value.ToString();
            workstation15_26_3.Text = workstation15_26_3Value.ToString();

            addCapacityRequirements[1] = workstation1_49_6Value + workstation1_29_6Value + workstation1_54_6Value;
            addCapacityRequirements[2] = workstation2_50_5Value + workstation2_55_5Value + workstation2_30_5Value;
            addCapacityRequirements[3] = workstation3_51_5Value + workstation3_56_6Value + workstation3_31_6Value;
            addCapacityRequirements[4] = workstation4_1_6Value + workstation4_2_7Value + workstation4_3_7Value;
            addCapacityRequirements[6] = workstation6_16_2Value + workstation6_18_3Value + workstation6_19_3Value + workstation6_20_3Value;
            addCapacityRequirements[7] = workstation7_10_2Value + workstation7_11_2Value + workstation7_12_2Value + workstation7_13_2Value + workstation7_14_2Value + workstation7_15_2Value + workstation7_18_2Value + workstation7_19_2Value + workstation7_20_2Value + workstation7_26_2Value;
            addCapacityRequirements[8] = workstation8_10_2Value + workstation8_11_2Value + workstation8_12_2Value + workstation8_13_2Value + workstation8_14_1Value + workstation8_15_2Value + workstation8_18_3Value + workstation8_19_3Value + workstation8_20_3Value;
            addCapacityRequirements[9] = workstation9_10_3Value + workstation9_11_3Value + workstation9_12_3Value + workstation9_13_3Value + workstation9_14_3Value + workstation9_15_3Value + workstation9_18_2Value + workstation9_19_2Value + workstation9_20_2Value;
            addCapacityRequirements[10] = workstation10_1_4Value + workstation10_2_4Value + workstation10_3_4Value + workstation10_4_4Value + workstation10_5_4Value + workstation10_6_4Value;
            addCapacityRequirements[11] = workstation11_1_3Value + workstation11_2_3Value + workstation11_3_3Value + workstation11_4_3Value + workstation11_5_3Value + workstation11_6_3Value;
            addCapacityRequirements[12] = workstation12_10_3Value + workstation12_11_3Value + workstation12_12_3Value + workstation12_13_3Value + workstation12_14_3Value + workstation12_15_3Value;
            addCapacityRequirements[13] = workstation13_10_2Value + workstation13_11_2Value + workstation13_12_2Value + workstation13_13_2Value + workstation13_14_2Value + workstation13_15_2Value;
            addCapacityRequirements[14] = workstation14_16_3Value;
            addCapacityRequirements[15] = workstation15_17_3Value + workstation15_26_3Value;

            newCapacityReq1.Text = addCapacityRequirements[1].ToString();
            newCapacityReq2.Text = addCapacityRequirements[2].ToString();
            newCapacityReq3.Text = addCapacityRequirements[3].ToString();
            newCapacityReq4.Text = addCapacityRequirements[4].ToString();
            newCapacityReq6.Text = addCapacityRequirements[6].ToString();
            newCapacityReq7.Text = addCapacityRequirements[7].ToString();
            newCapacityReq8.Text = addCapacityRequirements[8].ToString();
            newCapacityReq9.Text = addCapacityRequirements[9].ToString();
            newCapacityReq10.Text = addCapacityRequirements[10].ToString();
            newCapacityReq11.Text = addCapacityRequirements[11].ToString();
            newCapacityReq12.Text = addCapacityRequirements[12].ToString();
            newCapacityReq13.Text = addCapacityRequirements[13].ToString();
            newCapacityReq14.Text = addCapacityRequirements[14].ToString();
            newCapacityReq15.Text = addCapacityRequirements[15].ToString();

            capacityRequirementsBacklog1.Text = waitinglistworkstations[1].ToString();
            capacityRequirementsBacklog2.Text = waitinglistworkstations[2].ToString();
            capacityRequirementsBacklog3.Text = waitinglistworkstations[3].ToString();
            capacityRequirementsBacklog4.Text = waitinglistworkstations[4].ToString();
            capacityRequirementsBacklog6.Text = waitinglistworkstations[6].ToString();
            capacityRequirementsBacklog7.Text = waitinglistworkstations[7].ToString();
            capacityRequirementsBacklog8.Text = waitinglistworkstations[8].ToString();
            capacityRequirementsBacklog9.Text = waitinglistworkstations[9].ToString();
            capacityRequirementsBacklog10.Text = waitinglistworkstations[10].ToString();
            capacityRequirementsBacklog11.Text = waitinglistworkstations[11].ToString();
            capacityRequirementsBacklog12.Text = waitinglistworkstations[12].ToString();
            capacityRequirementsBacklog13.Text = waitinglistworkstations[13].ToString();
            capacityRequirementsBacklog14.Text = waitinglistworkstations[14].ToString();
            capacityRequirementsBacklog15.Text = waitinglistworkstations[15].ToString();

            AssignValue(setupTimeBacklog1, setupTimeBacklog, 1);
            AssignValue(setupTimeBacklog2, setupTimeBacklog, 2);
            AssignValue(setupTimeBacklog3, setupTimeBacklog, 3);
            AssignValue(setupTimeBacklog4, setupTimeBacklog, 4);
            AssignValue(setupTimeBacklog6, setupTimeBacklog, 6);
            AssignValue(setupTimeBacklog7, setupTimeBacklog, 7);
            AssignValue(setupTimeBacklog8, setupTimeBacklog, 8);
            AssignValue(setupTimeBacklog9, setupTimeBacklog, 9);
            AssignValue(setupTimeBacklog10, setupTimeBacklog, 10);
            AssignValue(setupTimeBacklog11, setupTimeBacklog, 11);
            AssignValue(setupTimeBacklog12, setupTimeBacklog, 12);
            AssignValue(setupTimeBacklog13, setupTimeBacklog, 13);
            AssignValue(setupTimeBacklog14, setupTimeBacklog, 14);
            AssignValue(setupTimeBacklog15, setupTimeBacklog, 15);
        }
    }
}
