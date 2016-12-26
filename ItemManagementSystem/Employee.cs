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
using ItemManagementSystem.DAL;
using ItemManagementSystem.Model;
using ItemManagementSystem.Model.View;

namespace ItemManagementSystem
{
    public partial class Employee : Form
    {
        DepartmentManager aDepartmentManager=new DepartmentManager();
        EmployeeManager aEmployeeManager=new EmployeeManager();
        DesignationManager aGeDesignationManager = new DesignationManager();
        public Employee()
        {
            InitializeComponent();
            List<Department> aDepartments = aDepartmentManager.GetDepartment();
            departmentComboBox.DataSource = aDepartments;
            departmentComboBox.DisplayMember = "Name";
            departmentComboBox.ValueMember = "Id";
            List<Designation> aDesignation = aGeDesignationManager.GetDesignation();
            designationComboBox.DataSource = aDesignation;
            designationComboBox.DisplayMember = "Name";
            designationComboBox.ValueMember = "Id";
           
            EmployeeGridView();
            employeeDataGridView.Columns[0].Visible = false;
        }

        public void ClearTextBox()
        {
            empNameTextBox.Text = string.Empty;
            departmentComboBox.Text = string.Empty;
            designationComboBox.Text = string.Empty;
            emailTextBox.Text = String.Empty;
            passwordTextBox.Text = String.Empty;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            EmployeeModel aModel=new EmployeeModel();
            aModel.Name = empNameTextBox.Text;
            aModel.DepartmentId = Convert.ToInt32(departmentComboBox.SelectedValue);
            aModel.Email = emailTextBox.Text;
            aModel.DesignationId = Convert.ToInt32(designationComboBox.SelectedValue);
            aModel.Password = passwordTextBox.Text;          
            MessageBox.Show(aEmployeeManager.SaveEmployee(aModel),"Save Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearTextBox();
            EmployeeGridView();
        }

        public void EmployeeGridView()
        {
            List<EmployeeView> aListEmployeeModels = aEmployeeManager.GetEmployee();
            employeeDataGridView.DataSource = aListEmployeeModels;
        }

        private void employeeDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            msgLabel.Text=employeeDataGridView.SelectedRows[0].Cells[0].Value.ToString();
           
            empNameTextBox.Text=employeeDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            departmentComboBox.Text=employeeDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            designationComboBox.Text = employeeDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            emailTextBox.Text=employeeDataGridView.SelectedRows[0].Cells[4].Value.ToString();  
            passwordTextBox.Text=employeeDataGridView.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            EmployeeModel aEmployeeModel=new EmployeeModel();
            aEmployeeModel.Id = Convert.ToInt32(msgLabel.Text);
            aEmployeeModel.Name = empNameTextBox.Text;
            aEmployeeModel.DepartmentId = Convert.ToInt32(departmentComboBox.SelectedValue);
            aEmployeeModel.DesignationId = Convert.ToInt32(designationComboBox.SelectedValue);
            aEmployeeModel.Email = emailTextBox.Text;
            aEmployeeModel.Password = passwordTextBox.Text;
            MessageBox.Show(aEmployeeManager.UpdateEmployee(aEmployeeModel),"Update Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            ClearTextBox();
            EmployeeGridView();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            EmployeeModel aEmployeeModel = new EmployeeModel();
            aEmployeeModel.Id = Convert.ToInt32(msgLabel.Text);
            aEmployeeModel.Name = empNameTextBox.Text;
            aEmployeeModel.DepartmentId = Convert.ToInt32(departmentComboBox.SelectedValue);
            aEmployeeModel.DesignationId = Convert.ToInt32(designationComboBox.SelectedValue);
            aEmployeeModel.Email = emailTextBox.Text;
            aEmployeeModel.Password = passwordTextBox.Text;
            MessageBox.Show(aEmployeeManager.DeleteEmployee(aEmployeeModel),"Update Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            ClearTextBox();
            EmployeeGridView();
        }
    }
}
