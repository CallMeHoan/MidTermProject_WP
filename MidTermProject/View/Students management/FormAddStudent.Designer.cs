
namespace MidTermProject
{
    partial class FormAddStudent
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
            this.AddPic_btn = new System.Windows.Forms.Button();
            this.Gender_Panel = new System.Windows.Forms.Panel();
            this.Gender2 = new System.Windows.Forms.RadioButton();
            this.Gender1 = new System.Windows.Forms.RadioButton();
            this.Add_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Address_txt = new System.Windows.Forms.TextBox();
            this.Phone_txt = new System.Windows.Forms.TextBox();
            this.LastName_txt = new System.Windows.Forms.TextBox();
            this.FirstName_txt = new System.Windows.Forms.TextBox();
            this.Id_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Gender_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddPic_btn
            // 
            this.AddPic_btn.Location = new System.Drawing.Point(200, 414);
            this.AddPic_btn.Name = "AddPic_btn";
            this.AddPic_btn.Size = new System.Drawing.Size(214, 28);
            this.AddPic_btn.TabIndex = 38;
            this.AddPic_btn.Text = "Add Picture";
            this.AddPic_btn.UseVisualStyleBackColor = true;
            this.AddPic_btn.Click += new System.EventHandler(this.AddPic_btn_Click_1);
            // 
            // Gender_Panel
            // 
            this.Gender_Panel.BackColor = System.Drawing.SystemColors.Control;
            this.Gender_Panel.Controls.Add(this.Gender2);
            this.Gender_Panel.Controls.Add(this.Gender1);
            this.Gender_Panel.Location = new System.Drawing.Point(199, 171);
            this.Gender_Panel.Name = "Gender_Panel";
            this.Gender_Panel.Size = new System.Drawing.Size(215, 34);
            this.Gender_Panel.TabIndex = 37;
            // 
            // Gender2
            // 
            this.Gender2.AutoSize = true;
            this.Gender2.Location = new System.Drawing.Point(101, 7);
            this.Gender2.Name = "Gender2";
            this.Gender2.Size = new System.Drawing.Size(75, 21);
            this.Gender2.TabIndex = 20;
            this.Gender2.TabStop = true;
            this.Gender2.Text = "Female";
            this.Gender2.UseVisualStyleBackColor = true;
            // 
            // Gender1
            // 
            this.Gender1.AutoSize = true;
            this.Gender1.Location = new System.Drawing.Point(36, 7);
            this.Gender1.Name = "Gender1";
            this.Gender1.Size = new System.Drawing.Size(59, 21);
            this.Gender1.TabIndex = 19;
            this.Gender1.TabStop = true;
            this.Gender1.Text = "Male";
            this.Gender1.UseVisualStyleBackColor = true;
            // 
            // Add_btn
            // 
            this.Add_btn.Location = new System.Drawing.Point(291, 457);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(99, 32);
            this.Add_btn.TabIndex = 36;
            this.Add_btn.Text = "Add";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click_1);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Location = new System.Drawing.Point(130, 457);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(99, 32);
            this.Cancel_btn.TabIndex = 35;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(200, 137);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(215, 22);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(200, 301);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // Address_txt
            // 
            this.Address_txt.Location = new System.Drawing.Point(200, 255);
            this.Address_txt.Name = "Address_txt";
            this.Address_txt.Size = new System.Drawing.Size(215, 22);
            this.Address_txt.TabIndex = 32;
            // 
            // Phone_txt
            // 
            this.Phone_txt.Location = new System.Drawing.Point(200, 216);
            this.Phone_txt.Name = "Phone_txt";
            this.Phone_txt.Size = new System.Drawing.Size(215, 22);
            this.Phone_txt.TabIndex = 31;
            // 
            // LastName_txt
            // 
            this.LastName_txt.Location = new System.Drawing.Point(200, 102);
            this.LastName_txt.Name = "LastName_txt";
            this.LastName_txt.Size = new System.Drawing.Size(215, 22);
            this.LastName_txt.TabIndex = 30;
            // 
            // FirstName_txt
            // 
            this.FirstName_txt.Location = new System.Drawing.Point(200, 63);
            this.FirstName_txt.Name = "FirstName_txt";
            this.FirstName_txt.Size = new System.Drawing.Size(215, 22);
            this.FirstName_txt.TabIndex = 29;
            // 
            // Id_txt
            // 
            this.Id_txt.Location = new System.Drawing.Point(200, 21);
            this.Id_txt.Name = "Id_txt";
            this.Id_txt.Size = new System.Drawing.Size(215, 22);
            this.Id_txt.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "PICTURE:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "ADDRESS:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "PHONE NUMBER:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "GENDER:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "DATE OF BIRTH:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "LAST NAME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "FIRST NAME:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "STUDENT ID:";
            // 
            // FormAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 510);
            this.Controls.Add(this.AddPic_btn);
            this.Controls.Add(this.Gender_Panel);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Address_txt);
            this.Controls.Add(this.Phone_txt);
            this.Controls.Add(this.LastName_txt);
            this.Controls.Add(this.FirstName_txt);
            this.Controls.Add(this.Id_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddStudent";
            this.Text = "FormAddStudent";
            this.Gender_Panel.ResumeLayout(false);
            this.Gender_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddPic_btn;
        private System.Windows.Forms.Panel Gender_Panel;
        private System.Windows.Forms.RadioButton Gender2;
        private System.Windows.Forms.RadioButton Gender1;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Address_txt;
        private System.Windows.Forms.TextBox Phone_txt;
        private System.Windows.Forms.TextBox LastName_txt;
        private System.Windows.Forms.TextBox FirstName_txt;
        private System.Windows.Forms.TextBox Id_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}