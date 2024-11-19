using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static supplyChainSimulation.SharedData;

namespace supplyChainSimulation
{
    public partial class BuildXML : Form
    {
        public BuildXML()
        {
            InitializeComponent();

            warningText.Text = "This is potentially dangerous!\n\n" +
                   "Don't use this if not explicitly in a sandbox environment\n" +
                   "and if it is not legally safe!\n\nPlease read:\n" +
                   "Strafgesetzbuch (StGB) § 303b Computersabotage";

        }

        private void p1_uploadXML_Click(object sender, EventArgs e)
        {
            if ((!hack_nope.Checked) && (!warningLabel.LinkVisited))
            {
                MessageBox.Show("Read the risks and accept the terms and conditions!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            if ((!hack_nope.Checked) && (warningLabel.LinkVisited))
            {
                MessageBox.Show("This is on you...", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                provideXML();
            }
            if (hack_nope.Checked)
            {
                provideXML();
            }
        }

        private void provideXML()
        {
            string filePath = GetSaveFilePath();
            if (string.IsNullOrWhiteSpace(filePath))
            {
                MessageBox.Show("No file selected. Exiting...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                GenerateXml(filePath);
                MessageBox.Show($"XML file successfully generated at:\n{filePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static string GetSaveFilePath()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "XML Files (*.xml)|*.xml";
                saveFileDialog.Title = "Choose a location to save the XML file";
                saveFileDialog.FileName = "inputXML.xml"; // Default file name

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return saveFileDialog.FileName;
                }
            }
            return null;
        }

        static void GenerateXml(string filePath)
        {
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = "  ",
                NewLineOnAttributes = false
            };

            using (XmlWriter writer = XmlWriter.Create(filePath, settings))
            {
                // Start document
                writer.WriteStartDocument();
                writer.WriteStartElement("input"); // Root element

                // Add <qualitycontrol> element, default 
                writer.WriteStartElement("qualitycontrol");
                writer.WriteAttributeString("type", "no");
                writer.WriteAttributeString("losequantity", "0");
                writer.WriteAttributeString("delay", "0");
                writer.WriteEndElement();

                // Add <sellwish> element
                writer.WriteStartElement("sellwish");
                for (int i = 1; i <= 3; i++)
                {
                    writer.WriteStartElement("item");
                    writer.WriteAttributeString("article", i.ToString());
                    writer.WriteAttributeString("quantity", (200 / i).ToString());
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();

                // Add <selldirect> element
                writer.WriteStartElement("selldirect");
                for (int i = 1; i <= 3; i++)
                {
                    writer.WriteStartElement("item");
                    writer.WriteAttributeString("article", i.ToString());
                    writer.WriteAttributeString("quantity", "0");
                    writer.WriteAttributeString("price", "0.0");
                    writer.WriteAttributeString("penalty", "0.0");
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();

                // Add <orderlist> element
                writer.WriteStartElement("orderlist");
                writer.WriteEndElement();

                writer.WriteEndElement(); // End root element
                writer.WriteEndDocument(); // End document
            }
        }

        private void switchPurchasePartDisposition_Click(object sender, EventArgs e)
        {
            MainOrchestrator mainOrchestrator = (MainOrchestrator)this.ParentForm;
            mainOrchestrator.ShowForm(new PurchasePartDisposition());
        }

        private void considerHacking_warning()
        {
            warningText.Visible = true;
            warningLabel.Visible = true;
        }

        private void considerHacking(object sender, KeyPressEventArgs e)
        {
            considerHacking_warning();
        }

        private void considerHacking(object sender, EventArgs e)
        {
            considerHacking_warning();
        }

        private void considerHacking(object sender, MouseEventArgs e)
        {
            considerHacking_warning();
        }

        private void warningLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            warningLabel.LinkVisited = true;
            try
            {
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://www.gesetze-im-internet.de/stgb/__303b.html",
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open the link. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
