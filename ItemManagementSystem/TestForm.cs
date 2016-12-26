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
    public partial class TestForm : Form
    {
        DepartmentManager aManager=new DepartmentManager();

        public TestForm()
        {
            
            InitializeComponent();
            List<Department> aDepartmentsList = aManager.GetDepartment();
            departmentComboBox.Text = "--Select--";
            departmentComboBox.DataSource = aDepartmentsList;
            departmentComboBox.DisplayMember = "Name";
            departmentComboBox.ValueMember = "Id";

        }

        private void submitButton_Click(object sender, EventArgs e)
        {

        }

        private void departmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int fid;
            bool a = Int32.TryParse(departmentComboBox.SelectedValue.ToString(), out fid);
            MessageBox.Show(fid.ToString());
        }
    }
}
