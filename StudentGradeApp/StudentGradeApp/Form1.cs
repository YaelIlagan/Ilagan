using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void genbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtname.Text))
            {
                MessageBox.Show("Please enter a name");
                
                return;
            }

            double english = Convert.ToDouble(txtenglish.Text);
            double math = Convert.ToDouble(txtmath.Text);
            double science = Convert.ToDouble(txtscience.Text);
            double filipino = Convert.ToDouble(txtfil.Text);
            double history = Convert.ToDouble(txthistory.Text);

            double average = (english + math + science + filipino + history) / 5;

            string result = average >= 75 ? "passed" : "failed";

            Gradeprompt.Text = "The student " + result;
            Gradepromtbl.Text = "The general average of " + txtname.Text + " is " + average;



        }
    }
}
