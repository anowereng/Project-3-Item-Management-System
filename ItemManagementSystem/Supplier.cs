using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ItemManagementSystem.BLL;
using ItemManagementSystem.Model;

namespace ItemManagementSystem
{
    public partial class Supplier : Form
    {
        SupplierManager aManager=new SupplierManager();
        public Supplier()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            SupplierModel aSupplierModel=new SupplierModel();
            aSupplierModel.Name = nameTextBox.Text;
            aSupplierModel.Comapany = companyTextBox.Text;
            aSupplierModel.Contact = contactTextBox.Text;
            aSupplierModel.Address = addressTextBox.Text;
            aSupplierModel.Email = emailTextBox.Text;
            MessageBox.Show(aManager.SupplierSave(aSupplierModel),"Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            nameTextBox.Text=String.Empty;
            companyTextBox.Text=String.Empty;
            contactTextBox.Text=String.Empty;
            addressTextBox.Text=String.Empty;
            emailTextBox.Text=String.Empty;

        }
    }
}
