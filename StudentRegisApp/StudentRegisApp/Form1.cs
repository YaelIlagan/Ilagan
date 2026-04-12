using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegisApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            adddate();
            addprogram();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void adddate()
        {
            int[] days = new int[31];
            for (int i = 0; i < 31; i++)
            {
                days[i] = i + 1;
            }

            foreach (int day in days)
            {
                cboxday.Items.Add(day);
            }

            cboxmonth.Items.AddRange(new string[]
            {
                "January", "February" , "March" , "April" , "May" , "June" , "July" , "August" , "September" , "October" , "November" , "December"
            });

            int[] currentyear = new int[DateTime.Now.Year];
            for (int i = 1900; i < DateTime.Now.Year; i++)
            {
                currentyear[i] = i + 1;
                cboxyear.Items.Add(currentyear[i]);
            }
            

            
        }

        private void addprogram()
        {
            cboxprogram.Items.AddRange(new string[]
            {
                "Bachelor of Science in Computer Science", "Bachelor of Science in Information Technology", "Bachelor of Science in Information Systems",
                "Bachelor of Science in Computer Engineering"
            });
        }


        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string fName = txtfirstname.Text;
            string lName = txtlastname.Text;
            String mname = txtmiddlename.Text;
            String fullname = (fName + " " + mname + " " + lName);
            

            string gender = "";
            if (rbtnmale.Checked)
            {
                gender = "Male";
            }
            else if (rbtnfemale.Checked)
            {
                gender = "Female";
            }
            else
            {
                gender = "Not selected";
            }

            string d = cboxday.Text;
            string m = cboxmonth.Text;
            string y = cboxyear.Text;
            string program = cboxprogram.Text;

            String date = (d + "/" + m + "/" + y);

            MessageBox.Show("Student Information" + "\nName: " + fullname + "\nGender: " + gender + "\nBirthdate: " + date  + "\nProgram: " + program , "Student Register Application");



        }
    }
}
