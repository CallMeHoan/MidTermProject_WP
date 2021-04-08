
namespace MidTermProject
{
    partial class FormRemoveScore
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
            this.showInfo_dgv = new System.Windows.Forms.DataGridView();
            this.remove_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.showInfo_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // showInfo_dgv
            // 
            this.showInfo_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showInfo_dgv.Location = new System.Drawing.Point(17, 13);
            this.showInfo_dgv.Name = "showInfo_dgv";
            this.showInfo_dgv.RowHeadersWidth = 51;
            this.showInfo_dgv.RowTemplate.Height = 24;
            this.showInfo_dgv.Size = new System.Drawing.Size(872, 496);
            this.showInfo_dgv.TabIndex = 0;
            // 
            // remove_btn
            // 
            this.remove_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_btn.Location = new System.Drawing.Point(235, 525);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(94, 34);
            this.remove_btn.TabIndex = 1;
            this.remove_btn.Text = "Remove";
            this.remove_btn.UseVisualStyleBackColor = true;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.Location = new System.Drawing.Point(552, 525);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(94, 34);
            this.cancel_btn.TabIndex = 2;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // FormRemoveScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 571);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.showInfo_dgv);
            this.Name = "FormRemoveScore";
            this.Text = "FormRemoveScore";
            this.Load += new System.EventHandler(this.FormRemoveScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showInfo_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView showInfo_dgv;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Button cancel_btn;
    }
}