namespace C968_Final_Project___Bdenis3
{
    partial class InventoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
            this.label_main = new System.Windows.Forms.Label();
            this.label_parts = new System.Windows.Forms.Label();
            this.part_search = new System.Windows.Forms.Button();
            this.partsearchval = new System.Windows.Forms.TextBox();
            this.dgParts = new System.Windows.Forms.DataGridView();
            this.part_add = new System.Windows.Forms.Button();
            this.part_edit = new System.Windows.Forms.Button();
            this.part_delete = new System.Windows.Forms.Button();
            this.product_delete = new System.Windows.Forms.Button();
            this.product_edit = new System.Windows.Forms.Button();
            this.product_add = new System.Windows.Forms.Button();
            this.dgProducts = new System.Windows.Forms.DataGridView();
            this.prodsearchval = new System.Windows.Forms.TextBox();
            this.product_search = new System.Windows.Forms.Button();
            this.label_products = new System.Windows.Forms.Label();
            this.cmd_exit = new System.Windows.Forms.Button();
            this.clearpartsearch = new System.Windows.Forms.Button();
            this.clearprodsearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // label_main
            // 
            resources.ApplyResources(this.label_main, "label_main");
            this.label_main.Name = "label_main";
            // 
            // label_parts
            // 
            resources.ApplyResources(this.label_parts, "label_parts");
            this.label_parts.Name = "label_parts";
            // 
            // part_search
            // 
            resources.ApplyResources(this.part_search, "part_search");
            this.part_search.Name = "part_search";
            this.part_search.UseVisualStyleBackColor = true;
            this.part_search.Click += new System.EventHandler(this.Part_Search_Click);
            // 
            // partsearchval
            // 
            resources.ApplyResources(this.partsearchval, "partsearchval");
            this.partsearchval.Name = "partsearchval";
            // 
            // dgParts
            // 
            this.dgParts.AllowUserToAddRows = false;
            this.dgParts.AllowUserToDeleteRows = false;
            this.dgParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgParts, "dgParts");
            this.dgParts.Name = "dgParts";
            this.dgParts.RowHeadersVisible = false;
            // 
            // part_add
            // 
            resources.ApplyResources(this.part_add, "part_add");
            this.part_add.Name = "part_add";
            this.part_add.UseVisualStyleBackColor = true;
            this.part_add.Click += new System.EventHandler(this.Part_Add_Click);
            // 
            // part_edit
            // 
            resources.ApplyResources(this.part_edit, "part_edit");
            this.part_edit.Name = "part_edit";
            this.part_edit.UseVisualStyleBackColor = true;
            this.part_edit.Click += new System.EventHandler(this.Part_Edit_Click);
            // 
            // part_delete
            // 
            resources.ApplyResources(this.part_delete, "part_delete");
            this.part_delete.Name = "part_delete";
            this.part_delete.UseVisualStyleBackColor = true;
            this.part_delete.Click += new System.EventHandler(this.Part_Delete_Click);
            // 
            // product_delete
            // 
            resources.ApplyResources(this.product_delete, "product_delete");
            this.product_delete.Name = "product_delete";
            this.product_delete.UseVisualStyleBackColor = true;
            this.product_delete.Click += new System.EventHandler(this.Product_Delete_Click);
            // 
            // product_edit
            // 
            resources.ApplyResources(this.product_edit, "product_edit");
            this.product_edit.Name = "product_edit";
            this.product_edit.UseVisualStyleBackColor = true;
            this.product_edit.Click += new System.EventHandler(this.Product_Edit_Click);
            // 
            // product_add
            // 
            resources.ApplyResources(this.product_add, "product_add");
            this.product_add.Name = "product_add";
            this.product_add.UseVisualStyleBackColor = true;
            this.product_add.Click += new System.EventHandler(this.Product_Add_Click);
            // 
            // dgProducts
            // 
            this.dgProducts.AllowUserToAddRows = false;
            this.dgProducts.AllowUserToDeleteRows = false;
            this.dgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgProducts, "dgProducts");
            this.dgProducts.Name = "dgProducts";
            this.dgProducts.RowHeadersVisible = false;
            // 
            // prodsearchval
            // 
            resources.ApplyResources(this.prodsearchval, "prodsearchval");
            this.prodsearchval.Name = "prodsearchval";
            // 
            // product_search
            // 
            resources.ApplyResources(this.product_search, "product_search");
            this.product_search.Name = "product_search";
            this.product_search.UseVisualStyleBackColor = true;
            this.product_search.Click += new System.EventHandler(this.Product_Search_Click);
            // 
            // label_products
            // 
            resources.ApplyResources(this.label_products, "label_products");
            this.label_products.Name = "label_products";
            // 
            // cmd_exit
            // 
            resources.ApplyResources(this.cmd_exit, "cmd_exit");
            this.cmd_exit.Name = "cmd_exit";
            this.cmd_exit.UseVisualStyleBackColor = true;
            this.cmd_exit.Click += new System.EventHandler(this.Cmd_Exit_Click);
            // 
            // clearpartsearch
            // 
            resources.ApplyResources(this.clearpartsearch, "clearpartsearch");
            this.clearpartsearch.Name = "clearpartsearch";
            this.clearpartsearch.UseVisualStyleBackColor = true;
            this.clearpartsearch.Click += new System.EventHandler(this.ClearPartSearch_Click);
            // 
            // clearprodsearch
            // 
            resources.ApplyResources(this.clearprodsearch, "clearprodsearch");
            this.clearprodsearch.Name = "clearprodsearch";
            this.clearprodsearch.UseVisualStyleBackColor = true;
            this.clearprodsearch.Click += new System.EventHandler(this.ClearProdSearch_Click);
            // 
            // InventoryForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clearprodsearch);
            this.Controls.Add(this.cmd_exit);
            this.Controls.Add(this.product_delete);
            this.Controls.Add(this.product_edit);
            this.Controls.Add(this.product_add);
            this.Controls.Add(this.dgProducts);
            this.Controls.Add(this.prodsearchval);
            this.Controls.Add(this.product_search);
            this.Controls.Add(this.label_products);
            this.Controls.Add(this.part_delete);
            this.Controls.Add(this.part_edit);
            this.Controls.Add(this.part_add);
            this.Controls.Add(this.dgParts);
            this.Controls.Add(this.partsearchval);
            this.Controls.Add(this.clearpartsearch);
            this.Controls.Add(this.part_search);
            this.Controls.Add(this.label_parts);
            this.Controls.Add(this.label_main);
            this.Name = "InventoryForm";
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_main;
        private System.Windows.Forms.Label label_parts;
        private System.Windows.Forms.Button part_search;
        private System.Windows.Forms.TextBox partsearchval;
        private System.Windows.Forms.DataGridView dgParts;
        private System.Windows.Forms.Button part_add;
        private System.Windows.Forms.Button part_edit;
        private System.Windows.Forms.Button part_delete;
        private System.Windows.Forms.Button product_delete;
        private System.Windows.Forms.Button product_edit;
        private System.Windows.Forms.Button product_add;
        private System.Windows.Forms.DataGridView dgProducts;
        private System.Windows.Forms.TextBox prodsearchval;
        private System.Windows.Forms.Button product_search;
        private System.Windows.Forms.Label label_products;
        private System.Windows.Forms.Button cmd_exit;
        private System.Windows.Forms.Button clearpartsearch;
        private System.Windows.Forms.Button clearprodsearch;
    }
}

