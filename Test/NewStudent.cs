using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using BEL;

namespace Test
{
    public partial class NewStudent : Form
    {
        public Student s { get; set; }

        public Informations info = new Informations();
        public Operations opr = new Operations();

        DataTable dt = new DataTable();
        string level;
        int studentNumber;
        List<bool> validation = new List<bool>();

        public NewStudent()
        {
            InitializeComponent();
        }

        public void ClearTextBoxes(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = String.Empty;
                }
                else
                {
                    ClearTextBoxes(ctrl.Controls);
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            validation.Clear();

            info.firstName = txtFirstName.Text.Trim();
            validation.Add(info.StringValidation(info.firstName, txtFirstName, epFirstName));            
            info.surname = txtSurname.Text.Trim();
            validation.Add(info.StringValidation(info.surname, txtSurname, epSurname));
            info.email = txtEmail.Text.Trim();
            validation.Add(info.BlanksValidation(info.email, txtEmail, epEmail));
            info.phone = txtPhone.Text.Trim();
            validation.Add(info.BlanksValidation(info.phone, txtPhone, epPhone));
            info.addressLine1 = txtAddress1.Text.Trim();
            validation.Add(info.BlanksValidation(info.addressLine1, txtAddress1, epAddressLine1));
            info.addressLine2 = txtAddress2.Text.Trim();
            validation.Add(info.BlanksValidation(info.addressLine2, txtAddress2, epAddressLine2));
            info.city = txtCity.Text.Trim();
            validation.Add(info.BlanksValidation(info.city, txtCity, epCity));
            info.county = cbCounty.Text;
            validation.Add(info.ComboBoxValidation(cbCounty, epCounty));
            if (rbPostgrad.Checked == true)
            {
                level = "Postgraduate";
            }
            else
            {
                level = "Undergraduate";
            }
            info.level = level;
            info.course = cbCourse.Text;
            validation.Add(info.ComboBoxValidation(cbCourse, epCourse));
            int.TryParse(txtStudentNumber.Text, out studentNumber);
            info.studentNumber = studentNumber;
            validation.Add(info.IntValidation(studentNumber, txtStudentNumber, epStudentId));
            dt = opr.StudentSearch(info);

            if (dt.Rows.Count < 1 && !validation.Contains(false))
            {
                //MessageBox.Show("Student does not exist");
                int rows = opr.InsertData(info);

                if (rows > 0)
                {
                    MessageBox.Show("Student entered successfully");
                    cbCounty.SelectedIndex = -1;
                    cbCourse.SelectedIndex = -1;
                    ClearTextBoxes(this.Controls);
                }
            }
    
            else if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Student with id " + studentNumber + " already exists. Please try again.");
            }
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            opr.Gridview(s.dgDatabase1, s.command);
            this.s.Show();
        }

        private void NewStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.f.Show();
        }
    }
}
