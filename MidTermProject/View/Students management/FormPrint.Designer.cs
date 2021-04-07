
namespace MidTermProject
{
    partial class FormPrint
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
            this.saveToExcel_btn = new System.Windows.Forms.Button();
            this.info_dgv = new System.Windows.Forms.DataGridView();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSet2 = new MidTermProject.studentDataSet();
            this.studentTableAdapter = new MidTermProject.studentDataSetTableAdapters.studentTableAdapter();
            this.main_pn = new System.Windows.Forms.Panel();
            this.check_btn = new System.Windows.Forms.Button();
            this.fMale_rbtn = new System.Windows.Forms.RadioButton();
            this.male_rbtn = new System.Windows.Forms.RadioButton();
            this.allGender_rbtn = new System.Windows.Forms.RadioButton();
            this.second_pn = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.time2_tp = new System.Windows.Forms.DateTimePicker();
            this.time1_tp = new System.Windows.Forms.DateTimePicker();
            this.date_lb = new System.Windows.Forms.Label();
            this.uselb = new System.Windows.Forms.Label();
            this.no_rbtn = new System.Windows.Forms.RadioButton();
            this.yes_rbtn = new System.Windows.Forms.RadioButton();
            this.print_btn = new System.Windows.Forms.Button();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.saveWord_btn = new System.Windows.Forms.Button();
            this.savePDF_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.info_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet2)).BeginInit();
            this.main_pn.SuspendLayout();
            this.second_pn.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveToExcel_btn
            // 
            this.saveToExcel_btn.Location = new System.Drawing.Point(206, 531);
            this.saveToExcel_btn.Name = "saveToExcel_btn";
            this.saveToExcel_btn.Size = new System.Drawing.Size(95, 42);
            this.saveToExcel_btn.TabIndex = 4;
            this.saveToExcel_btn.Text = "Save to MS Excel";
            this.saveToExcel_btn.UseVisualStyleBackColor = true;
            this.saveToExcel_btn.Click += new System.EventHandler(this.saveToExcel_btn_Click);
            // 
            // info_dgv
            // 
            this.info_dgv.AutoGenerateColumns = false;
            this.info_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.info_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.fNameColumn,
            this.lNameColumn,
            this.dobColumn,
            this.genderColumn,
            this.phoneColumn,
            this.addressColumn,
            this.picColumn});
            this.info_dgv.DataSource = this.studentBindingSource;
            this.info_dgv.Location = new System.Drawing.Point(12, 144);
            this.info_dgv.Name = "info_dgv";
            this.info_dgv.RowHeadersWidth = 51;
            this.info_dgv.RowTemplate.Height = 24;
            this.info_dgv.Size = new System.Drawing.Size(936, 364);
            this.info_dgv.TabIndex = 3;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.studentDataSet2;
            // 
            // studentDataSet2
            // 
            this.studentDataSet2.DataSetName = "studentDataSet2";
            this.studentDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // main_pn
            // 
            this.main_pn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.main_pn.Controls.Add(this.check_btn);
            this.main_pn.Controls.Add(this.fMale_rbtn);
            this.main_pn.Controls.Add(this.male_rbtn);
            this.main_pn.Controls.Add(this.allGender_rbtn);
            this.main_pn.Controls.Add(this.second_pn);
            this.main_pn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_pn.Location = new System.Drawing.Point(12, 15);
            this.main_pn.Name = "main_pn";
            this.main_pn.Size = new System.Drawing.Size(935, 112);
            this.main_pn.TabIndex = 5;
            // 
            // check_btn
            // 
            this.check_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.check_btn.Location = new System.Drawing.Point(794, 39);
            this.check_btn.Name = "check_btn";
            this.check_btn.Size = new System.Drawing.Size(105, 45);
            this.check_btn.TabIndex = 4;
            this.check_btn.Text = "Check";
            this.check_btn.UseVisualStyleBackColor = false;
            this.check_btn.Click += new System.EventHandler(this.check_btn_Click);
            // 
            // fMale_rbtn
            // 
            this.fMale_rbtn.AutoSize = true;
            this.fMale_rbtn.Location = new System.Drawing.Point(202, 50);
            this.fMale_rbtn.Name = "fMale_rbtn";
            this.fMale_rbtn.Size = new System.Drawing.Size(85, 23);
            this.fMale_rbtn.TabIndex = 3;
            this.fMale_rbtn.TabStop = true;
            this.fMale_rbtn.Text = "Female";
            this.fMale_rbtn.UseVisualStyleBackColor = true;
            // 
            // male_rbtn
            // 
            this.male_rbtn.AutoSize = true;
            this.male_rbtn.Location = new System.Drawing.Point(133, 50);
            this.male_rbtn.Name = "male_rbtn";
            this.male_rbtn.Size = new System.Drawing.Size(72, 23);
            this.male_rbtn.TabIndex = 2;
            this.male_rbtn.TabStop = true;
            this.male_rbtn.Text = "Male ";
            this.male_rbtn.UseVisualStyleBackColor = true;
            // 
            // allGender_rbtn
            // 
            this.allGender_rbtn.AutoSize = true;
            this.allGender_rbtn.Location = new System.Drawing.Point(14, 50);
            this.allGender_rbtn.Name = "allGender_rbtn";
            this.allGender_rbtn.Size = new System.Drawing.Size(113, 23);
            this.allGender_rbtn.TabIndex = 1;
            this.allGender_rbtn.TabStop = true;
            this.allGender_rbtn.Text = "All Gender";
            this.allGender_rbtn.UseVisualStyleBackColor = true;
            // 
            // second_pn
            // 
            this.second_pn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.second_pn.Controls.Add(this.label1);
            this.second_pn.Controls.Add(this.time2_tp);
            this.second_pn.Controls.Add(this.time1_tp);
            this.second_pn.Controls.Add(this.date_lb);
            this.second_pn.Controls.Add(this.uselb);
            this.second_pn.Controls.Add(this.no_rbtn);
            this.second_pn.Controls.Add(this.yes_rbtn);
            this.second_pn.Location = new System.Drawing.Point(311, 23);
            this.second_pn.Name = "second_pn";
            this.second_pn.Size = new System.Drawing.Size(426, 75);
            this.second_pn.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "And";
            // 
            // time2_tp
            // 
            this.time2_tp.CustomFormat = "yyyy-MM-dd";
            this.time2_tp.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time2_tp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.time2_tp.Location = new System.Drawing.Point(322, 44);
            this.time2_tp.Name = "time2_tp";
            this.time2_tp.Size = new System.Drawing.Size(99, 25);
            this.time2_tp.TabIndex = 9;
            // 
            // time1_tp
            // 
            this.time1_tp.CustomFormat = "dd-MM-yyyy";
            this.time1_tp.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time1_tp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.time1_tp.Location = new System.Drawing.Point(174, 44);
            this.time1_tp.Name = "time1_tp";
            this.time1_tp.Size = new System.Drawing.Size(99, 25);
            this.time1_tp.TabIndex = 8;
            // 
            // date_lb
            // 
            this.date_lb.AutoSize = true;
            this.date_lb.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_lb.Location = new System.Drawing.Point(4, 46);
            this.date_lb.Name = "date_lb";
            this.date_lb.Size = new System.Drawing.Size(161, 22);
            this.date_lb.TabIndex = 7;
            this.date_lb.Text = "Birthday Between:";
            // 
            // uselb
            // 
            this.uselb.AutoSize = true;
            this.uselb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uselb.Location = new System.Drawing.Point(67, 11);
            this.uselb.Name = "uselb";
            this.uselb.Size = new System.Drawing.Size(154, 23);
            this.uselb.TabIndex = 6;
            this.uselb.Text = "Use Date Range:";
            // 
            // no_rbtn
            // 
            this.no_rbtn.AutoSize = true;
            this.no_rbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_rbtn.Location = new System.Drawing.Point(301, 9);
            this.no_rbtn.Name = "no_rbtn";
            this.no_rbtn.Size = new System.Drawing.Size(55, 27);
            this.no_rbtn.TabIndex = 5;
            this.no_rbtn.TabStop = true;
            this.no_rbtn.Text = "No";
            this.no_rbtn.UseVisualStyleBackColor = true;
            // 
            // yes_rbtn
            // 
            this.yes_rbtn.AutoSize = true;
            this.yes_rbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yes_rbtn.Location = new System.Drawing.Point(235, 9);
            this.yes_rbtn.Name = "yes_rbtn";
            this.yes_rbtn.Size = new System.Drawing.Size(60, 27);
            this.yes_rbtn.TabIndex = 4;
            this.yes_rbtn.TabStop = true;
            this.yes_rbtn.Text = "Yes";
            this.yes_rbtn.UseVisualStyleBackColor = true;
            // 
            // print_btn
            // 
            this.print_btn.Location = new System.Drawing.Point(661, 531);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(95, 42);
            this.print_btn.TabIndex = 6;
            this.print_btn.Text = "Print";
            this.print_btn.UseVisualStyleBackColor = true;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // idColumn
            // 
            this.idColumn.DataPropertyName = "StudentID";
            this.idColumn.HeaderText = "ID";
            this.idColumn.MinimumWidth = 6;
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Width = 89;
            // 
            // fNameColumn
            // 
            this.fNameColumn.DataPropertyName = "FirstName";
            this.fNameColumn.HeaderText = "First Name";
            this.fNameColumn.MinimumWidth = 6;
            this.fNameColumn.Name = "fNameColumn";
            this.fNameColumn.ReadOnly = true;
            this.fNameColumn.Width = 125;
            // 
            // lNameColumn
            // 
            this.lNameColumn.DataPropertyName = "LastName";
            this.lNameColumn.HeaderText = "Last Name";
            this.lNameColumn.MinimumWidth = 6;
            this.lNameColumn.Name = "lNameColumn";
            this.lNameColumn.ReadOnly = true;
            this.lNameColumn.Width = 125;
            // 
            // dobColumn
            // 
            this.dobColumn.DataPropertyName = "DateOfBirth";
            this.dobColumn.HeaderText = "Date of birth";
            this.dobColumn.MinimumWidth = 6;
            this.dobColumn.Name = "dobColumn";
            this.dobColumn.ReadOnly = true;
            this.dobColumn.Width = 125;
            // 
            // genderColumn
            // 
            this.genderColumn.DataPropertyName = "Gender";
            this.genderColumn.HeaderText = "Gender";
            this.genderColumn.MinimumWidth = 6;
            this.genderColumn.Name = "genderColumn";
            this.genderColumn.ReadOnly = true;
            this.genderColumn.Width = 75;
            // 
            // phoneColumn
            // 
            this.phoneColumn.DataPropertyName = "PhoneNumber";
            this.phoneColumn.HeaderText = "Phone number";
            this.phoneColumn.MinimumWidth = 6;
            this.phoneColumn.Name = "phoneColumn";
            this.phoneColumn.ReadOnly = true;
            this.phoneColumn.Width = 130;
            // 
            // addressColumn
            // 
            this.addressColumn.DataPropertyName = "Address";
            this.addressColumn.HeaderText = "Address";
            this.addressColumn.MinimumWidth = 6;
            this.addressColumn.Name = "addressColumn";
            this.addressColumn.ReadOnly = true;
            this.addressColumn.Width = 125;
            // 
            // picColumn
            // 
            this.picColumn.DataPropertyName = "Picture";
            this.picColumn.HeaderText = "Picture";
            this.picColumn.MinimumWidth = 6;
            this.picColumn.Name = "picColumn";
            this.picColumn.ReadOnly = true;
            this.picColumn.Width = 89;
            // 
            // saveWord_btn
            // 
            this.saveWord_btn.Location = new System.Drawing.Point(358, 531);
            this.saveWord_btn.Name = "saveWord_btn";
            this.saveWord_btn.Size = new System.Drawing.Size(95, 42);
            this.saveWord_btn.TabIndex = 7;
            this.saveWord_btn.Text = "Save to MS Word";
            this.saveWord_btn.UseVisualStyleBackColor = true;
            this.saveWord_btn.Click += new System.EventHandler(this.saveWord_btn_Click);
            // 
            // savePDF_btn
            // 
            this.savePDF_btn.Location = new System.Drawing.Point(511, 531);
            this.savePDF_btn.Name = "savePDF_btn";
            this.savePDF_btn.Size = new System.Drawing.Size(95, 42);
            this.savePDF_btn.TabIndex = 8;
            this.savePDF_btn.Text = "Save to PDF";
            this.savePDF_btn.UseVisualStyleBackColor = true;
            this.savePDF_btn.Click += new System.EventHandler(this.savePDF_btn_Click);
            // 
            // FormPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 607);
            this.Controls.Add(this.savePDF_btn);
            this.Controls.Add(this.saveWord_btn);
            this.Controls.Add(this.print_btn);
            this.Controls.Add(this.main_pn);
            this.Controls.Add(this.saveToExcel_btn);
            this.Controls.Add(this.info_dgv);
            this.Name = "FormPrint";
            this.Text = "PrintForm";
            this.Load += new System.EventHandler(this.FormPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.info_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet2)).EndInit();
            this.main_pn.ResumeLayout(false);
            this.main_pn.PerformLayout();
            this.second_pn.ResumeLayout(false);
            this.second_pn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveToExcel_btn;
        private System.Windows.Forms.DataGridView info_dgv;
        private studentDataSet studentDataSet2;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private studentDataSetTableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.Panel main_pn;
        private System.Windows.Forms.RadioButton fMale_rbtn;
        private System.Windows.Forms.RadioButton male_rbtn;
        private System.Windows.Forms.RadioButton allGender_rbtn;
        private System.Windows.Forms.Panel second_pn;
        private System.Windows.Forms.Label uselb;
        private System.Windows.Forms.RadioButton no_rbtn;
        private System.Windows.Forms.RadioButton yes_rbtn;
        private System.Windows.Forms.Button check_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker time2_tp;
        private System.Windows.Forms.DateTimePicker time1_tp;
        private System.Windows.Forms.Label date_lb;
        private System.Windows.Forms.Button print_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressColumn;
        private System.Windows.Forms.DataGridViewImageColumn picColumn;
        private System.Windows.Forms.Button saveWord_btn;
        private System.Windows.Forms.Button savePDF_btn;
    }
}