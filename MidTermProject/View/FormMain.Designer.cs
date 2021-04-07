
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
            this.searchStuToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.printStu_ToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.staticToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.manageStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOURSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sCOREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.searchStuToolStrip,
            this.printStu_ToolStrip,
            this.staticToolStrip,
            this.manageStudentToolStripMenuItem});
            this.StudentToolStrip.Name = "StudentToolStrip";
            this.StudentToolStrip.Size = new System.Drawing.Size(87, 24);
            this.StudentToolStrip.Text = "STUDENT";
            // 
            // AddStuToolStrip
            // 
            this.AddStuToolStrip.Name = "AddStuToolStrip";
            this.AddStuToolStrip.Size = new System.Drawing.Size(201, 26);
            this.AddStuToolStrip.Text = "Add Student";
            this.AddStuToolStrip.Click += new System.EventHandler(this.AddStuToolStrip_Click);
            // 
            // ListStuToolStrip
            // 
            this.ListStuToolStrip.Name = "ListStuToolStrip";
            this.ListStuToolStrip.Size = new System.Drawing.Size(201, 26);
            this.ListStuToolStrip.Text = "List Student";
            this.ListStuToolStrip.Click += new System.EventHandler(this.ListStuToolStrip_Click);
            // 
            // searchStuToolStrip
            // 
            this.searchStuToolStrip.Name = "searchStuToolStrip";
            this.searchStuToolStrip.Size = new System.Drawing.Size(201, 26);
            this.searchStuToolStrip.Text = "Search Student";
            this.searchStuToolStrip.Click += new System.EventHandler(this.searchStuToolStrip_Click);
            // 
            // printStu_ToolStrip
            // 
            this.printStu_ToolStrip.Name = "printStu_ToolStrip";
            this.printStu_ToolStrip.Size = new System.Drawing.Size(201, 26);
            this.printStu_ToolStrip.Text = "Print Student";
            this.printStu_ToolStrip.Click += new System.EventHandler(this.printStu_ToolStrip_Click);
            // 
            // staticToolStrip
            // 
            this.staticToolStrip.Name = "staticToolStrip";
            this.staticToolStrip.Size = new System.Drawing.Size(201, 26);
            this.staticToolStrip.Text = "Statics";
            this.staticToolStrip.Click += new System.EventHandler(this.staticToolStrip_Click);
            // 
            // manageStudentToolStripMenuItem
            // 
            this.manageStudentToolStripMenuItem.Name = "manageStudentToolStripMenuItem";
            this.manageStudentToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.manageStudentToolStripMenuItem.Text = "Manage Student";
            this.manageStudentToolStripMenuItem.Click += new System.EventHandler(this.manageStudentToolStripMenuItem_Click);
            // 
            // cOURSEToolStripMenuItem
            // 
            this.cOURSEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCourseToolStripMenuItem,
            this.editCourseToolStripMenuItem,
            this.manageCourseToolStripMenuItem,
            this.removeCourseToolStripMenuItem,
            this.printCourseToolStripMenuItem});
            this.cOURSEToolStripMenuItem.Name = "cOURSEToolStripMenuItem";
            this.cOURSEToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.cOURSEToolStripMenuItem.Text = "COURSE";
            // 
            // sCOREToolStripMenuItem
            // 
            this.sCOREToolStripMenuItem.Name = "sCOREToolStripMenuItem";
            this.sCOREToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.sCOREToolStripMenuItem.Text = "SCORE";
            // 
            // addCourseToolStripMenuItem
            // 
            this.addCourseToolStripMenuItem.Name = "addCourseToolStripMenuItem";
            this.addCourseToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addCourseToolStripMenuItem.Text = "Add Course";
            this.addCourseToolStripMenuItem.Click += new System.EventHandler(this.addCourseToolStripMenuItem_Click);
            // 
            // editCourseToolStripMenuItem
            // 
            this.editCourseToolStripMenuItem.Name = "editCourseToolStripMenuItem";
            this.editCourseToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editCourseToolStripMenuItem.Text = "Edit Course";
            this.editCourseToolStripMenuItem.Click += new System.EventHandler(this.editCourseToolStripMenuItem_Click);
            // 
            // manageCourseToolStripMenuItem
            // 
            this.manageCourseToolStripMenuItem.Name = "manageCourseToolStripMenuItem";
            this.manageCourseToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.manageCourseToolStripMenuItem.Text = "Manage Course";
            this.manageCourseToolStripMenuItem.Click += new System.EventHandler(this.manageCourseToolStripMenuItem_Click);
            // 
            // removeCourseToolStripMenuItem
            // 
            this.removeCourseToolStripMenuItem.Name = "removeCourseToolStripMenuItem";
            this.removeCourseToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.removeCourseToolStripMenuItem.Text = "Remove Course";
            this.removeCourseToolStripMenuItem.Click += new System.EventHandler(this.removeCourseToolStripMenuItem_Click);
            // 
            // printCourseToolStripMenuItem
            // 
            this.printCourseToolStripMenuItem.Name = "printCourseToolStripMenuItem";
            this.printCourseToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.printCourseToolStripMenuItem.Text = "Print Course";
            this.printCourseToolStripMenuItem.Click += new System.EventHandler(this.printCourseToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem printStu_ToolStrip;
        private System.Windows.Forms.ToolStripMenuItem staticToolStrip;
        private System.Windows.Forms.ToolStripMenuItem manageStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printCourseToolStripMenuItem;
    }
}