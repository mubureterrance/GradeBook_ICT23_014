using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeBook_ICT23_014
{
    public partial class FrmLogin : Form
    {
        //global values
        DataValidate dv = new DataValidate();
        DataAcces da = new DataAcces();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {   //validate user entries
                if (dv.isPresent(txtUsername, "Username") &&
                    dv.isValidEmail(txtUsername, "Username") &&
                    dv.isPresent(txtPassword, "Password"))
                {
                    //check if entered details are authentic
                    string[] loginDetails = da.AuthenticateUser("users.txt", txtUsername.Text.ToLower().Trim(), txtPassword.Text.Trim(), 1, 2);

                    if (loginDetails.Length == 0)
                    {
                        MessageBox.Show("Invalid login details!", da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        da.ClearFormControls(this);
                        return;
                    }

                    //get user fullname
                    string fullname = $"{loginDetails[3]} {loginDetails[4]}";

                    //set static values for the current user
                    FrmMain.userFullname = fullname;
                    FrmMain.userID = loginDetails[0];
                    FrmMain.username = loginDetails[1];
                    FrmMain.position = loginDetails[7];

                    //Open the main menu
                    Form frm = new FrmMain();
                    frm.ShowDialog();

                    //close the login form
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnforgot_Click(object sender, EventArgs e)
        {
            try
            {   //display message if user has forgotten their login details
                MessageBox.Show("If you have forgotten your password please contact the System Adminstrator for assistance", da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboShow_CheckedChanged(object sender, EventArgs e)
        {
            try
            {   //show password to the user
                if (cboShow.Checked)
                {
                    txtPassword.UseSystemPasswordChar = false;
                }
                else
                {
                    txtPassword.UseSystemPasswordChar = true;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //form resizing and location setting
            //get the form dimensions 
            System.Drawing.Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
            this.Size = new System.Drawing.Size(Convert.ToInt32(0.5 * workingArea.Width), Convert.ToInt32(0.9 * workingArea.Height));
            int fromLeft = Convert.ToInt32(0.5 * workingArea.Width / 2);

            //set location of form to upper left corner
            this.Location = new System.Drawing.Point(fromLeft, 50);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
