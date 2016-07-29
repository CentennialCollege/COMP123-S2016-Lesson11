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
            
           
        }

        private void StudentListForm_Load(object sender, EventArgs e)
        {
            this.studentsTableAdapter.Fill(this.cOMP123DataSet.Students);
        }

        private void StudentsDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void StudentsDataGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void StudentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

    }
}
