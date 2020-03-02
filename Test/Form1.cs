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
    public partial class Form1 : Form
    {
        public Informations info = new Informations();
        public Operations opr = new Operations();

        DataTable dt = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

 

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            info.username = txtUsername.Text.Trim();
            info.password = txtPassword.Text.Trim();
            dt = opr.Login(info);

            if (dt.Rows.Count > 0)
            {
                Student s = new Student();
                s.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
            txtUsername.Clear();
            txtPassword.Clear();
        }
    }
}
