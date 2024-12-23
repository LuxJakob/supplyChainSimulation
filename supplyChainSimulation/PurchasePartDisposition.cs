﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static supplyChainSimulation.SharedData;

namespace supplyChainSimulation
{
    public partial class PurchasePartDisposition : Form
    {
        public PurchasePartDisposition()
        {
            InitializeComponent();

            string periodLabel = CultureInfo.CurrentCulture.Name.Equals("de", StringComparison.OrdinalIgnoreCase) ? "Periode" : "Period";

            Label_PeriodProg0.Text = $"{periodLabel} {current_period + 1}";
            Label_PeriodProg1.Text = $"{periodLabel} {current_period + 2}";
            Label_PeriodProg2.Text = $"{periodLabel} {current_period + 3}";
            Label_PeriodProg3.Text = $"{periodLabel} {current_period + 4}";
            Label_PeriodFuture0.Text = $"{periodLabel} {current_period + 1}";
            Label_PeriodFuture1.Text = $"{periodLabel} {current_period + 2}";
            Label_PeriodFuture2.Text = $"{periodLabel} {current_period + 3}";
            Label_PeriodFuture3.Text = $"{periodLabel} {current_period + 4}";

            InventoryK21.Text = warehousestock[21].ToString();
            InventoryK22.Text = warehousestock[22].ToString();
            InventoryK23.Text = warehousestock[23].ToString();
            InventoryK24.Text = warehousestock[24].ToString();
            InventoryK25.Text = warehousestock[25].ToString();
            InventoryK27.Text = warehousestock[27].ToString();
            InventoryK28.Text = warehousestock[28].ToString();
            InventoryK32.Text = warehousestock[32].ToString();
            InventoryK33.Text = warehousestock[33].ToString();
            InventoryK34.Text = warehousestock[34].ToString();
            InventoryK35.Text = warehousestock[35].ToString();
            InventoryK36.Text = warehousestock[36].ToString();
            InventoryK37.Text = warehousestock[37].ToString();
            InventoryK38.Text = warehousestock[38].ToString();
            InventoryK39.Text = warehousestock[39].ToString();
            InventoryK40.Text = warehousestock[40].ToString();
            InventoryK41.Text = warehousestock[41].ToString();
            InventoryK42.Text = warehousestock[42].ToString();
            InventoryK43.Text = warehousestock[43].ToString();
            InventoryK44.Text = warehousestock[44].ToString();
            InventoryK45.Text = warehousestock[45].ToString();
            InventoryK46.Text = warehousestock[46].ToString();
            InventoryK47.Text = warehousestock[47].ToString();
            InventoryK48.Text = warehousestock[48].ToString();
            InventoryK52.Text = warehousestock[52].ToString();
            InventoryK53.Text = warehousestock[53].ToString();
            InventoryK57.Text = warehousestock[57].ToString();
            InventoryK58.Text = warehousestock[58].ToString();
            InventoryK59.Text = warehousestock[59].ToString();

            CalcRequirements();

            if (initialInitPurchase == 0)
            {
                InwardStock();

                initialInitPurchase = 1;
            }

            CalcFutureStock();

            ColoringTheFuture();
        }

        private void switchCapacityPlanning_Click(object sender, EventArgs e)
        {
            MainOrchestrator mainOrchestrator = (MainOrchestrator)this.ParentForm;
            mainOrchestrator.ShowForm(new CapacityPlanning());
        }

        private void InwardStock()
        {
            futureinwardstockmovement = rootElement.Element("futureinwardstockmovement");
            foreach (var stock in futureinwardstockmovement.Elements("order"))
            {
                int article = int.TryParse(stock.Attribute("article")?.Value, out int articleValue) ? articleValue : 0;
                int amount = int.TryParse(stock.Attribute("amount")?.Value, out int amountValue) ? amountValue : 0;
                int orderperiod = int.TryParse(stock.Attribute("orderperiod")?.Value, out int orderperiodValue) ? orderperiodValue : 0;
                int ordermode = int.TryParse(stock.Attribute("mode")?.Value, out int modeValue) ? modeValue : 0;

                futureStockList.Add((article, amount, orderperiod, ((ordermode - 4) * 2)));
            }
        }

        private void ColoringTheFuture()
        {
            foreach (var pick in discountQuantity)
            {
                int id = pick.Key;
                for (int i = 0; i < 4; i++)
                {
                    string labelName = $"FutureK{id}_{i}";

                    var label = this.Controls.Find(labelName, true).FirstOrDefault() as Label;

                    if (label != null)
                    {
                        int value = Int32.Parse(label.Text);
                        if (value > 0)
                        {
                            if (evenRows.Contains(id))
                            {
                                label.BackColor = DefaultBackColor;
                            }
                            else
                            {
                                label.BackColor = Color.Gainsboro;
                            }
                        }
                        else
                        {
                            label.BackColor = Color.Red;
                        }
                    }
                }
            }
        }

        private void switchBuildXML_Click(object sender, EventArgs e)
        {
            purchaseParts[21] = ((int)OrderQuantity21.Value, (OrderModeK21.SelectedIndex + 4));
            purchaseParts[22] = ((int)OrderQuantity22.Value, (OrderModeK22.SelectedIndex + 4));
            purchaseParts[23] = ((int)OrderQuantity23.Value, (OrderModeK23.SelectedIndex + 4));
            purchaseParts[24] = ((int)OrderQuantity24.Value, (OrderModeK24.SelectedIndex + 4));
            purchaseParts[25] = ((int)OrderQuantity25.Value, (OrderModeK25.SelectedIndex + 4));
            purchaseParts[27] = ((int)OrderQuantity27.Value, (OrderModeK27.SelectedIndex + 4));
            purchaseParts[28] = ((int)OrderQuantity28.Value, (OrderModeK28.SelectedIndex + 4));
            purchaseParts[32] = ((int)OrderQuantity32.Value, (OrderModeK32.SelectedIndex + 4));
            purchaseParts[33] = ((int)OrderQuantity33.Value, (OrderModeK33.SelectedIndex + 4));
            purchaseParts[34] = ((int)OrderQuantity34.Value, (OrderModeK34.SelectedIndex + 4));
            purchaseParts[35] = ((int)OrderQuantity35.Value, (OrderModeK35.SelectedIndex + 4));
            purchaseParts[36] = ((int)OrderQuantity36.Value, (OrderModeK36.SelectedIndex + 4));
            purchaseParts[37] = ((int)OrderQuantity37.Value, (OrderModeK37.SelectedIndex + 4));
            purchaseParts[38] = ((int)OrderQuantity38.Value, (OrderModeK38.SelectedIndex + 4));
            purchaseParts[39] = ((int)OrderQuantity39.Value, (OrderModeK39.SelectedIndex + 4));
            purchaseParts[40] = ((int)OrderQuantity40.Value, (OrderModeK40.SelectedIndex + 4));
            purchaseParts[41] = ((int)OrderQuantity41.Value, (OrderModeK41.SelectedIndex + 4));
            purchaseParts[42] = ((int)OrderQuantity42.Value, (OrderModeK42.SelectedIndex + 4));
            purchaseParts[43] = ((int)OrderQuantity43.Value, (OrderModeK43.SelectedIndex + 4));
            purchaseParts[44] = ((int)OrderQuantity44.Value, (OrderModeK44.SelectedIndex + 4));
            purchaseParts[45] = ((int)OrderQuantity45.Value, (OrderModeK45.SelectedIndex + 4));
            purchaseParts[46] = ((int)OrderQuantity46.Value, (OrderModeK46.SelectedIndex + 4));
            purchaseParts[47] = ((int)OrderQuantity47.Value, (OrderModeK47.SelectedIndex + 4));
            purchaseParts[48] = ((int)OrderQuantity48.Value, (OrderModeK48.SelectedIndex + 4));
            purchaseParts[52] = ((int)OrderQuantity52.Value, (OrderModeK52.SelectedIndex + 4));
            purchaseParts[53] = ((int)OrderQuantity53.Value, (OrderModeK53.SelectedIndex + 4));
            purchaseParts[57] = ((int)OrderQuantity57.Value, (OrderModeK57.SelectedIndex + 4));
            purchaseParts[58] = ((int)OrderQuantity58.Value, (OrderModeK58.SelectedIndex + 4));
            purchaseParts[59] = ((int)OrderQuantity59.Value, (OrderModeK59.SelectedIndex + 4));



            MainOrchestrator mainOrchestrator = (MainOrchestrator)this.ParentForm;
            mainOrchestrator.ShowForm(new BuildXML());
        }

        private void CalcRequirements()
        {
            foreach (var part in partUsage)
            {
                int id = part.Key;

                requirement0[id] = (production0[1] * part.Value.Item1) + (production0[2] * part.Value.Item2) + (production0[3] * part.Value.Item3);
                requirement1[id] = (production1[1] * part.Value.Item1) + (production1[2] * part.Value.Item2) + (production1[3] * part.Value.Item3);
                requirement2[id] = (production2[1] * part.Value.Item1) + (production2[2] * part.Value.Item2) + (production2[3] * part.Value.Item3);
                requirement3[id] = (production3[1] * part.Value.Item1) + (production3[2] * part.Value.Item2) + (production3[3] * part.Value.Item3);
            }

            RequK21_0.Text = requirement0[21].ToString();
            RequK21_1.Text = requirement1[21].ToString();
            RequK21_2.Text = requirement2[21].ToString();
            RequK21_3.Text = requirement3[21].ToString();
            RequK22_0.Text = requirement0[22].ToString();
            RequK22_1.Text = requirement1[22].ToString();
            RequK22_2.Text = requirement2[22].ToString();
            RequK22_3.Text = requirement3[22].ToString();
            RequK23_0.Text = requirement0[23].ToString();
            RequK23_1.Text = requirement1[23].ToString();
            RequK23_2.Text = requirement2[23].ToString();
            RequK23_3.Text = requirement3[23].ToString();
            RequK24_0.Text = requirement0[24].ToString();
            RequK24_1.Text = requirement1[24].ToString();
            RequK24_2.Text = requirement2[24].ToString();
            RequK24_3.Text = requirement3[24].ToString();
            RequK25_0.Text = requirement0[25].ToString();
            RequK25_1.Text = requirement1[25].ToString();
            RequK25_2.Text = requirement2[25].ToString();
            RequK25_3.Text = requirement3[25].ToString();
            RequK27_0.Text = requirement0[27].ToString();
            RequK27_1.Text = requirement1[27].ToString();
            RequK27_2.Text = requirement2[27].ToString();
            RequK27_3.Text = requirement3[27].ToString();
            RequK28_0.Text = requirement0[28].ToString();
            RequK28_1.Text = requirement1[28].ToString();
            RequK28_2.Text = requirement2[28].ToString();
            RequK28_3.Text = requirement3[28].ToString();
            RequK32_0.Text = requirement0[32].ToString();
            RequK32_1.Text = requirement1[32].ToString();
            RequK32_2.Text = requirement2[32].ToString();
            RequK32_3.Text = requirement3[32].ToString();
            RequK33_0.Text = requirement0[33].ToString();
            RequK33_1.Text = requirement1[33].ToString();
            RequK33_2.Text = requirement2[33].ToString();
            RequK33_3.Text = requirement3[33].ToString();
            RequK34_0.Text = requirement0[34].ToString();
            RequK34_1.Text = requirement1[34].ToString();
            RequK34_2.Text = requirement2[34].ToString();
            RequK34_3.Text = requirement3[34].ToString();
            RequK35_0.Text = requirement0[35].ToString();
            RequK35_1.Text = requirement1[35].ToString();
            RequK35_2.Text = requirement2[35].ToString();
            RequK35_3.Text = requirement3[35].ToString();
            RequK36_0.Text = requirement0[36].ToString();
            RequK36_1.Text = requirement1[36].ToString();
            RequK36_2.Text = requirement2[36].ToString();
            RequK36_3.Text = requirement3[36].ToString();
            RequK37_0.Text = requirement0[37].ToString();
            RequK37_1.Text = requirement1[37].ToString();
            RequK37_2.Text = requirement2[37].ToString();
            RequK37_3.Text = requirement3[37].ToString();
            RequK38_0.Text = requirement0[38].ToString();
            RequK38_1.Text = requirement1[38].ToString();
            RequK38_2.Text = requirement2[38].ToString();
            RequK38_3.Text = requirement3[38].ToString();
            RequK39_0.Text = requirement0[39].ToString();
            RequK39_1.Text = requirement1[39].ToString();
            RequK39_2.Text = requirement2[39].ToString();
            RequK39_3.Text = requirement3[39].ToString();
            RequK40_0.Text = requirement0[40].ToString();
            RequK40_1.Text = requirement1[40].ToString();
            RequK40_2.Text = requirement2[40].ToString();
            RequK40_3.Text = requirement3[40].ToString();
            RequK41_0.Text = requirement0[41].ToString();
            RequK41_1.Text = requirement1[41].ToString();
            RequK41_2.Text = requirement2[41].ToString();
            RequK41_3.Text = requirement3[41].ToString();
            RequK42_0.Text = requirement0[42].ToString();
            RequK42_1.Text = requirement1[42].ToString();
            RequK42_2.Text = requirement2[42].ToString();
            RequK42_3.Text = requirement3[42].ToString();
            RequK43_0.Text = requirement0[43].ToString();
            RequK43_1.Text = requirement1[43].ToString();
            RequK43_2.Text = requirement2[43].ToString();
            RequK43_3.Text = requirement3[43].ToString();
            RequK44_0.Text = requirement0[44].ToString();
            RequK44_1.Text = requirement1[44].ToString();
            RequK44_2.Text = requirement2[44].ToString();
            RequK44_3.Text = requirement3[44].ToString();
            RequK45_0.Text = requirement0[45].ToString();
            RequK45_1.Text = requirement1[45].ToString();
            RequK45_2.Text = requirement2[45].ToString();
            RequK45_3.Text = requirement3[45].ToString();
            RequK46_0.Text = requirement0[46].ToString();
            RequK46_1.Text = requirement1[46].ToString();
            RequK46_2.Text = requirement2[46].ToString();
            RequK46_3.Text = requirement3[46].ToString();
            RequK47_0.Text = requirement0[47].ToString();
            RequK47_1.Text = requirement1[47].ToString();
            RequK47_2.Text = requirement2[47].ToString();
            RequK47_3.Text = requirement3[47].ToString();
            RequK48_0.Text = requirement0[48].ToString();
            RequK48_1.Text = requirement1[48].ToString();
            RequK48_2.Text = requirement2[48].ToString();
            RequK48_3.Text = requirement3[48].ToString();
            RequK52_0.Text = requirement0[52].ToString();
            RequK52_1.Text = requirement1[52].ToString();
            RequK52_2.Text = requirement2[52].ToString();
            RequK52_3.Text = requirement3[52].ToString();
            RequK53_0.Text = requirement0[53].ToString();
            RequK53_1.Text = requirement1[53].ToString();
            RequK53_2.Text = requirement2[53].ToString();
            RequK53_3.Text = requirement3[53].ToString();
            RequK57_0.Text = requirement0[57].ToString();
            RequK57_1.Text = requirement1[57].ToString();
            RequK57_2.Text = requirement2[57].ToString();
            RequK57_3.Text = requirement3[57].ToString();
            RequK58_0.Text = requirement0[58].ToString();
            RequK58_1.Text = requirement1[58].ToString();
            RequK58_2.Text = requirement2[58].ToString();
            RequK58_3.Text = requirement3[58].ToString();
            RequK59_0.Text = requirement0[59].ToString();
            RequK59_1.Text = requirement1[59].ToString();
            RequK59_2.Text = requirement2[59].ToString();
            RequK59_3.Text = requirement3[59].ToString();
        }

        private void CalcFutureStock()
        {
            foreach (var part in partUsage)
            {
                int id = part.Key;

                incomingStocks[0] = 0;
                incomingStocks[1] = 0;
                incomingStocks[2] = 0;
                incomingStocks[3] = 0;

                foreach (var stock in futureStockList)
                {
                    if (stock.Item1 == id)
                    {
                        int incomingPeriod = stock.Item3 + (int)Math.Ceiling(deliveryTime[id].Item1 + ((deliveryTime[id].Item2 * stock.Item4) / 2));

                        int diff = incomingPeriod - (current_period + 1);
                        incomingStocks[diff] = stock.Item2;
                    }
                }

                futureStock0[id] = warehousestock[id] - (requirement0[id])
                    + incomingStocks[0];
                futureStock1[id] = warehousestock[id] - (requirement0[id] + requirement1[id])
                    + incomingStocks[1] + incomingStocks[0];
                futureStock2[id] = warehousestock[id] - (requirement0[id] + requirement1[id] + requirement2[id])
                    + incomingStocks[2] + incomingStocks[1] + incomingStocks[0];
                futureStock3[id] = warehousestock[id] - (requirement0[id] + requirement1[id] + requirement2[id] + requirement3[id])
                    + incomingStocks[3] + incomingStocks[2] + incomingStocks[1] + incomingStocks[0];
            }

            FutureK21_0.Text = futureStock0[21].ToString();
            FutureK21_1.Text = futureStock1[21].ToString();
            FutureK21_2.Text = futureStock2[21].ToString();
            FutureK21_3.Text = futureStock3[21].ToString();
            FutureK22_0.Text = futureStock0[22].ToString();
            FutureK22_1.Text = futureStock1[22].ToString();
            FutureK22_2.Text = futureStock2[22].ToString();
            FutureK22_3.Text = futureStock3[22].ToString();
            FutureK23_0.Text = futureStock0[23].ToString();
            FutureK23_1.Text = futureStock1[23].ToString();
            FutureK23_2.Text = futureStock2[23].ToString();
            FutureK23_3.Text = futureStock3[23].ToString();
            FutureK24_0.Text = futureStock0[24].ToString();
            FutureK24_1.Text = futureStock1[24].ToString();
            FutureK24_2.Text = futureStock2[24].ToString();
            FutureK24_3.Text = futureStock3[24].ToString();
            FutureK25_0.Text = futureStock0[25].ToString();
            FutureK25_1.Text = futureStock1[25].ToString();
            FutureK25_2.Text = futureStock2[25].ToString();
            FutureK25_3.Text = futureStock3[25].ToString();
            FutureK27_0.Text = futureStock0[27].ToString();
            FutureK27_1.Text = futureStock1[27].ToString();
            FutureK27_2.Text = futureStock2[27].ToString();
            FutureK27_3.Text = futureStock3[27].ToString();
            FutureK28_0.Text = futureStock0[28].ToString();
            FutureK28_1.Text = futureStock1[28].ToString();
            FutureK28_2.Text = futureStock2[28].ToString();
            FutureK28_3.Text = futureStock3[28].ToString();
            FutureK32_0.Text = futureStock0[32].ToString();
            FutureK32_1.Text = futureStock1[32].ToString();
            FutureK32_2.Text = futureStock2[32].ToString();
            FutureK32_3.Text = futureStock3[32].ToString();
            FutureK33_0.Text = futureStock0[33].ToString();
            FutureK33_1.Text = futureStock1[33].ToString();
            FutureK33_2.Text = futureStock2[33].ToString();
            FutureK33_3.Text = futureStock3[33].ToString();
            FutureK34_0.Text = futureStock0[34].ToString();
            FutureK34_1.Text = futureStock1[34].ToString();
            FutureK34_2.Text = futureStock2[34].ToString();
            FutureK34_3.Text = futureStock3[34].ToString();
            FutureK35_0.Text = futureStock0[35].ToString();
            FutureK35_1.Text = futureStock1[35].ToString();
            FutureK35_2.Text = futureStock2[35].ToString();
            FutureK35_3.Text = futureStock3[35].ToString();
            FutureK36_0.Text = futureStock0[36].ToString();
            FutureK36_1.Text = futureStock1[36].ToString();
            FutureK36_2.Text = futureStock2[36].ToString();
            FutureK36_3.Text = futureStock3[36].ToString();
            FutureK37_0.Text = futureStock0[37].ToString();
            FutureK37_1.Text = futureStock1[37].ToString();
            FutureK37_2.Text = futureStock2[37].ToString();
            FutureK37_3.Text = futureStock3[37].ToString();
            FutureK38_0.Text = futureStock0[38].ToString();
            FutureK38_1.Text = futureStock1[38].ToString();
            FutureK38_2.Text = futureStock2[38].ToString();
            FutureK38_3.Text = futureStock3[38].ToString();
            FutureK39_0.Text = futureStock0[39].ToString();
            FutureK39_1.Text = futureStock1[39].ToString();
            FutureK39_2.Text = futureStock2[39].ToString();
            FutureK39_3.Text = futureStock3[39].ToString();
            FutureK40_0.Text = futureStock0[40].ToString();
            FutureK40_1.Text = futureStock1[40].ToString();
            FutureK40_2.Text = futureStock2[40].ToString();
            FutureK40_3.Text = futureStock3[40].ToString();
            FutureK41_0.Text = futureStock0[41].ToString();
            FutureK41_1.Text = futureStock1[41].ToString();
            FutureK41_2.Text = futureStock2[41].ToString();
            FutureK41_3.Text = futureStock3[41].ToString();
            FutureK42_0.Text = futureStock0[42].ToString();
            FutureK42_1.Text = futureStock1[42].ToString();
            FutureK42_2.Text = futureStock2[42].ToString();
            FutureK42_3.Text = futureStock3[42].ToString();
            FutureK43_0.Text = futureStock0[43].ToString();
            FutureK43_1.Text = futureStock1[43].ToString();
            FutureK43_2.Text = futureStock2[43].ToString();
            FutureK43_3.Text = futureStock3[43].ToString();
            FutureK44_0.Text = futureStock0[44].ToString();
            FutureK44_1.Text = futureStock1[44].ToString();
            FutureK44_2.Text = futureStock2[44].ToString();
            FutureK44_3.Text = futureStock3[44].ToString();
            FutureK45_0.Text = futureStock0[45].ToString();
            FutureK45_1.Text = futureStock1[45].ToString();
            FutureK45_2.Text = futureStock2[45].ToString();
            FutureK45_3.Text = futureStock3[45].ToString();
            FutureK46_0.Text = futureStock0[46].ToString();
            FutureK46_1.Text = futureStock1[46].ToString();
            FutureK46_2.Text = futureStock2[46].ToString();
            FutureK46_3.Text = futureStock3[46].ToString();
            FutureK47_0.Text = futureStock0[47].ToString();
            FutureK47_1.Text = futureStock1[47].ToString();
            FutureK47_2.Text = futureStock2[47].ToString();
            FutureK47_3.Text = futureStock3[47].ToString();
            FutureK48_0.Text = futureStock0[48].ToString();
            FutureK48_1.Text = futureStock1[48].ToString();
            FutureK48_2.Text = futureStock2[48].ToString();
            FutureK48_3.Text = futureStock3[48].ToString();
            FutureK52_0.Text = futureStock0[52].ToString();
            FutureK52_1.Text = futureStock1[52].ToString();
            FutureK52_2.Text = futureStock2[52].ToString();
            FutureK52_3.Text = futureStock3[52].ToString();
            FutureK53_0.Text = futureStock0[53].ToString();
            FutureK53_1.Text = futureStock1[53].ToString();
            FutureK53_2.Text = futureStock2[53].ToString();
            FutureK53_3.Text = futureStock3[53].ToString();
            FutureK57_0.Text = futureStock0[57].ToString();
            FutureK57_1.Text = futureStock1[57].ToString();
            FutureK57_2.Text = futureStock2[57].ToString();
            FutureK57_3.Text = futureStock3[57].ToString();
            FutureK58_0.Text = futureStock0[58].ToString();
            FutureK58_1.Text = futureStock1[58].ToString();
            FutureK58_2.Text = futureStock2[58].ToString();
            FutureK58_3.Text = futureStock3[58].ToString();
            FutureK59_0.Text = futureStock0[59].ToString();
            FutureK59_1.Text = futureStock1[59].ToString();
            FutureK59_2.Text = futureStock2[59].ToString();
            FutureK59_3.Text = futureStock3[59].ToString();
        }

        private void orderModeChange(object sender, EventArgs e)
        {
            string comboName = ((ComboBox)sender).Name;

            string labelnumber = comboName.Substring(comboName.Length - 2);

            string numericName = $"OrderQuantity{labelnumber}";

            var numericThingy = this.Controls.Find(numericName, true).FirstOrDefault() as NumericUpDown;

            if (numericThingy != null)
            {
                if (numericThingy.Value == 0)
                {
                    ((ComboBox)sender).SelectedIndex = -1;
                }
            }

        }

        private void orderQuantityChange(object sender, EventArgs e)
        {
            string numericName = ((NumericUpDown)sender).Name;

            string labelnumber = numericName.Substring(numericName.Length - 2);

            string comboBoxName = $"OrderModeK{labelnumber}";

            var comboBox = this.Controls.Find(comboBoxName, true).FirstOrDefault() as ComboBox;

            if (comboBox != null)
            {
                if (((NumericUpDown)sender).Value != 0)
                {
                    if (comboBox.SelectedIndex == -1)
                    {
                        comboBox.SelectedIndex = 1;
                    }
                }
                else
                {
                    comboBox.SelectedIndex = -1;
                }
            }
        }
    }
}
