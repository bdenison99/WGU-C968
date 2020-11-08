using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace C968_Final_Project___Bdenis3
{
    public partial class ModPartForm : Form
    {
        private bool isChanged = false;

        public ModPartForm(int partID)
        {
            InitializeComponent();
            ModPart_InhouseRadio.Checked = false;
            ModPart_OutsourcedRadio.Checked = false;

            if (Inventory.lookupPart(partID).GetType() == typeof(InHouse))
            {
                InHouse modPart = (InHouse)Inventory.lookupPart(partID);
                ModPart_TextPartId.Text = modPart.PartID.ToString();
                ModPart_TextName.Text = modPart.Name;
                ModPart_TextPrice.Text = modPart.Price.ToString();
                ModPart_TextInventory.Text = modPart.InStock.ToString();
                ModPart_TextMax.Text = modPart.Max.ToString();
                ModPart_TextMin.Text = modPart.Min.ToString();
                ModPart_TextSource.Text = modPart.MachineID.ToString();
                ModPart_InhouseRadio.Checked = true;
                ModPart_OutsourcedRadio.Checked = false;
            }
            else
            {
                Outsourced modPart = (Outsourced)Inventory.lookupPart(partID);
                ModPart_TextPartId.Text = modPart.PartID.ToString();
                ModPart_TextName.Text = modPart.Name;
                ModPart_TextPrice.Text = modPart.Price.ToString();
                ModPart_TextInventory.Text = modPart.InStock.ToString();
                ModPart_TextMax.Text = modPart.Max.ToString();
                ModPart_TextMin.Text = modPart.Min.ToString();
                ModPart_TextSource.Text = modPart.CompanyName.ToString();
                ModPart_OutsourcedRadio.Checked = true;
                ModPart_InhouseRadio.Checked = false;
            }
        }

        private void ModPart_buttoncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModPart_OutsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (ModPart_OutsourcedRadio.Checked)
            { ModPart_LabelSource.Text = "Company Name"; }
            else { ModPart_LabelSource.Text = "Machine ID"; }
            isChanged = true;
        }

        private void ModPart_buttonsave_Click(object sender, EventArgs e)
        {
            if (isChanged)
            {
                if (ModPart_OutsourcedRadio.Checked)
                {
                    Outsourced updatedPart = new Outsourced
                    {
                        PartID = Convert.ToInt32(ModPart_TextPartId.Text),
                        Name = ModPart_TextName.Text,
                        Price = Convert.ToDecimal(ModPart_TextPrice.Text),
                        InStock = Convert.ToInt32(ModPart_TextInventory.Text),
                        Max = Convert.ToInt32(ModPart_TextMax.Text),
                        Min = Convert.ToInt32(ModPart_TextMin.Text),
                        CompanyName = ModPart_TextSource.Text
                    };
                    Inventory.updatePart(Convert.ToInt32(ModPart_TextPartId.Text), updatedPart);
                }
                else
                {
                    InHouse updatedPart = new InHouse
                    {
                        PartID = Convert.ToInt32(ModPart_TextPartId.Text),
                        Name = ModPart_TextName.Text,
                        Price = Convert.ToDecimal(ModPart_TextPrice.Text),
                        InStock = Convert.ToInt32(ModPart_TextInventory.Text),
                        Max = Convert.ToInt32(ModPart_TextMax.Text),
                        Min = Convert.ToInt32(ModPart_TextMin.Text),
                        MachineID = Convert.ToInt32(ModPart_TextSource.Text)
                    };
                    Inventory.updatePart(Convert.ToInt32(ModPart_TextPartId.Text), updatedPart);
                }
            }
            this.Close();
        }

        private void PartFieldChanged(object sender, EventArgs e)
        {
            // This function is used as an event handler for all text fields and radio buttons on the modify part form.
            // If anything changes, set this flag to true so the save button knows it needs to update the part.
            isChanged = true;
        }
    }
}
