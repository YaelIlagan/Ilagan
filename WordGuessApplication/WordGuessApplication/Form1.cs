using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGuessApplication
{
    public partial class frmGuessWord : Form
    {
        public frmGuessWord()
        {
            InitializeComponent();
        }

        private void btnguess_Click(object sender, EventArgs e)
        {
            string answer = "computer";

            string txtgues = txtguess.Text;
            bool guesscontain = txtgues.Contains("computer");
            string guesses = txtguess.Text;


            if (guesscontain)
            {
                labelbox.Text = answer;
                MessageBox.Show("Correct Guess", "Guess Application");
            }else
            {
                MessageBox.Show("Wrong Guess \nTry again", "Guess Application");
                lboxwrong.Items.Add(guesses);
                
            }
            
            
        }
    }
}