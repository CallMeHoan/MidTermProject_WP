
namespace MidTermProject
{
    partial class FormManageCourse
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
            this.showCourse_dgv = new System.Windows.Forms.DataGridView();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesDataSetFull = new MidTermProject.coursesDataSetFull();
            this.name_rbtn = new System.Windows.Forms.RadioButton();
            this.id_rabtn = new System.Windows.Forms.RadioButton();
            this.search_btn = new System.Windows.Forms.Button();
            this.SearchBar_txt = new System.Windows.Forms.TextBox();
            this.coursesTableAdapter = new MidTermProject.coursesDataSetFullTableAdapters.coursesTableAdapter();
            this.description_lb = new System.Windows.Forms.Label();
            this.period_lb = new System.Windows.Forms.Label();
            this.name_lb = new System.Windows.Forms.Label();
            this.ID_lb = new System.Windows.Forms.Label();
            this.descript_txt = new System.Windows.Forms.TextBox();
            this.period_txt = new System.Windows.Forms.TextBox();
            this.cName_txt = new System.Windows.Forms.TextBox();
            this.cid_txt = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.refresh_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.showCourse_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataSetFull)).BeginInit();
            this.SuspendLayout();
            // 
            // showCourse_dgv
            // 
            this.showCourse_dgv.AutoGenerateColumns = false;
            this.showCourse_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showCourse_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseIDDataGridViewTextBoxColumn,
            this.labelDataGridViewTextBoxColumn,
            this.periodDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.showCourse_dgv.DataSource = this.coursesBindingSource;
            this.showCourse_dgv.Location = new System.Drawing.Point(365, 77);
            this.showCourse_dgv.Name = "showCourse_dgv";
            this.showCourse_dgv.RowHeadersWidth = 51;
            this.showCourse_dgv.RowTemplate.Height = 24;
            this.showCourse_dgv.Size = new System.Drawing.Size(738, 297);
            this.showCourse_dgv.TabIndex = 96;
            this.showCourse_dgv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.show_datagv_RowHeaderMouseClick);
            // 
            // courseIDDataGridViewTextBoxColumn
            // 
            this.courseIDDataGridViewTextBoxColumn.DataPropertyName = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.HeaderText = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseIDDataGridViewTextBoxColumn.Name = "courseIDDataGridViewTextBoxColumn";
            this.courseIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // labelDataGridViewTextBoxColumn
            // 
            this.labelDataGridViewTextBoxColumn.DataPropertyName = "Label";
            this.labelDataGridViewTextBoxColumn.HeaderText = "Label";
            this.labelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.labelDataGridViewTextBoxColumn.Name = "labelDataGridViewTextBoxColumn";
            this.labelDataGridViewTextBoxColumn.Width = 125;
            // 
            // periodDataGridViewTextBoxColumn
            // 
            this.periodDataGridViewTextBoxColumn.DataPropertyName = "Period";
            this.periodDataGridViewTextBoxColumn.HeaderText = "Period";
            this.periodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.periodDataGridViewTextBoxColumn.Name = "periodDataGridViewTextBoxColumn";
            this.periodDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "courses";
            this.coursesBindingSource.DataSource = this.coursesDataSetFull;
            // 
            // coursesDataSetFull
            // 
            this.coursesDataSetFull.DataSetName = "coursesDataSetFull";
            this.coursesDataSetFull.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // name_rbtn
            // 
            this.name_rbtn.AutoSize = true;
            this.name_rbtn.Location = new System.Drawing.Point(462, 12);
            this.name_rbtn.Name = "name_rbtn";
            this.name_rbtn.Size = new System.Drawing.Size(115, 21);
            this.name_rbtn.TabIndex = 94;
            this.name_rbtn.TabStop = true;
            this.name_rbtn.Text = "Course Name";
            this.name_rbtn.UseVisualStyleBackColor = true;
            // 
            // id_rabtn
            // 
            this.id_rabtn.AutoSize = true;
            this.id_rabtn.Location = new System.Drawing.Point(365, 11);
            this.id_rabtn.Name = "id_rabtn";
            this.id_rabtn.Size = new System.Drawing.Size(91, 21);
            this.id_rabtn.TabIndex = 93;
            this.id_rabtn.TabStop = true;
            this.id_rabtn.Text = "Course ID";
            this.id_rabtn.UseVisualStyleBackColor = true;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(691, 38);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(112, 26);
            this.search_btn.TabIndex = 92;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            // 
            // SearchBar_txt
            // 
            this.SearchBar_txt.Location = new System.Drawing.Point(365, 38);
            this.SearchBar_txt.Multiline = true;
            this.SearchBar_txt.Name = "SearchBar_txt";
            this.SearchBar_txt.Size = new System.Drawing.Size(322, 26);
            this.SearchBar_txt.TabIndex = 91;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // description_lb
            // 
            this.description_lb.AutoSize = true;
            this.description_lb.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_lb.Location = new System.Drawing.Point(20, 238);
            this.description_lb.Name = "description_lb";
            this.description_lb.Size = new System.Drawing.Size(103, 19);
            this.description_lb.TabIndex = 104;
            this.description_lb.Text = "Description:";
            // 
            // period_lb
            // 
            this.period_lb.AutoSize = true;
            this.period_lb.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period_lb.Location = new System.Drawing.Point(57, 183);
            this.period_lb.Name = "period_lb";
            this.period_lb.Size = new System.Drawing.Size(66, 19);
            this.period_lb.TabIndex = 103;
            this.period_lb.Text = "Period:";
            // 
            // name_lb
            // 
            this.name_lb.AutoSize = true;
            this.name_lb.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lb.Location = new System.Drawing.Point(9, 132);
            this.name_lb.Name = "name_lb";
            this.name_lb.Size = new System.Drawing.Size(114, 19);
            this.name_lb.TabIndex = 102;
            this.name_lb.Text = "Course Name:";
            // 
            // ID_lb
            // 
            this.ID_lb.AutoSize = true;
            this.ID_lb.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_lb.Location = new System.Drawing.Point(33, 78);
            this.ID_lb.Name = "ID_lb";
            this.ID_lb.Size = new System.Drawing.Size(90, 19);
            this.ID_lb.TabIndex = 101;
            this.ID_lb.Text = "Course ID:";
            // 
            // descript_txt
            // 
            this.descript_txt.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descript_txt.Location = new System.Drawing.Point(137, 238);
            this.descript_txt.Multiline = true;
            this.descript_txt.Name = "descript_txt";
            this.descript_txt.Size = new System.Drawing.Size(195, 66);
            this.descript_txt.TabIndex = 100;
            // 
            // period_txt
            // 
            this.period_txt.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period_txt.Location = new System.Drawing.Point(137, 183);
            this.period_txt.Name = "period_txt";
            this.period_txt.Size = new System.Drawing.Size(195, 22);
            this.period_txt.TabIndex = 99;
            // 
            // cName_txt
            // 
            this.cName_txt.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cName_txt.Location = new System.Drawing.Point(137, 132);
            this.cName_txt.Name = "cName_txt";
            this.cName_txt.Size = new System.Drawing.Size(195, 22);
            this.cName_txt.TabIndex = 98;
            // 
            // cid_txt
            // 
            this.cid_txt.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cid_txt.Location = new System.Drawing.Point(137, 78);
            this.cid_txt.Name = "cid_txt";
            this.cid_txt.Size = new System.Drawing.Size(195, 22);
            this.cid_txt.TabIndex = 97;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(11, 348);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(112, 26);
            this.add_btn.TabIndex = 107;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(129, 348);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(112, 26);
            this.edit_btn.TabIndex = 108;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(247, 348);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(112, 26);
            this.delete_btn.TabIndex = 109;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(926, 387);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(112, 26);
            this.cancel_btn.TabIndex = 110;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // refresh_btn
            // 
            this.refresh_btn.Location = new System.Drawing.Point(784, 387);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(112, 26);
            this.refresh_btn.TabIndex = 111;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // FormManageCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 425);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.description_lb);
            this.Controls.Add(this.period_lb);
            this.Controls.Add(this.name_lb);
            this.Controls.Add(this.ID_lb);
            this.Controls.Add(this.descript_txt);
            this.Controls.Add(this.period_txt);
            this.Controls.Add(this.cName_txt);
            this.Controls.Add(this.cid_txt);
            this.Controls.Add(this.showCourse_dgv);
            this.Controls.Add(this.name_rbtn);
            this.Controls.Add(this.id_rabtn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.SearchBar_txt);
            this.Name = "FormManageCourse";
            this.Text = "FormManageCourse";
            this.Load += new System.EventHandler(this.FormManageCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showCourse_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataSetFull)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView showCourse_dgv;
        private System.Windows.Forms.RadioButton name_rbtn;
        private System.Windows.Forms.RadioButton id_rabtn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox SearchBar_txt;
        private coursesDataSetFull coursesDataSetFull;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private coursesDataSetFullTableAdapters.coursesTableAdapter coursesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn labelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label description_lb;
        private System.Windows.Forms.Label period_lb;
        private System.Windows.Forms.Label name_lb;
        private System.Windows.Forms.Label ID_lb;
        private System.Windows.Forms.TextBox descript_txt;
        private System.Windows.Forms.TextBox period_txt;
        private System.Windows.Forms.TextBox cName_txt;
        private System.Windows.Forms.TextBox cid_txt;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button refresh_btn;
    }
}