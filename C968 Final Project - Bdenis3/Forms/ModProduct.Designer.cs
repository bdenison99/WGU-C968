namespace C968_Final_Project___Bdenis3
{
    partial class ModProductForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ModProduct_IdLabel = new System.Windows.Forms.Label();
            this.ModProduct_ProdId = new System.Windows.Forms.TextBox();
            this.ModProduct_NameLabel = new System.Windows.Forms.Label();
            this.ModProduct_NameText = new System.Windows.Forms.TextBox();
            this.ModProduct_InventoryLabel = new System.Windows.Forms.Label();
            this.ModProduct_InventoryText = new System.Windows.Forms.TextBox();
            this.ModProduct_PriceLabel = new System.Windows.Forms.Label();
            this.ModProduct_PriceText = new System.Windows.Forms.TextBox();
            this.ModProduct_MinLabel = new System.Windows.Forms.Label();
            this.ModProduct_MinText = new System.Windows.Forms.TextBox();
            this.ModProduct_MaxLabel = new System.Windows.Forms.Label();
            this.ModProduct_MaxText = new System.Windows.Forms.TextBox();
            this.ModProduct_dgAllParts = new System.Windows.Forms.DataGridView();
            this.ModProduct_SearchLabel = new System.Windows.Forms.Label();
            this.ModProduct_SearchText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ModProduct_dgAssocParts = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.ModProduct_AssocPartWithProdButton = new System.Windows.Forms.Button();
            this.ModProduct_DeletePartFromProductButton = new System.Windows.Forms.Button();
            this.ModProduct_SaveProductButton = new System.Windows.Forms.Button();
            this.ModProduct_CancelButton = new System.Windows.Forms.Button();
            this.ModProduct_SearchButton = new System.Windows.Forms.Button();
            this.ModProduct_ClearSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ModProduct_dgAllParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModProduct_dgAssocParts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modify Product";
            // 
            // ModProduct_IdLabel
            // 
            this.ModProduct_IdLabel.AutoSize = true;
            this.ModProduct_IdLabel.Location = new System.Drawing.Point(13, 61);
            this.ModProduct_IdLabel.Name = "ModProduct_IdLabel";
            this.ModProduct_IdLabel.Size = new System.Drawing.Size(18, 13);
            this.ModProduct_IdLabel.TabIndex = 1;
            this.ModProduct_IdLabel.Text = "ID";
            // 
            // ModProduct_ProdId
            // 
            this.ModProduct_ProdId.Location = new System.Drawing.Point(71, 58);
            this.ModProduct_ProdId.Name = "ModProduct_ProdId";
            this.ModProduct_ProdId.Size = new System.Drawing.Size(148, 20);
            this.ModProduct_ProdId.TabIndex = 2;
            this.ModProduct_ProdId.TextChanged += new System.EventHandler(this.ProductFieldChanged);
            // 
            // ModProduct_NameLabel
            // 
            this.ModProduct_NameLabel.AutoSize = true;
            this.ModProduct_NameLabel.Location = new System.Drawing.Point(14, 88);
            this.ModProduct_NameLabel.Name = "ModProduct_NameLabel";
            this.ModProduct_NameLabel.Size = new System.Drawing.Size(35, 13);
            this.ModProduct_NameLabel.TabIndex = 1;
            this.ModProduct_NameLabel.Text = "Name";
            // 
            // ModProduct_NameText
            // 
            this.ModProduct_NameText.Location = new System.Drawing.Point(71, 85);
            this.ModProduct_NameText.Name = "ModProduct_NameText";
            this.ModProduct_NameText.Size = new System.Drawing.Size(148, 20);
            this.ModProduct_NameText.TabIndex = 3;
            this.ModProduct_NameText.TextChanged += new System.EventHandler(this.ProductFieldChanged);
            // 
            // ModProduct_InventoryLabel
            // 
            this.ModProduct_InventoryLabel.AutoSize = true;
            this.ModProduct_InventoryLabel.Location = new System.Drawing.Point(14, 114);
            this.ModProduct_InventoryLabel.Name = "ModProduct_InventoryLabel";
            this.ModProduct_InventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.ModProduct_InventoryLabel.TabIndex = 1;
            this.ModProduct_InventoryLabel.Text = "Inventory";
            // 
            // ModProduct_InventoryText
            // 
            this.ModProduct_InventoryText.Location = new System.Drawing.Point(71, 111);
            this.ModProduct_InventoryText.Name = "ModProduct_InventoryText";
            this.ModProduct_InventoryText.Size = new System.Drawing.Size(148, 20);
            this.ModProduct_InventoryText.TabIndex = 4;
            this.ModProduct_InventoryText.TextChanged += new System.EventHandler(this.ProductFieldChanged);
            // 
            // ModProduct_PriceLabel
            // 
            this.ModProduct_PriceLabel.AutoSize = true;
            this.ModProduct_PriceLabel.Location = new System.Drawing.Point(14, 140);
            this.ModProduct_PriceLabel.Name = "ModProduct_PriceLabel";
            this.ModProduct_PriceLabel.Size = new System.Drawing.Size(31, 13);
            this.ModProduct_PriceLabel.TabIndex = 1;
            this.ModProduct_PriceLabel.Text = "Price";
            // 
            // ModProduct_PriceText
            // 
            this.ModProduct_PriceText.Location = new System.Drawing.Point(71, 137);
            this.ModProduct_PriceText.Name = "ModProduct_PriceText";
            this.ModProduct_PriceText.Size = new System.Drawing.Size(148, 20);
            this.ModProduct_PriceText.TabIndex = 5;
            this.ModProduct_PriceText.TextChanged += new System.EventHandler(this.ProductFieldChanged);
            // 
            // ModProduct_MinLabel
            // 
            this.ModProduct_MinLabel.AutoSize = true;
            this.ModProduct_MinLabel.Location = new System.Drawing.Point(133, 166);
            this.ModProduct_MinLabel.Name = "ModProduct_MinLabel";
            this.ModProduct_MinLabel.Size = new System.Drawing.Size(24, 13);
            this.ModProduct_MinLabel.TabIndex = 1;
            this.ModProduct_MinLabel.Text = "Min";
            // 
            // ModProduct_MinText
            // 
            this.ModProduct_MinText.Location = new System.Drawing.Point(163, 163);
            this.ModProduct_MinText.Name = "ModProduct_MinText";
            this.ModProduct_MinText.Size = new System.Drawing.Size(56, 20);
            this.ModProduct_MinText.TabIndex = 7;
            this.ModProduct_MinText.TextChanged += new System.EventHandler(this.ProductFieldChanged);
            // 
            // ModProduct_MaxLabel
            // 
            this.ModProduct_MaxLabel.AutoSize = true;
            this.ModProduct_MaxLabel.Location = new System.Drawing.Point(14, 166);
            this.ModProduct_MaxLabel.Name = "ModProduct_MaxLabel";
            this.ModProduct_MaxLabel.Size = new System.Drawing.Size(27, 13);
            this.ModProduct_MaxLabel.TabIndex = 1;
            this.ModProduct_MaxLabel.Text = "Max";
            // 
            // ModProduct_MaxText
            // 
            this.ModProduct_MaxText.Location = new System.Drawing.Point(47, 163);
            this.ModProduct_MaxText.Name = "ModProduct_MaxText";
            this.ModProduct_MaxText.Size = new System.Drawing.Size(56, 20);
            this.ModProduct_MaxText.TabIndex = 6;
            this.ModProduct_MaxText.TextChanged += new System.EventHandler(this.ProductFieldChanged);
            // 
            // ModProduct_dgAllParts
            // 
            this.ModProduct_dgAllParts.AllowUserToAddRows = false;
            this.ModProduct_dgAllParts.AllowUserToDeleteRows = false;
            this.ModProduct_dgAllParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ModProduct_dgAllParts.Location = new System.Drawing.Point(259, 58);
            this.ModProduct_dgAllParts.Name = "ModProduct_dgAllParts";
            this.ModProduct_dgAllParts.RowHeadersVisible = false;
            this.ModProduct_dgAllParts.Size = new System.Drawing.Size(605, 150);
            this.ModProduct_dgAllParts.TabIndex = 3;
            // 
            // ModProduct_SearchLabel
            // 
            this.ModProduct_SearchLabel.AutoSize = true;
            this.ModProduct_SearchLabel.Location = new System.Drawing.Point(257, 35);
            this.ModProduct_SearchLabel.Name = "ModProduct_SearchLabel";
            this.ModProduct_SearchLabel.Size = new System.Drawing.Size(41, 13);
            this.ModProduct_SearchLabel.TabIndex = 1;
            this.ModProduct_SearchLabel.Text = "Search";
            // 
            // ModProduct_SearchText
            // 
            this.ModProduct_SearchText.Location = new System.Drawing.Point(304, 32);
            this.ModProduct_SearchText.Name = "ModProduct_SearchText";
            this.ModProduct_SearchText.Size = new System.Drawing.Size(398, 20);
            this.ModProduct_SearchText.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Candidate Parts";
            // 
            // ModProduct_dgAssocParts
            // 
            this.ModProduct_dgAssocParts.AllowUserToAddRows = false;
            this.ModProduct_dgAssocParts.AllowUserToDeleteRows = false;
            this.ModProduct_dgAssocParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ModProduct_dgAssocParts.Location = new System.Drawing.Point(258, 263);
            this.ModProduct_dgAssocParts.Name = "ModProduct_dgAssocParts";
            this.ModProduct_dgAssocParts.RowHeadersVisible = false;
            this.ModProduct_dgAssocParts.Size = new System.Drawing.Size(605, 150);
            this.ModProduct_dgAssocParts.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(256, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Associated Parts";
            // 
            // ModProduct_AssocPartWithProdButton
            // 
            this.ModProduct_AssocPartWithProdButton.Location = new System.Drawing.Point(666, 216);
            this.ModProduct_AssocPartWithProdButton.Name = "ModProduct_AssocPartWithProdButton";
            this.ModProduct_AssocPartWithProdButton.Size = new System.Drawing.Size(197, 24);
            this.ModProduct_AssocPartWithProdButton.TabIndex = 12;
            this.ModProduct_AssocPartWithProdButton.Text = "Ass&ociate Part with Product";
            this.ModProduct_AssocPartWithProdButton.UseVisualStyleBackColor = true;
            this.ModProduct_AssocPartWithProdButton.Click += new System.EventHandler(this.ModProduct_AssocPartWithProdButton_Click);
            // 
            // ModProduct_DeletePartFromProductButton
            // 
            this.ModProduct_DeletePartFromProductButton.Location = new System.Drawing.Point(666, 420);
            this.ModProduct_DeletePartFromProductButton.Name = "ModProduct_DeletePartFromProductButton";
            this.ModProduct_DeletePartFromProductButton.Size = new System.Drawing.Size(198, 23);
            this.ModProduct_DeletePartFromProductButton.TabIndex = 14;
            this.ModProduct_DeletePartFromProductButton.Text = "&Disassociate Part from Product";
            this.ModProduct_DeletePartFromProductButton.UseVisualStyleBackColor = true;
            this.ModProduct_DeletePartFromProductButton.Click += new System.EventHandler(this.ModProduct_DeletePartFromProductButton_Click);
            // 
            // ModProduct_SaveProductButton
            // 
            this.ModProduct_SaveProductButton.Location = new System.Drawing.Point(71, 217);
            this.ModProduct_SaveProductButton.Name = "ModProduct_SaveProductButton";
            this.ModProduct_SaveProductButton.Size = new System.Drawing.Size(147, 23);
            this.ModProduct_SaveProductButton.TabIndex = 8;
            this.ModProduct_SaveProductButton.Text = "&Save Product";
            this.ModProduct_SaveProductButton.UseVisualStyleBackColor = true;
            this.ModProduct_SaveProductButton.Click += new System.EventHandler(this.ModProduct_SaveProductButton_Click);
            // 
            // ModProduct_CancelButton
            // 
            this.ModProduct_CancelButton.Location = new System.Drawing.Point(71, 246);
            this.ModProduct_CancelButton.Name = "ModProduct_CancelButton";
            this.ModProduct_CancelButton.Size = new System.Drawing.Size(147, 23);
            this.ModProduct_CancelButton.TabIndex = 9;
            this.ModProduct_CancelButton.Text = "&Cancel";
            this.ModProduct_CancelButton.UseVisualStyleBackColor = true;
            this.ModProduct_CancelButton.Click += new System.EventHandler(this.ModProduct_CancelButton_Click);
            // 
            // ModProduct_SearchButton
            // 
            this.ModProduct_SearchButton.Location = new System.Drawing.Point(708, 30);
            this.ModProduct_SearchButton.Name = "ModProduct_SearchButton";
            this.ModProduct_SearchButton.Size = new System.Drawing.Size(75, 23);
            this.ModProduct_SearchButton.TabIndex = 11;
            this.ModProduct_SearchButton.Text = "S&earch";
            this.ModProduct_SearchButton.UseVisualStyleBackColor = true;
            this.ModProduct_SearchButton.Click += new System.EventHandler(this.ModProduct_SearchButton_Click);
            // 
            // ModProduct_ClearSearch
            // 
            this.ModProduct_ClearSearch.Location = new System.Drawing.Point(789, 30);
            this.ModProduct_ClearSearch.Name = "ModProduct_ClearSearch";
            this.ModProduct_ClearSearch.Size = new System.Drawing.Size(75, 23);
            this.ModProduct_ClearSearch.TabIndex = 15;
            this.ModProduct_ClearSearch.Text = "C&lear";
            this.ModProduct_ClearSearch.UseVisualStyleBackColor = true;
            this.ModProduct_ClearSearch.Click += new System.EventHandler(this.ModProduct_ClearSearch_Click);
            // 
            // ModProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.ModProduct_ClearSearch);
            this.Controls.Add(this.ModProduct_SearchButton);
            this.Controls.Add(this.ModProduct_CancelButton);
            this.Controls.Add(this.ModProduct_SaveProductButton);
            this.Controls.Add(this.ModProduct_DeletePartFromProductButton);
            this.Controls.Add(this.ModProduct_AssocPartWithProdButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ModProduct_dgAssocParts);
            this.Controls.Add(this.ModProduct_dgAllParts);
            this.Controls.Add(this.ModProduct_MaxText);
            this.Controls.Add(this.ModProduct_MinText);
            this.Controls.Add(this.ModProduct_MaxLabel);
            this.Controls.Add(this.ModProduct_PriceText);
            this.Controls.Add(this.ModProduct_MinLabel);
            this.Controls.Add(this.ModProduct_InventoryText);
            this.Controls.Add(this.ModProduct_PriceLabel);
            this.Controls.Add(this.ModProduct_NameText);
            this.Controls.Add(this.ModProduct_InventoryLabel);
            this.Controls.Add(this.ModProduct_SearchText);
            this.Controls.Add(this.ModProduct_ProdId);
            this.Controls.Add(this.ModProduct_SearchLabel);
            this.Controls.Add(this.ModProduct_NameLabel);
            this.Controls.Add(this.ModProduct_IdLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModProductForm";
            this.Text = "Modify Product";
            ((System.ComponentModel.ISupportInitialize)(this.ModProduct_dgAllParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModProduct_dgAssocParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ModProduct_IdLabel;
        private System.Windows.Forms.TextBox ModProduct_ProdId;
        private System.Windows.Forms.Label ModProduct_NameLabel;
        private System.Windows.Forms.TextBox ModProduct_NameText;
        private System.Windows.Forms.Label ModProduct_InventoryLabel;
        private System.Windows.Forms.TextBox ModProduct_InventoryText;
        private System.Windows.Forms.Label ModProduct_PriceLabel;
        private System.Windows.Forms.TextBox ModProduct_PriceText;
        private System.Windows.Forms.Label ModProduct_MinLabel;
        private System.Windows.Forms.TextBox ModProduct_MinText;
        private System.Windows.Forms.Label ModProduct_MaxLabel;
        private System.Windows.Forms.TextBox ModProduct_MaxText;
        private System.Windows.Forms.DataGridView ModProduct_dgAllParts;
        private System.Windows.Forms.Label ModProduct_SearchLabel;
        private System.Windows.Forms.TextBox ModProduct_SearchText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ModProduct_dgAssocParts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ModProduct_AssocPartWithProdButton;
        private System.Windows.Forms.Button ModProduct_DeletePartFromProductButton;
        private System.Windows.Forms.Button ModProduct_SaveProductButton;
        private System.Windows.Forms.Button ModProduct_CancelButton;
        private System.Windows.Forms.Button ModProduct_SearchButton;
        private System.Windows.Forms.Button ModProduct_ClearSearch;
    }
}