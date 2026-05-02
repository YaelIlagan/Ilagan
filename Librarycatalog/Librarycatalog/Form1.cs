using LibraryCatalog.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Librarycatalog
{
    public partial class Form1 : Form
    {
        private List<Book> books = new List<Book>();
        public Form1()
        {
            InitializeComponent();
            books.Add(new Book());  
            RefreshList();
        }

        private void RefreshList()
        {
            lboxcatalog.Items.Clear();
            foreach (Book b in books)
                lboxcatalog.Items.Add(b.Title + " — " + b.ISBN);
        }

      
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string isbn = txtLSBN.Text.Trim();
            string title = txtTitle.Text.Trim();
            string author = txtAuthor.Text.Trim();
            string yearText = txtYear.Text.Trim();
            string copiesText = txtCopies.Text.Trim();

            if (isbn == "" || title == "" || author == "")
            {
                MessageBox.Show("ISBN, Title, and Author are required.");
                return;
            }

            if (yearText == "" && copiesText == "")
            {
                books.Add(new Book(isbn, title, author));
            }
            else
            {
                int year, copies;
                if (!int.TryParse(yearText, out year) || !int.TryParse(copiesText, out copies))
                {
                    MessageBox.Show("Year and Copies must be valid numbers.");
                    return;
                }
                books.Add(new Book(isbn, title, author, year, copies));
            }

            RefreshList();
            btnClear_Click(sender, e);
        }

       
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLSBN.Text = "";
            txtTitle.Text = "";
            txtAuthor.Text = "";
            txtYear.Text = "";
            txtCopies.Text = "";
            txtdetails.Text = "";
            txtLSBN.Focus();
        }

    
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lboxcatalog.SelectedIndex == -1) return;
            books.RemoveAt(lboxcatalog.SelectedIndex);
            RefreshList();
            txtdetails.Text = "";
        }

   
        private void lstBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxcatalog.SelectedIndex == -1) return;
            txtdetails.Text = books[lboxcatalog.SelectedIndex].GetDetails();
        }


        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (lboxcatalog.SelectedIndex == -1) return;
            bool success = books[lboxcatalog.SelectedIndex].BorrowCopy();
            if (!success)
                MessageBox.Show("No copies available.");
            txtdetails.Text = books[lboxcatalog.SelectedIndex].GetDetails();
        }

        
        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (lboxcatalog.SelectedIndex == -1) return;
            books[lboxcatalog.SelectedIndex].ReturnCopy();
            txtdetails.Text = books[lboxcatalog.SelectedIndex].GetDetails();
        }
    }
}
