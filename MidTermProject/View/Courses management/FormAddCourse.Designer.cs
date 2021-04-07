
namespace MidTermProject
{
    partial class FormAddCourse
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
            this.cid_txt = new System.Windows.Forms.TextBox();
            this.cName_txt = new System.Windows.Forms.TextBox();
            this.period_txt = new System.Windows.Forms.TextBox();
            this.descript_txt = new System.Windows.Forms.TextBox();
            this.ID_lb = new System.Windows.Forms.Label();
            this.name_lb = new System.Windows.Forms.Label();
            this.period_lb = new System.Windows.Forms.Label();
            this.description_lb = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cid_txt
            // 
            this.cid_txt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cid_txt.Location = new System.Drawing.Point(269, 32);
            this.cid_txt.Name = "cid_txt";
            this.cid_txt.Size = new System.Drawing.Size(211, 34);
            this.cid_txt.TabIndex = 0;
            // 
            // cName_txt
            // 
            this.cName_txt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cName_txt.Location = new System.Drawing.Point(269, 86);
            this.cName_txt.Name = "cName_txt";
            this.cName_txt.Size = new System.Drawing.Size(211, 34);
            this.cName_txt.TabIndex = 1;
            // 
            // period_txt
            // 
            this.period_txt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period_txt.Location = new System.Drawing.Point(269, 137);
            this.period_txt.Name = "period_txt";
            this.period_txt.Size = new System.Drawing.Size(211, 34);
            this.period_txt.TabIndex = 2;
            // 
            // descript_txt
            // 
            this.descript_txt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descript_txt.Location = new System.Drawing.Point(269, 192);
            this.descript_txt.Multiline = true;
            this.descript_txt.Name = "descript_txt";
            this.descript_txt.Size = new System.Drawing.Size(211, 66);
            this.descript_txt.TabIndex = 3;
            // 
            // ID_lb
            // 
            this.ID_lb.AutoSize = true;
            this.ID_lb.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_lb.Location = new System.Drawing.Point(112, 40);
            this.ID_lb.Name = "ID_lb";
            this.ID_lb.Size = new System.Drawing.Size(125, 26);
            this.ID_lb.TabIndex = 4;
            this.ID_lb.Text = "Course ID:";
            // 
            // name_lb
            // 
            this.name_lb.AutoSize = true;
            this.name_lb.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lb.Location = new System.Drawing.Point(79, 94);
            this.name_lb.Name = "name_lb";
            this.name_lb.Size = new System.Drawing.Size(158, 26);
            this.name_lb.TabIndex = 5;
            this.name_lb.Text = "Course Name:";
            // 
            // period_lb
            // 
            this.period_lb.AutoSize = true;
            this.period_lb.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period_lb.Location = new System.Drawing.Point(148, 145);
            this.period_lb.Name = "period_lb";
            this.period_lb.Size = new System.Drawing.Size(89, 26);
            this.period_lb.TabIndex = 6;
            this.period_lb.Text = "Period:";
            // 
            // description_lb
            // 
            this.description_lb.AutoSize = true;
            this.description_lb.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_lb.Location = new System.Drawing.Point(98, 192);
            this.description_lb.Name = "description_lb";
            this.description_lb.Size = new System.Drawing.Size(139, 26);
            this.description_lb.TabIndex = 7;
            this.description_lb.Text = "Description:";
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(125, 308);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(140, 38);
            this.add_btn.TabIndex = 8;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.Location = new System.Drawing.Point(297, 308);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(140, 38);
            this.cancel_btn.TabIndex = 9;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // FormAddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 403);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.description_lb);
            this.Controls.Add(this.period_lb);
            this.Controls.Add(this.name_lb);
            this.Controls.Add(this.ID_lb);
            this.Controls.Add(this.descript_txt);
            this.Controls.Add(this.period_txt);
            this.Controls.Add(this.cName_txt);
            this.Controls.Add(this.cid_txt);
            this.Name = "FormAddCourse";
            this.Text = "FormAddCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ID_lb;
        private System.Windows.Forms.Label name_lb;
        private System.Windows.Forms.Label period_lb;
        private System.Windows.Forms.Label description_lb;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.TextBox cid_txt;
        private System.Windows.Forms.TextBox cName_txt;
        private System.Windows.Forms.TextBox period_txt;
        private System.Windows.Forms.TextBox descript_txt;
    }
}