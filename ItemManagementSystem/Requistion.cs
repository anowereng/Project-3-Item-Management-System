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
using ItemManagementSystem.Model.View;

namespace ItemManagementSystem
{
    public partial class Requistion : Form
    {
         RequistionManager aRequistionManager = new RequistionManager();
         DepartmentManager aDepartmentManager = new DepartmentManager();
        CategoryManager aCategoryManager=new CategoryManager();
        EmployeeManager aEmployeeManager=new EmployeeManager();
        public Requistion()
        {

            InitializeComponent();

            List<Department> aDepartmentsList = aDepartmentManager.GetDepartment();
            //departmentComboBox.Text = "--Select--";
            //departmentComboBox.DataSource = aDepartmentsList;
            //departmentComboBox.DisplayMember = "Name";
            //departmentComboBox.ValueMember = "Id";
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(reqSlTextBox.Text) || string.IsNullOrEmpty(reqByTextBox.Text) ||
                //string.IsNullOrEmpty(departmentComboBox.Text) || string.IsNullOrEmpty(employeeComboBox.Text) ||
                string.IsNullOrEmpty(reqDateTimePicker.Text) || string.IsNullOrEmpty(CatComboBox.Text) ||
                string.IsNullOrEmpty(quantityTextBox.Text) || string.IsNullOrEmpty(supplierTextBox.Text))
            {

                reqSlTextBox.Focus();
                reqByTextBox.Focus();
                MessageBox.Show("Fill Box", "Blank Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                RequistionModel aRequistionModel = new RequistionModel();
                aRequistionModel.SlNo = Convert.ToInt32(reqSlTextBox.Text);
                aRequistionModel.ReqBy = reqByTextBox.Text;
                //aRequistionModel.DepartmentId = Convert.ToInt32(departmentComboBox);
                aRequistionModel.EmployeeId = Convert.ToInt32(employeeComboBox);
                aRequistionModel.ReqDate = Convert.ToDateTime(reqDateTimePicker.Text);
                aRequistionModel.CategoryModel = reqDateTimePicker.Text;
                aRequistionModel.CategoryId = Convert.ToInt32(CatComboBox.Text);
                aRequistionModel.Quantity = Convert.ToInt32(quantityTextBox.Text);
                aRequistionModel.SupplierId = Convert.ToInt32(supplierTextBox.Text);
                ClearText();
                MessageBox.Show(aRequistionManager.SaveRequistion(aRequistionModel), "Save Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void GridViewLoad()
        {
            List<RequistionView> aRequistionList = aRequistionManager.GetRequistion();
            requistionGridView.DataSource = aRequistionList;

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        public void ClearText()
        {
            reqSlTextBox.Text = String.Empty;
            reqByTextBox.Text = String.Empty;
            //departmentComboBox.Text = string.Empty;
            employeeComboBox.Text = String.Empty;
            CatComboBox.Text = string.Empty;
            quantityTextBox.Text = string.Empty;
            supplierTextBox.Text = string.Empty;
        }

        private void departmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //employeeComboBox.Text = "--Select--";
            
            
        }

        public void hello()
        {
            int departmentId = 0;

            //bool a = Int32.TryParse(departmentComboBox.SelectedValue.ToString(), out departmentId);

            List<EmployeeModel> aEmployeeModel = aEmployeeManager.GetEmployeeById(departmentId);
            employeeComboBox.DataSource = aEmployeeModel;
            employeeComboBox.DisplayMember = "Name";
            employeeComboBox.ValueMember = "Id";
            List<CategoryModel> aCategoryModels = aCategoryManager.GetCategoryModel();
            CatComboBox.DataSource = aCategoryModels;
            CatComboBox.DisplayMember = "Name";
            CatComboBox.ValueMember = "Id";
        }

       
    }
}