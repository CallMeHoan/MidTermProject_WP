
namespace MidTermProject
{
    partial class FormAvgScore
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
            this.course_lb = new System.Windows.Forms.ListBox();
            this.coursesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentManageDataSet1 = new MidTermProject.StudentManageDataSet1();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesTableAdapter = new MidTermProject.StudentManageDataSet1TableAdapters.coursesTableAdapter();
            this.showScore_dgv = new System.Windows.Forms.DataGridView();
            this.showStu_dgv = new System.Windows.Forms.DataGridView();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.studentTableAdapter = new MidTermProject.StudentManageDataSet1TableAdapters.studentTableAdapter();
            this.result_btn = new System.Windows.Forms.Button();
            this.courseName_txt = new System.Windows.Forms.TextBox();
            this.AVG_txt = new System.Windows.Forms.TextBox();
            this.courseID_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManageDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showScore_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showStu_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // course_lb
            // 
            this.course_lb.DataSource = this.coursesBindingSource1;
            this.course_lb.DisplayMember = "Label";
            this.course_lb.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_lb.FormattingEnabled = true;
            this.course_lb.ItemHeight = 26;
            this.course_lb.Location = new System.Drawing.Point(12, 113);
            this.course_lb.Name = "course_lb";
            this.course_lb.Size = new System.Drawing.Size(180, 368);
            this.course_lb.TabIndex = 0;
            this.course_lb.ValueMember = "CourseID";
            this.course_lb.Click += new System.EventHandler(this.course_lb_Click);
            // 
            // coursesBindingSource1
            // 
            this.coursesBindingSource1.DataMember = "courses";
            this.coursesBindingSource1.DataSource = this.studentManageDataSet1;
            // 
            // studentManageDataSet1
            // 
            this.studentManageDataSet1.DataSetName = "StudentManageDataSet1";
            this.studentManageDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "courses";
            this.coursesBindingSource.DataSource = this.studentManageDataSet1;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // showScore_dgv
            // 
            this.showScore_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showScore_dgv.Location = new System.Drawing.Point(198, 113);
            this.showScore_dgv.Name = "showScore_dgv";
            this.showScore_dgv.RowHeadersWidth = 51;
            this.showScore_dgv.RowTemplate.Height = 24;
            this.showScore_dgv.Size = new System.Drawing.Size(593, 367);
            this.showScore_dgv.TabIndex = 1;
            // 
            // showStu_dgv
            // 
            this.showStu_dgv.AutoGenerateColumns = false;
            this.showStu_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showStu_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn});
            this.showStu_dgv.DataSource = this.studentBindingSource;
            this.showStu_dgv.Location = new System.Drawing.Point(797, 113);
            this.showStu_dgv.Name = "showStu_dgv";
            this.showStu_dgv.RowHeadersWidth = 51;
            this.showStu_dgv.RowTemplate.Height = 24;
            this.showStu_dgv.Size = new System.Drawing.Size(316, 367);
            this.showStu_dgv.TabIndex = 2;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.studentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.Width = 40;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 70;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 70;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.studentManageDataSet1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.courseID_txt);
            this.panel1.Controls.Add(this.AVG_txt);
            this.panel1.Controls.Add(this.courseName_txt);
            this.panel1.Controls.Add(this.result_btn);
            this.panel1.Location = new System.Drawing.Point(12, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 86);
            this.panel1.TabIndex = 3;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // result_btn
            // 
            this.result_btn.Location = new System.Drawing.Point(81, 31);
            this.result_btn.Name = "result_btn";
            this.result_btn.Size = new System.Drawing.Size(75, 23);
            this.result_btn.TabIndex = 0;
            this.result_btn.Text = "Result";
            this.result_btn.UseVisualStyleBackColor = true;
            this.result_btn.Click += new System.EventHandler(this.result_btn_Click);
            // 
            // courseName_txt
            // 
            this.courseName_txt.Location = new System.Drawing.Point(290, 31);
            this.courseName_txt.Name = "courseName_txt";
            this.courseName_txt.ReadOnly = true;
            this.courseName_txt.Size = new System.Drawing.Size(204, 22);
            this.courseName_txt.TabIndex = 1;
            // 
            // AVG_txt
            // 
            this.AVG_txt.Location = new System.Drawing.Point(565, 31);
            this.AVG_txt.Name = "AVG_txt";
            this.AVG_txt.ReadOnly = true;
            this.AVG_txt.Size = new System.Drawing.Size(58, 22);
            this.AVG_txt.TabIndex = 2;
            // 
            // courseID_txt
            // 
            this.courseID_txt.Location = new System.Drawing.Point(177, 31);
            this.courseID_txt.Name = "courseID_txt";
            this.courseID_txt.ReadOnly = true;
            this.courseID_txt.Size = new System.Drawing.Size(58, 22);
            this.courseID_txt.TabIndex = 3;
            // 
            // FormAvgScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 528);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.showStu_dgv);
            this.Controls.Add(this.showScore_dgv);
            this.Controls.Add(this.course_lb);
            this.Name = "FormAvgScore";
            this.Text = "FormAvgScore";
            this.Load += new System.EventHandler(this.FormAvgScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManageDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showScore_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showStu_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox course_lb;
        private StudentManageDataSet1 studentManageDataSet1;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private StudentManageDataSet1TableAdapters.coursesTableAdapter coursesTableAdapter;
        private System.Windows.Forms.BindingSource coursesBindingSource1;
        private System.Windows.Forms.DataGridView showScore_dgv;
        private System.Windows.Forms.DataGridView showStu_dgv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private StudentManageDataSet1TableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox courseID_txt;
        private System.Windows.Forms.TextBox AVG_txt;
        private System.Windows.Forms.TextBox courseName_txt;
        private System.Windows.Forms.Button result_btn;
    }
}