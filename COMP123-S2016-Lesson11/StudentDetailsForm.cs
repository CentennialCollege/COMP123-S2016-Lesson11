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

            // check if the form type is Details, Edit or Delete
            if(this.FormType > 3)
            {
                newStudent = (from student in db.Students
                              where student.StudentID == this.StudentID
                              select student).FirstOrDefault();
            }

            // copy data into Student Object from form Text Boxes
            newStudent.FirstName = FirstNameTextBox.Text;
            newStudent.LastName = LastNameTextBox.Text;
            newStudent.Number = StudentNumberTextBox.Text;

            // Check if Form Type is "Add Student"
            if(this.FormType < 4) {
                // Insert the new Student Object into the SQL Database
                db.GetTable<Student>().InsertOnSubmit(newStudent);
            }

            // Delete Record
            if(this.FormType == (int)ColumnButton.Delete)
            {
                //Confirm if the user wants to delete the record
                DialogResult result = MessageBox.Show("Are You Sure?", "Confirm Deletion", MessageBoxButtons.OKCancel);
                if(result == DialogResult.OK)
                {
                    db.GetTable<Student>().DeleteOnSubmit(newStudent);
                }
            }

            // Save changes / update record
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
            // create a db object 
            StudentDataContext db = new StudentDataContext();

            // check to ensure that you are asking for Details Form, a Edit Form or a Delete Form
            if(this.FormType > 3) { 
                Student studentDetails = (from student in db.Students
                                      where student.StudentID == this.StudentID
                                      select student).FirstOrDefault();

                // Dispaly details in the Text Boxes of the Form
                FirstNameTextBox.Text = studentDetails.FirstName;
                LastNameTextBox.Text = studentDetails.LastName;
                StudentNumberTextBox.Text = studentDetails.Number;
            }

            switch(this.FormType)
            {
                // if the button clicked is the Details Button
                case (int)ColumnButton.Details:
                    NewStudentLabel.Text = "Student Details";
                    this.Text = "Student Details";
                    SubmitButton.Visible = false;
                    FirstNameTextBox.ReadOnly = true;
                    LastNameTextBox.ReadOnly = true;
                    StudentNumberTextBox.ReadOnly = true;
                    CancelButton.Text = "Back";
                    break;
                // if the button clicked is the Edit Button
                case (int)ColumnButton.Edit:
                    NewStudentLabel.Text = "Edit Student";
                    this.Text = "Edit Student";
                    SubmitButton.Text = "Update";
                    break;
                // if the button clicked is the Delete Button
                case (int)ColumnButton.Delete:
                    NewStudentLabel.Text = "Delete Student";
                    this.Text = "Delete Student";
                    FirstNameTextBox.ReadOnly = true;
                    LastNameTextBox.ReadOnly = true;
                    StudentNumberTextBox.ReadOnly = true;
                    SubmitButton.Text = "Delete";
                    SubmitButton.BackColor = Color.Red;
                    break;
            }

        }

        private void StudentDetailsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
