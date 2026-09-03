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
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }

        private void btnComputeSalary_Click(object sender, EventArgs e)
        {
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;
            string department = txtDepartment.Text;
            string job = txtJobTitle.Text;  

            if(!double.TryParse(txtRatePerHour.Text, out double ratePerHour) || !int.TryParse(txtTotalHoursWorked.Text, out int hours))
            {
                MessageBox.Show("Please Enter a numeric value for Rate Per Hour and Total Hours Worked");
                return;
            }

            PartTimeEmployee emp = new PartTimeEmployee(fname, lname, department, job);
            emp.computeSalary(hours, ratePerHour);

            lblFirstName.Text = emp.FirstName;
            lblLastName.Text = emp.LastName;
            lblSalary.Text = emp.BasicSalary.ToString("F2");

        }
    }
}
