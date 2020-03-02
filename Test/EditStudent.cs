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
    public partial class EditStudent : Form
    {
        public Student s { get; set; }
        public NewStudent ns = new NewStudent();

        public Informations info = new Informations();
        public Operations opr = new Operations();

        List<bool> validation = new List<bool>();

        DataTable dt = new DataTable();
        int studentNumber;
        string level;

        public EditStudent()
        {
            InitializeComponent();
            gbStudentData.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int.TryParse(txtStudentIdSearch.Text, out studentNumber);
            info.studentNumber = studentNumber;
            dt = opr.StudentSearch(info);

            if (dt.Rows.Count > 0)
            {
                dt = opr.PopulateStudentDetails(info);
                lblStudentIdReadOnly.Text = info.studentNumber.ToString();
                lblFirstNameReadOnly.Text = info.firstName;
                lblSurnameReadOnly.Text = info.surname;
                txtEmail.Text = info.email;
                txtPhone.Text = info.phone;
                txtAddress1.Text = info.addressLine1;
                txtAddress2.Text = info.addressLine2;
                txtCity.Text = info.city;
                cbCounty.SelectedItem = info.county;
                if (info.level == "Postgraduate")
                {
                    rbPostgrad.Checked = true;
                }
                else
                {
                    rbUndergrad.Checked = true;
                }
                lblCourseReadOnly.Text = info.course;
                gbStudentData.Visible = true;
            }
            else
            {
                MessageBox.Show("Student does not exist");
                gbStudentData.Visible = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            validation.Clear();

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

            if (!validation.Contains(false))
            {
                int rows = opr.UpdateStudentDetails(info);
                MessageBox.Show("Student updated successfully");
                gbStudentData.Visible = false;
            }
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.s.Show();
            opr.Gridview(s.dgDatabase1, s.command);
        }

        private void EditStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.f.Show();
        }
    }
}
