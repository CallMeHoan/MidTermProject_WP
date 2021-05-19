
namespace MidTermProject
{
    partial class FormEditRemove
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.address_txt = new System.Windows.Forms.TextBox();
            this.remove_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
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
            this.cancel_btn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ptb)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(165, 165);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(201, 22);
            this.dateTimePicker1.TabIndex = 54;
            // 
            // address_txt
            // 
            this.address_txt.Location = new System.Drawing.Point(503, 35);
            this.address_txt.Multiline = true;
            this.address_txt.Name = "address_txt";
            this.address_txt.Size = new System.Drawing.Size(249, 59);
            this.address_txt.TabIndex = 53;
            // 
            // remove_btn
            // 
            this.remove_btn.Location = new System.Drawing.Point(328, 363);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(167, 56);
            this.remove_btn.TabIndex = 52;
            this.remove_btn.Text = "Remove";
            this.remove_btn.UseVisualStyleBackColor = true;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(93, 363);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(167, 56);
            this.edit_btn.TabIndex = 51;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // loadPic_btn
            // 
            this.loadPic_btn.Location = new System.Drawing.Point(579, 280);
            this.loadPic_btn.Name = "loadPic_btn";
            this.loadPic_btn.Size = new System.Drawing.Size(103, 42);
            this.loadPic_btn.TabIndex = 50;
            this.loadPic_btn.Text = "Load Image";
            this.loadPic_btn.UseVisualStyleBackColor = true;
            this.loadPic_btn.Click += new System.EventHandler(this.loadPic_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picture_ptb);
            this.panel2.Location = new System.Drawing.Point(503, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 152);
            this.panel2.TabIndex = 49;
            // 
            // picture_ptb
            // 
            this.picture_ptb.BackColor = System.Drawing.SystemColors.Control;
            this.picture_ptb.Location = new System.Drawing.Point(3, 3);
            this.picture_ptb.Name = "picture_ptb";
            this.picture_ptb.Size = new System.Drawing.Size(246, 147);
            this.picture_ptb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_ptb.TabIndex = 0;
            this.picture_ptb.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fMale_rbtn);
            this.panel1.Controls.Add(this.Male_rbtn);
            this.panel1.Location = new System.Drawing.Point(165, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 27);
            this.panel1.TabIndex = 48;
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
            this.Male_rbtn.Location = new System.Drawing.Point(21, 3);
            this.Male_rbtn.Name = "Male_rbtn";
            this.Male_rbtn.Size = new System.Drawing.Size(59, 21);
            this.Male_rbtn.TabIndex = 0;
            this.Male_rbtn.TabStop = true;
            this.Male_rbtn.Text = "Male";
            this.Male_rbtn.UseVisualStyleBackColor = true;
            // 
            // phone_txt
            // 
            this.phone_txt.Location = new System.Drawing.Point(165, 250);
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.Size = new System.Drawing.Size(202, 22);
            this.phone_txt.TabIndex = 47;
            // 
            // lName_txt
            // 
            this.lName_txt.Location = new System.Drawing.Point(165, 118);
            this.lName_txt.Name = "lName_txt";
            this.lName_txt.Size = new System.Drawing.Size(202, 22);
            this.lName_txt.TabIndex = 46;
            // 
            // fName_txt
            // 
            this.fName_txt.Location = new System.Drawing.Point(165, 72);
            this.fName_txt.Name = "fName_txt";
            this.fName_txt.Size = new System.Drawing.Size(202, 22);
            this.fName_txt.TabIndex = 45;
            // 
            // ID_txt
            // 
            this.ID_txt.Location = new System.Drawing.Point(165, 32);
            this.ID_txt.Name = "ID_txt";
            this.ID_txt.ReadOnly = true;
            this.ID_txt.Size = new System.Drawing.Size(202, 22);
            this.ID_txt.TabIndex = 44;
            // 
            // Pic_lb
            // 
            this.Pic_lb.AutoSize = true;
            this.Pic_lb.Location = new System.Drawing.Point(432, 124);
            this.Pic_lb.Name = "Pic_lb";
            this.Pic_lb.Size = new System.Drawing.Size(56, 17);
            this.Pic_lb.TabIndex = 43;
            this.Pic_lb.Text = "Picture:";
            // 
            // Address_lb
            // 
            this.Address_lb.AutoSize = true;
            this.Address_lb.Location = new System.Drawing.Point(424, 35);
            this.Address_lb.Name = "Address_lb";
            this.Address_lb.Size = new System.Drawing.Size(64, 17);
            this.Address_lb.TabIndex = 42;
            this.Address_lb.Text = "Address:";
            // 
            // phoneNum_lb
            // 
            this.phoneNum_lb.AutoSize = true;
            this.phoneNum_lb.Location = new System.Drawing.Point(45, 250);
            this.phoneNum_lb.Name = "phoneNum_lb";
            this.phoneNum_lb.Size = new System.Drawing.Size(105, 17);
            this.phoneNum_lb.TabIndex = 41;
            this.phoneNum_lb.Text = "Phone number:";
            // 
            // Gender_lb
            // 
            this.Gender_lb.AutoSize = true;
            this.Gender_lb.Location = new System.Drawing.Point(90, 209);
            this.Gender_lb.Name = "Gender_lb";
            this.Gender_lb.Size = new System.Drawing.Size(60, 17);
            this.Gender_lb.TabIndex = 40;
            this.Gender_lb.Text = "Gender:";
            // 
            // DoB_lb
            // 
            this.DoB_lb.AutoSize = true;
            this.DoB_lb.Location = new System.Drawing.Point(60, 165);
            this.DoB_lb.Name = "DoB_lb";
            this.DoB_lb.Size = new System.Drawing.Size(90, 17);
            this.DoB_lb.TabIndex = 39;
            this.DoB_lb.Text = "Date of birth:";
            // 
            // Lname_lb
            // 
            this.Lname_lb.AutoSize = true;
            this.Lname_lb.Location = new System.Drawing.Point(70, 118);
            this.Lname_lb.Name = "Lname_lb";
            this.Lname_lb.Size = new System.Drawing.Size(80, 17);
            this.Lname_lb.TabIndex = 38;
            this.Lname_lb.Text = "Last Name:";
            // 
            // Fname_lb
            // 
            this.Fname_lb.AutoSize = true;
            this.Fname_lb.Location = new System.Drawing.Point(70, 75);
            this.Fname_lb.Name = "Fname_lb";
            this.Fname_lb.Size = new System.Drawing.Size(80, 17);
            this.Fname_lb.TabIndex = 37;
            this.Fname_lb.Text = "First Name:";
            // 
            // ID_lb
            // 
            this.ID_lb.AutoSize = true;
            this.ID_lb.Location = new System.Drawing.Point(125, 32);
            this.ID_lb.Name = "ID_lb";
            this.ID_lb.Size = new System.Drawing.Size(25, 17);
            this.ID_lb.TabIndex = 36;
            this.ID_lb.Text = "ID:";
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(544, 363);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(167, 56);
            this.cancel_btn.TabIndex = 55;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // FormEditRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.address_txt);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.loadPic_btn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
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
            this.Name = "FormEditRemove";
            this.Text = "FormEditRemove";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_ptb)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button loadPic_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Pic_lb;
        private System.Windows.Forms.Label Address_lb;
        private System.Windows.Forms.Label phoneNum_lb;
        private System.Windows.Forms.Label Gender_lb;
        private System.Windows.Forms.Label DoB_lb;
        private System.Windows.Forms.Label Lname_lb;
        private System.Windows.Forms.Label Fname_lb;
        private System.Windows.Forms.Label ID_lb;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.TextBox address_txt;
        public System.Windows.Forms.PictureBox picture_ptb;
        public System.Windows.Forms.RadioButton fMale_rbtn;
        public System.Windows.Forms.RadioButton Male_rbtn;
        public System.Windows.Forms.TextBox phone_txt;
        public System.Windows.Forms.TextBox lName_txt;
        public System.Windows.Forms.TextBox fName_txt;
        public System.Windows.Forms.TextBox ID_txt;
        private System.Windows.Forms.Button cancel_btn;
    }
}