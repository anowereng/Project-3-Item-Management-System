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
    public partial class Category : Form
    {
        CategoryManager aCategoryManager=new CategoryManager();
        public Category()
        {
            InitializeComponent();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text==string.Empty)
            {
                MessageBox.Show("Must Filled Box", "Empty Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CategoryModel aCategory = new CategoryModel();
                aCategory.Name = nameTextBox.Text;
                aCategory.Status = statusRichTextBox.Text;
                nameTextBox.Text = string.Empty;
                MessageBox.Show(aCategoryManager.SaveCategory(aCategory), "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
