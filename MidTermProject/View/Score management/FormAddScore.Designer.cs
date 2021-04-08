
namespace MidTermProject
{
    partial class FormAddScore
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
            this.cancel_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.description_lb = new System.Windows.Forms.Label();
            this.period_lb = new System.Windows.Forms.Label();
            this.name_lb = new System.Windows.Forms.Label();
            this.ID_lb = new System.Windows.Forms.Label();
            this.descript_txt = new System.Windows.Forms.TextBox();
            this.score_txt = new System.Windows.Forms.TextBox();
            this.StuID_txt = new System.Windows.Forms.TextBox();
            this.course_cb = new System.Windows.Forms.ComboBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentManageDataSet1 = new MidTermProject.StudentManageDataSet1();
            this.showInfo_dgv = new System.Windows.Forms.DataGridView();
            this.studentTableAdapter = new MidTermProject.StudentManageDataSet1TableAdapters.studentTableAdapter();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesTableAdapter = new MidTermProject.StudentManageDataSet1TableAdapters.coursesTableAdapter();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManageDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showInfo_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel_btn
            // 
            this.cancel_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.Location = new System.Drawing.Point(674, 372);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(140, 38);
            this.cancel_btn.TabIndex = 19;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(133, 318);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(169, 38);
            this.add_btn.TabIndex = 18;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // description_lb
            // 
            this.description_lb.AutoSize = true;
            this.description_lb.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_lb.Location = new System.Drawing.Point(46, 209);
            this.description_lb.Name = "description_lb";
            this.description_lb.Size = new System.Drawing.Size(139, 26);
            this.description_lb.TabIndex = 17;
            this.description_lb.Text = "Description:";
            // 
            // period_lb
            // 
            this.period_lb.AutoSize = true;
            this.period_lb.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period_lb.Location = new System.Drawing.Point(107, 162);
            this.period_lb.Name = "period_lb";
            this.period_lb.Size = new System.Drawing.Size(78, 26);
            this.period_lb.TabIndex = 16;
            this.period_lb.Text = "Score:";
            // 
            // name_lb
            // 
            this.name_lb.AutoSize = true;
            this.name_lb.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lb.Location = new System.Drawing.Point(25, 111);
            this.name_lb.Name = "name_lb";
            this.name_lb.Size = new System.Drawing.Size(160, 26);
            this.name_lb.TabIndex = 15;
            this.name_lb.Text = "Select Course:";
            // 
            // ID_lb
            // 
            this.ID_lb.AutoSize = true;
            this.ID_lb.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_lb.Location = new System.Drawing.Point(54, 57);
            this.ID_lb.Name = "ID_lb";
            this.ID_lb.Size = new System.Drawing.Size(131, 26);
            this.ID_lb.TabIndex = 14;
            this.ID_lb.Text = "Student ID:";
            // 
            // descript_txt
            // 
            this.descript_txt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descript_txt.Location = new System.Drawing.Point(204, 209);
            this.descript_txt.Multiline = true;
            this.descript_txt.Name = "descript_txt";
            this.descript_txt.Size = new System.Drawing.Size(211, 66);
            this.descript_txt.TabIndex = 13;
            // 
            // score_txt
            // 
            this.score_txt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_txt.Location = new System.Drawing.Point(204, 154);
            this.score_txt.Name = "score_txt";
            this.score_txt.Size = new System.Drawing.Size(211, 34);
            this.score_txt.TabIndex = 12;
            // 
            // StuID_txt
            // 
            this.StuID_txt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuID_txt.Location = new System.Drawing.Point(204, 49);
            this.StuID_txt.Name = "StuID_txt";
            this.StuID_txt.Size = new System.Drawing.Size(211, 34);
            this.StuID_txt.TabIndex = 10;
            // 
            // course_cb
            // 
            this.course_cb.DataSource = this.coursesBindingSource;
            this.course_cb.DisplayMember = "Label";
            this.course_cb.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_cb.FormattingEnabled = true;
            this.course_cb.Location = new System.Drawing.Point(204, 103);
            this.course_cb.Name = "course_cb";
            this.course_cb.Size = new System.Drawing.Size(211, 34);
            this.course_cb.TabIndex = 20;
            this.course_cb.ValueMember = "CourseID";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.studentManageDataSet1;
            // 
            // studentManageDataSet1
            // 
            this.studentManageDataSet1.DataSetName = "StudentManageDataSet1";
            this.studentManageDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // showInfo_dgv
            // 
            this.showInfo_dgv.AutoGenerateColumns = false;
            this.showInfo_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showInfo_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn});
            this.showInfo_dgv.DataSource = this.studentBindingSource;
            this.showInfo_dgv.Location = new System.Drawing.Point(450, 46);
            this.showInfo_dgv.Name = "showInfo_dgv";
            this.showInfo_dgv.RowHeadersWidth = 51;
            this.showInfo_dgv.RowTemplate.Height = 24;
            this.showInfo_dgv.Size = new System.Drawing.Size(370, 310);
            this.showInfo_dgv.TabIndex = 21;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
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
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.Width = 75;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 75;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 75;
            // 
            // FormAddScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 432);
            this.Controls.Add(this.showInfo_dgv);
            this.Controls.Add(this.course_cb);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.description_lb);
            this.Controls.Add(this.period_lb);
            this.Controls.Add(this.name_lb);
            this.Controls.Add(this.ID_lb);
            this.Controls.Add(this.descript_txt);
            this.Controls.Add(this.score_txt);
            this.Controls.Add(this.StuID_txt);
            this.Name = "FormAddScore";
            this.Text = "FormAddScore";
            this.Load += new System.EventHandler(this.FormAddScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManageDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showInfo_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label description_lb;
        private System.Windows.Forms.Label period_lb;
        private System.Windows.Forms.Label name_lb;
        private System.Windows.Forms.Label ID_lb;
        private System.Windows.Forms.TextBox descript_txt;
        private System.Windows.Forms.TextBox score_txt;
        private System.Windows.Forms.TextBox StuID_txt;
        private System.Windows.Forms.ComboBox course_cb;
        private System.Windows.Forms.DataGridView showInfo_dgv;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private StudentManageDataSet1 studentManageDataSet1;
        private StudentManageDataSet1TableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private StudentManageDataSet1TableAdapters.coursesTableAdapter coursesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
    }
}