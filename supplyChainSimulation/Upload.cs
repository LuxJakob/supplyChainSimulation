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
using static System.Windows.Forms.DataFormats;

namespace supplyChainSimulation
{
    public partial class Upload : Form
    {
        public Upload()
        {
            InitializeComponent();
        }

        private void p1_uploadXML_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*",
                Title = "Select an XML File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    SharedData.XML_doc = XDocument.Load(filePath);

                    // Validate that it contains a <results> element with required attributes
                    XElement resultsElement = SharedData.XML_doc.Element("results");
                    if (resultsElement != null &&
                        resultsElement.Attribute("game") != null &&
                        resultsElement.Attribute("group") != null &&
                        resultsElement.Attribute("period") != null)
                    {
                        // Validation successful
                        MessageBox.Show("XML file is valid and loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        switchToLieferProdProg.Enabled = true;
                    }
                    else
                    {
                        // Validation failed
                        MessageBox.Show("XML file is invalid. Please upload your result file.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading XML file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void switchToLieferProdProg_Click(object sender, EventArgs e)
        {
            MainOrchestrator mainOrchestrator = (MainOrchestrator)this.ParentForm;
            mainOrchestrator.ShowForm(new SalesProduction());
        }

        private void Upload_Load(object sender, EventArgs e)
        {

        }
    }
}
