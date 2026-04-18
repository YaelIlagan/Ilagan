using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentNamespace
{
    class StudentInfo
    {
        private string studid;
        private string fname;
        private string lname;

        public StudentInfo()
        {
        }

        public StudentInfo(string studid, string fname, string lname)
        {
            this.studid = studid;
            this.fname = fname;
            this.lname = lname;
        }

        public string StudID
        {
            get { return studid; }
            set { studid = value; }
        }

        public string FirstName
        {
            get { return fname; }
            set { fname = value; }
        }

        public string LastName
        {
            get { return lname; }
            set { lname = value; }
        }
    }
}
