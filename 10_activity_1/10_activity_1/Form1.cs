using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_activity_1
{
    public partial class Form1 : Form
    {
        
        Administrator admin = new Administrator("yael", "admin01", "qwerty");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (admin.verifyLogin(txtUsername.Text, txtPassword.Text))
            {
                MessageBox.Show("Log In Successful");
            } else
            {
                MessageBox.Show("Log In Failed");
            }
        }

        private void btnUpdateAdminName_Click(object sender, EventArgs e)
        {
            admin.updateAdminName(txtUpdate.Text);
            MessageBox.Show("Update Successful");
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            admin.updatePassword(txtPassword.Text);
            MessageBox.Show("Password Updated");
        }
    }
}
