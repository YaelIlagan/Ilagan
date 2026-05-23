using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserAccountNamespace;

namespace CashierApp
{
    public partial class LoginAccount : Form
    {
        private Cashier cashier = new Cashier("Raphael Ilagan", "Finance", "cashier101", "qwerty");

        public LoginAccount()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string uName = txtUsername.Text;
            string password = txtPassword.Text;

            if (cashier.validateLogin(uName, password))
            {
                MessageBox.Show("Welcome " + cashier.getFullName() + " of " + cashier.getDepartment());


                Form1 frmPurchase = new Form1();
                this.Hide();
                frmPurchase.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.",
                                "Login Failed");
            }
        }
    }
}