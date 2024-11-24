using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static supplyChainSimulation.SharedData;

namespace supplyChainSimulation
{
    public partial class SalesProduction : Form
    {
        public SalesProduction()
        {
            InitializeComponent();
        }

        private void SalesProduction_Load(object sender, EventArgs e)
        {
            forecast = rootElement.Element("forecast");

            if (forecast != null)
            {
                forecast0[1] = int.TryParse(forecast.Attribute("p1")?.Value, out int p1Value) ? p1Value : 0;
                forecast0[2] = int.TryParse(forecast.Attribute("p2")?.Value, out int p2Value) ? p2Value : 0;
                forecast0[3] = int.TryParse(forecast.Attribute("p3")?.Value, out int p3Value) ? p3Value : 0;
            }
            else
            {
                MessageBox.Show("The <forecast> element is missing. ERROR!", "Breaking Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            SalesXP1.Text = forecast0[1].ToString();
            SalesXP2.Text = forecast0[2].ToString();
            SalesXP3.Text = forecast0[3].ToString();

            ProdXP1_0.Text = forecast0[1].ToString();
            ProdXP2_0.Text = forecast0[2].ToString();
            ProdXP3_0.Text = forecast0[3].ToString();

            var periodFormat = CultureInfo.CurrentCulture.Name.Equals("de", StringComparison.OrdinalIgnoreCase) ? "Periode" : "Period";

            Label_Period0.Text = $"{periodFormat} {current_period + 1}";
            Label_Period1.Text = $"{periodFormat} {current_period + 2}";
            Label_Period2.Text = $"{periodFormat} {current_period + 3}";
            Label_Period3.Text = $"{periodFormat} {current_period + 4}";

            Label_Period0_1.Text = $"{periodFormat} {current_period + 1}";
            Label_Period1_1.Text = $"{periodFormat} {current_period + 2}";
            Label_Period2_1.Text = $"{periodFormat} {current_period + 3}";
            Label_Period3_1.Text = $"{periodFormat} {current_period + 4}";
        }

        private void switchToUpload_Click(object sender, EventArgs e)
        {
            MainOrchestrator mainOrchestrator = (MainOrchestrator)this.ParentForm;
            mainOrchestrator.ShowForm(new Upload());
        }

        private void switchMaterialP1_Click(object sender, EventArgs e)
        {
            forecast1[1] = (int)SalesXP1_1.Value;
            forecast1[2] = (int)SalesXP2_1.Value;
            forecast1[3] = (int)SalesXP3_1.Value;
            forecast2[1] = (int)SalesXP1_2.Value;
            forecast2[2] = (int)SalesXP2_2.Value;
            forecast2[3] = (int)SalesXP3_2.Value;
            forecast3[1] = (int)SalesXP1_3.Value;
            forecast3[2] = (int)SalesXP2_3.Value;
            forecast3[3] = (int)SalesXP3_3.Value;

            production0[1] = (int)ProdXP1_0.Value;
            production0[2] = (int)ProdXP2_0.Value;
            production0[3] = (int)ProdXP3_0.Value;
            production1[1] = (int)ProdXP1_1.Value;
            production1[2] = (int)ProdXP2_1.Value;
            production1[3] = (int)ProdXP3_1.Value;
            production2[1] = (int)ProdXP1_2.Value;
            production2[2] = (int)ProdXP2_2.Value;
            production2[3] = (int)ProdXP3_2.Value;
            production3[1] = (int)ProdXP1_3.Value;
            production3[2] = (int)ProdXP2_3.Value;
            production3[3] = (int)ProdXP3_3.Value;

            directSale0[1] = (int)DirectXP1_0.Value;
            directSale0[2] = (int)DirectXP2_0.Value;
            directSale0[3] = (int)DirectXP3_0.Value;
            directSale1[1] = (int)DirectXP1_1.Value;
            directSale1[2] = (int)DirectXP2_1.Value;
            directSale1[3] = (int)DirectXP3_1.Value;
            directSale2[1] = (int)DirectXP1_2.Value;
            directSale2[2] = (int)DirectXP2_2.Value;
            directSale2[3] = (int)DirectXP3_2.Value;

            MainOrchestrator mainOrchestrator = (MainOrchestrator)this.ParentForm;
            mainOrchestrator.ShowForm(new MaterialPlanning());
        }
    }
}
