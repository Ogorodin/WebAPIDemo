using DataLayer.Helpers;
using System;
using System.Windows.Forms;
using DataLayer.Entity;

namespace BackandGUI
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.InsertProduct(txtBoxProductTitle.Text, txtBoxDescription.Text, (Product.EProductType)comboBoxProductType.SelectedIndex);
            txtBoxProductTitle.Text = "";
            txtBoxDescription.Text = "";


        }
    }
}
