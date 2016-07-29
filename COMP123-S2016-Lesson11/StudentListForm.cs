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
    public partial class StudentListForm : Form
    {
        public StudentListForm()
        {
            InitializeComponent();
        }

        private void AddStudenButton_Click(object sender, EventArgs e)
        {
            StudentDetailsForm addStudentForm = new StudentDetailsForm();
            addStudentForm.studentListForm = this;
            addStudentForm.Show();
            this.Hide();
        }

        private void StudentListForm_Activated(object sender, EventArgs e)
        {
            this.studentsTableAdapter.Fill(this.cOMP123DataSet.Students);
        }

        private void StudentListForm_Load(object sender, EventArgs e)
        {
            
        }

        private void StudentsDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void StudentsDataGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void StudentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // create the new studentDetails form
            StudentDetailsForm StudentDetails = new StudentDetailsForm();
            StudentDetails.studentListForm = this; // make a reference to this form
            StudentDetails.FormType = e.ColumnIndex; // send over the button that is clicked

            // get the student id from the StudentsDataGridView
            StudentDetails.StudentID = Convert.ToInt32(StudentsDataGridView.Rows[e.RowIndex].Cells["StudentID"].Value);

            StudentDetails.Show(); // show the studentDetails Form
            this.Hide(); // hide this form
        }

    }
}
