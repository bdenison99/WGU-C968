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
    public partial class ModProductForm : Form
    {
        private bool isChanged = false;

        public ModProductForm(int prodID)
        {
            InitializeComponent();
            Product prod = Inventory.lookupProduct(prodID);
            
            ModProduct_ProdId.Text = prod.ProductID.ToString();
            ModProduct_NameText.Text = prod.Name;
            ModProduct_PriceText.Text = prod.Price.ToString();
            ModProduct_InventoryText.Text = prod.InStock.ToString();
            ModProduct_MinText.Text = prod.Min.ToString();
            ModProduct_MaxText.Text = prod.Max.ToString();
            ModProduct_dgAssocParts.DataSource = prod.associatedParts;
            ModProduct_dgAllParts.DataSource = Inventory.AllParts;

            ModProduct_dgAllParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ModProduct_dgAllParts.RowHeadersDefaultCellStyle.SelectionBackColor = Color.DodgerBlue;

            ModProduct_dgAssocParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ModProduct_dgAssocParts.RowHeadersDefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
        }

        private void ProductFieldChanged(object sender, EventArgs e)
        {
            this.isChanged = true;
        }

        private void ModProduct_SaveProductButton_Click(object sender, EventArgs e)
        {
            if (this.isChanged)
            {
                Product updatedProduct = new Product
                {
                    ProductID = Convert.ToInt32(ModProduct_ProdId.Text),
                    Name = ModProduct_NameText.Text,
                    Price = Convert.ToDecimal(ModProduct_PriceText.Text),
                    InStock = Convert.ToInt32(ModProduct_InventoryText.Text),
                    Min = Convert.ToInt32(ModProduct_MinText.Text),
                    Max = Convert.ToInt32(ModProduct_MaxText.Text)
                };
                BindingList<Part> updatedParts = new BindingList<Part>();
                for (int i = 0; i < ModProduct_dgAssocParts.RowCount; i++)
                {
                    int partid = Convert.ToInt32(ModProduct_dgAssocParts.Rows[i].Cells["PartID"].Value);
                    if (Inventory.lookupPart(partid).GetType() == typeof(InHouse))
                    {
                        InHouse p = (InHouse)Inventory.lookupPart(partid);
                        updatedParts.Add(p);
                    }
                }
                updatedProduct.associatedParts = updatedParts;
                Inventory.updateProduct(Convert.ToInt32(ModProduct_ProdId.Text), updatedProduct);
            }
            this.Close();
        }

        private void ModProduct_CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModProduct_AssocPartWithProdButton_Click(object sender, EventArgs e)
        {
            int newPartIdx = ModProduct_dgAllParts.CurrentCell.RowIndex;
            int newPartID = Convert.ToInt32(ModProduct_dgAllParts.Rows[newPartIdx].Cells["PartID"].Value);
            Product p = Inventory.lookupProduct(Convert.ToInt32(ModProduct_ProdId.Text));
            p.AddAssociatedParts(Inventory.lookupPart(newPartID));
        }

        private void ModProduct_DeletePartFromProductButton_Click(object sender, EventArgs e)
        {
            int delPartIdx = ModProduct_dgAssocParts.CurrentCell.RowIndex;
            int delPartID = Convert.ToInt32(ModProduct_dgAssocParts.Rows[delPartIdx].Cells["PartID"].Value);
            Product p = Inventory.lookupProduct(Convert.ToInt32(ModProduct_ProdId.Text));
            p.RemoveAssociatedPart(delPartID);
        }

        private void ModProduct_SearchButton_Click(object sender, EventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)BindingContext[ModProduct_dgAllParts.DataSource];
            cm.SuspendBinding();
            ModProduct_dgAllParts.ClearSelection();
            for (int i = 0; i < ModProduct_dgAllParts.RowCount; i++)
            {
                if (ModProduct_dgAllParts.Rows[i].Cells["PartID"].Value.ToString().ToLower().Contains(ModProduct_SearchText.Text.ToString().ToLower()) ||
                        ModProduct_dgAllParts.Rows[i].Cells["Name"].Value.ToString().ToLower().Contains(ModProduct_SearchText.Text.ToString().ToLower())
                    )
                {
                    ModProduct_dgAllParts.Rows[i].Visible = true;
                }
                else { ModProduct_dgAllParts.Rows[i].Visible = false; }
            }
            cm.ResumeBinding();
        }

        private void ModProduct_ClearSearch_Click(object sender, EventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)BindingContext[ModProduct_dgAllParts.DataSource];
            cm.SuspendBinding();
            ModProduct_dgAllParts.ClearSelection();
            for (int i = 0; i < ModProduct_dgAllParts.RowCount - 1; i++)
            {
                ModProduct_dgAllParts.Rows[i].Visible = true;
            }
            cm.ResumeBinding();
            ModProduct_SearchText.Text = "";
        }
    }
}

