namespace C968_Final_Project___Bdenis3
{
    partial class AddProductForm
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
            this.AddProduct_SaveProductButton = new System.Windows.Forms.Button();
            this.AddProduct_dgAssocParts = new System.Windows.Forms.DataGridView();
            this.AddProduct_SearchText = new System.Windows.Forms.TextBox();
            this.ModProduct_SearchLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddProduct_DeletePartFromProductButton = new System.Windows.Forms.Button();
            this.AddProduct_AssocPartWithProdButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.AddProduct_CancelButton = new System.Windows.Forms.Button();
            this.AddProduct_dgParts = new System.Windows.Forms.DataGridView();
            this.AddProduct_MaxText = new System.Windows.Forms.TextBox();
            this.AddProduct_MinText = new System.Windows.Forms.TextBox();
            this.ModProduct_MaxLabel = new System.Windows.Forms.Label();
            this.AddProduct_PriceText = new System.Windows.Forms.TextBox();
            this.ModProduct_MinLabel = new System.Windows.Forms.Label();
            this.AddProduct_InventoryText = new System.Windows.Forms.TextBox();
            this.ModProduct_PriceLabel = new System.Windows.Forms.Label();
            this.AddProduct_NameText = new System.Windows.Forms.TextBox();
            this.ModProduct_InventoryLabel = new System.Windows.Forms.Label();
            this.AddProduct_ProdId = new System.Windows.Forms.TextBox();
            this.ModProduct_NameLabel = new System.Windows.Forms.Label();
            this.ModProduct_IdLabel = new System.Windows.Forms.Label();
            this.AddProduct_Label = new System.Windows.Forms.Label();
            this.FillDummyData = new System.Windows.Forms.Button();
            this.addproduct_searchpart = new System.Windows.Forms.Button();
            this.AddProduct_ClearSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AddProduct_dgAssocParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddProduct_dgParts)).BeginInit();
            this.SuspendLayout();
            // 
            // AddProduct_SaveProductButton
            // 
            this.AddProduct_SaveProductButton.Location = new System.Drawing.Point(74, 221);
            this.AddProduct_SaveProductButton.Name = "AddProduct_SaveProductButton";
            this.AddProduct_SaveProductButton.Size = new System.Drawing.Size(147, 23);
            this.AddProduct_SaveProductButton.TabIndex = 6;
            this.AddProduct_SaveProductButton.Text = "&Save Product";
            this.AddProduct_SaveProductButton.UseVisualStyleBackColor = true;
            this.AddProduct_SaveProductButton.Click += new System.EventHandler(this.AddProduct_SaveProductButton_Click);
            // 
            // AddProduct_dgAssocParts
            // 
            this.AddProduct_dgAssocParts.AllowUserToAddRows = false;
            this.AddProduct_dgAssocParts.AllowUserToDeleteRows = false;
            this.AddProduct_dgAssocParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddProduct_dgAssocParts.Location = new System.Drawing.Point(261, 267);
            this.AddProduct_dgAssocParts.Name = "AddProduct_dgAssocParts";
            this.AddProduct_dgAssocParts.RowHeadersVisible = false;
            this.AddProduct_dgAssocParts.Size = new System.Drawing.Size(605, 150);
            this.AddProduct_dgAssocParts.TabIndex = 12;
            // 
            // AddProduct_SearchText
            // 
            this.AddProduct_SearchText.Location = new System.Drawing.Point(307, 36);
            this.AddProduct_SearchText.Name = "AddProduct_SearchText";
            this.AddProduct_SearchText.Size = new System.Drawing.Size(413, 20);
            this.AddProduct_SearchText.TabIndex = 8;
            // 
            // ModProduct_SearchLabel
            // 
            this.ModProduct_SearchLabel.AutoSize = true;
            this.ModProduct_SearchLabel.Location = new System.Drawing.Point(260, 39);
            this.ModProduct_SearchLabel.Name = "ModProduct_SearchLabel";
            this.ModProduct_SearchLabel.Size = new System.Drawing.Size(41, 13);
            this.ModProduct_SearchLabel.TabIndex = 11;
            this.ModProduct_SearchLabel.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Candidate Parts";
            // 
            // AddProduct_DeletePartFromProductButton
            // 
            this.AddProduct_DeletePartFromProductButton.Location = new System.Drawing.Point(669, 424);
            this.AddProduct_DeletePartFromProductButton.Name = "AddProduct_DeletePartFromProductButton";
            this.AddProduct_DeletePartFromProductButton.Size = new System.Drawing.Size(198, 23);
            this.AddProduct_DeletePartFromProductButton.TabIndex = 13;
            this.AddProduct_DeletePartFromProductButton.Text = "&Disassociate Part from Product";
            this.AddProduct_DeletePartFromProductButton.UseVisualStyleBackColor = true;
            this.AddProduct_DeletePartFromProductButton.Click += new System.EventHandler(this.AddProduct_DeletePartFromProductButton_Click);
            // 
            // AddProduct_AssocPartWithProdButton
            // 
            this.AddProduct_AssocPartWithProdButton.Location = new System.Drawing.Point(669, 220);
            this.AddProduct_AssocPartWithProdButton.Name = "AddProduct_AssocPartWithProdButton";
            this.AddProduct_AssocPartWithProdButton.Size = new System.Drawing.Size(197, 24);
            this.AddProduct_AssocPartWithProdButton.TabIndex = 11;
            this.AddProduct_AssocPartWithProdButton.Text = "Ass&ociate Part with Product";
            this.AddProduct_AssocPartWithProdButton.UseVisualStyleBackColor = true;
            this.AddProduct_AssocPartWithProdButton.Click += new System.EventHandler(this.AddProduct_AssocPartWithProdButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Associated Parts";
            // 
            // AddProduct_CancelButton
            // 
            this.AddProduct_CancelButton.Location = new System.Drawing.Point(74, 250);
            this.AddProduct_CancelButton.Name = "AddProduct_CancelButton";
            this.AddProduct_CancelButton.Size = new System.Drawing.Size(147, 23);
            this.AddProduct_CancelButton.TabIndex = 7;
            this.AddProduct_CancelButton.Text = "&Cancel";
            this.AddProduct_CancelButton.UseVisualStyleBackColor = true;
            this.AddProduct_CancelButton.Click += new System.EventHandler(this.AddProduct_CancelButton_Click);
            // 
            // AddProduct_dgParts
            // 
            this.AddProduct_dgParts.AllowUserToAddRows = false;
            this.AddProduct_dgParts.AllowUserToDeleteRows = false;
            this.AddProduct_dgParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddProduct_dgParts.Location = new System.Drawing.Point(262, 62);
            this.AddProduct_dgParts.Name = "AddProduct_dgParts";
            this.AddProduct_dgParts.RowHeadersVisible = false;
            this.AddProduct_dgParts.Size = new System.Drawing.Size(605, 150);
            this.AddProduct_dgParts.TabIndex = 10;
            // 
            // AddProduct_MaxText
            // 
            this.AddProduct_MaxText.Location = new System.Drawing.Point(50, 167);
            this.AddProduct_MaxText.Name = "AddProduct_MaxText";
            this.AddProduct_MaxText.Size = new System.Drawing.Size(56, 20);
            this.AddProduct_MaxText.TabIndex = 4;
            // 
            // AddProduct_MinText
            // 
            this.AddProduct_MinText.Location = new System.Drawing.Point(166, 167);
            this.AddProduct_MinText.Name = "AddProduct_MinText";
            this.AddProduct_MinText.Size = new System.Drawing.Size(56, 20);
            this.AddProduct_MinText.TabIndex = 5;
            // 
            // ModProduct_MaxLabel
            // 
            this.ModProduct_MaxLabel.AutoSize = true;
            this.ModProduct_MaxLabel.Location = new System.Drawing.Point(17, 170);
            this.ModProduct_MaxLabel.Name = "ModProduct_MaxLabel";
            this.ModProduct_MaxLabel.Size = new System.Drawing.Size(27, 13);
            this.ModProduct_MaxLabel.TabIndex = 16;
            this.ModProduct_MaxLabel.Text = "Max";
            // 
            // AddProduct_PriceText
            // 
            this.AddProduct_PriceText.Location = new System.Drawing.Point(74, 141);
            this.AddProduct_PriceText.Name = "AddProduct_PriceText";
            this.AddProduct_PriceText.Size = new System.Drawing.Size(148, 20);
            this.AddProduct_PriceText.TabIndex = 3;
            // 
            // ModProduct_MinLabel
            // 
            this.ModProduct_MinLabel.AutoSize = true;
            this.ModProduct_MinLabel.Location = new System.Drawing.Point(136, 170);
            this.ModProduct_MinLabel.Name = "ModProduct_MinLabel";
            this.ModProduct_MinLabel.Size = new System.Drawing.Size(24, 13);
            this.ModProduct_MinLabel.TabIndex = 14;
            this.ModProduct_MinLabel.Text = "Min";
            // 
            // AddProduct_InventoryText
            // 
            this.AddProduct_InventoryText.Location = new System.Drawing.Point(74, 115);
            this.AddProduct_InventoryText.Name = "AddProduct_InventoryText";
            this.AddProduct_InventoryText.Size = new System.Drawing.Size(148, 20);
            this.AddProduct_InventoryText.TabIndex = 2;
            // 
            // ModProduct_PriceLabel
            // 
            this.ModProduct_PriceLabel.AutoSize = true;
            this.ModProduct_PriceLabel.Location = new System.Drawing.Point(17, 144);
            this.ModProduct_PriceLabel.Name = "ModProduct_PriceLabel";
            this.ModProduct_PriceLabel.Size = new System.Drawing.Size(31, 13);
            this.ModProduct_PriceLabel.TabIndex = 13;
            this.ModProduct_PriceLabel.Text = "Price";
            // 
            // AddProduct_NameText
            // 
            this.AddProduct_NameText.Location = new System.Drawing.Point(74, 89);
            this.AddProduct_NameText.Name = "AddProduct_NameText";
            this.AddProduct_NameText.Size = new System.Drawing.Size(148, 20);
            this.AddProduct_NameText.TabIndex = 1;
            // 
            // ModProduct_InventoryLabel
            // 
            this.ModProduct_InventoryLabel.AutoSize = true;
            this.ModProduct_InventoryLabel.Location = new System.Drawing.Point(17, 118);
            this.ModProduct_InventoryLabel.Name = "ModProduct_InventoryLabel";
            this.ModProduct_InventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.ModProduct_InventoryLabel.TabIndex = 12;
            this.ModProduct_InventoryLabel.Text = "Inventory";
            // 
            // AddProduct_ProdId
            // 
            this.AddProduct_ProdId.Enabled = false;
            this.AddProduct_ProdId.Location = new System.Drawing.Point(74, 62);
            this.AddProduct_ProdId.Name = "AddProduct_ProdId";
            this.AddProduct_ProdId.Size = new System.Drawing.Size(148, 20);
            this.AddProduct_ProdId.TabIndex = 0;
            // 
            // ModProduct_NameLabel
            // 
            this.ModProduct_NameLabel.AutoSize = true;
            this.ModProduct_NameLabel.Location = new System.Drawing.Point(17, 92);
            this.ModProduct_NameLabel.Name = "ModProduct_NameLabel";
            this.ModProduct_NameLabel.Size = new System.Drawing.Size(35, 13);
            this.ModProduct_NameLabel.TabIndex = 10;
            this.ModProduct_NameLabel.Text = "Name";
            // 
            // ModProduct_IdLabel
            // 
            this.ModProduct_IdLabel.AutoSize = true;
            this.ModProduct_IdLabel.Location = new System.Drawing.Point(16, 65);
            this.ModProduct_IdLabel.Name = "ModProduct_IdLabel";
            this.ModProduct_IdLabel.Size = new System.Drawing.Size(18, 13);
            this.ModProduct_IdLabel.TabIndex = 15;
            this.ModProduct_IdLabel.Text = "ID";
            // 
            // AddProduct_Label
            // 
            this.AddProduct_Label.AutoSize = true;
            this.AddProduct_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProduct_Label.Location = new System.Drawing.Point(16, 17);
            this.AddProduct_Label.Name = "AddProduct_Label";
            this.AddProduct_Label.Size = new System.Drawing.Size(108, 20);
            this.AddProduct_Label.TabIndex = 8;
            this.AddProduct_Label.Text = "Add Product";
            // 
            // FillDummyData
            // 
            this.FillDummyData.Location = new System.Drawing.Point(74, 333);
            this.FillDummyData.Name = "FillDummyData";
            this.FillDummyData.Size = new System.Drawing.Size(148, 23);
            this.FillDummyData.TabIndex = 27;
            this.FillDummyData.Text = "Fill Sample";
            this.FillDummyData.UseVisualStyleBackColor = true;
            this.FillDummyData.Click += new System.EventHandler(this.FillDummyData_Click);
            // 
            // addproduct_searchpart
            // 
            this.addproduct_searchpart.Location = new System.Drawing.Point(726, 34);
            this.addproduct_searchpart.Name = "addproduct_searchpart";
            this.addproduct_searchpart.Size = new System.Drawing.Size(67, 23);
            this.addproduct_searchpart.TabIndex = 9;
            this.addproduct_searchpart.Text = "S&earch";
            this.addproduct_searchpart.UseVisualStyleBackColor = true;
            this.addproduct_searchpart.Click += new System.EventHandler(this.addproduct_searchpart_Click);
            // 
            // AddProduct_ClearSearch
            // 
            this.AddProduct_ClearSearch.Location = new System.Drawing.Point(799, 34);
            this.AddProduct_ClearSearch.Name = "AddProduct_ClearSearch";
            this.AddProduct_ClearSearch.Size = new System.Drawing.Size(67, 23);
            this.AddProduct_ClearSearch.TabIndex = 9;
            this.AddProduct_ClearSearch.Text = "C&lear";
            this.AddProduct_ClearSearch.UseVisualStyleBackColor = true;
            this.AddProduct_ClearSearch.Click += new System.EventHandler(this.AddProduct_ClearSearch_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.AddProduct_ClearSearch);
            this.Controls.Add(this.addproduct_searchpart);
            this.Controls.Add(this.FillDummyData);
            this.Controls.Add(this.AddProduct_SaveProductButton);
            this.Controls.Add(this.AddProduct_dgAssocParts);
            this.Controls.Add(this.AddProduct_SearchText);
            this.Controls.Add(this.ModProduct_SearchLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddProduct_DeletePartFromProductButton);
            this.Controls.Add(this.AddProduct_AssocPartWithProdButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddProduct_CancelButton);
            this.Controls.Add(this.AddProduct_dgParts);
            this.Controls.Add(this.AddProduct_MaxText);
            this.Controls.Add(this.AddProduct_MinText);
            this.Controls.Add(this.ModProduct_MaxLabel);
            this.Controls.Add(this.AddProduct_PriceText);
            this.Controls.Add(this.ModProduct_MinLabel);
            this.Controls.Add(this.AddProduct_InventoryText);
            this.Controls.Add(this.ModProduct_PriceLabel);
            this.Controls.Add(this.AddProduct_NameText);
            this.Controls.Add(this.ModProduct_InventoryLabel);
            this.Controls.Add(this.AddProduct_ProdId);
            this.Controls.Add(this.ModProduct_NameLabel);
            this.Controls.Add(this.ModProduct_IdLabel);
            this.Controls.Add(this.AddProduct_Label);
            this.Name = "AddProductForm";
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.AddProduct_dgAssocParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddProduct_dgParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddProduct_SaveProductButton;
        private System.Windows.Forms.DataGridView AddProduct_dgAssocParts;
        private System.Windows.Forms.TextBox AddProduct_SearchText;
        private System.Windows.Forms.Label ModProduct_SearchLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddProduct_DeletePartFromProductButton;
        private System.Windows.Forms.Button AddProduct_AssocPartWithProdButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddProduct_CancelButton;
        private System.Windows.Forms.DataGridView AddProduct_dgParts;
        private System.Windows.Forms.TextBox AddProduct_MaxText;
        private System.Windows.Forms.TextBox AddProduct_MinText;
        private System.Windows.Forms.Label ModProduct_MaxLabel;
        private System.Windows.Forms.TextBox AddProduct_PriceText;
        private System.Windows.Forms.Label ModProduct_MinLabel;
        private System.Windows.Forms.TextBox AddProduct_InventoryText;
        private System.Windows.Forms.Label ModProduct_PriceLabel;
        private System.Windows.Forms.TextBox AddProduct_NameText;
        private System.Windows.Forms.Label ModProduct_InventoryLabel;
        private System.Windows.Forms.TextBox AddProduct_ProdId;
        private System.Windows.Forms.Label ModProduct_NameLabel;
        private System.Windows.Forms.Label ModProduct_IdLabel;
        private System.Windows.Forms.Label AddProduct_Label;
        private System.Windows.Forms.Button FillDummyData;
        private System.Windows.Forms.Button addproduct_searchpart;
        private System.Windows.Forms.Button AddProduct_ClearSearch;
    }
}