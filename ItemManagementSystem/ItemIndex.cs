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
    public partial class ItemIndex : Form
    {
       
        public ItemIndex()
        {
            InitializeComponent();
            

        }

        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Category aCategory=new Category();
            aCategory.Show();
        }

        private void addRequistionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Requistion aRequistion=new Requistion();
            aRequistion.Show();
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee aEmployee=new Employee();
            aEmployee.Show();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supplier aSupplier=new Supplier();
            aSupplier.Show();
        }

       
    }
}
