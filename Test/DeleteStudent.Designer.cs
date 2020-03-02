namespace Test
{
    partial class DeleteStudent
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
            this.gbDeleteStudent = new System.Windows.Forms.GroupBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.gbDeleteStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDeleteStudent
            // 
            this.gbDeleteStudent.Controls.Add(this.btnReturn);
            this.gbDeleteStudent.Controls.Add(this.btnDelete);
            this.gbDeleteStudent.Controls.Add(this.txtStudentId);
            this.gbDeleteStudent.Controls.Add(this.lblStudentId);
            this.gbDeleteStudent.Location = new System.Drawing.Point(60, 59);
            this.gbDeleteStudent.Name = "gbDeleteStudent";
            this.gbDeleteStudent.Size = new System.Drawing.Size(585, 211);
            this.gbDeleteStudent.TabIndex = 1;
            this.gbDeleteStudent.TabStop = false;
            this.gbDeleteStudent.Text = "Delete Student";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(451, 145);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(90, 33);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(321, 145);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 33);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(315, 79);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(226, 26);
            this.txtStudentId.TabIndex = 1;
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(66, 79);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(131, 20);
            this.lblStudentId.TabIndex = 0;
            this.lblStudentId.Text = "Enter Student Id:";
            // 
            // DeleteStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 326);
            this.Controls.Add(this.gbDeleteStudent);
            this.Name = "DeleteStudent";
            this.Text = "DeleteStudent";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DeleteStudent_FormClosed);
            this.gbDeleteStudent.ResumeLayout(false);
            this.gbDeleteStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDeleteStudent;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label lblStudentId;
    }
}