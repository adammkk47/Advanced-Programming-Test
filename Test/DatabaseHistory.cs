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
    public partial class DatabaseHistory : Form
    {
        public Operations opr = new Operations();
        string command = "SELECT* FROM AuditStudent";

        public DatabaseHistory()
        {
            InitializeComponent();
            opr.Gridview(dgDatabaseHistory, command);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            Student s = new Student();
            s.Show();
        }

        private void DatabaseHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.f.Show();
        }
    }
}
