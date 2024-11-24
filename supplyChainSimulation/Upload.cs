using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;
using static supplyChainSimulation.SharedData;

namespace supplyChainSimulation
{
    public partial class Upload : Form
    {
        public Upload()
        {
            InitializeComponent();

            initialInitMaterial = 0;
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
                    XML_doc = XDocument.Load(filePath);

                    // Validate that it contains a <results> element with required attributes
                    rootElement = XML_doc.Element("results");
                    if (rootElement != null &&
                        rootElement.Attribute("game") != null &&
                        rootElement.Attribute("group") != null &&
                        rootElement.Attribute("period") != null)
                    {
                        if (CultureInfo.CurrentCulture.Name.Equals("de", StringComparison.OrdinalIgnoreCase))
                        {
                            MessageBox.Show("XML Datei erfolgreich erkannt und geladen!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            current_period = int.TryParse(rootElement.Attribute("period")?.Value, result: out int XValue) ? XValue : 0;
                            switchToLieferProdProg.Enabled = true;

                        }
                        else
                        {
                            // Validation successful
                            MessageBox.Show("XML file is valid and loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            current_period = int.TryParse(rootElement.Attribute("period")?.Value, out int XValue) ? XValue : 0;
                            switchToLieferProdProg.Enabled = true;
                        }
                    }
                    else
                    {
                        if (CultureInfo.CurrentCulture.Name.Equals("de", StringComparison.OrdinalIgnoreCase))
                        {
                            MessageBox.Show("XML Datei ist ungültig", "Validierungsfehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        else
                        {
                            // Validation failed
                            MessageBox.Show("XML file is invalid. Please upload your result file.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
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

        private bool isRestarting = false;

        private void cmbLanguageChange_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected language
            string selectedLanguage = cmbLanguageChange.SelectedItem.ToString();

            // Only trigger the change if the application is not already restarting
            if (!isRestarting)
            {
                string currentLanguage = ConfigurationManager.AppSettings["language"] ?? "en";

                if (selectedLanguage != currentLanguage)
                {
                    // Mark the application as restarting
                    isRestarting = true;

                    // Update language setting and restart application
                    ChangeApplicationLanguage(selectedLanguage);
                }
            }
        }

        private void ChangeApplicationLanguage(string language)
        {
            var changeLanguage = new ChangeLanguage();
            // Update configuration or apply language-specific logic
            if (language == "English")
            {
                changeLanguage.UpdateConfig("language", "en");
            }
            else if (language == "German")
            {
                changeLanguage.UpdateConfig("language", "de");
            }

            // Restart the application
            Application.Restart();
        }
    }
}
