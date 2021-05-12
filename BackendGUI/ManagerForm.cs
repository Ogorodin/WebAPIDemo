using DataLayer.Helpers;
using System;
using System.Windows.Forms;
using DataLayer.Entity;
using System.Data;

namespace BackandGUI
{
    public partial class ManagerForm : Form
    {
        private DataAccess _db;
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                _db = new DataAccess();
                _db.InsertProduct(txtBoxProductTitle.Text, txtBoxDescription.Text, (Product.EProductType)comboBoxProductType.SelectedIndex);
                txtBoxProductTitle.Text = "";
                txtBoxDescription.Text = "";
                lblActionResult_TextChanged_ResponseTo_IsProductAdded(true);
            }
            catch (Exception)
            {
                lblActionResult_TextChanged_ResponseTo_IsProductAdded(false);
            }
        }

        private void lblActionResult_TextChanged_ResponseTo_IsProductAdded(bool result)
        {
            if (result)
            {
                lblActionResult.ForeColor = System.Drawing.Color.Green;
                lblActionResult.Text = "Item added to database.";
            }
            else
            {
                lblActionResult.ForeColor = System.Drawing.Color.Red;
                lblActionResult.Text = "Something went wrong. No items inserted.";
            }
        }
    }
}
