
namespace MidTermProject.View.Result
{
    partial class AVG
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
            this.lname_lb = new System.Windows.Forms.Label();
            this.fname_lb = new System.Windows.Forms.Label();
            this.ID_lb = new System.Windows.Forms.Label();
            this.lname_txt = new System.Windows.Forms.TextBox();
            this.fname_txt = new System.Windows.Forms.TextBox();
            this.StuID_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchbar_txt = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.showInfo_dgv = new System.Windows.Forms.DataGridView();
            this.studentManageDataSet1 = new MidTermProject.StudentManageDataSet1();
            this.studentManageDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.print_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.showInfo_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManageDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManageDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lname_lb
            // 
            this.lname_lb.AutoSize = true;
            this.lname_lb.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname_lb.Location = new System.Drawing.Point(25, 181);
            this.lname_lb.Name = "lname_lb";
            this.lname_lb.Size = new System.Drawing.Size(126, 26);
            this.lname_lb.TabIndex = 33;
            this.lname_lb.Text = "Last name:";
            // 
            // fname_lb
            // 
            this.fname_lb.AutoSize = true;
            this.fname_lb.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname_lb.Location = new System.Drawing.Point(25, 129);
            this.fname_lb.Name = "fname_lb";
            this.fname_lb.Size = new System.Drawing.Size(131, 26);
            this.fname_lb.TabIndex = 32;
            this.fname_lb.Text = "First name:";
            // 
            // ID_lb
            // 
            this.ID_lb.AutoSize = true;
            this.ID_lb.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_lb.Location = new System.Drawing.Point(25, 82);
            this.ID_lb.Name = "ID_lb";
            this.ID_lb.Size = new System.Drawing.Size(131, 26);
            this.ID_lb.TabIndex = 31;
            this.ID_lb.Text = "Student ID:";
            // 
            // lname_txt
            // 
            this.lname_txt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname_txt.Location = new System.Drawing.Point(175, 178);
            this.lname_txt.Multiline = true;
            this.lname_txt.Name = "lname_txt";
            this.lname_txt.Size = new System.Drawing.Size(211, 37);
            this.lname_txt.TabIndex = 30;
            // 
            // fname_txt
            // 
            this.fname_txt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname_txt.Location = new System.Drawing.Point(175, 126);
            this.fname_txt.Name = "fname_txt";
            this.fname_txt.Size = new System.Drawing.Size(211, 34);
            this.fname_txt.TabIndex = 29;
            // 
            // StuID_txt
            // 
            this.StuID_txt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuID_txt.Location = new System.Drawing.Point(175, 74);
            this.StuID_txt.Name = "StuID_txt";
            this.StuID_txt.Size = new System.Drawing.Size(211, 34);
            this.StuID_txt.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 26);
            this.label1.TabIndex = 34;
            this.label1.Text = "Search by ID, Fname, Lname";
            // 
            // searchbar_txt
            // 
            this.searchbar_txt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbar_txt.Location = new System.Drawing.Point(30, 296);
            this.searchbar_txt.Name = "searchbar_txt";
            this.searchbar_txt.Size = new System.Drawing.Size(211, 34);
            this.searchbar_txt.TabIndex = 35;
            // 
            // search_btn
            // 
            this.search_btn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.Location = new System.Drawing.Point(273, 302);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(63, 25);
            this.search_btn.TabIndex = 36;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // showInfo_dgv
            // 
            this.showInfo_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showInfo_dgv.Location = new System.Drawing.Point(442, 82);
            this.showInfo_dgv.Name = "showInfo_dgv";
            this.showInfo_dgv.RowHeadersWidth = 51;
            this.showInfo_dgv.RowTemplate.Height = 24;
            this.showInfo_dgv.Size = new System.Drawing.Size(1007, 260);
            this.showInfo_dgv.TabIndex = 37;
            this.showInfo_dgv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.showInfo_dgv_RowHeaderMouseClick);
            // 
            // studentManageDataSet1
            // 
            this.studentManageDataSet1.DataSetName = "StudentManageDataSet1";
            this.studentManageDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentManageDataSet1BindingSource
            // 
            this.studentManageDataSet1BindingSource.DataSource = this.studentManageDataSet1;
            this.studentManageDataSet1BindingSource.Position = 0;
            // 
            // print_btn
            // 
            this.print_btn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_btn.Location = new System.Drawing.Point(442, 378);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(63, 25);
            this.print_btn.TabIndex = 38;
            this.print_btn.Text = "Print";
            this.print_btn.UseVisualStyleBackColor = true;
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_btn.Location = new System.Drawing.Point(631, 378);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(63, 25);
            this.Cancel_btn.TabIndex = 39;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(380, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 30);
            this.label2.TabIndex = 40;
            this.label2.Text = "Student\'s result";
            // 
            // AVG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.print_btn);
            this.Controls.Add(this.showInfo_dgv);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.searchbar_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lname_lb);
            this.Controls.Add(this.fname_lb);
            this.Controls.Add(this.ID_lb);
            this.Controls.Add(this.lname_txt);
            this.Controls.Add(this.fname_txt);
            this.Controls.Add(this.StuID_txt);
            this.Name = "AVG";
            this.Text = "AVG";
            this.Load += new System.EventHandler(this.AVG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showInfo_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManageDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManageDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lname_lb;
        private System.Windows.Forms.Label fname_lb;
        private System.Windows.Forms.Label ID_lb;
        private System.Windows.Forms.TextBox lname_txt;
        private System.Windows.Forms.TextBox fname_txt;
        private System.Windows.Forms.TextBox StuID_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchbar_txt;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.DataGridView showInfo_dgv;
        private StudentManageDataSet1 studentManageDataSet1;
        private System.Windows.Forms.BindingSource studentManageDataSet1BindingSource;
        private System.Windows.Forms.Button print_btn;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Label label2;
    }
}