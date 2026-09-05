using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmRegistration
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();

            cbProgram.Items.Add("BS in Computer Science");
            cbProgram.Items.Add("BS in Information Technology");
            cbProgram.Items.Add("BS in Information Systems");

        }

        

        private void btnNext_Click(object sender, EventArgs e)
        {
            StudentInfoClass.StudentNo = Convert.ToInt64(txtStudentNo.Text);
            StudentInfoClass.Program = cbProgram.Text;
            StudentInfoClass.LastName = txtLastName.Text;
            StudentInfoClass.FirstName = txtFirstName.Text;
            StudentInfoClass.MiddleName = txtMiddleName.Text;
            StudentInfoClass.Age = Convert.ToInt64(txtAge.Text);
            StudentInfoClass.ContactNo = Convert.ToInt64(txtContactNo.Text);
            StudentInfoClass.Address = txtAddress.Text;

            FrmConfirm frmConfirm = new FrmConfirm();
            DialogResult result = frmConfirm.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtStudentNo.Text = "";
                cbProgram.Text = "";
                txtLastName.Text = "";
                txtFirstName.Text = "";
                txtMiddleName.Text = "";
                txtAge.Text = "";
                txtContactNo.Text = "";
                txtAddress.Text = "";
            }
        }
    }
}
