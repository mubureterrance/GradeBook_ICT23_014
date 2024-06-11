using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace GradeBook_ICT23_014
{
    internal class DataValidate
    {
        //method to check for entry in required field textBox
        public bool isPresent(System.Windows.Forms.TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show($"{name} is a required field.", "SCIS GradeBook Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                return false;
            }
            return true;
        }

        //method to check for entry in required field comboBox
        public bool isPresentCbox(System.Windows.Forms.ComboBox cBox, string name)
        {
            if (cBox.Text == "")
            {
                MessageBox.Show($"{name} is a required field.", "SCIS GradeBook Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cBox.Focus();
                return false;
            }
            return true;
        }

        //method to check for entry in required field dateTimePicker
        public bool isPresentDtp(DateTimePicker dtp, string name)
        {
            if (dtp.Text == "")
            {
                MessageBox.Show($"{name} is a required field.", "SCIS GradeBook Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtp.Focus();
                return false;
            }
            return true;
        }



        //method to chech for special charector in a string
        public bool Contains(System.Windows.Forms.TextBox txtBox, string name, char charector)
        {
            bool isCharectorPresent = txtBox.Text.Contains(charector);
            if (isCharectorPresent == false)
            {
                MessageBox.Show($"You have entered an invalid {name}", "SCIS GradeBook Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBox.Focus();
                return false;
            }
            return true;
        }

        public bool DropdownSelection(System.Windows.Forms.ComboBox cBox, string name, string[] list)
        {

            bool match = false;
            foreach (string str in list)
            {
                if (cBox.Text == str)
                {
                    match = true;
                    break;
                }
            }
            if (match == false)
            {
                MessageBox.Show($"You have entered an invalid {name}, please select from dropdown", "SCIS GradeBook Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cBox.Text = "";
                cBox.Focus();
                return false;
            }
            return true;
        }

        //method check if data is valid numeric value
        public bool IsDecimal(System.Windows.Forms.TextBox textBox, string name)
        {
            decimal number = 0m;
            if (decimal.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show($"{name} must be a numeric value", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
                textBox.Focus();
                return false;
            }
        }

        //method checks for valid numeric range
        public bool IsWithinRange(System.Windows.Forms.TextBox textBox, string name, decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show($"{name} must be a numeric value\n between {min.ToString()} and {max.ToString()}", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
                textBox.Focus();
                return false;
            }
            return true;
        }

        //method for validating numbers using multiple checks by calling other methods
        public bool isValidNumeral(System.Windows.Forms.TextBox textBox, string name, double minNum, double maxNum)
        {
            try
            {
                if (isPresent(textBox, name) &&
                    IsWithinRange(textBox, name, (decimal)minNum, (decimal)maxNum) &&
                    IsDecimal(textBox, name))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //method fro validating combo boxes by combining multiple methods
        public bool isComboValid(System.Windows.Forms.ComboBox cBox, string[] list, string name)
        {
            try
            {
                if(isPresentCbox(cBox,name)&&DropdownSelection(cBox,name,list))
                {
                    return true;
                }
                else { return false; }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //validates emails using regex
        public bool isValidEmail(System.Windows.Forms.TextBox txtBox, string name)
        {
            try
            {
                // Basic email format check
                Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)\.[a-zA-Z]{2,}$", RegexOptions.IgnoreCase);

                if (emailRegex.IsMatch(txtBox.Text.Trim().ToLower()))
                {
                    // Check if domain is specifically .bw
                    if (txtBox.Text.Trim().ToLower().EndsWith("scis.bw", StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show($"You have entered an invalid {name}, only emails with [scis.bw] domain are allowed", "SCIS GradeBook Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false; //  "Email address valid format, but domain must be scis.bw"
                    }
                }
                else
                {
                    MessageBox.Show($"You have entered an invalid {name}", "SCIS GradeBook Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; //email address formart not valid
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
