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
    public partial class MaterialPlanning_P2 : Form
    {
        public MaterialPlanning_P2()
        {
            InitializeComponent();
        }

        private void CalculateTable(object sender = null, EventArgs e = null)
        {

        }

        private void switchMaterialP1_Click(object sender, EventArgs e)
        {
            MainOrchestrator mainOrchestrator = (MainOrchestrator)this.ParentForm;
            mainOrchestrator.ShowForm(new MaterialPlanning());
        }

        private void switchMaterialP3_Click(object sender, EventArgs e)
        {
            MainOrchestrator mainOrchestrator = (MainOrchestrator)this.ParentForm;
            mainOrchestrator.ShowForm(new MaterialPlanning_P3());
        }
    }
}
