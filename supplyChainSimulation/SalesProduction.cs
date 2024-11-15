using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            XElement forecast = rootElement.Element("forecast");

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

            Label_Period0.Text = $"Period {current_period + 1}";
            Label_Period1.Text = $"Period {current_period + 2}";
            Label_Period2.Text = $"Period {current_period + 3}";
            Label_Period3.Text = $"Period {current_period + 4}";

            Label_Period0_1.Text = $"Period {current_period + 1}";
            Label_Period1_1.Text = $"Period {current_period + 2}";
            Label_Period2_1.Text = $"Period {current_period + 3}";
            Label_Period3_1.Text = $"Period {current_period + 4}";
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

            MainOrchestrator mainOrchestrator = (MainOrchestrator)this.ParentForm;
            mainOrchestrator.ShowForm(new MaterialPlanning());
        }
    }
}
