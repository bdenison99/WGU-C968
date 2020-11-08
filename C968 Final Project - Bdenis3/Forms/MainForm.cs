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
    public partial class InventoryForm : Form
    {

        public InventoryForm()
        {
            InitializeComponent();
            CreateTestData();  // just loads some dummy parts and product data for 2 sizes of bikes (same size pedals / handlebars / seats, different size frame and tires)
            dgParts.DataSource = Inventory.AllParts;
            dgProducts.DataSource = Inventory.Products;
            Format_Datagrids();
        }

        private void CreateTestData()
        {
            // Create test inventory data

            // These are component parts for two sizes of bicycle - 24" and 32".  Pedals, seats, and handlebars should be common between them.
            Inventory.addPart(new InHouse("24 in. Bike Tire", (decimal)7.99, 20, 6, 40, 1));
            Inventory.addPart(new InHouse("24 in. Bike Frame", (decimal)29.99, 10, 3, 20, 2));
            Inventory.addPart(new Outsourced("Bicycle seat - foam", (decimal)4.99, 8, 3, 16, "ACME Seating"));
            Inventory.addPart(new InHouse("Pedal Set - Bicycle", (decimal)3.99, 12, 10, 40, 4));
            Inventory.addPart(new InHouse("Handlebars - Chrome", (decimal)9.99, 11, 8, 20, 8));
            Inventory.addPart(new InHouse("32 in. Bike Tire", (decimal)9.99, 20, 6, 40, 16));
            Inventory.addPart(new InHouse("32 in. Bike Frame", (decimal)39.99, 10, 3, 20, 32));

            // This is an assembled 24" bike
            BindingList<Part> tempPartList = new BindingList<Part>
            {
                Inventory.lookupPart("24 in. Bike Frame").First(),
                Inventory.lookupPart("24 in. Bike Tire").First(),
                Inventory.lookupPart("Bicycle seat - foam").First(),
                Inventory.lookupPart("Pedal Set - Bicycle").First(),
                Inventory.lookupPart("Handlebars - Chrome").First()
            };

            Inventory.addProduct(new Product("24 in. Bicycle", (decimal)89.99, 3, 1, 25, tempPartList));
            tempPartList = null;

            // This is an assembled 32" bike, re-using the previous temp part list variable.
            tempPartList = new BindingList<Part>
            {
                Inventory.lookupPart("32 in. Bike Frame").First(),
                Inventory.lookupPart("32 in. Bike Tire").First(),
                Inventory.lookupPart("Bicycle seat - foam").First(),
                Inventory.lookupPart("Pedal Set - Bicycle").First(),
                Inventory.lookupPart("Handlebars - Chrome").First()
            };
            Inventory.addProduct(new Product("32 in. Bicycle", (decimal)109.99, 3, 1, 25, tempPartList));
        }


        // string name, decimal price, int inStock, int min, int max

        private void Cmd_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Part_Search_Click(object sender, EventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)BindingContext[dgParts.DataSource];
            cm.SuspendBinding();
            dgParts.ClearSelection();
            for (int i = 0; i < dgParts.RowCount;i++)
            {
                if (    dgParts.Rows[i].Cells["PartID"].Value.ToString().ToLower().Contains(partsearchval.Text.ToString().ToLower()) ||
                        dgParts.Rows[i].Cells["Name"].Value.ToString().ToLower().Contains(partsearchval.Text.ToString().ToLower())
                    )
                {
                    dgParts.Rows[i].Visible = true;
                }
                else { dgParts.Rows[i].Visible = false; }
            }
            cm.ResumeBinding();
        }

        private void Product_Search_Click(object sender, EventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)BindingContext[dgProducts.DataSource];
            cm.SuspendBinding();
            dgProducts.ClearSelection();
            for (int i = 0; i < dgProducts.RowCount; i++)
            {
                if (dgProducts.Rows[i].Cells["ProductID"].Value.ToString().ToLower().Contains(prodsearchval.Text.ToString().ToLower()) ||
                        dgProducts.Rows[i].Cells["Name"].Value.ToString().ToLower().Contains(prodsearchval.Text.ToString().ToLower())
                    )
                {
                    dgProducts.Rows[i].Visible = true;
                }
                else { dgProducts.Rows[i].Visible = false; }
            }
            cm.ResumeBinding();
        }

        private void Part_Add_Click(object sender, EventArgs e)
        {
            Form add_part = new AddPartForm();
            add_part.Show();
        }

        private void Part_Edit_Click(object sender, EventArgs e)
        {
            int modify_index = dgParts.CurrentCell.RowIndex;
            if (modify_index >= 0)
            {
                Form modPart = new ModPartForm((int)dgParts.Rows[modify_index].Cells["PartID"].Value);
                modPart.Show();
            }
            else
            {
                MessageBox.Show("Select a part to modify");
            }
            modify_index = -1;
        }

        private void Part_Delete_Click(object sender, EventArgs e)
        {
            int delete_index = dgParts.CurrentCell.RowIndex;
            if (delete_index >= 0)
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].PartID == (int)dgParts.Rows[delete_index].Cells["PartID"].Value)
                    {
                        Inventory.AllParts.RemoveAt(i);
                    }
                }
                dgParts.ClearSelection();
                delete_index = -1;
            }
            else
            {
                MessageBox.Show("Select a part to delete");
            }
        }

        private void Product_Add_Click(object sender, EventArgs e)
        {
            Form new_product = new AddProductForm();
            new_product.Show();
        }

        private void Product_Edit_Click(object sender, EventArgs e)
        {
            Form modProduct = new ModProductForm((int)dgProducts.Rows[dgProducts.CurrentCell.RowIndex].Cells["ProductID"].Value);
            modProduct.Show();
        }

        private void Product_Delete_Click(object sender, EventArgs e)
        {
            int delete_index = dgProducts.CurrentCell.RowIndex;
            if (delete_index >= 0)
            {
                for (int i = 0; i < Inventory.Products.Count; i++)
                {
                    if (Inventory.Products[i].ProductID == (int)dgProducts.Rows[delete_index].Cells["ProductID"].Value)
                    {
                        if (Inventory.Products[i].associatedParts.Count > 0)
                        {
                            MessageBox.Show("Please remove all associated parts before deleting this product!");
                            break;
                        }
                        Inventory.Products.RemoveAt(i);
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a product to delete");
            }

        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
        }

        private void Format_Datagrids()
        {
            dgParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgParts.RowHeadersDefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
            dgParts.Columns["PartID"].HeaderText = "Part ID";         // Add a space in the header cell
            dgParts.Columns["Price"].DefaultCellStyle.Format = "c";   // stackoverflow.com/questions/37026196/datagridview-how-to-set-the-currency-format-for-a-single-column-only
            dgParts.Columns["InStock"].HeaderText = "Inventory";      // Treat the InStock property as the quantity on hand inventory
            dgParts.ClearSelection();
            dgParts.CurrentCell = null;

            dgProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgProducts.RowHeadersDefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
            dgProducts.Columns["ProductID"].HeaderText = "Product ID";
            dgProducts.Columns["InStock"].HeaderText = "Inventory";      // Treat the InStock property as the quantity on hand inventory
            dgProducts.ClearSelection();
            dgProducts.CurrentCell = null;
        }

        private void ClearPartSearch_Click(object sender, EventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)BindingContext[dgParts.DataSource];
            cm.SuspendBinding();
            dgParts.ClearSelection();
            for (int i = 0; i < dgParts.RowCount - 1; i++)
            {
                dgParts.Rows[i].Visible = true;
            }
            cm.ResumeBinding();
            partsearchval.Text = "";
        }

        private void ClearProdSearch_Click(object sender, EventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)BindingContext[dgProducts.DataSource];
            cm.SuspendBinding();
            dgProducts.ClearSelection();
            for (int i = 0; i < dgProducts.RowCount - 1; i++)
            {
                dgProducts.Rows[i].Visible = true;
            }
            cm.ResumeBinding();
            prodsearchval.Text = "";
        }
    }
}
