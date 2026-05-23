using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeNamespace;

namespace EmployeeApplication
{
    public partial class frmEmployeeApplication : Form
    {
        private List<employee> employeeList = new List<employee>();
        public frmEmployeeApplication()
        {
            InitializeComponent();
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            dvgemployeelist.Columns.Clear();
            dvgemployeelist.Columns.Add("colId", "ID");
            dvgemployeelist.Columns.Add("colFirstName", "First Name");
            dvgemployeelist.Columns.Add("colLastName", "Last Name");
            dvgemployeelist.Columns.Add("colPosition", "Postition");

            dvgemployeelist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void RefreshGrid()
        {
            dvgemployeelist.Rows.Clear();
            foreach (employee emp in employeeList)
            {
                dvgemployeelist.Rows.Add(emp.Id, emp.FirstName, emp.LastName, emp.Position);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtemployeeid.Text) ||
                string.IsNullOrWhiteSpace(txtfname.Text) ||
                string.IsNullOrWhiteSpace(txtlname.Text) ||
                string.IsNullOrWhiteSpace(txtposition.Text))
            {
                MessageBox.Show("Fill all fields", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            int empId;
            if (!int.TryParse(txtemployeeid.Text, out empId))
            {
                MessageBox.Show("Employee ID should be a number", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            
            employee newEmployee = new employee(
                empId,
                txtfname.Text,
                txtlname.Text,
                txtposition.Text
            );

            employeeList.Add(newEmployee);
            RefreshGrid();
            ClearFields();

            MessageBox.Show("Added successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearFields()
        {
            txtemployeeid.Clear();
            txtfname.Clear();
            txtlname.Clear();
            txtposition.Clear();
            txtemployeeid.Focus();
        }
    }
}
