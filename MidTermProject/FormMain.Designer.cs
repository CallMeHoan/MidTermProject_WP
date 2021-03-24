
namespace MidTermProject
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.StudentToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.AddStuToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ListStuToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.cOURSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sCOREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchStuToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StudentToolStrip,
            this.cOURSEToolStripMenuItem,
            this.sCOREToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // StudentToolStrip
            // 
            this.StudentToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddStuToolStrip,
            this.ListStuToolStrip,
            this.searchStuToolStrip});
            this.StudentToolStrip.Name = "StudentToolStrip";
            this.StudentToolStrip.Size = new System.Drawing.Size(87, 24);
            this.StudentToolStrip.Text = "STUDENT";
            // 
            // AddStuToolStrip
            // 
            this.AddStuToolStrip.Name = "AddStuToolStrip";
            this.AddStuToolStrip.Size = new System.Drawing.Size(224, 26);
            this.AddStuToolStrip.Text = "Add Student";
            this.AddStuToolStrip.Click += new System.EventHandler(this.AddStuToolStrip_Click);
            // 
            // ListStuToolStrip
            // 
            this.ListStuToolStrip.Name = "ListStuToolStrip";
            this.ListStuToolStrip.Size = new System.Drawing.Size(224, 26);
            this.ListStuToolStrip.Text = "List Student";
            this.ListStuToolStrip.Click += new System.EventHandler(this.ListStuToolStrip_Click);
            // 
            // cOURSEToolStripMenuItem
            // 
            this.cOURSEToolStripMenuItem.Name = "cOURSEToolStripMenuItem";
            this.cOURSEToolStripMenuItem.Size = new System.Drawing.Size(78, 26);
            this.cOURSEToolStripMenuItem.Text = "COURSE";
            // 
            // sCOREToolStripMenuItem
            // 
            this.sCOREToolStripMenuItem.Name = "sCOREToolStripMenuItem";
            this.sCOREToolStripMenuItem.Size = new System.Drawing.Size(68, 26);
            this.sCOREToolStripMenuItem.Text = "SCORE";
            // 
            // searchStuToolStrip
            // 
            this.searchStuToolStrip.Name = "searchStuToolStrip";
            this.searchStuToolStrip.Size = new System.Drawing.Size(224, 26);
            this.searchStuToolStrip.Text = "Search Student";
            this.searchStuToolStrip.Click += new System.EventHandler(this.searchStuToolStrip_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem StudentToolStrip;
        private System.Windows.Forms.ToolStripMenuItem AddStuToolStrip;
        private System.Windows.Forms.ToolStripMenuItem ListStuToolStrip;
        private System.Windows.Forms.ToolStripMenuItem cOURSEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sCOREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchStuToolStrip;
    }
}