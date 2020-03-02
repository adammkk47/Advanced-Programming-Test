namespace Test
{
    partial class Student
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
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.txtStudentNumber = new System.Windows.Forms.TextBox();
            this.btnXML = new System.Windows.Forms.Button();
            this.dgDatabase = new System.Windows.Forms.DataGridView();
            this.gbStudentMenu = new System.Windows.Forms.GroupBox();
            this.btnStudentExit = new System.Windows.Forms.Button();
            this.btnStudentLogout = new System.Windows.Forms.Button();
            this.gbStudent = new System.Windows.Forms.GroupBox();
            this.btnDatabaseHistory = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnEditStudent = new System.Windows.Forms.Button();
            this.btnNewStudent = new System.Windows.Forms.Button();
            this.gbSaveToXML = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatabase)).BeginInit();
            this.gbStudentMenu.SuspendLayout();
            this.gbStudent.SuspendLayout();
            this.gbSaveToXML.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.Location = new System.Drawing.Point(160, 31);
            this.lblStudentNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(115, 13);
            this.lblStudentNumber.TabIndex = 11;
            this.lblStudentNumber.Text = "Enter Student Number:";
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.Location = new System.Drawing.Point(296, 30);
            this.txtStudentNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new System.Drawing.Size(197, 20);
            this.txtStudentNumber.TabIndex = 10;
            // 
            // btnXML
            // 
            this.btnXML.Location = new System.Drawing.Point(511, 31);
            this.btnXML.Margin = new System.Windows.Forms.Padding(2);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(109, 23);
            this.btnXML.TabIndex = 9;
            this.btnXML.Text = "Save as XML";
            this.btnXML.UseVisualStyleBackColor = true;
            this.btnXML.Click += new System.EventHandler(this.BtnXML_Click);
            // 
            // dgDatabase
            // 
            this.dgDatabase.AllowUserToAddRows = false;
            this.dgDatabase.AllowUserToDeleteRows = false;
            this.dgDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatabase.Location = new System.Drawing.Point(36, 393);
            this.dgDatabase.Margin = new System.Windows.Forms.Padding(2);
            this.dgDatabase.Name = "dgDatabase";
            this.dgDatabase.ReadOnly = true;
            this.dgDatabase.RowHeadersWidth = 62;
            this.dgDatabase.RowTemplate.Height = 28;
            this.dgDatabase.Size = new System.Drawing.Size(649, 129);
            this.dgDatabase.TabIndex = 8;
            // 
            // gbStudentMenu
            // 
            this.gbStudentMenu.Controls.Add(this.btnStudentExit);
            this.gbStudentMenu.Controls.Add(this.btnStudentLogout);
            this.gbStudentMenu.Location = new System.Drawing.Point(91, 30);
            this.gbStudentMenu.Margin = new System.Windows.Forms.Padding(2);
            this.gbStudentMenu.Name = "gbStudentMenu";
            this.gbStudentMenu.Padding = new System.Windows.Forms.Padding(2);
            this.gbStudentMenu.Size = new System.Drawing.Size(533, 61);
            this.gbStudentMenu.TabIndex = 7;
            this.gbStudentMenu.TabStop = false;
            this.gbStudentMenu.Text = "Menu";
            // 
            // btnStudentExit
            // 
            this.btnStudentExit.Location = new System.Drawing.Point(445, 23);
            this.btnStudentExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnStudentExit.Name = "btnStudentExit";
            this.btnStudentExit.Size = new System.Drawing.Size(68, 23);
            this.btnStudentExit.TabIndex = 1;
            this.btnStudentExit.Text = "Exit";
            this.btnStudentExit.UseVisualStyleBackColor = true;
            this.btnStudentExit.Click += new System.EventHandler(this.BtnStudentExit_Click);
            // 
            // btnStudentLogout
            // 
            this.btnStudentLogout.Location = new System.Drawing.Point(358, 23);
            this.btnStudentLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnStudentLogout.Name = "btnStudentLogout";
            this.btnStudentLogout.Size = new System.Drawing.Size(68, 23);
            this.btnStudentLogout.TabIndex = 0;
            this.btnStudentLogout.Text = "Logout";
            this.btnStudentLogout.UseVisualStyleBackColor = true;
            this.btnStudentLogout.Click += new System.EventHandler(this.BtnStudentLogout_Click);
            // 
            // gbStudent
            // 
            this.gbStudent.Controls.Add(this.btnDatabaseHistory);
            this.gbStudent.Controls.Add(this.btnDeleteStudent);
            this.gbStudent.Controls.Add(this.btnEditStudent);
            this.gbStudent.Controls.Add(this.btnNewStudent);
            this.gbStudent.Location = new System.Drawing.Point(91, 95);
            this.gbStudent.Margin = new System.Windows.Forms.Padding(2);
            this.gbStudent.Name = "gbStudent";
            this.gbStudent.Padding = new System.Windows.Forms.Padding(2);
            this.gbStudent.Size = new System.Drawing.Size(533, 191);
            this.gbStudent.TabIndex = 6;
            this.gbStudent.TabStop = false;
            this.gbStudent.Text = "Student";
            // 
            // btnDatabaseHistory
            // 
            this.btnDatabaseHistory.Location = new System.Drawing.Point(188, 138);
            this.btnDatabaseHistory.Margin = new System.Windows.Forms.Padding(2);
            this.btnDatabaseHistory.Name = "btnDatabaseHistory";
            this.btnDatabaseHistory.Size = new System.Drawing.Size(144, 35);
            this.btnDatabaseHistory.TabIndex = 3;
            this.btnDatabaseHistory.Text = "View Database History";
            this.btnDatabaseHistory.UseVisualStyleBackColor = true;
            this.btnDatabaseHistory.Click += new System.EventHandler(this.btnDatabaseHistory_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(188, 101);
            this.btnDeleteStudent.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(144, 22);
            this.btnDeleteStudent.TabIndex = 2;
            this.btnDeleteStudent.Text = "Delete Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnEditStudent
            // 
            this.btnEditStudent.Location = new System.Drawing.Point(195, 62);
            this.btnEditStudent.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.Size = new System.Drawing.Size(129, 25);
            this.btnEditStudent.TabIndex = 1;
            this.btnEditStudent.Text = "Edit Student";
            this.btnEditStudent.UseVisualStyleBackColor = true;
            this.btnEditStudent.Click += new System.EventHandler(this.btnEditStudent_Click);
            // 
            // btnNewStudent
            // 
            this.btnNewStudent.Location = new System.Drawing.Point(195, 25);
            this.btnNewStudent.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewStudent.Name = "btnNewStudent";
            this.btnNewStudent.Size = new System.Drawing.Size(129, 23);
            this.btnNewStudent.TabIndex = 0;
            this.btnNewStudent.Text = "New Student";
            this.btnNewStudent.UseVisualStyleBackColor = true;
            this.btnNewStudent.Click += new System.EventHandler(this.btnNewStudent_Click);
            // 
            // gbSaveToXML
            // 
            this.gbSaveToXML.Controls.Add(this.btnXML);
            this.gbSaveToXML.Controls.Add(this.lblStudentNumber);
            this.gbSaveToXML.Controls.Add(this.txtStudentNumber);
            this.gbSaveToXML.Location = new System.Drawing.Point(36, 304);
            this.gbSaveToXML.Name = "gbSaveToXML";
            this.gbSaveToXML.Size = new System.Drawing.Size(649, 73);
            this.gbSaveToXML.TabIndex = 12;
            this.gbSaveToXML.TabStop = false;
            this.gbSaveToXML.Text = "Save To XML";
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 545);
            this.Controls.Add(this.gbSaveToXML);
            this.Controls.Add(this.dgDatabase);
            this.Controls.Add(this.gbStudentMenu);
            this.Controls.Add(this.gbStudent);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Student";
            this.Text = "Student";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Student_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgDatabase)).EndInit();
            this.gbStudentMenu.ResumeLayout(false);
            this.gbStudent.ResumeLayout(false);
            this.gbSaveToXML.ResumeLayout(false);
            this.gbSaveToXML.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.Button btnXML;
        private System.Windows.Forms.DataGridView dgDatabase;
        private System.Windows.Forms.GroupBox gbStudentMenu;
        private System.Windows.Forms.Button btnStudentExit;
        private System.Windows.Forms.Button btnStudentLogout;
        private System.Windows.Forms.GroupBox gbStudent;
        private System.Windows.Forms.Button btnDatabaseHistory;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnEditStudent;
        private System.Windows.Forms.Button btnNewStudent;
        private System.Windows.Forms.GroupBox gbSaveToXML;
    }
}