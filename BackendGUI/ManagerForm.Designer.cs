
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.lblProductList = new System.Windows.Forms.Label();
            this.listBoxProductList = new System.Windows.Forms.ListBox();
            this.lblActionResult = new System.Windows.Forms.Label();
            this.lblProdutType = new System.Windows.Forms.Label();
            this.comboBoxProductType = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtBoxDescription = new System.Windows.Forms.TextBox();
            this.txtBoxProductTitle = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.lblAddProductTitle = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoadTable = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.comboBoxSearchCriteria = new System.Windows.Forms.ComboBox();
            this.textBoxSearchBar = new System.Windows.Forms.TextBox();
            this.lblSearchCriteria = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.tabAddProduct.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabAddProduct
            // 
            this.tabAddProduct.Controls.Add(this.tabPage1);
            this.tabAddProduct.Controls.Add(this.tabPage2);
            this.tabAddProduct.Location = new System.Drawing.Point(0, 3);
            this.tabAddProduct.Name = "tabAddProduct";
            this.tabAddProduct.SelectedIndex = 0;
            this.tabAddProduct.Size = new System.Drawing.Size(730, 504);
            this.tabAddProduct.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnRefreshList);
            this.tabPage1.Controls.Add(this.lblProductList);
            this.tabPage1.Controls.Add(this.listBoxProductList);
            this.tabPage1.Controls.Add(this.lblActionResult);
            this.tabPage1.Controls.Add(this.lblProdutType);
            this.tabPage1.Controls.Add(this.comboBoxProductType);
            this.tabPage1.Controls.Add(this.lblDescription);
            this.tabPage1.Controls.Add(this.lblProductName);
            this.tabPage1.Controls.Add(this.txtBoxDescription);
            this.tabPage1.Controls.Add(this.txtBoxProductTitle);
            this.tabPage1.Controls.Add(this.btnAddProduct);
            this.tabPage1.Controls.Add(this.lblAddProductTitle);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(722, 471);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Location = new System.Drawing.Point(486, 428);
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
            this.lblProductList.Location = new System.Drawing.Point(457, 34);
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
            this.listBoxProductList.Size = new System.Drawing.Size(286, 304);
            this.listBoxProductList.TabIndex = 18;
            // 
            // lblActionResult
            // 
            this.lblActionResult.AutoSize = true;
            this.lblActionResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblActionResult.Location = new System.Drawing.Point(228, 184);
            this.lblActionResult.Name = "lblActionResult";
            this.lblActionResult.Size = new System.Drawing.Size(0, 28);
            this.lblActionResult.TabIndex = 17;
            this.lblActionResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.comboBoxProductType.Location = new System.Drawing.Point(166, 238);
            this.comboBoxProductType.Name = "comboBoxProductType";
            this.comboBoxProductType.Size = new System.Drawing.Size(151, 28);
            this.comboBoxProductType.TabIndex = 15;
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
            // txtBoxDescription
            // 
            this.txtBoxDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtBoxDescription.Location = new System.Drawing.Point(166, 178);
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.Size = new System.Drawing.Size(151, 27);
            this.txtBoxDescription.TabIndex = 12;
            // 
            // txtBoxProductTitle
            // 
            this.txtBoxProductTitle.Location = new System.Drawing.Point(166, 115);
            this.txtBoxProductTitle.Name = "txtBoxProductTitle";
            this.txtBoxProductTitle.Size = new System.Drawing.Size(151, 27);
            this.txtBoxProductTitle.TabIndex = 11;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(128, 337);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(94, 29);
            this.btnAddProduct.TabIndex = 10;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // lblAddProductTitle
            // 
            this.lblAddProductTitle.AutoSize = true;
            this.lblAddProductTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddProductTitle.Location = new System.Drawing.Point(97, 34);
            this.lblAddProductTitle.Name = "lblAddProductTitle";
            this.lblAddProductTitle.Size = new System.Drawing.Size(159, 32);
            this.lblAddProductTitle.TabIndex = 9;
            this.lblAddProductTitle.Text = "Add Product";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnLoadTable);
            this.tabPage2.Controls.Add(this.dataGridView);
            this.tabPage2.Controls.Add(this.comboBoxSearchCriteria);
            this.tabPage2.Controls.Add(this.textBoxSearchBar);
            this.tabPage2.Controls.Add(this.lblSearchCriteria);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(722, 471);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Find";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(204, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Disfunctional / Stuck at populating the table.";
            // 
            // btnLoadTable
            // 
            this.btnLoadTable.Location = new System.Drawing.Point(477, 103);
            this.btnLoadTable.Name = "btnLoadTable";
            this.btnLoadTable.Size = new System.Drawing.Size(94, 29);
            this.btnLoadTable.TabIndex = 4;
            this.btnLoadTable.Text = "Load table";
            this.btnLoadTable.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(42, 152);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(646, 293);
            this.dataGridView.TabIndex = 3;
            // 
            // comboBoxSearchCriteria
            // 
            this.comboBoxSearchCriteria.FormattingEnabled = true;
            this.comboBoxSearchCriteria.Items.AddRange(new object[] {
            "Title",
            "Description",
            "Price range",
            "Fish type"});
            this.comboBoxSearchCriteria.Location = new System.Drawing.Point(265, 72);
            this.comboBoxSearchCriteria.Name = "comboBoxSearchCriteria";
            this.comboBoxSearchCriteria.Size = new System.Drawing.Size(182, 28);
            this.comboBoxSearchCriteria.TabIndex = 2;
            // 
            // textBoxSearchBar
            // 
            this.textBoxSearchBar.Location = new System.Drawing.Point(265, 105);
            this.textBoxSearchBar.Name = "textBoxSearchBar";
            this.textBoxSearchBar.Size = new System.Drawing.Size(182, 27);
            this.textBoxSearchBar.TabIndex = 1;
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
            this.ClientSize = new System.Drawing.Size(726, 506);
            this.Controls.Add(this.tabAddProduct);
            this.Name = "ManagerForm";
            this.Text = "FishShop - Product manager";
            this.tabAddProduct.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAddProduct;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblActionResult;
        private System.Windows.Forms.Label lblProdutType;
        private System.Windows.Forms.ComboBox comboBoxProductType;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtBoxDescription;
        private System.Windows.Forms.TextBox txtBoxProductTitle;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label lblAddProductTitle;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxSearchBar;
        private System.Windows.Forms.Label lblSearchCriteria;
        private System.Windows.Forms.ComboBox comboBoxSearchCriteria;
        private System.Windows.Forms.Button btnLoadTable;
        private System.Windows.Forms.DataGridView dataGridView;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProductList;
        private System.Windows.Forms.ListBox listBoxProductList;
        private System.Windows.Forms.Button btnRefreshList;
    }
}

