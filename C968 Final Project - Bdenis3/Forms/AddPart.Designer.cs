namespace C968_Final_Project___Bdenis3
{
    partial class AddPartForm
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
            this.AddPart_InhouseRadio = new System.Windows.Forms.RadioButton();
            this.AddPart_OutsourcedRadio = new System.Windows.Forms.RadioButton();
            this.AddPart_TextPartId = new System.Windows.Forms.TextBox();
            this.AddPart_LabelPartId = new System.Windows.Forms.Label();
            this.AddPart_MainLabel = new System.Windows.Forms.Label();
            this.AddPart_PartNameLabel = new System.Windows.Forms.Label();
            this.AddPart_InventoryLabel = new System.Windows.Forms.Label();
            this.AddPart_PriceLabel = new System.Windows.Forms.Label();
            this.AddPart_MinLabel = new System.Windows.Forms.Label();
            this.AddPart_MaxLabel = new System.Windows.Forms.Label();
            this.AddPart_CompanyMachineLabel = new System.Windows.Forms.Label();
            this.AddPart_TextName = new System.Windows.Forms.TextBox();
            this.AddPart_TextInventory = new System.Windows.Forms.TextBox();
            this.AddPart_TextPrice = new System.Windows.Forms.TextBox();
            this.AddPart_TextMin = new System.Windows.Forms.TextBox();
            this.AddPart_TextMax = new System.Windows.Forms.TextBox();
            this.AddPart_TextSource = new System.Windows.Forms.TextBox();
            this.AddPart_ButtonSave = new System.Windows.Forms.Button();
            this.AddPart_ButtonCancel = new System.Windows.Forms.Button();
            this.LoadSampleData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddPart_InhouseRadio
            // 
            this.AddPart_InhouseRadio.AutoSize = true;
            this.AddPart_InhouseRadio.Location = new System.Drawing.Point(114, 12);
            this.AddPart_InhouseRadio.Name = "AddPart_InhouseRadio";
            this.AddPart_InhouseRadio.Size = new System.Drawing.Size(68, 17);
            this.AddPart_InhouseRadio.TabIndex = 0;
            this.AddPart_InhouseRadio.TabStop = true;
            this.AddPart_InhouseRadio.Text = "In-House";
            this.AddPart_InhouseRadio.UseVisualStyleBackColor = true;
            this.AddPart_InhouseRadio.CheckedChanged += new System.EventHandler(this.AddPart_InhouseRadio_CheckedChanged);
            // 
            // AddPart_OutsourcedRadio
            // 
            this.AddPart_OutsourcedRadio.AutoSize = true;
            this.AddPart_OutsourcedRadio.Checked = true;
            this.AddPart_OutsourcedRadio.Location = new System.Drawing.Point(188, 12);
            this.AddPart_OutsourcedRadio.Name = "AddPart_OutsourcedRadio";
            this.AddPart_OutsourcedRadio.Size = new System.Drawing.Size(80, 17);
            this.AddPart_OutsourcedRadio.TabIndex = 1;
            this.AddPart_OutsourcedRadio.TabStop = true;
            this.AddPart_OutsourcedRadio.Text = "Outsourced";
            this.AddPart_OutsourcedRadio.UseVisualStyleBackColor = true;
            this.AddPart_OutsourcedRadio.CheckedChanged += new System.EventHandler(this.AddPart_OutsourcedRadio_CheckedChanged);
            // 
            // AddPart_TextPartId
            // 
            this.AddPart_TextPartId.Enabled = false;
            this.AddPart_TextPartId.Location = new System.Drawing.Point(114, 65);
            this.AddPart_TextPartId.Name = "AddPart_TextPartId";
            this.AddPart_TextPartId.Size = new System.Drawing.Size(154, 20);
            this.AddPart_TextPartId.TabIndex = 2;
            // 
            // AddPart_LabelPartId
            // 
            this.AddPart_LabelPartId.AutoSize = true;
            this.AddPart_LabelPartId.Location = new System.Drawing.Point(27, 68);
            this.AddPart_LabelPartId.Name = "AddPart_LabelPartId";
            this.AddPart_LabelPartId.Size = new System.Drawing.Size(40, 13);
            this.AddPart_LabelPartId.TabIndex = 3;
            this.AddPart_LabelPartId.Text = "Part ID";
            // 
            // AddPart_MainLabel
            // 
            this.AddPart_MainLabel.AutoSize = true;
            this.AddPart_MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPart_MainLabel.Location = new System.Drawing.Point(12, 14);
            this.AddPart_MainLabel.Name = "AddPart_MainLabel";
            this.AddPart_MainLabel.Size = new System.Drawing.Size(71, 20);
            this.AddPart_MainLabel.TabIndex = 3;
            this.AddPart_MainLabel.Text = "Add Part";
            // 
            // AddPart_PartNameLabel
            // 
            this.AddPart_PartNameLabel.AutoSize = true;
            this.AddPart_PartNameLabel.Location = new System.Drawing.Point(27, 94);
            this.AddPart_PartNameLabel.Name = "AddPart_PartNameLabel";
            this.AddPart_PartNameLabel.Size = new System.Drawing.Size(35, 13);
            this.AddPart_PartNameLabel.TabIndex = 3;
            this.AddPart_PartNameLabel.Text = "Name";
            // 
            // AddPart_InventoryLabel
            // 
            this.AddPart_InventoryLabel.AutoSize = true;
            this.AddPart_InventoryLabel.Location = new System.Drawing.Point(27, 120);
            this.AddPart_InventoryLabel.Name = "AddPart_InventoryLabel";
            this.AddPart_InventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.AddPart_InventoryLabel.TabIndex = 3;
            this.AddPart_InventoryLabel.Text = "Inventory";
            // 
            // AddPart_PriceLabel
            // 
            this.AddPart_PriceLabel.AutoSize = true;
            this.AddPart_PriceLabel.Location = new System.Drawing.Point(27, 146);
            this.AddPart_PriceLabel.Name = "AddPart_PriceLabel";
            this.AddPart_PriceLabel.Size = new System.Drawing.Size(63, 13);
            this.AddPart_PriceLabel.TabIndex = 3;
            this.AddPart_PriceLabel.Text = "Price / Cost";
            // 
            // AddPart_MinLabel
            // 
            this.AddPart_MinLabel.AutoSize = true;
            this.AddPart_MinLabel.Location = new System.Drawing.Point(191, 172);
            this.AddPart_MinLabel.Name = "AddPart_MinLabel";
            this.AddPart_MinLabel.Size = new System.Drawing.Size(24, 13);
            this.AddPart_MinLabel.TabIndex = 3;
            this.AddPart_MinLabel.Text = "Min";
            // 
            // AddPart_MaxLabel
            // 
            this.AddPart_MaxLabel.AutoSize = true;
            this.AddPart_MaxLabel.Location = new System.Drawing.Point(81, 172);
            this.AddPart_MaxLabel.Name = "AddPart_MaxLabel";
            this.AddPart_MaxLabel.Size = new System.Drawing.Size(27, 13);
            this.AddPart_MaxLabel.TabIndex = 3;
            this.AddPart_MaxLabel.Text = "Max";
            // 
            // AddPart_CompanyMachineLabel
            // 
            this.AddPart_CompanyMachineLabel.AutoSize = true;
            this.AddPart_CompanyMachineLabel.Location = new System.Drawing.Point(27, 198);
            this.AddPart_CompanyMachineLabel.Name = "AddPart_CompanyMachineLabel";
            this.AddPart_CompanyMachineLabel.Size = new System.Drawing.Size(51, 13);
            this.AddPart_CompanyMachineLabel.TabIndex = 3;
            this.AddPart_CompanyMachineLabel.Text = "Company";
            // 
            // AddPart_TextName
            // 
            this.AddPart_TextName.Location = new System.Drawing.Point(114, 91);
            this.AddPart_TextName.Name = "AddPart_TextName";
            this.AddPart_TextName.Size = new System.Drawing.Size(154, 20);
            this.AddPart_TextName.TabIndex = 3;
            // 
            // AddPart_TextInventory
            // 
            this.AddPart_TextInventory.Location = new System.Drawing.Point(114, 117);
            this.AddPart_TextInventory.Name = "AddPart_TextInventory";
            this.AddPart_TextInventory.Size = new System.Drawing.Size(154, 20);
            this.AddPart_TextInventory.TabIndex = 4;
            // 
            // AddPart_TextPrice
            // 
            this.AddPart_TextPrice.Location = new System.Drawing.Point(114, 143);
            this.AddPart_TextPrice.Name = "AddPart_TextPrice";
            this.AddPart_TextPrice.Size = new System.Drawing.Size(154, 20);
            this.AddPart_TextPrice.TabIndex = 5;
            // 
            // AddPart_TextMin
            // 
            this.AddPart_TextMin.Location = new System.Drawing.Point(221, 169);
            this.AddPart_TextMin.Name = "AddPart_TextMin";
            this.AddPart_TextMin.Size = new System.Drawing.Size(47, 20);
            this.AddPart_TextMin.TabIndex = 7;
            // 
            // AddPart_TextMax
            // 
            this.AddPart_TextMax.Location = new System.Drawing.Point(114, 169);
            this.AddPart_TextMax.Name = "AddPart_TextMax";
            this.AddPart_TextMax.Size = new System.Drawing.Size(47, 20);
            this.AddPart_TextMax.TabIndex = 6;
            // 
            // AddPart_TextSource
            // 
            this.AddPart_TextSource.Location = new System.Drawing.Point(114, 198);
            this.AddPart_TextSource.Name = "AddPart_TextSource";
            this.AddPart_TextSource.Size = new System.Drawing.Size(154, 20);
            this.AddPart_TextSource.TabIndex = 8;
            // 
            // AddPart_ButtonSave
            // 
            this.AddPart_ButtonSave.Location = new System.Drawing.Point(107, 247);
            this.AddPart_ButtonSave.Name = "AddPart_ButtonSave";
            this.AddPart_ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.AddPart_ButtonSave.TabIndex = 9;
            this.AddPart_ButtonSave.Text = "&Save";
            this.AddPart_ButtonSave.UseVisualStyleBackColor = true;
            this.AddPart_ButtonSave.Click += new System.EventHandler(this.AddPart_ButtonSave_Click);
            // 
            // AddPart_ButtonCancel
            // 
            this.AddPart_ButtonCancel.Location = new System.Drawing.Point(193, 247);
            this.AddPart_ButtonCancel.Name = "AddPart_ButtonCancel";
            this.AddPart_ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.AddPart_ButtonCancel.TabIndex = 10;
            this.AddPart_ButtonCancel.Text = "&Cancel";
            this.AddPart_ButtonCancel.UseVisualStyleBackColor = true;
            this.AddPart_ButtonCancel.Click += new System.EventHandler(this.AddPart_ButtonCancel_Click);
            // 
            // LoadSampleData
            // 
            this.LoadSampleData.Location = new System.Drawing.Point(16, 247);
            this.LoadSampleData.Name = "LoadSampleData";
            this.LoadSampleData.Size = new System.Drawing.Size(75, 23);
            this.LoadSampleData.TabIndex = 11;
            this.LoadSampleData.Text = "Fill Data";
            this.LoadSampleData.UseVisualStyleBackColor = true;
            this.LoadSampleData.Click += new System.EventHandler(this.LoadSampleData_click);
            // 
            // AddPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 291);
            this.Controls.Add(this.LoadSampleData);
            this.Controls.Add(this.AddPart_ButtonCancel);
            this.Controls.Add(this.AddPart_ButtonSave);
            this.Controls.Add(this.AddPart_MainLabel);
            this.Controls.Add(this.AddPart_MaxLabel);
            this.Controls.Add(this.AddPart_MinLabel);
            this.Controls.Add(this.AddPart_CompanyMachineLabel);
            this.Controls.Add(this.AddPart_PriceLabel);
            this.Controls.Add(this.AddPart_InventoryLabel);
            this.Controls.Add(this.AddPart_PartNameLabel);
            this.Controls.Add(this.AddPart_LabelPartId);
            this.Controls.Add(this.AddPart_TextMax);
            this.Controls.Add(this.AddPart_TextMin);
            this.Controls.Add(this.AddPart_TextSource);
            this.Controls.Add(this.AddPart_TextPrice);
            this.Controls.Add(this.AddPart_TextInventory);
            this.Controls.Add(this.AddPart_TextName);
            this.Controls.Add(this.AddPart_TextPartId);
            this.Controls.Add(this.AddPart_OutsourcedRadio);
            this.Controls.Add(this.AddPart_InhouseRadio);
            this.Name = "AddPartForm";
            this.Text = "Add Part - Bart Denison";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton AddPart_InhouseRadio;
        private System.Windows.Forms.RadioButton AddPart_OutsourcedRadio;
        private System.Windows.Forms.TextBox AddPart_TextPartId;
        private System.Windows.Forms.Label AddPart_LabelPartId;
        private System.Windows.Forms.Label AddPart_MainLabel;
        private System.Windows.Forms.Label AddPart_PartNameLabel;
        private System.Windows.Forms.Label AddPart_InventoryLabel;
        private System.Windows.Forms.Label AddPart_PriceLabel;
        private System.Windows.Forms.Label AddPart_MinLabel;
        private System.Windows.Forms.Label AddPart_MaxLabel;
        private System.Windows.Forms.Label AddPart_CompanyMachineLabel;
        private System.Windows.Forms.TextBox AddPart_TextName;
        private System.Windows.Forms.TextBox AddPart_TextInventory;
        private System.Windows.Forms.TextBox AddPart_TextPrice;
        private System.Windows.Forms.TextBox AddPart_TextMin;
        private System.Windows.Forms.TextBox AddPart_TextMax;
        private System.Windows.Forms.TextBox AddPart_TextSource;
        private System.Windows.Forms.Button AddPart_ButtonSave;
        private System.Windows.Forms.Button AddPart_ButtonCancel;
        private System.Windows.Forms.Button LoadSampleData;
    }
}