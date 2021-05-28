using DataLayer.Helpers;
using System;
using System.Windows.Forms;
using DataLayer.Entity;
using System.Collections.Generic;
using System.Linq;

namespace BackandGUI
{
    public partial class ManagerForm : Form
    {
        private DataAccess _db;
        private IEnumerable<object> _productList = Enumerable.Empty<object>();
        public ManagerForm()
        {
            InitializeComponent();
            LoadProductList();
        }

        public void LoadProductList()
        {
            _db = new DataAccess();
            _productList = _db.GetProductList();
            WireUpProductList();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                _db = new DataAccess();
                _db.InsertProduct(addTabTxtBoxProductTitle.Text, AddTabTxtBoxDescription.Text, (Product.EProductType)addTabComboBoxProductType.SelectedIndex);
                addTabTxtBoxProductTitle.Text = "";
                AddTabTxtBoxDescription.Text = "";
                lblActionResult_TextChanged_ResponseTo_IsProductAdded(true);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
                lblActionResult_TextChanged_ResponseTo_IsProductAdded(false);
            }
        }

        private void lblActionResult_TextChanged_ResponseTo_IsProductAdded(bool result)
        {
            if (result)
            {
                addTablblActionResult.ForeColor = System.Drawing.Color.Green;
                addTablblActionResult.Text = "Item added to database.";
            }
            else
            {
                addTablblActionResult.ForeColor = System.Drawing.Color.Red;
                addTablblActionResult.Text = "Something went wrong. No items inserted.";
            }
        }

        private void WireUpProductList()
        {
            listBoxProductList.DataSource = null;
            listBoxProductList.DataSource = _productList;
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            LoadProductList();
        }

        private void btnLoadTable_Click(object sender, EventArgs e)
        {
            _db = new DataAccess();
            _productList = _db.GetProductListWithSearchCriteria(findTabComboBoxColumnName.Text, findTabTextBoxSearchBar.Text).ToList();
            findTabComboBoxColumnName.Text = "";
            findTabTextBoxSearchBar.Text = "";
        }


    }
}
