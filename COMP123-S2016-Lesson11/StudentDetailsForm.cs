using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_Lesson11
{
    public partial class StudentDetailsForm : Form
    {
        // Public Properties
        public StudentListForm studentListForm { get; set; } // references previous form
        public int FormType { get; set; } // what type of form do I need?
        public int StudentID { get; set; } // what is the studentID of the row that is clicked?

        public StudentDetailsForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // creates a reference to the SQL Database
            StudentDataContext db = new StudentDataContext();

            Student newStudent = new Student();

            // copy data into Student Object from form Text Boxes
            newStudent.FirstName = FirstNameTextBox.Text;
            newStudent.LastName = LastNameTextBox.Text;
            newStudent.Number = StudentNumberTextBox.Text;

            // Insert the new Student Object into the SQL Database
            db.GetTable<Student>().InsertOnSubmit(newStudent);

            // Save changes
            db.SubmitChanges();

            // show the Student List Form
            this.studentListForm.Show();

            // close this form
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.studentListForm.Show();
            this.Close();
        }

        private void StudentDetailsForm_Load(object sender, EventArgs e)
        {
           
        }

        private void StudentDetailsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
