using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentNamespace;

namespace StudentInfoApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            StudentInfo student = new StudentInfo(
                txtstudid.Text,
                txtfname.Text,
                txtlname.Text
            );

            lboxstudid.Items.Add(student.StudID);
            lboxfname.Items.Add(student.FirstName);
            lboxlname.Items.Add(student.LastName);

            txtstudid.Clear();
            txtfname.Clear();
            txtlname.Clear();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            lboxstudid.Items.Clear();
            lboxfname.Items.Clear();
            lboxlname.Items.Clear();

            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
