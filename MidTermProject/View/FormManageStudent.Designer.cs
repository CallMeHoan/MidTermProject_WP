
namespace MidTermProject
{
    partial class FormManageStudent
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.address_txt = new System.Windows.Forms.TextBox();
            this.loadPic_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picture_ptb = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fMale_rbtn = new System.Windows.Forms.RadioButton();
            this.Male_rbtn = new System.Windows.Forms.RadioButton();
            this.phone_txt = new System.Windows.Forms.TextBox();
            this.lName_txt = new System.Windows.Forms.TextBox();
            this.fName_txt = new System.Windows.Forms.TextBox();
            this.ID_txt = new System.Windows.Forms.TextBox();
            this.Pic_lb = new System.Windows.Forms.Label();
            this.Address_lb = new System.Windows.Forms.Label();
            this.phoneNum_lb = new System.Windows.Forms.Label();
            this.Gender_lb = new System.Windows.Forms.Label();
            this.DoB_lb = new System.Windows.Forms.Label();
            this.Lname_lb = new System.Windows.Forms.Label();
            this.Fname_lb = new System.Windows.Forms.Label();
            this.ID_lb = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            this.SearchBar_txt = new System.Windows.Forms.TextBox();
            this.studentDataSet = new MidTermProject.studentDataSet();
            this.studentDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lName_rabtn = new System.Windows.Forms.RadioButton();
            this.fName_rabtn = new System.Windows.Forms.RadioButton();
            this.id_rabtn = new System.Windows.Forms.RadioButton();
            this.studentTableAdapter = new MidTermProject.studentDataSetTableAdapters.studentTableAdapter();
            this.show_datagv = new System.Windows.Forms.DataGridView();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.remove_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.text = new System.Windows.Forms.Label();
            this.result_lb = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ptb)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_datagv)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(125, 132);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(202, 22);
            this.dateTimePicker1.TabIndex = 71;
            // 
            // address_txt
            // 
            this.address_txt.Location = new System.Drawing.Point(125, 221);
            this.address_txt.Multiline = true;
            this.address_txt.Name = "address_txt";
            this.address_txt.Size = new System.Drawing.Size(202, 59);
            this.address_txt.TabIndex = 70;
            // 
            // loadPic_btn
            // 
            this.loadPic_btn.Location = new System.Drawing.Point(125, 442);
            this.loadPic_btn.Name = "loadPic_btn";
            this.loadPic_btn.Size = new System.Drawing.Size(202, 28);
            this.loadPic_btn.TabIndex = 69;
            this.loadPic_btn.Text = "Load Image";
            this.loadPic_btn.UseVisualStyleBackColor = true;
            this.loadPic_btn.Click += new System.EventHandler(this.loadPic_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Controls.Add(this.picture_ptb);
            this.panel2.Location = new System.Drawing.Point(125, 286);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 152);
            this.panel2.TabIndex = 68;
            // 
            // picture_ptb
            // 
            this.picture_ptb.BackColor = System.Drawing.SystemColors.Control;
            this.picture_ptb.Location = new System.Drawing.Point(3, 3);
            this.picture_ptb.Name = "picture_ptb";
            this.picture_ptb.Size = new System.Drawing.Size(196, 147);
            this.picture_ptb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_ptb.TabIndex = 0;
            this.picture_ptb.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fMale_rbtn);
            this.panel1.Controls.Add(this.Male_rbtn);
            this.panel1.Location = new System.Drawing.Point(125, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 27);
            this.panel1.TabIndex = 67;
            // 
            // fMale_rbtn
            // 
            this.fMale_rbtn.AutoSize = true;
            this.fMale_rbtn.Location = new System.Drawing.Point(112, 3);
            this.fMale_rbtn.Name = "fMale_rbtn";
            this.fMale_rbtn.Size = new System.Drawing.Size(75, 21);
            this.fMale_rbtn.TabIndex = 1;
            this.fMale_rbtn.TabStop = true;
            this.fMale_rbtn.Text = "Female";
            this.fMale_rbtn.UseVisualStyleBackColor = true;
            // 
            // Male_rbtn
            // 
            this.Male_rbtn.AutoSize = true;
            this.Male_rbtn.Location = new System.Drawing.Point(20, 3);
            this.Male_rbtn.Name = "Male_rbtn";
            this.Male_rbtn.Size = new System.Drawing.Size(59, 21);
            this.Male_rbtn.TabIndex = 0;
            this.Male_rbtn.TabStop = true;
            this.Male_rbtn.Text = "Male";
            this.Male_rbtn.UseVisualStyleBackColor = true;
            // 
            // phone_txt
            // 
            this.phone_txt.Location = new System.Drawing.Point(125, 193);
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.Size = new System.Drawing.Size(202, 22);
            this.phone_txt.TabIndex = 66;
            // 
            // lName_txt
            // 
            this.lName_txt.Location = new System.Drawing.Point(125, 104);
            this.lName_txt.Name = "lName_txt";
            this.lName_txt.Size = new System.Drawing.Size(202, 22);
            this.lName_txt.TabIndex = 65;
            // 
            // fName_txt
            // 
            this.fName_txt.Location = new System.Drawing.Point(125, 76);
            this.fName_txt.Name = "fName_txt";
            this.fName_txt.Size = new System.Drawing.Size(202, 22);
            this.fName_txt.TabIndex = 64;
            // 
            // ID_txt
            // 
            this.ID_txt.Location = new System.Drawing.Point(125, 48);
            this.ID_txt.Name = "ID_txt";
            this.ID_txt.Size = new System.Drawing.Size(202, 22);
            this.ID_txt.TabIndex = 63;
            // 
            // Pic_lb
            // 
            this.Pic_lb.AutoSize = true;
            this.Pic_lb.Location = new System.Drawing.Point(54, 286);
            this.Pic_lb.Name = "Pic_lb";
            this.Pic_lb.Size = new System.Drawing.Size(56, 17);
            this.Pic_lb.TabIndex = 62;
            this.Pic_lb.Text = "Picture:";
            // 
            // Address_lb
            // 
            this.Address_lb.AutoSize = true;
            this.Address_lb.Location = new System.Drawing.Point(46, 221);
            this.Address_lb.Name = "Address_lb";
            this.Address_lb.Size = new System.Drawing.Size(64, 17);
            this.Address_lb.TabIndex = 61;
            this.Address_lb.Text = "Address:";
            // 
            // phoneNum_lb
            // 
            this.phoneNum_lb.AutoSize = true;
            this.phoneNum_lb.Location = new System.Drawing.Point(5, 193);
            this.phoneNum_lb.Name = "phoneNum_lb";
            this.phoneNum_lb.Size = new System.Drawing.Size(105, 17);
            this.phoneNum_lb.TabIndex = 60;
            this.phoneNum_lb.Text = "Phone number:";
            // 
            // Gender_lb
            // 
            this.Gender_lb.AutoSize = true;
            this.Gender_lb.Location = new System.Drawing.Point(50, 167);
            this.Gender_lb.Name = "Gender_lb";
            this.Gender_lb.Size = new System.Drawing.Size(60, 17);
            this.Gender_lb.TabIndex = 59;
            this.Gender_lb.Text = "Gender:";
            // 
            // DoB_lb
            // 
            this.DoB_lb.AutoSize = true;
            this.DoB_lb.Location = new System.Drawing.Point(20, 137);
            this.DoB_lb.Name = "DoB_lb";
            this.DoB_lb.Size = new System.Drawing.Size(90, 17);
            this.DoB_lb.TabIndex = 58;
            this.DoB_lb.Text = "Date of birth:";
            // 
            // Lname_lb
            // 
            this.Lname_lb.AutoSize = true;
            this.Lname_lb.Location = new System.Drawing.Point(30, 109);
            this.Lname_lb.Name = "Lname_lb";
            this.Lname_lb.Size = new System.Drawing.Size(80, 17);
            this.Lname_lb.TabIndex = 57;
            this.Lname_lb.Text = "Last Name:";
            // 
            // Fname_lb
            // 
            this.Fname_lb.AutoSize = true;
            this.Fname_lb.Location = new System.Drawing.Point(30, 81);
            this.Fname_lb.Name = "Fname_lb";
            this.Fname_lb.Size = new System.Drawing.Size(80, 17);
            this.Fname_lb.TabIndex = 56;
            this.Fname_lb.Text = "First Name:";
            // 
            // ID_lb
            // 
            this.ID_lb.AutoSize = true;
            this.ID_lb.Location = new System.Drawing.Point(85, 53);
            this.ID_lb.Name = "ID_lb";
            this.ID_lb.Size = new System.Drawing.Size(25, 17);
            this.ID_lb.TabIndex = 55;
            this.ID_lb.Text = "ID:";
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(672, 37);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(112, 26);
            this.search_btn.TabIndex = 74;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click_1);
            // 
            // SearchBar_txt
            // 
            this.SearchBar_txt.Location = new System.Drawing.Point(344, 37);
            this.SearchBar_txt.Multiline = true;
            this.SearchBar_txt.Name = "SearchBar_txt";
            this.SearchBar_txt.Size = new System.Drawing.Size(322, 26);
            this.SearchBar_txt.TabIndex = 73;
            // 
            // studentDataSet
            // 
            this.studentDataSet.DataSetName = "studentDataSet";
            this.studentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDataSet1BindingSource
            // 
            this.studentDataSet1BindingSource.DataSource = this.studentDataSet;
            this.studentDataSet1BindingSource.Position = 0;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.studentDataSet1BindingSource;
            // 
            // lName_rabtn
            // 
            this.lName_rabtn.AutoSize = true;
            this.lName_rabtn.Location = new System.Drawing.Point(494, 10);
            this.lName_rabtn.Name = "lName_rabtn";
            this.lName_rabtn.Size = new System.Drawing.Size(97, 21);
            this.lName_rabtn.TabIndex = 79;
            this.lName_rabtn.TabStop = true;
            this.lName_rabtn.Text = "Last Name";
            this.lName_rabtn.UseVisualStyleBackColor = true;
            // 
            // fName_rabtn
            // 
            this.fName_rabtn.AutoSize = true;
            this.fName_rabtn.Location = new System.Drawing.Point(391, 10);
            this.fName_rabtn.Name = "fName_rabtn";
            this.fName_rabtn.Size = new System.Drawing.Size(97, 21);
            this.fName_rabtn.TabIndex = 78;
            this.fName_rabtn.TabStop = true;
            this.fName_rabtn.Text = "First Name";
            this.fName_rabtn.UseVisualStyleBackColor = true;
            // 
            // id_rabtn
            // 
            this.id_rabtn.AutoSize = true;
            this.id_rabtn.Location = new System.Drawing.Point(343, 10);
            this.id_rabtn.Name = "id_rabtn";
            this.id_rabtn.Size = new System.Drawing.Size(42, 21);
            this.id_rabtn.TabIndex = 77;
            this.id_rabtn.TabStop = true;
            this.id_rabtn.Text = "ID";
            this.id_rabtn.UseVisualStyleBackColor = true;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // show_datagv
            // 
            this.show_datagv.AutoGenerateColumns = false;
            this.show_datagv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.show_datagv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.pictureDataGridViewImageColumn});
            this.show_datagv.DataSource = this.studentBindingSource;
            this.show_datagv.Location = new System.Drawing.Point(344, 76);
            this.show_datagv.Name = "show_datagv";
            this.show_datagv.RowHeadersWidth = 51;
            this.show_datagv.RowTemplate.Height = 24;
            this.show_datagv.Size = new System.Drawing.Size(440, 362);
            this.show_datagv.TabIndex = 80;
            this.show_datagv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.show_datagv_RowHeaderMouseClick);
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "picture";
            this.pictureDataGridViewImageColumn.HeaderText = "picture";
            this.pictureDataGridViewImageColumn.MinimumWidth = 6;
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            this.pictureDataGridViewImageColumn.Width = 125;
            // 
            // remove_btn
            // 
            this.remove_btn.Location = new System.Drawing.Point(144, 493);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(82, 34);
            this.remove_btn.TabIndex = 82;
            this.remove_btn.Text = "Remove";
            this.remove_btn.UseVisualStyleBackColor = true;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(64, 493);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(72, 34);
            this.edit_btn.TabIndex = 81;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // Add_btn
            // 
            this.Add_btn.Location = new System.Drawing.Point(232, 493);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(82, 34);
            this.Add_btn.TabIndex = 83;
            this.Add_btn.Text = "Add";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // refresh_btn
            // 
            this.refresh_btn.Location = new System.Drawing.Point(320, 493);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(82, 34);
            this.refresh_btn.TabIndex = 84;
            this.refresh_btn.Text = "Refressh";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.result_lb);
            this.panel3.Controls.Add(this.text);
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(567, 462);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(216, 42);
            this.panel3.TabIndex = 85;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.Location = new System.Drawing.Point(3, 8);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(149, 28);
            this.text.TabIndex = 0;
            this.text.Text = "Total student:";
            // 
            // result_lb
            // 
            this.result_lb.AutoSize = true;
            this.result_lb.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_lb.Location = new System.Drawing.Point(152, 8);
            this.result_lb.Name = "result_lb";
            this.result_lb.Size = new System.Drawing.Size(0, 28);
            this.result_lb.TabIndex = 1;
            // 
            // FormManageStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.show_datagv);
            this.Controls.Add(this.lName_rabtn);
            this.Controls.Add(this.fName_rabtn);
            this.Controls.Add(this.id_rabtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.SearchBar_txt);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.address_txt);
            this.Controls.Add(this.loadPic_btn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.phone_txt);
            this.Controls.Add(this.lName_txt);
            this.Controls.Add(this.fName_txt);
            this.Controls.Add(this.ID_txt);
            this.Controls.Add(this.Pic_lb);
            this.Controls.Add(this.Address_lb);
            this.Controls.Add(this.phoneNum_lb);
            this.Controls.Add(this.Gender_lb);
            this.Controls.Add(this.DoB_lb);
            this.Controls.Add(this.Lname_lb);
            this.Controls.Add(this.Fname_lb);
            this.Controls.Add(this.ID_lb);
            this.Name = "FormManageStudent";
            this.Text = "FormManageStudent";
            this.Load += new System.EventHandler(this.FormManageStudent_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_ptb)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_datagv)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.TextBox address_txt;
        private System.Windows.Forms.Button loadPic_btn;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.PictureBox picture_ptb;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.RadioButton fMale_rbtn;
        public System.Windows.Forms.RadioButton Male_rbtn;
        public System.Windows.Forms.TextBox phone_txt;
        public System.Windows.Forms.TextBox lName_txt;
        public System.Windows.Forms.TextBox fName_txt;
        public System.Windows.Forms.TextBox ID_txt;
        private System.Windows.Forms.Label Pic_lb;
        private System.Windows.Forms.Label Address_lb;
        private System.Windows.Forms.Label phoneNum_lb;
        private System.Windows.Forms.Label Gender_lb;
        private System.Windows.Forms.Label DoB_lb;
        private System.Windows.Forms.Label Lname_lb;
        private System.Windows.Forms.Label Fname_lb;
        private System.Windows.Forms.Label ID_lb;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox SearchBar_txt;
        private studentDataSet studentDataSet;
        private System.Windows.Forms.BindingSource studentDataSet1BindingSource;
        private System.Windows.Forms.RadioButton lName_rabtn;
        private System.Windows.Forms.RadioButton fName_rabtn;
        private System.Windows.Forms.RadioButton id_rabtn;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private studentDataSetTableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridView show_datagv;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label result_lb;
        private System.Windows.Forms.Label text;
    }
}