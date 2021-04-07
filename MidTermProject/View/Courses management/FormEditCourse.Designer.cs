
namespace MidTermProject
{
    partial class FormEditCourse
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
            this.edit_btn = new System.Windows.Forms.Button();
            this.description_lb = new System.Windows.Forms.Label();
            this.period_lb = new System.Windows.Forms.Label();
            this.name_lb = new System.Windows.Forms.Label();
            this.ID_lb = new System.Windows.Forms.Label();
            this.descript_txt = new System.Windows.Forms.TextBox();
            this.cName_txt = new System.Windows.Forms.TextBox();
            this.ID_cb = new System.Windows.Forms.ComboBox();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesDataSet = new MidTermProject.coursesDataSet();
            this.period_nud = new System.Windows.Forms.NumericUpDown();
            this.coursesTableAdapter = new MidTermProject.coursesDataSetTableAdapters.coursesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.period_nud)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel_btn
            // 
            this.cancel_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.Location = new System.Drawing.Point(269, 295);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(140, 38);
            this.cancel_btn.TabIndex = 19;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.Location = new System.Drawing.Point(97, 295);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(140, 38);
            this.edit_btn.TabIndex = 18;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // description_lb
            // 
            this.description_lb.AutoSize = true;
            this.description_lb.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_lb.Location = new System.Drawing.Point(79, 179);
            this.description_lb.Name = "description_lb";
            this.description_lb.Size = new System.Drawing.Size(139, 26);
            this.description_lb.TabIndex = 17;
            this.description_lb.Text = "Description:";
            // 
            // period_lb
            // 
            this.period_lb.AutoSize = true;
            this.period_lb.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period_lb.Location = new System.Drawing.Point(129, 132);
            this.period_lb.Name = "period_lb";
            this.period_lb.Size = new System.Drawing.Size(89, 26);
            this.period_lb.TabIndex = 16;
            this.period_lb.Text = "Period:";
            // 
            // name_lb
            // 
            this.name_lb.AutoSize = true;
            this.name_lb.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lb.Location = new System.Drawing.Point(60, 81);
            this.name_lb.Name = "name_lb";
            this.name_lb.Size = new System.Drawing.Size(158, 26);
            this.name_lb.TabIndex = 15;
            this.name_lb.Text = "Course Name:";
            // 
            // ID_lb
            // 
            this.ID_lb.AutoSize = true;
            this.ID_lb.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_lb.Location = new System.Drawing.Point(32, 27);
            this.ID_lb.Name = "ID_lb";
            this.ID_lb.Size = new System.Drawing.Size(186, 26);
            this.ID_lb.TabIndex = 14;
            this.ID_lb.Text = "Select course ID:";
            // 
            // descript_txt
            // 
            this.descript_txt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descript_txt.Location = new System.Drawing.Point(250, 179);
            this.descript_txt.Multiline = true;
            this.descript_txt.Name = "descript_txt";
            this.descript_txt.Size = new System.Drawing.Size(211, 66);
            this.descript_txt.TabIndex = 13;
            // 
            // cName_txt
            // 
            this.cName_txt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cName_txt.Location = new System.Drawing.Point(250, 73);
            this.cName_txt.Name = "cName_txt";
            this.cName_txt.Size = new System.Drawing.Size(211, 34);
            this.cName_txt.TabIndex = 11;
            // 
            // ID_cb
            // 
            this.ID_cb.DataSource = this.coursesBindingSource;
            this.ID_cb.DisplayMember = "CourseID";
            this.ID_cb.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_cb.FormattingEnabled = true;
            this.ID_cb.Location = new System.Drawing.Point(250, 19);
            this.ID_cb.Name = "ID_cb";
            this.ID_cb.Size = new System.Drawing.Size(211, 34);
            this.ID_cb.TabIndex = 20;
            this.ID_cb.ValueMember = "CourseID";
            this.ID_cb.SelectedValueChanged += new System.EventHandler(this.ID_cb_SelectedValueChanged);
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "courses";
            this.coursesBindingSource.DataSource = this.coursesDataSet;
            // 
            // coursesDataSet
            // 
            this.coursesDataSet.DataSetName = "coursesDataSet";
            this.coursesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // period_nud
            // 
            this.period_nud.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period_nud.Location = new System.Drawing.Point(250, 124);
            this.period_nud.Name = "period_nud";
            this.period_nud.Size = new System.Drawing.Size(211, 34);
            this.period_nud.TabIndex = 21;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // FormEditCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 357);
            this.Controls.Add(this.period_nud);
            this.Controls.Add(this.ID_cb);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.description_lb);
            this.Controls.Add(this.period_lb);
            this.Controls.Add(this.name_lb);
            this.Controls.Add(this.ID_lb);
            this.Controls.Add(this.descript_txt);
            this.Controls.Add(this.cName_txt);
            this.Name = "FormEditCourse";
            this.Text = "FormEditCourse";
            this.Load += new System.EventHandler(this.FormEditCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.period_nud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Label description_lb;
        private System.Windows.Forms.Label period_lb;
        private System.Windows.Forms.Label name_lb;
        private System.Windows.Forms.Label ID_lb;
        private System.Windows.Forms.TextBox descript_txt;
        private System.Windows.Forms.TextBox cName_txt;
        private System.Windows.Forms.ComboBox ID_cb;
        private System.Windows.Forms.NumericUpDown period_nud;
        private coursesDataSet coursesDataSet;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private coursesDataSetTableAdapters.coursesTableAdapter coursesTableAdapter;
    }
}