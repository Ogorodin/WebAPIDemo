
namespace BackandGUI
{
    partial class ManagerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAddProductTitle = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.txtBoxProductTitle = new System.Windows.Forms.TextBox();
            this.txtBoxDescription = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.comboBoxProductType = new System.Windows.Forms.ComboBox();
            this.lblProdutType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAddProductTitle
            // 
            this.lblAddProductTitle.AutoSize = true;
            this.lblAddProductTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddProductTitle.Location = new System.Drawing.Point(94, 55);
            this.lblAddProductTitle.Name = "lblAddProductTitle";
            this.lblAddProductTitle.Size = new System.Drawing.Size(159, 32);
            this.lblAddProductTitle.TabIndex = 0;
            this.lblAddProductTitle.Text = "Add Product";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(125, 358);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(94, 29);
            this.btnAddProduct.TabIndex = 1;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // txtBoxProductTitle
            // 
            this.txtBoxProductTitle.Location = new System.Drawing.Point(163, 136);
            this.txtBoxProductTitle.Name = "txtBoxProductTitle";
            this.txtBoxProductTitle.Size = new System.Drawing.Size(151, 27);
            this.txtBoxProductTitle.TabIndex = 2;
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.Location = new System.Drawing.Point(163, 199);
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.PlaceholderText = "latin name";
            this.txtBoxDescription.Size = new System.Drawing.Size(151, 27);
            this.txtBoxDescription.TabIndex = 3;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(41, 143);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(41, 20);
            this.lblProductName.TabIndex = 4;
            this.lblProductName.Text = "Title:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(41, 206);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(88, 20);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description:";
            // 
            // comboBoxProductType
            // 
            this.comboBoxProductType.FormattingEnabled = true;
            this.comboBoxProductType.Items.AddRange(new object[] {
            "FW_FISH",
            "SW_FISH",
            "P_FISH",
            "CRAB_FISH",
            "FW_PLANT",
            "P_PLANT",
            "FOOD",
            "TANK",
            "FILTER",
            "CO2"});
            this.comboBoxProductType.Location = new System.Drawing.Point(163, 259);
            this.comboBoxProductType.Name = "comboBoxProductType";
            this.comboBoxProductType.Size = new System.Drawing.Size(151, 28);
            this.comboBoxProductType.TabIndex = 6;
            // 
            // lblProdutType
            // 
            this.lblProdutType.AutoSize = true;
            this.lblProdutType.Location = new System.Drawing.Point(41, 267);
            this.lblProdutType.Name = "lblProdutType";
            this.lblProdutType.Size = new System.Drawing.Size(96, 20);
            this.lblProdutType.TabIndex = 7;
            this.lblProdutType.Text = "Product type:";
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 501);
            this.Controls.Add(this.lblProdutType);
            this.Controls.Add(this.comboBoxProductType);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.txtBoxDescription);
            this.Controls.Add(this.txtBoxProductTitle);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.lblAddProductTitle);
            this.Name = "ManagerForm";
            this.Text = "FishShop - Product manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddProductTitle;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox txtBoxProductTitle;
        private System.Windows.Forms.TextBox txtBoxDescription;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ComboBox comboBoxProductType;
        private System.Windows.Forms.Label lblProdutType;
    }
}

