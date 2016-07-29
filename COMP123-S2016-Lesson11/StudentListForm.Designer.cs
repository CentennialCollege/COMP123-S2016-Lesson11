namespace COMP123_S2016_Lesson11
{
    partial class StudentListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.StudentsDataGridView = new System.Windows.Forms.DataGridView();
            this.studentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cOMP123DataSet = new COMP123_S2016_Lesson11.COMP123DataSet();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new COMP123_S2016_Lesson11.COMP123DataSetTableAdapters.StudentsTableAdapter();
            this.StudentListLabel = new System.Windows.Forms.Label();
            this.AddStudenButton = new System.Windows.Forms.Button();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMP123DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentsDataGridView
            // 
            this.StudentsDataGridView.AllowUserToResizeColumns = false;
            this.StudentsDataGridView.AllowUserToResizeRows = false;
            this.StudentsDataGridView.AutoGenerateColumns = false;
            this.StudentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.StudentsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StudentsDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.StudentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.Details,
            this.Edit,
            this.Delete});
            this.StudentsDataGridView.DataSource = this.studentsBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.StudentsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.StudentsDataGridView.GridColor = System.Drawing.Color.White;
            this.StudentsDataGridView.Location = new System.Drawing.Point(12, 97);
            this.StudentsDataGridView.Name = "StudentsDataGridView";
            this.StudentsDataGridView.ReadOnly = true;
            this.StudentsDataGridView.RowHeadersVisible = false;
            this.StudentsDataGridView.RowTemplate.Height = 25;
            this.StudentsDataGridView.Size = new System.Drawing.Size(1027, 511);
            this.StudentsDataGridView.TabIndex = 0;
            this.StudentsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsDataGridView_CellContentClick);
            this.StudentsDataGridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsDataGridView_CellMouseEnter);
            this.StudentsDataGridView.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsDataGridView_CellMouseLeave);
            // 
            // studentsBindingSource1
            // 
            this.studentsBindingSource1.DataMember = "Students";
            this.studentsBindingSource1.DataSource = this.cOMP123DataSet;
            // 
            // cOMP123DataSet
            // 
            this.cOMP123DataSet.DataSetName = "COMP123DataSet";
            this.cOMP123DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.cOMP123DataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // StudentListLabel
            // 
            this.StudentListLabel.AutoSize = true;
            this.StudentListLabel.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentListLabel.Location = new System.Drawing.Point(12, 9);
            this.StudentListLabel.Name = "StudentListLabel";
            this.StudentListLabel.Size = new System.Drawing.Size(184, 31);
            this.StudentListLabel.TabIndex = 1;
            this.StudentListLabel.Text = "Student List";
            // 
            // AddStudenButton
            // 
            this.AddStudenButton.BackColor = System.Drawing.Color.LimeGreen;
            this.AddStudenButton.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStudenButton.ForeColor = System.Drawing.Color.White;
            this.AddStudenButton.Location = new System.Drawing.Point(18, 43);
            this.AddStudenButton.Name = "AddStudenButton";
            this.AddStudenButton.Size = new System.Drawing.Size(217, 48);
            this.AddStudenButton.TabIndex = 2;
            this.AddStudenButton.Text = "Add Student";
            this.AddStudenButton.UseVisualStyleBackColor = false;
            this.AddStudenButton.Click += new System.EventHandler(this.AddStudenButton_Click);
            // 
            // StudentID
            // 
            this.StudentID.DataPropertyName = "StudentID";
            this.StudentID.HeaderText = "StudentID";
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            this.StudentID.Visible = false;
            this.StudentID.Width = 170;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 196;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 189;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberDataGridViewTextBoxColumn.Width = 165;
            // 
            // Details
            // 
            this.Details.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Details.HeaderText = "Details";
            this.Details.Name = "Details";
            this.Details.ReadOnly = true;
            this.Details.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Details.Text = "Details";
            this.Details.UseColumnTextForButtonValue = true;
            this.Details.Width = 150;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 150;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 150;
            // 
            // StudentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 620);
            this.Controls.Add(this.AddStudenButton);
            this.Controls.Add(this.StudentListLabel);
            this.Controls.Add(this.StudentsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StudentListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student List";
            this.Activated += new System.EventHandler(this.StudentListForm_Activated);
            this.Load += new System.EventHandler(this.StudentListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMP123DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentsDataGridView;
        private COMP123DataSet cOMP123DataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private COMP123DataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.Label StudentListLabel;
        private System.Windows.Forms.Button AddStudenButton;
        private System.Windows.Forms.BindingSource studentsBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Details;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}

