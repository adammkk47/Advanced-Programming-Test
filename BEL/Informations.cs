using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BEL
{
    public class Informations
    {
        //login
        public string username { get; set; }
        public string password { get; set; }

        //new student
        public string firstName { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string addressLine1 { get; set; }
        public string addressLine2 { get; set; }
        public string city { get; set; }
        public string county { get; set; }
        public string level { get; set; }
        public string course { get; set; }
        public int studentNumber { get; set; }

        public string operation { get; set; }

        public bool BlanksValidation(string text, TextBox textBox, ErrorProvider errorProvider)
        {
            if (String.IsNullOrEmpty(text) || text.Length > 20)
            {
                errorProvider.SetError(textBox, "Must not be blank or more than 20 characters long.");
                return false;
            }
            else
            {
                errorProvider.Clear();
                return true;
            }
        }

        public bool StringValidation(string text, TextBox textBox, ErrorProvider errorProvider)
        {
            if (text.Any(char.IsDigit) || String.IsNullOrEmpty(text) || text.Length > 20)
            {
                errorProvider.SetError(textBox, "Must not contain numbers or be blank or be more than 20 characters long.");
                //validation.Add(false);
                return false;
            }
            else
            {
                errorProvider.Clear();
                //validation.Add(true);
                return true;
            }
        }

        public bool ComboBoxValidation(ComboBox comboBox, ErrorProvider errorProvider)
        {
            if (comboBox.SelectedIndex == -1)
            {
                errorProvider.SetError(comboBox, "Please select a value.");
                return false;
            }
            else
            {
                errorProvider.Clear();
                return true;
            }
        }

        public bool IntValidation(int value, TextBox textBox, ErrorProvider errorProvider)
        {
            if (int.TryParse(textBox.Text, out value) && value.ToString().Length < 9)
            {
                errorProvider.Clear();
                return true;
            }
            else
            {
                errorProvider.SetError(textBox, "Student id must be an integer less than 9 digits.");
                return false;
            }
        }

    }
}


