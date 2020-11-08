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
    public partial class AddProductForm : Form
    {
        private BindingList<Part> assocParts = new BindingList<Part>();
        public AddProductForm()
        {
            InitializeComponent();
            AddProduct_dgParts.DataSource = Inventory.AllParts;
            AddProduct_dgAssocParts.DataSource = assocParts;
            AddProduct_ProdId.Text = Inventory.NextPartID.ToString();
        }

        private void AddProduct_SaveProductButton_Click(object sender, EventArgs e)
        {
            Product newProd = new Product
            {
                ProductID = Convert.ToInt32(AddProduct_ProdId.Text),
                Name = AddProduct_NameText.Text,
                Price = Convert.ToDecimal(AddProduct_PriceText.Text),
                InStock = Convert.ToInt32(AddProduct_InventoryText.Text),
                Min = Convert.ToInt32(AddProduct_MinText.Text),
                Max = Convert.ToInt32(AddProduct_MaxText.Text)
            };
            BindingList<Part> newParts = new BindingList<Part>();
            for (int i = 0; i < AddProduct_dgAssocParts.RowCount; i++)
            {
                int partid = Convert.ToInt32(AddProduct_dgAssocParts.Rows[i].Cells["PartID"].Value);
                if (Inventory.lookupPart(partid).GetType() == typeof(InHouse))
                {
                    InHouse p = (InHouse)Inventory.lookupPart(partid);
                    newParts.Add(p);
                }
            }
            newProd.associatedParts = newParts;
            Inventory.addProduct(newProd);
            this.Close();
        }

        private void AddProduct_CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillDummyData_Click(object sender, EventArgs e)
        {
            AddProduct_ProdId.Text = Inventory.NextProductID.ToString();
            AddProduct_NameText.Text = "Hot Hair Luft Balloon";
            AddProduct_PriceText.Text = "0.99";
            AddProduct_MinText.Text = "9";
            AddProduct_MaxText.Text = "99";
            AddProduct_InventoryText.Text = "89";

        }

        private void addproduct_searchpart_Click(object sender, EventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)BindingContext[AddProduct_dgParts.DataSource];
            cm.SuspendBinding();
            AddProduct_dgParts.ClearSelection();
            for (int i = 0; i < AddProduct_dgParts.RowCount; i++)
            {
                if (AddProduct_dgParts.Rows[i].Cells["PartID"].Value.ToString().ToLower().Contains(AddProduct_SearchText.Text.ToString().ToLower()) ||
                        AddProduct_dgParts.Rows[i].Cells["Name"].Value.ToString().ToLower().Contains(AddProduct_SearchText.Text.ToString().ToLower())
                    )
                {
                    AddProduct_dgParts.Rows[i].Visible = true;
                }
                else { AddProduct_dgParts.Rows[i].Visible = false; }
            }
            cm.ResumeBinding();
        }

        private void AddProduct_AssocPartWithProdButton_Click(object sender, EventArgs e)
        {
            int newPartIdx = AddProduct_dgParts.CurrentCell.RowIndex;
            int newPartID = Convert.ToInt32(AddProduct_dgParts.Rows[newPartIdx].Cells["PartID"].Value);
            Product p = Inventory.lookupProduct(newPartID);
            assocParts.Add(Inventory.lookupPart(newPartID));
        }

        private void AddProduct_DeletePartFromProductButton_Click(object sender, EventArgs e)
        {
            int delPartIdx = AddProduct_dgAssocParts.CurrentCell.RowIndex;
            int delPartID = Convert.ToInt32(AddProduct_dgAssocParts.Rows[delPartIdx].Cells["PartID"].Value);
            Part p = Inventory.lookupPart(delPartID);
            assocParts.Remove(p);
        }

        private void AddProduct_ClearSearch_Click(object sender, EventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)BindingContext[AddProduct_dgParts.DataSource];
            cm.SuspendBinding();
            AddProduct_dgParts.ClearSelection();
            for (int i = 0; i < AddProduct_dgParts.RowCount - 1; i++)
            {
                AddProduct_dgParts.Rows[i].Visible = true;
            }
            cm.ResumeBinding();
            AddProduct_SearchText.Text = "";
        }
    }
}
