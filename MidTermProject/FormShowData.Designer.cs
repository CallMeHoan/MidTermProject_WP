
namespace MidTermProject
{
    partial class FormShowData
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
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSet = new MidTermProject.studentDataSet();
            this.studentTableAdapter = new MidTermProject.studentDataSetTableAdapters.studentTableAdapter();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.fNameColumn,
            this.lNameColumn,
            this.dobColumn,
            this.genderColumn,
            this.phoneColumn,
            this.addressColumn,
            this.picColumn});
            this.dataGridView1.DataSource = this.studentBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1017, 450);
            this.dataGridView1.TabIndex = 1;
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "student";
            this.studentBindingSource1.DataSource = this.studentDataSet;
            // 
            // studentDataSet
            // 
            this.studentDataSet.DataSetName = "studentDataSet";
            this.studentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // idColumn
            // 
            this.idColumn.DataPropertyName = "StudentID";
            this.idColumn.HeaderText = "ID";
            this.idColumn.MinimumWidth = 6;
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Width = 50;
            // 
            // fNameColumn
            // 
            this.fNameColumn.DataPropertyName = "FirstName";
            this.fNameColumn.HeaderText = "First Name";
            this.fNameColumn.MinimumWidth = 6;
            this.fNameColumn.Name = "fNameColumn";
            this.fNameColumn.ReadOnly = true;
            this.fNameColumn.Width = 125;
            // 
            // lNameColumn
            // 
            this.lNameColumn.DataPropertyName = "LastName";
            this.lNameColumn.HeaderText = "Last Name";
            this.lNameColumn.MinimumWidth = 6;
            this.lNameColumn.Name = "lNameColumn";
            this.lNameColumn.ReadOnly = true;
            this.lNameColumn.Width = 125;
            // 
            // dobColumn
            // 
            this.dobColumn.DataPropertyName = "DateOfBirth";
            this.dobColumn.HeaderText = "Date of birth";
            this.dobColumn.MinimumWidth = 6;
            this.dobColumn.Name = "dobColumn";
            this.dobColumn.ReadOnly = true;
            this.dobColumn.Width = 125;
            // 
            // genderColumn
            // 
            this.genderColumn.DataPropertyName = "Gender";
            this.genderColumn.HeaderText = "Gender";
            this.genderColumn.MinimumWidth = 6;
            this.genderColumn.Name = "genderColumn";
            this.genderColumn.ReadOnly = true;
            this.genderColumn.Width = 75;
            // 
            // phoneColumn
            // 
            this.phoneColumn.DataPropertyName = "PhoneNumber";
            this.phoneColumn.HeaderText = "Phone number";
            this.phoneColumn.MinimumWidth = 6;
            this.phoneColumn.Name = "phoneColumn";
            this.phoneColumn.ReadOnly = true;
            this.phoneColumn.Width = 130;
            // 
            // addressColumn
            // 
            this.addressColumn.DataPropertyName = "Address";
            this.addressColumn.HeaderText = "Address";
            this.addressColumn.MinimumWidth = 6;
            this.addressColumn.Name = "addressColumn";
            this.addressColumn.ReadOnly = true;
            this.addressColumn.Width = 125;
            // 
            // picColumn
            // 
            this.picColumn.DataPropertyName = "Picture";
            this.picColumn.HeaderText = "Picture";
            this.picColumn.MinimumWidth = 6;
            this.picColumn.Name = "picColumn";
            this.picColumn.ReadOnly = true;
            this.picColumn.Width = 125;
            // 
            // FormShowData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormShowData";
            this.Text = "FormShowData";
            this.Load += new System.EventHandler(this.FormShowData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private studentDataSet studentDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private studentDataSetTableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressColumn;
        private System.Windows.Forms.DataGridViewImageColumn picColumn;
    }
}