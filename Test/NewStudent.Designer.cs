namespace Test
{
    partial class NewStudent
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
            this.gbNewStudent = new System.Windows.Forms.GroupBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cbCourse = new System.Windows.Forms.ComboBox();
            this.cbCounty = new System.Windows.Forms.ComboBox();
            this.rbUndergrad = new System.Windows.Forms.RadioButton();
            this.rbPostgrad = new System.Windows.Forms.RadioButton();
            this.txtStudentNumber = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.epStudentId = new System.Windows.Forms.ErrorProvider(this.components);
            this.epFirstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSurname = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCounty = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCourse = new System.Windows.Forms.ErrorProvider(this.components);
            this.epEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.epAddressLine1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.epAddressLine2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCity = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbNewStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epStudentId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSurname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCounty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAddressLine1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAddressLine2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCity)).BeginInit();
            this.SuspendLayout();
            // 
            // gbNewStudent
            // 
            this.gbNewStudent.Controls.Add(this.btnReturn);
            this.gbNewStudent.Controls.Add(this.btnSubmit);
            this.gbNewStudent.Controls.Add(this.cbCourse);
            this.gbNewStudent.Controls.Add(this.cbCounty);
            this.gbNewStudent.Controls.Add(this.rbUndergrad);
            this.gbNewStudent.Controls.Add(this.rbPostgrad);
            this.gbNewStudent.Controls.Add(this.txtStudentNumber);
            this.gbNewStudent.Controls.Add(this.txtCity);
            this.gbNewStudent.Controls.Add(this.txtAddress2);
            this.gbNewStudent.Controls.Add(this.txtAddress1);
            this.gbNewStudent.Controls.Add(this.txtPhone);
            this.gbNewStudent.Controls.Add(this.txtEmail);
            this.gbNewStudent.Controls.Add(this.txtSurname);
            this.gbNewStudent.Controls.Add(this.txtFirstName);
            this.gbNewStudent.Controls.Add(this.lblStudentNumber);
            this.gbNewStudent.Controls.Add(this.lblCourse);
            this.gbNewStudent.Controls.Add(this.lblLevel);
            this.gbNewStudent.Controls.Add(this.lblCounty);
            this.gbNewStudent.Controls.Add(this.lblCity);
            this.gbNewStudent.Controls.Add(this.lblAddress2);
            this.gbNewStudent.Controls.Add(this.lblAddress1);
            this.gbNewStudent.Controls.Add(this.lblPhone);
            this.gbNewStudent.Controls.Add(this.lblEmail);
            this.gbNewStudent.Controls.Add(this.lblSurname);
            this.gbNewStudent.Controls.Add(this.lblFirstName);
            this.gbNewStudent.Location = new System.Drawing.Point(55, 44);
            this.gbNewStudent.Name = "gbNewStudent";
            this.gbNewStudent.Size = new System.Drawing.Size(947, 701);
            this.gbNewStudent.TabIndex = 1;
            this.gbNewStudent.TabStop = false;
            this.gbNewStudent.Text = "New Student";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(672, 619);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(112, 35);
            this.btnReturn.TabIndex = 27;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(509, 619);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(112, 35);
            this.btnSubmit.TabIndex = 26;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cbCourse
            // 
            this.cbCourse.FormattingEnabled = true;
            this.cbCourse.Items.AddRange(new object[] {
            "Computing",
            "Arts",
            "Buisness",
            "Economics",
            "Law"});
            this.cbCourse.Location = new System.Drawing.Point(510, 494);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(236, 28);
            this.cbCourse.TabIndex = 25;
            // 
            // cbCounty
            // 
            this.cbCounty.FormattingEnabled = true;
            this.cbCounty.Items.AddRange(new object[] {
            "Antrim",
            "Armagh",
            "Carlow",
            "Cavan",
            "Clare",
            "Cork",
            "Donegal",
            "Down",
            "Dublin",
            "Fermanagh",
            "Galway",
            "Kerry",
            "Kildare",
            "Kilkenny",
            "Laois",
            "Leitrim",
            "Limerick",
            "Longford",
            "Louth",
            "Mayo",
            "Meath",
            "Monaghan",
            "Offaly",
            "Roscommon",
            "Sligo",
            "Tipperary",
            "Tyrone",
            "Waterford",
            "Westmeath",
            "Wexford",
            "Wicklow"});
            this.cbCounty.Location = new System.Drawing.Point(509, 383);
            this.cbCounty.Name = "cbCounty";
            this.cbCounty.Size = new System.Drawing.Size(236, 28);
            this.cbCounty.TabIndex = 24;
            this.cbCounty.Tag = "";
            // 
            // rbUndergrad
            // 
            this.rbUndergrad.AutoSize = true;
            this.rbUndergrad.Location = new System.Drawing.Point(658, 436);
            this.rbUndergrad.Name = "rbUndergrad";
            this.rbUndergrad.Size = new System.Drawing.Size(142, 24);
            this.rbUndergrad.TabIndex = 23;
            this.rbUndergrad.TabStop = true;
            this.rbUndergrad.Text = "Undergraduate";
            this.rbUndergrad.UseVisualStyleBackColor = true;
            // 
            // rbPostgrad
            // 
            this.rbPostgrad.AutoSize = true;
            this.rbPostgrad.Checked = true;
            this.rbPostgrad.Location = new System.Drawing.Point(512, 436);
            this.rbPostgrad.Name = "rbPostgrad";
            this.rbPostgrad.Size = new System.Drawing.Size(130, 24);
            this.rbPostgrad.TabIndex = 22;
            this.rbPostgrad.TabStop = true;
            this.rbPostgrad.Text = "Postgraduate";
            this.rbPostgrad.UseVisualStyleBackColor = true;
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.Location = new System.Drawing.Point(510, 553);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new System.Drawing.Size(236, 26);
            this.txtStudentNumber.TabIndex = 21;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(509, 334);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(236, 26);
            this.txtCity.TabIndex = 17;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(510, 287);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(236, 26);
            this.txtAddress2.TabIndex = 16;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(510, 234);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(236, 26);
            this.txtAddress1.TabIndex = 15;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(510, 193);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(236, 26);
            this.txtPhone.TabIndex = 14;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(510, 148);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(236, 26);
            this.txtEmail.TabIndex = 13;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(509, 91);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(236, 26);
            this.txtSurname.TabIndex = 12;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(509, 36);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(236, 26);
            this.txtFirstName.TabIndex = 11;
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.Location = new System.Drawing.Point(115, 561);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(130, 20);
            this.lblStudentNumber.TabIndex = 10;
            this.lblStudentNumber.Text = "Student Number:";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(115, 502);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(64, 20);
            this.lblCourse.TabIndex = 9;
            this.lblCourse.Text = "Course:";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(117, 444);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(50, 20);
            this.lblLevel.TabIndex = 8;
            this.lblLevel.Text = "Level:";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(114, 391);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(63, 20);
            this.lblCounty.TabIndex = 7;
            this.lblCounty.Text = "County:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(114, 342);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(39, 20);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "City:";
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Location = new System.Drawing.Point(115, 295);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(119, 20);
            this.lblAddress2.TabIndex = 5;
            this.lblAddress2.Text = "Address Line 2:";
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Location = new System.Drawing.Point(115, 242);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(119, 20);
            this.lblAddress1.TabIndex = 4;
            this.lblAddress1.Text = "Address Line 1:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(115, 201);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(59, 20);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "Phone:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(115, 156);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(114, 99);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(78, 20);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surname:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(114, 44);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(90, 20);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // epStudentId
            // 
            this.epStudentId.ContainerControl = this;
            // 
            // epFirstName
            // 
            this.epFirstName.ContainerControl = this;
            // 
            // epSurname
            // 
            this.epSurname.ContainerControl = this;
            // 
            // epCounty
            // 
            this.epCounty.ContainerControl = this;
            // 
            // epCourse
            // 
            this.epCourse.ContainerControl = this;
            // 
            // epEmail
            // 
            this.epEmail.ContainerControl = this;
            // 
            // epPhone
            // 
            this.epPhone.ContainerControl = this;
            // 
            // epAddressLine1
            // 
            this.epAddressLine1.ContainerControl = this;
            // 
            // epAddressLine2
            // 
            this.epAddressLine2.ContainerControl = this;
            // 
            // epCity
            // 
            this.epCity.ContainerControl = this;
            // 
            // NewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 782);
            this.Controls.Add(this.gbNewStudent);
            this.Name = "NewStudent";
            this.Text = "NewStudent";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewStudent_FormClosed);
            this.gbNewStudent.ResumeLayout(false);
            this.gbNewStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epStudentId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSurname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCounty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAddressLine1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAddressLine2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNewStudent;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cbCourse;
        private System.Windows.Forms.ComboBox cbCounty;
        private System.Windows.Forms.RadioButton rbUndergrad;
        private System.Windows.Forms.RadioButton rbPostgrad;
        private System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.ErrorProvider epStudentId;
        private System.Windows.Forms.ErrorProvider epFirstName;
        private System.Windows.Forms.ErrorProvider epSurname;
        private System.Windows.Forms.ErrorProvider epCounty;
        private System.Windows.Forms.ErrorProvider epCourse;
        private System.Windows.Forms.ErrorProvider epEmail;
        private System.Windows.Forms.ErrorProvider epPhone;
        private System.Windows.Forms.ErrorProvider epAddressLine1;
        private System.Windows.Forms.ErrorProvider epAddressLine2;
        private System.Windows.Forms.ErrorProvider epCity;
    }
}