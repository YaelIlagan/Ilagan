using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LibraryCatalog.Models
{
    public class Book
    {
       
        private string lsbn;
        private string title;
        private string author;
        private int year;
        private int copies;

      
        public string ISBN 
        { get 
            { 
                return lsbn; 
            } set 
            { 
                lsbn = value; 
            } 
        }
        public string Title 
        { get 
            { 
                return title; 
            } set 
            { 
                title = value; 
            } 
        }
        public string Author 
        { get 
            { 
                return author; 
            } set 
            { 
                author = value; 
            } 
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value < 1450 || value > DateTime.Now.Year)
                    year = 1450;
                else
                    year = value;
            }
        }

        public int Copies
        {
            get { return copies; }
            set
            {
                if (value < 0)
                    copies = 0;
                else
                    copies = value;
            }
        }

        
        public Book()
        {
            ISBN = "000-00000";
            Title = "Untitled";
            Author = "Unknown";
            Year = 1450;
            Copies = 0;
        }

        
        public Book(string isbn, string title, string author)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            Year = 1450;
            Copies = 0;
        }

       
        public Book(string isbn, string title, string author, int year, int copies)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            Year = year;
            Copies = copies;
        }

       
        public string GetDetails()
        {
            return "ISBN: " + ISBN + "\r\n" +
           "Title: " + Title + "\r\n" +
           "Author: " + Author + "\r\n" +
           "Year: " + Year + "\r\n" +
           "Copies Available: " + Copies;
        }

        
        public bool BorrowCopy()
        {
            if (Copies > 0)
            {
                Copies--;
                return true;
            }
            return false;
        }

       
        public bool ReturnCopy()
        {
            Copies++;
            return true;
        }
    }
}
