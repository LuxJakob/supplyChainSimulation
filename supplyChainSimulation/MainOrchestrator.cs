using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace supplyChainSimulation
{
    public partial class MainOrchestrator : Form
    {
        private Form currentForm;

        public MainOrchestrator()
        {
            InitializeComponent();
            ShowForm(new Upload());
        }

        private void MainOrchestrator_Load(object sender, EventArgs e)
        {

        }

        public void ShowForm(Form form)
        {
            if (currentForm != null)
                currentForm.Close();

            currentForm = form;
            currentForm.TopLevel = false;
            currentForm.FormBorderStyle = FormBorderStyle.None;
            currentForm.Dock = DockStyle.Fill;
            this.Controls.Add(currentForm);
            currentForm.Show();
        }
    }
}
