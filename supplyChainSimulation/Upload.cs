using System;
using System.Collections.Generic;
using System.ComponentModel;
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

            // ComboBox für die Sprachauswahl hinzufügen
            ComboBox cmbLanguage = new ComboBox
            {
                Name = "cmbLanguage",
                Location = new System.Drawing.Point(10, 10),
                Size = new System.Drawing.Size(150, 25),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbLanguage.Items.Add("Deutsch");
            cmbLanguage.Items.Add("English");
            cmbLanguage.SelectedItem = "English"; // Standardsprache
            cmbLanguage.SelectedIndexChanged += CmbLanguage_SelectedIndexChanged;
            this.Controls.Add(cmbLanguage);

            // UI mit Standardkultur initialisieren
            UpdateUI();
        }

        private void CmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = sender as ComboBox;
            if (cmb.SelectedItem.ToString() == "Deutsch")
            {
                SetLanguage("de");
            }
            else
            {
                SetLanguage("en");
            }
        }

        private void SetLanguage(string culture)
        {
            // Kultur setzen
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(culture);

            // UI aktualisieren
            UpdateUI();
        }

        private void UpdateUI()
        {
            // Beispielhafte Aktualisierung von UI-Elementen
            this.Text = Thread.CurrentThread.CurrentUICulture.Name == "de" ? "Hochladen" : "Upload";
            switchToLieferProdProg.Text = Thread.CurrentThread.CurrentUICulture.Name == "de" ? "Zum Lieferplan" : "To Production Plan";

            // Weitere Elemente können hier hinzugefügt werden...
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
                        // Validation successful
                        MessageBox.Show("XML file is valid and loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        current_period = int.TryParse(rootElement.Attribute("period")?.Value, out int XValue) ? XValue : 0;
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}
