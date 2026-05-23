using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeNamespace
{
    public class employee
    {
        
        private int id;
        private string firstName;
        private string lastName;
        private string position;

        public int Id
        {
            get 
            {
                return id; 
            }
            set 
            {
                this.id = value; 
            }
        }

        public string FirstName
        {
            get 
            { 
                return firstName; 
            }
            set 
            { 
                this.firstName = value; 
            }

        }

        public string LastName
        {
            get 
            {
                return lastName; 
            }
            set 
            {
                this.lastName = value; 
            }
        }

        public string Position
        {
            get 
            {
                return position; 
            }
            set 
            {
                this.position = value; 
            }
        }

       
        public employee()
        {
            this.id = 0;
            this.firstName = "";
            this.lastName = "";
            this.position = "";
        }

        
        public employee(int id, string firstName, string lastName, string position)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.position = position;
        }
    }
}
