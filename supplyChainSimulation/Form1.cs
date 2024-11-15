using System.Xml.Linq;

namespace supplyChainSimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void p1_desc_Click(object sender, EventArgs e)
        {

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
                    XDocument xmlDoc = XDocument.Load(filePath);

                    // Validate that it contains a <results> element with required attributes
                    XElement resultsElement = xmlDoc.Element("results");
                    if (resultsElement != null &&
                        resultsElement.Attribute("game") != null &&
                        resultsElement.Attribute("group") != null &&
                        resultsElement.Attribute("period") != null)
                    {
                        // Validation successful
                        MessageBox.Show("XML file is valid and loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Proceed with further processing if necessary
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
    }
}
