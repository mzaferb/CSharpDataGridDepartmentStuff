namespace StaffSaitOrhan
{
    partial class FormStuffs
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tcno_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dep_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 46);
            this.panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(174, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 33);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(93, 7);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 33);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 33);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_c,
            this.Name_c,
            this.Surname_c,
            this.BirthDate_c,
            this.Gender_c,
            this.Tcno_c,
            this.dep_c});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(861, 404);
            this.dataGridView1.TabIndex = 1;
            // 
            // Id_c
            // 
            this.Id_c.HeaderText = "Id";
            this.Id_c.MinimumWidth = 6;
            this.Id_c.Name = "Id_c";
            this.Id_c.ReadOnly = true;
            this.Id_c.Visible = false;
            // 
            // Name_c
            // 
            this.Name_c.HeaderText = "Name";
            this.Name_c.MinimumWidth = 6;
            this.Name_c.Name = "Name_c";
            this.Name_c.ReadOnly = true;
            // 
            // Surname_c
            // 
            this.Surname_c.HeaderText = "Surname";
            this.Surname_c.MinimumWidth = 6;
            this.Surname_c.Name = "Surname_c";
            this.Surname_c.ReadOnly = true;
            // 
            // BirthDate_c
            // 
            this.BirthDate_c.HeaderText = "Birth Date";
            this.BirthDate_c.MinimumWidth = 6;
            this.BirthDate_c.Name = "BirthDate_c";
            this.BirthDate_c.ReadOnly = true;
            // 
            // Gender_c
            // 
            this.Gender_c.HeaderText = "Gender";
            this.Gender_c.MinimumWidth = 6;
            this.Gender_c.Name = "Gender_c";
            this.Gender_c.ReadOnly = true;
            // 
            // Tcno_c
            // 
            this.Tcno_c.HeaderText = "TC No";
            this.Tcno_c.MinimumWidth = 6;
            this.Tcno_c.Name = "Tcno_c";
            this.Tcno_c.ReadOnly = true;
            // 
            // dep_c
            // 
            this.dep_c.HeaderText = "Department";
            this.dep_c.MinimumWidth = 6;
            this.dep_c.Name = "dep_c";
            this.dep_c.ReadOnly = true;
            // 
            // FormStuffs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FormStuffs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stuffs";
            this.Load += new System.EventHandler(this.Departments_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tcno_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn dep_c;
    }
}