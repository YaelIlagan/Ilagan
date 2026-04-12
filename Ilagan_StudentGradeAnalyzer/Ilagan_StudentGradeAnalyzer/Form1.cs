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

namespace Ilagan_StudentGradeAnalyzer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public struct Student
        {
            public string number;
            public string name;
            public double prelim;
            public double midterm;
            public double finals;
            public double average;
            public string remarks;
        }

        double ComputeAverage(double prelim, double midterm, double final)
        {
            return (prelim + midterm + final )/3;
        }

        double ComputeAverage(double prelim, double midterm)
        {
            return (prelim + midterm)/2;
        }

        static string Remarks(double avg)
        {
            if (avg >= 75)  
                return "PASSED";
            else 
                return "FAILED";
        }
        private void btncompute_Click(object sender, EventArgs e)
        {
            Student stud = new Student();
            double avg;

            stud.number = txtstudentnum.Text;
            stud.name = txtstudentname.Text;
            
            stud.prelim = Convert.ToDouble(txtprelim.Text);
            stud.midterm = Convert.ToDouble(txtmidterm.Text);
            stud.finals = Convert.ToDouble(txtfinal.Text);

            if (txtfinal.Text == "")
                avg = ComputeAverage(stud.prelim, stud.midterm); 
            else
                avg = ComputeAverage(stud.prelim, stud.midterm, stud.finals);

            stud.average = avg;
            stud.remarks = Remarks(stud.average);
            DisplayStudent(stud);
        }
        void DisplayStudent(Student stud)
        {
            lboxshowgrade.Items.Clear();

            lboxshowgrade.Items.Add("ID: " + stud.number);
            lboxshowgrade.Items.Add("Name: " + stud.name);
            lboxshowgrade.Items.Add("Prelim: " + stud.prelim);
            lboxshowgrade.Items.Add("Midterm: " + stud.midterm);
            lboxshowgrade.Items.Add("Final: " + stud.finals);
            lboxshowgrade.Items.Add("Average: " + stud.average + " ( " + stud.remarks + " )" );
            
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            txtstudentnum.Clear();
            txtstudentname.Clear();
            txtprelim.Clear();
            txtmidterm.Clear();
            txtfinal.Clear();
            lboxshowgrade.Items.Clear();
            txtstudentnum.Focus();
        }
    }

    
}
