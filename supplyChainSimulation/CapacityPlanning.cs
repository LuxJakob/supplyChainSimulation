using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supplyChainSimulation
{
    public partial class CapacityPlanning : Form
    {
        public CapacityPlanning()
        {
            InitializeComponent();
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
