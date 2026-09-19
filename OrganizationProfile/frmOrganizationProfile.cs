using System.Text.RegularExpressions;

namespace OrganizationProfile
{
    public partial class Form1 : Form
    {
        private string _FullName;
        private int _Age;
        private long _ContactNo;
        private long _StudentNo;

        public Form1()
        {
            InitializeComponent();

            cbGenders.Items.Add("Male");
            cbGenders.Items.Add("Female");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] listOfProgram = new string[]
            {

            "BS Information Technology",
            "BS Computer Science",
            "BS Information Systems",
            "BS in Accountancy",
            "BS in Hospitality Management",
            "BS in Tourism Management"

            };

            for (int i = 0; i < 6; i++)
            {
                cbPrograms.Items.Add(listOfProgram[i].ToString());
            }

        }



        public long StudentNumber(string studNum)
        {

            if (Regex.IsMatch(studNum, @"^[0-9]{1,20}$"))
            {
                _StudentNo = long.Parse(studNum);
            }
            else
            {
                throw new OverflowException("Student No. should have numbers only");
            }
            return _StudentNo;
        }

        public long ContactNo(string Contact)
        {
            if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
            {
                _ContactNo = long.Parse(Contact);
            }
            else
            {
                throw new FormatException("Contact No. should be 10-11 digits");
            }
            return _ContactNo;
        }

        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            if (Regex.IsMatch(LastName, @"^[a-zA-Z]+(\s[a-zA-Z]+)*$") && Regex.IsMatch(FirstName, @"^[a-zA-Z]+(\s[a-zA-Z]+)*$") &&
                Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
            {
                _FullName = LastName + ", " + FirstName + " " + MiddleInitial + ".";
            }
            else
            {
                throw new ArgumentNullException("Please enter a valid name");
            }
            return _FullName;
        }

        public int Age(string age)
        {
            if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
            {
                _Age = Int32.Parse(age);
            }
            else
            {
                throw new IndexOutOfRangeException("Enter a valid age");
            }
            return _Age;
        }

        public string Gender(string gender)
        {
            if (!string.IsNullOrWhiteSpace(gender))
            {
                return gender;
            }
            else
            {
                throw new ArgumentNullException("Select a gender first");
            }
        }

        public string Program(string program)
        {
            if (!string.IsNullOrWhiteSpace(program))
            {
                return program;
            }
            else
            {
                throw new ArgumentNullException("Program", "Please select a program first.");
            }
        }

        private void ClearRegistrationFields()
        {
            txtStudentNo.Clear();
            txtLastName.Clear();
            txtFirstName.Clear();
            txtMiddleInitial.Clear();
            txtAge.Clear();
            txtContactNo.Clear();
            cbPrograms.SelectedIndex = -1;
            cbGenders.SelectedIndex = -1;
            datePickerBirthday.Value = DateTime.Now;
        }



        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {

                StudentInformationClass.SetFullName = FullName(txtLastName.Text, txtFirstName.Text, txtMiddleInitial.Text);
                StudentInformationClass.SetStudentNo = StudentNumber(txtStudentNo.Text);
                StudentInformationClass.SetProgram = Program(cbPrograms.Text);
                StudentInformationClass.SetGender = Gender(cbGenders.Text);
                StudentInformationClass.SetContactNo = ContactNo(txtContactNo.Text);
                StudentInformationClass.SetAge = Age(txtAge.Text);
                StudentInformationClass.SetBirthday = datePickerBirthday.Value.ToString("yyyy-MM-dd");

                frmConfirmation frm = new frmConfirmation();
                frm.ShowDialog();

                ClearRegistrationFields();

            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Contact No.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Student No.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("Registration Attempt Completed");
            }

        }




    }
}

