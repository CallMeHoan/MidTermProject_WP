
namespace MidTermProject
{
    partial class FormStatics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tt_lb = new System.Windows.Forms.Label();
            this.total_lb = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_lb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.fm_lb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.data1_lb = new System.Windows.Forms.Label();
            this.studentDataSet3 = new MidTermProject.StudentManageDataSet1();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new MidTermProject.StudentManageDataSet1TableAdapters.studentTableAdapter();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.viewChart_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.tt_lb);
            this.panel1.Controls.Add(this.total_lb);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 217);
            this.panel1.TabIndex = 3;
            // 
            // tt_lb
            // 
            this.tt_lb.AutoSize = true;
            this.tt_lb.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tt_lb.Location = new System.Drawing.Point(285, 86);
            this.tt_lb.Name = "tt_lb";
            this.tt_lb.Size = new System.Drawing.Size(0, 37);
            this.tt_lb.TabIndex = 7;
            // 
            // total_lb
            // 
            this.total_lb.AutoSize = true;
            this.total_lb.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_lb.Location = new System.Drawing.Point(63, 86);
            this.total_lb.Name = "total_lb";
            this.total_lb.Size = new System.Drawing.Size(212, 37);
            this.total_lb.TabIndex = 6;
            this.total_lb.Text = "Total student:";
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(208, 217);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(180, 209);
            this.panel4.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(180, 217);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(208, 209);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.m_lb);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(11, 228);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 209);
            this.panel2.TabIndex = 4;
            // 
            // m_lb
            // 
            this.m_lb.AutoSize = true;
            this.m_lb.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lb.Location = new System.Drawing.Point(88, 84);
            this.m_lb.Name = "m_lb";
            this.m_lb.Size = new System.Drawing.Size(0, 32);
            this.m_lb.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Male:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 37);
            this.label2.TabIndex = 9;
            this.label2.Text = "Male";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Magenta;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.fm_lb);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(205, 228);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(194, 209);
            this.panel5.TabIndex = 5;
            // 
            // fm_lb
            // 
            this.fm_lb.AutoSize = true;
            this.fm_lb.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fm_lb.Location = new System.Drawing.Point(102, 84);
            this.fm_lb.Name = "fm_lb";
            this.fm_lb.Size = new System.Drawing.Size(0, 32);
            this.fm_lb.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-3, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Female:";
            // 
            // data1_lb
            // 
            this.data1_lb.AutoSize = true;
            this.data1_lb.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data1_lb.Location = new System.Drawing.Point(261, 97);
            this.data1_lb.Name = "data1_lb";
            this.data1_lb.Size = new System.Drawing.Size(0, 37);
            this.data1_lb.TabIndex = 7;
            // 
            // studentDataSet3
            // 
            this.studentDataSet3.DataSetName = "studentDataSet3";
            this.studentDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.studentDataSet3;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(405, 11);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(383, 426);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Pie chart (Gender)";
            this.chart1.Titles.Add(title1);
            // 
            // viewChart_btn
            // 
            this.viewChart_btn.Location = new System.Drawing.Point(652, 390);
            this.viewChart_btn.Name = "viewChart_btn";
            this.viewChart_btn.Size = new System.Drawing.Size(125, 36);
            this.viewChart_btn.TabIndex = 11;
            this.viewChart_btn.Text = "View chart";
            this.viewChart_btn.UseVisualStyleBackColor = true;
            this.viewChart_btn.Click += new System.EventHandler(this.viewChart_btn_Click);
            // 
            // FormStatics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewChart_btn);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.data1_lb);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormStatics";
            this.Text = "FormStatics";
            this.Load += new System.EventHandler(this.FormStatics_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label data1_lb;
        private System.Windows.Forms.Label tt_lb;
        private System.Windows.Forms.Label m_lb;
        private System.Windows.Forms.Label fm_lb;
        private System.Windows.Forms.Label total_lb;
        private StudentManageDataSet1 studentDataSet3;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private StudentManageDataSet1TableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button viewChart_btn;
    }
}