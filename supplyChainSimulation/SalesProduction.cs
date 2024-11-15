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
    public partial class SalesProduction : Form
    {
        public SalesProduction()
        {
            InitializeComponent();
        }

        private void SalesProduction_Load(object sender, EventArgs e)
        {

        }

        private void switchToUpload_Click(object sender, EventArgs e)
        {
            MainOrchestrator mainOrchestrator = (MainOrchestrator)this.ParentForm;
            mainOrchestrator.ShowForm(new Upload());
        }

        private void switchMaterialP1_Click(object sender, EventArgs e)
        {
            MainOrchestrator mainOrchestrator = (MainOrchestrator)this.ParentForm;
            mainOrchestrator.ShowForm(new MaterialPlanning());
        }
    }
}
