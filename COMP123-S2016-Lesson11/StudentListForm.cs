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

            StudentDataContext db = new StudentDataContext();
            List<Student> studentList = (from student in db.Students
                                   select student).ToList();

            StudentsDataGridView.DataSource = studentList;
        }

        private void RemoveHeaderTextFromButtonColumn(string columnString)
        {
            DataGridViewButtonColumn column = (DataGridViewButtonColumn)StudentsDataGridView.Columns[columnString];
            column.HeaderText = String.Empty;
            column.ReadOnly = false;
            if(columnString == "Edit")
            {
                column.CellTemplate.Style.ForeColor = Color.Blue;
            }
            if(columnString == "Delete")
            {
                column.CellTemplate.Style.ForeColor = Color.Red;
            }
        }


        private void StudentListForm_Load(object sender, EventArgs e)
        {
            this.RemoveHeaderTextFromButtonColumn("Details");
            this.RemoveHeaderTextFromButtonColumn("Edit");
            this.RemoveHeaderTextFromButtonColumn("Delete");
        }

        private void StudentsDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void StudentsDataGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void StudentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // if header row not clicked and Details, Edit or Delete columns are clicked
            if((e.RowIndex != -1) && (e.ColumnIndex > 3))
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
}
