using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentsRegistrationApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            adddate();

        }

        private void adddate()
        {

            for (int d = 1; d <= 31; d++)
            {
                day.Items.Add(d);
            }
            for (int m = 1; m <= 12; m++)
            {
                month.Items.Add(m);
            }
            int currentYear = DateTime.Now.Year;
            for (int y = 1900; y <= currentYear; y++)
            {
                year.Items.Add(y);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string fName = firstname.Text;
            string lName = lastname.Text;
            String mname = middlein.Text;
            String fullname = (fName + " " + mname + " " + lName);

            string gender = "";
            if (male.Checked)
            {
                gender = "Male";
            }
            else if (female.Checked)
            {
                gender = "Female";
            }
            else
            {
                gender = "Not selected";
            }

            
            string d = day.Text;
            string m = month.Text;
            string y = year.Text;

            String date = (y + "/" + m + "/" + d);

            MessageBox.Show("Student Information" + "\nName: " + fullname + "\nGender: " + gender + "\nBirthdate: " + date, "Output");


        }

        private void textBox1_TextChanged(object sender, EventArgs e){}
        private void label6_Click(object sender, EventArgs e){}
        private void label3_Click(object sender, EventArgs e){}
        private void label4_Click(object sender, EventArgs e){}
        private void radioButton1_CheckedChanged(object sender, EventArgs e){}
        private void label5_Click(object sender, EventArgs e){}
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e){}
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e){}
        private void year_SelectedIndexChanged(object sender, EventArgs e){}


       
    }
    }

