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
    public partial class AddPartForm : Form
    {
        public AddPartForm()
        {
            InitializeComponent();
        }

        private void AddPart_InhouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            this.AddPart_CompanyMachineLabel.Text = "Machine ID";
        }

        private void AddPart_OutsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            this.AddPart_CompanyMachineLabel.Text = "Company Name";
        }

        private void AddPart_ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPart_ButtonSave_Click(object sender, EventArgs e)
        {
            if (AddPart_InhouseRadio.Checked)
            {
                Inventory.addPart(
                    new InHouse(AddPart_TextName.Text,
                                Convert.ToDecimal(AddPart_TextPrice.Text.ToString()),
                                Convert.ToInt32(AddPart_TextInventory.Text.ToString()),
                                Convert.ToInt32(AddPart_TextMin.Text.ToString()),
                                Convert.ToInt32(AddPart_TextMax.Text.ToString()),
                                Convert.ToInt32(AddPart_TextSource.Text.ToString())
                    )

                );
            }
            else
            {
                Inventory.addPart(
                    new Outsourced(AddPart_TextName.Text,
                                Convert.ToDecimal(AddPart_TextPrice.Text.ToString()),
                                Convert.ToInt32(AddPart_TextInventory.Text.ToString()),
                                Convert.ToInt32(AddPart_TextMin.Text.ToString()),
                                Convert.ToInt32(AddPart_TextMax.Text.ToString()),
                                AddPart_TextSource.Text.ToString()
                    )

                );
            }
            this.Close();
        }

        private void LoadSampleData_click(object sender, EventArgs e)
        {
            AddPart_TextName.Text = "Luft Balloons";
            AddPart_TextInventory.Text = "49";
            AddPart_TextPrice.Text = "0.99";
            AddPart_TextMin.Text = "9";
            AddPart_TextMax.Text = "99";
            AddPart_TextSource.Text = "99";
        }
    }
}
