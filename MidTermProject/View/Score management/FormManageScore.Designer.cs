
namespace MidTermProject
{
    partial class FormManageScore
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
            this.course_cb = new System.Windows.Forms.ComboBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.description_lb = new System.Windows.Forms.Label();
            this.period_lb = new System.Windows.Forms.Label();
            this.name_lb = new System.Windows.Forms.Label();
            this.ID_lb = new System.Windows.Forms.Label();
            this.descript_txt = new System.Windows.Forms.TextBox();
            this.score_txt = new System.Windows.Forms.TextBox();
            this.StuID_txt = new System.Windows.Forms.TextBox();
            this.showInfo_dgv = new System.Windows.Forms.DataGridView();
            this.showStu_btn = new System.Windows.Forms.Button();
            this.showSco_btn = new System.Windows.Forms.Button();
            this.remove_btn = new System.Windows.Forms.Button();
            this.showAvg_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.studentManageDataSet1 = new MidTermProject.StudentManageDataSet1();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesTableAdapter = new MidTermProject.StudentManageDataSet1TableAdapters.coursesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.showInfo_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManageDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // course_cb
            // 
            this.course_cb.DataSource = this.coursesBindingSource;
            this.course_cb.DisplayMember = "Label";
            this.course_cb.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_cb.FormattingEnabled = true;
            this.course_cb.Location = new System.Drawing.Point(184, 116);
            this.course_cb.Name = "course_cb";
            this.course_cb.Size = new System.Drawing.Size(211, 34);
            this.course_cb.TabIndex = 29;
            this.course_cb.ValueMember = "CourseID";
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(36, 322);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(112, 38);
            this.add_btn.TabIndex = 28;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // description_lb
            // 
            this.description_lb.AutoSize = true;
            this.description_lb.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_lb.Location = new System.Drawing.Point(26, 222);
            this.description_lb.Name = "description_lb";
            this.description_lb.Size = new System.Drawing.Size(139, 26);
            this.description_lb.TabIndex = 27;
            this.description_lb.Text = "Description:";
            // 
            // period_lb
            // 
            this.period_lb.AutoSize = true;
            this.period_lb.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period_lb.Location = new System.Drawing.Point(87, 175);
            this.period_lb.Name = "period_lb";
            this.period_lb.Size = new System.Drawing.Size(78, 26);
            this.period_lb.TabIndex = 26;
            this.period_lb.Text = "Score:";
            // 
            // name_lb
            // 
            this.name_lb.AutoSize = true;
            this.name_lb.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lb.Location = new System.Drawing.Point(5, 124);
            this.name_lb.Name = "name_lb";
            this.name_lb.Size = new System.Drawing.Size(160, 26);
            this.name_lb.TabIndex = 25;
            this.name_lb.Text = "Select Course:";
            // 
            // ID_lb
            // 
            this.ID_lb.AutoSize = true;
            this.ID_lb.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_lb.Location = new System.Drawing.Point(34, 70);
            this.ID_lb.Name = "ID_lb";
            this.ID_lb.Size = new System.Drawing.Size(131, 26);
            this.ID_lb.TabIndex = 24;
            this.ID_lb.Text = "Student ID:";
            // 
            // descript_txt
            // 
            this.descript_txt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descript_txt.Location = new System.Drawing.Point(184, 222);
            this.descript_txt.Multiline = true;
            this.descript_txt.Name = "descript_txt";
            this.descript_txt.Size = new System.Drawing.Size(211, 66);
            this.descript_txt.TabIndex = 23;
            // 
            // score_txt
            // 
            this.score_txt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_txt.Location = new System.Drawing.Point(184, 167);
            this.score_txt.Name = "score_txt";
            this.score_txt.Size = new System.Drawing.Size(211, 34);
            this.score_txt.TabIndex = 22;
            // 
            // StuID_txt
            // 
            this.StuID_txt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuID_txt.Location = new System.Drawing.Point(184, 62);
            this.StuID_txt.Name = "StuID_txt";
            this.StuID_txt.Size = new System.Drawing.Size(211, 34);
            this.StuID_txt.TabIndex = 21;
            // 
            // showInfo_dgv
            // 
            this.showInfo_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showInfo_dgv.Location = new System.Drawing.Point(430, 116);
            this.showInfo_dgv.Name = "showInfo_dgv";
            this.showInfo_dgv.RowHeadersWidth = 51;
            this.showInfo_dgv.RowTemplate.Height = 24;
            this.showInfo_dgv.Size = new System.Drawing.Size(876, 244);
            this.showInfo_dgv.TabIndex = 30;
            this.showInfo_dgv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.showInfo_dgv_RowHeaderMouseClick);
            // 
            // showStu_btn
            // 
            this.showStu_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showStu_btn.Location = new System.Drawing.Point(581, 58);
            this.showStu_btn.Name = "showStu_btn";
            this.showStu_btn.Size = new System.Drawing.Size(261, 38);
            this.showStu_btn.TabIndex = 31;
            this.showStu_btn.Text = "Show Student";
            this.showStu_btn.UseVisualStyleBackColor = true;
            this.showStu_btn.Click += new System.EventHandler(this.showStu_btn_Click);
            // 
            // showSco_btn
            // 
            this.showSco_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showSco_btn.Location = new System.Drawing.Point(900, 60);
            this.showSco_btn.Name = "showSco_btn";
            this.showSco_btn.Size = new System.Drawing.Size(262, 38);
            this.showSco_btn.TabIndex = 32;
            this.showSco_btn.Text = "Show Score";
            this.showSco_btn.UseVisualStyleBackColor = true;
            this.showSco_btn.Click += new System.EventHandler(this.showSco_btn_Click);
            // 
            // remove_btn
            // 
            this.remove_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_btn.Location = new System.Drawing.Point(272, 322);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(112, 38);
            this.remove_btn.TabIndex = 33;
            this.remove_btn.Text = "Remove";
            this.remove_btn.UseVisualStyleBackColor = true;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // showAvg_btn
            // 
            this.showAvg_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAvg_btn.Location = new System.Drawing.Point(51, 385);
            this.showAvg_btn.Name = "showAvg_btn";
            this.showAvg_btn.Size = new System.Drawing.Size(312, 38);
            this.showAvg_btn.TabIndex = 34;
            this.showAvg_btn.Text = "AVG Score By Course";
            this.showAvg_btn.UseVisualStyleBackColor = true;
            this.showAvg_btn.Click += new System.EventHandler(this.showAvg_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.Location = new System.Drawing.Point(1161, 385);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(145, 38);
            this.cancel_btn.TabIndex = 35;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.Location = new System.Drawing.Point(154, 322);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(112, 38);
            this.edit_btn.TabIndex = 36;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
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
            // FormManageScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 434);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.showAvg_btn);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.showSco_btn);
            this.Controls.Add(this.showStu_btn);
            this.Controls.Add(this.showInfo_dgv);
            this.Controls.Add(this.course_cb);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.description_lb);
            this.Controls.Add(this.period_lb);
            this.Controls.Add(this.name_lb);
            this.Controls.Add(this.ID_lb);
            this.Controls.Add(this.descript_txt);
            this.Controls.Add(this.score_txt);
            this.Controls.Add(this.StuID_txt);
            this.Name = "FormManageScore";
            this.Text = "FormManageScore";
            this.Load += new System.EventHandler(this.FormManageScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showInfo_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManageDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox course_cb;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label description_lb;
        private System.Windows.Forms.Label period_lb;
        private System.Windows.Forms.Label name_lb;
        private System.Windows.Forms.Label ID_lb;
        private System.Windows.Forms.TextBox descript_txt;
        private System.Windows.Forms.TextBox score_txt;
        private System.Windows.Forms.TextBox StuID_txt;
        private System.Windows.Forms.DataGridView showInfo_dgv;
        private System.Windows.Forms.Button showStu_btn;
        private System.Windows.Forms.Button showSco_btn;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Button showAvg_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button edit_btn;
        private StudentManageDataSet1 studentManageDataSet1;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private StudentManageDataSet1TableAdapters.coursesTableAdapter coursesTableAdapter;
    }
}