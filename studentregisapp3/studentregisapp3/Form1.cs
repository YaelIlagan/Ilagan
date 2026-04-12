using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentregisapp3
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            adddate();
            addprogram();
           

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "title";
                ofd.Filter = "Image Files(*jpg; *jpeg; *png)|*jpg; *jpeg; *png";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    
                    imgbox.BackgroundImage = new Bitmap(ofd.FileName);
                    imgbox.BackgroundImageLayout = ImageLayout.Stretch;
                }
               
            }


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
                daycbox.Items.Add(day);
            }

            monthcbox.Items.AddRange(new string[]
            {
                "January", "February" , "March" , "April" , "May" , "June" , "July" , "August" , "September" , "October" , "November" , "December"
            });

            int[] currentyear = new int[DateTime.Now.Year];
            for (int i = 1900; i < DateTime.Now.Year; i++)
            {
                currentyear[i] = i + 1;
                yearcbox.Items.Add(currentyear[i]);
            }



        }

        
       

        private void addprogram()
        {
            programcbox.Items.AddRange(new string[]
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

        private void regisbtn_Click_1(object sender, EventArgs e)
        {

            string fName = firsttxt.Text;
            string lName = lasttxt.Text;
            String mname = middletxt.Text;
            String name = (fName + " " + mname + " " + lName);
            string halfname = (fName + " " + lName);

            string gender = "";
                if (malerdbtn.Checked)
                {
                    gender = "Male";
                }
                else if (femalerdbtn.Checked)
                {
                    gender = "Female";
                }
                else
                {
                    gender = "Not selected";
                }

                string d = daycbox.Text;
                string m = monthcbox.Text;
                string y = yearcbox.Text;
                string program = programcbox.Text;

                String date = (d + "/" + m + "/" + y);

            displayinfo(name ,gender, date, program);
            displayinfo(name, program);
            displayinfo(halfname,  program);



        }

       
        public void displayinfo(String name, string gender, string date, String program)
        {
            MessageBox.Show("Student Information" + "\nName: " + name + "\nGender: " + gender + "\nBirthdate: " + date + "\nProgram: " + program, "Student Register Application");
        }
        public void displayinfo(String name, String program)
        {
            MessageBox.Show("Student Information" + "\nName: " + name + program, "Student Register Application");
        }

        public void displayinfo(String halfname, string gender, String program)
        {
            MessageBox.Show("Student Information" + "\nName: " + halfname + program + "\nGender: " + gender, "Student Register Application" );
        }

    }
}
