
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
            this.tabAddProduct = new System.Windows.Forms.TabControl();
            this.tabAddPage = new System.Windows.Forms.TabPage();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.lblProductList = new System.Windows.Forms.Label();
            this.listBoxProductList = new System.Windows.Forms.ListBox();
            this.addTablblActionResult = new System.Windows.Forms.Label();
            this.lblProdutType = new System.Windows.Forms.Label();
            this.addTabComboBoxProductType = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.AddTabTxtBoxDescription = new System.Windows.Forms.TextBox();
            this.addTabTxtBoxProductTitle = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.addTablblAddProductTitle = new System.Windows.Forms.Label();
            this.tabFind = new System.Windows.Forms.TabPage();
            this.listBoxFindView = new System.Windows.Forms.ListBox();
            this.btnLoadTable = new System.Windows.Forms.Button();
            this.findTabComboBoxColumnName = new System.Windows.Forms.ComboBox();
            this.findTabTextBoxSearchBar = new System.Windows.Forms.TextBox();
            this.lblSearchCriteria = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.tabAddProduct.SuspendLayout();
            this.tabAddPage.SuspendLayout();
            this.tabFind.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAddProduct
            // 
            this.tabAddProduct.Controls.Add(this.tabAddPage);
            this.tabAddProduct.Controls.Add(this.tabFind);
            this.tabAddProduct.Location = new System.Drawing.Point(0, 3);
            this.tabAddProduct.Name = "tabAddProduct";
            this.tabAddProduct.SelectedIndex = 0;
            this.tabAddProduct.Size = new System.Drawing.Size(1097, 504);
            this.tabAddProduct.TabIndex = 9;
            // 
            // tabAddPage
            // 
            this.tabAddPage.Controls.Add(this.btnRefreshList);
            this.tabAddPage.Controls.Add(this.lblProductList);
            this.tabAddPage.Controls.Add(this.listBoxProductList);
            this.tabAddPage.Controls.Add(this.addTablblActionResult);
            this.tabAddPage.Controls.Add(this.lblProdutType);
            this.tabAddPage.Controls.Add(this.addTabComboBoxProductType);
            this.tabAddPage.Controls.Add(this.lblDescription);
            this.tabAddPage.Controls.Add(this.lblProductName);
            this.tabAddPage.Controls.Add(this.AddTabTxtBoxDescription);
            this.tabAddPage.Controls.Add(this.addTabTxtBoxProductTitle);
            this.tabAddPage.Controls.Add(this.btnAddProduct);
            this.tabAddPage.Controls.Add(this.addTablblAddProductTitle);
            this.tabAddPage.Location = new System.Drawing.Point(4, 29);
            this.tabAddPage.Name = "tabAddPage";
            this.tabAddPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddPage.Size = new System.Drawing.Size(1089, 471);
            this.tabAddPage.TabIndex = 0;
            this.tabAddPage.Text = "Add";
            this.tabAddPage.UseVisualStyleBackColor = true;
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Location = new System.Drawing.Point(665, 424);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(94, 29);
            this.btnRefreshList.TabIndex = 20;
            this.btnRefreshList.Text = "Refresh List";
            this.btnRefreshList.UseVisualStyleBackColor = true;
            this.btnRefreshList.Click += new System.EventHandler(this.btnRefreshList_Click);
            // 
            // lblProductList
            // 
            this.lblProductList.AutoSize = true;
            this.lblProductList.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProductList.Location = new System.Drawing.Point(638, 34);
            this.lblProductList.Name = "lblProductList";
            this.lblProductList.Size = new System.Drawing.Size(146, 32);
            this.lblProductList.TabIndex = 19;
            this.lblProductList.Text = "Product list";
            // 
            // listBoxProductList
            // 
            this.listBoxProductList.FormattingEnabled = true;
            this.listBoxProductList.ItemHeight = 20;
            this.listBoxProductList.Location = new System.Drawing.Point(385, 95);
            this.listBoxProductList.Name = "listBoxProductList";
            this.listBoxProductList.Size = new System.Drawing.Size(669, 304);
            this.listBoxProductList.TabIndex = 18;
            // 
            // addTablblActionResult
            // 
            this.addTablblActionResult.AutoSize = true;
            this.addTablblActionResult.BackColor = System.Drawing.Color.Gainsboro;
            this.addTablblActionResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addTablblActionResult.Location = new System.Drawing.Point(64, 290);
            this.addTablblActionResult.Name = "addTablblActionResult";
            this.addTablblActionResult.Size = new System.Drawing.Size(0, 28);
            this.addTablblActionResult.TabIndex = 17;
            this.addTablblActionResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProdutType
            // 
            this.lblProdutType.AutoSize = true;
            this.lblProdutType.Location = new System.Drawing.Point(44, 246);
            this.lblProdutType.Name = "lblProdutType";
            this.lblProdutType.Size = new System.Drawing.Size(96, 20);
            this.lblProdutType.TabIndex = 16;
            this.lblProdutType.Text = "Product type:";
            // 
            // addTabComboBoxProductType
            // 
            this.addTabComboBoxProductType.FormattingEnabled = true;
            this.addTabComboBoxProductType.Items.AddRange(new object[] {
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
            this.addTabComboBoxProductType.Location = new System.Drawing.Point(166, 238);
            this.addTabComboBoxProductType.Name = "addTabComboBoxProductType";
            this.addTabComboBoxProductType.Size = new System.Drawing.Size(151, 28);
            this.addTabComboBoxProductType.TabIndex = 15;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(44, 185);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(88, 20);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = "Description:";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(44, 122);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(41, 20);
            this.lblProductName.TabIndex = 13;
            this.lblProductName.Text = "Title:";
            // 
            // AddTabTxtBoxDescription
            // 
            this.AddTabTxtBoxDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.AddTabTxtBoxDescription.Location = new System.Drawing.Point(166, 178);
            this.AddTabTxtBoxDescription.Name = "AddTabTxtBoxDescription";
            this.AddTabTxtBoxDescription.Size = new System.Drawing.Size(151, 27);
            this.AddTabTxtBoxDescription.TabIndex = 12;
            // 
            // addTabTxtBoxProductTitle
            // 
            this.addTabTxtBoxProductTitle.Location = new System.Drawing.Point(166, 115);
            this.addTabTxtBoxProductTitle.Name = "addTabTxtBoxProductTitle";
            this.addTabTxtBoxProductTitle.Size = new System.Drawing.Size(151, 27);
            this.addTabTxtBoxProductTitle.TabIndex = 11;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(150, 337);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(94, 29);
            this.btnAddProduct.TabIndex = 10;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // addTablblAddProductTitle
            // 
            this.addTablblAddProductTitle.AutoSize = true;
            this.addTablblAddProductTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addTablblAddProductTitle.Location = new System.Drawing.Point(97, 34);
            this.addTablblAddProductTitle.Name = "addTablblAddProductTitle";
            this.addTablblAddProductTitle.Size = new System.Drawing.Size(159, 32);
            this.addTablblAddProductTitle.TabIndex = 9;
            this.addTablblAddProductTitle.Text = "Add Product";
            // 
            // tabFind
            // 
            this.tabFind.Controls.Add(this.listBoxFindView);
            this.tabFind.Controls.Add(this.btnLoadTable);
            this.tabFind.Controls.Add(this.findTabComboBoxColumnName);
            this.tabFind.Controls.Add(this.findTabTextBoxSearchBar);
            this.tabFind.Controls.Add(this.lblSearchCriteria);
            this.tabFind.Location = new System.Drawing.Point(4, 29);
            this.tabFind.Name = "tabFind";
            this.tabFind.Padding = new System.Windows.Forms.Padding(3);
            this.tabFind.Size = new System.Drawing.Size(1089, 471);
            this.tabFind.TabIndex = 1;
            this.tabFind.Text = "Find";
            this.tabFind.UseVisualStyleBackColor = true;
            // 
            // listBoxFindView
            // 
            this.listBoxFindView.FormattingEnabled = true;
            this.listBoxFindView.ItemHeight = 20;
            this.listBoxFindView.Location = new System.Drawing.Point(26, 143);
            this.listBoxFindView.Name = "listBoxFindView";
            this.listBoxFindView.Size = new System.Drawing.Size(561, 304);
            this.listBoxFindView.TabIndex = 7;
            // 
            // btnLoadTable
            // 
            this.btnLoadTable.Location = new System.Drawing.Point(477, 103);
            this.btnLoadTable.Name = "btnLoadTable";
            this.btnLoadTable.Size = new System.Drawing.Size(94, 29);
            this.btnLoadTable.TabIndex = 4;
            this.btnLoadTable.Text = "Load table";
            this.btnLoadTable.UseVisualStyleBackColor = true;
            this.btnLoadTable.Click += new System.EventHandler(this.btnLoadTable_Click);
            // 
            // findTabComboBoxColumnName
            // 
            this.findTabComboBoxColumnName.FormattingEnabled = true;
            this.findTabComboBoxColumnName.Items.AddRange(new object[] {
            "Title",
            "Description",
            "Price range",
            "Fish type"});
            this.findTabComboBoxColumnName.Location = new System.Drawing.Point(265, 72);
            this.findTabComboBoxColumnName.Name = "findTabComboBoxColumnName";
            this.findTabComboBoxColumnName.Size = new System.Drawing.Size(182, 28);
            this.findTabComboBoxColumnName.TabIndex = 2;
            // 
            // findTabTextBoxSearchBar
            // 
            this.findTabTextBoxSearchBar.Location = new System.Drawing.Point(265, 105);
            this.findTabTextBoxSearchBar.Name = "findTabTextBoxSearchBar";
            this.findTabTextBoxSearchBar.Size = new System.Drawing.Size(182, 27);
            this.findTabTextBoxSearchBar.TabIndex = 1;
            // 
            // lblSearchCriteria
            // 
            this.lblSearchCriteria.AutoSize = true;
            this.lblSearchCriteria.Location = new System.Drawing.Point(142, 72);
            this.lblSearchCriteria.Name = "lblSearchCriteria";
            this.lblSearchCriteria.Size = new System.Drawing.Size(106, 20);
            this.lblSearchCriteria.TabIndex = 0;
            this.lblSearchCriteria.Text = "Search criteria:";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 519);
            this.Controls.Add(this.tabAddProduct);
            this.Name = "ManagerForm";
            this.Text = "FishShop - Product manager";
            this.tabAddProduct.ResumeLayout(false);
            this.tabAddPage.ResumeLayout(false);
            this.tabAddPage.PerformLayout();
            this.tabFind.ResumeLayout(false);
            this.tabFind.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAddProduct;
        private System.Windows.Forms.TabPage tabAddPage;
        private System.Windows.Forms.Label addTablblActionResult;
        private System.Windows.Forms.Label lblProdutType;
        private System.Windows.Forms.ComboBox addTabComboBoxProductType;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox AddTabTxtBoxDescription;
        private System.Windows.Forms.TextBox addTabTxtBoxProductTitle;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label addTablblAddProductTitle;
        private System.Windows.Forms.TabPage tabFind;
        private System.Windows.Forms.TextBox findTabTextBoxSearchBar;
        private System.Windows.Forms.Label lblSearchCriteria;
        private System.Windows.Forms.ComboBox findTabComboBoxColumnName;
        private System.Windows.Forms.Button btnLoadTable;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Label lblProductList;
        private System.Windows.Forms.ListBox listBoxProductList;
        private System.Windows.Forms.Button btnRefreshList;
        private System.Windows.Forms.ListBox listBoxFindView;
    }
}

