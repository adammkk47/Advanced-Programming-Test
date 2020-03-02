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
    public partial class Student : Form
    {
        public Operations opr = new Operations();
        public Informations info = new Informations();
        DataSet ds;
        DataTable dt = new DataTable();
        public DataGridView dgDatabase1;

        public string command = "SELECT* FROM Students";
        int studentNumber;

        public Student()
        {
            InitializeComponent();
            dgDatabase1 = dgDatabase;
            opr.Gridview(dgDatabase1,command);
        }

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            NewStudent ns = new NewStudent();
            ns.s = this;
            ns.Show();
            this.Hide();
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            EditStudent es = new EditStudent();
            es.s = this;
            es.Show();
            this.Hide();
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            DeleteStudent ds = new DeleteStudent();
            ds.s = this;
            ds.Show();
            this.Hide();
        }

        private void BtnXML_Click(object sender, EventArgs e)
        {
            int.TryParse(txtStudentNumber.Text, out studentNumber);
            info.studentNumber = studentNumber;
            dt = opr.StudentSearch(info);
            string fileName = "Student_" + studentNumber + ".xml";

            if (dt.Rows.Count > 0)
            {
                ds = opr.SaveToXml(info);
                ds.WriteXml(fileName);
                MessageBox.Show("Saved as " + fileName);
            }
            else
            {
                MessageBox.Show("Student not found.");
            }
        }

        private void BtnStudentLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.f.Show();
        }

        private void BtnStudentExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.f.Close();
        }

        private void btnDatabaseHistory_Click(object sender, EventArgs e)
        {
            this.Close();
            DatabaseHistory dh = new DatabaseHistory();
            dh.Show();
        }

        private void Student_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.f.Show();
        }
    }
}
