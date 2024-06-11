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
    public partial class FrmRegisterUser : Form
    {
        //global form section
        DataAcces da = new DataAcces();
        DataValidate dv = new DataValidate();

        
        string[] positions = { "Admin", "Registrar", "Admin Assistant" };
        //add gender values
        Dictionary<String, String> dict = new Dictionary<string, string>()
        {
            ["F"] = "Female",
            ["M"] = "Male"
        };
        public FrmRegisterUser()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //check if student ID is already in the system to avoid dublicates
                if (da.IsRecordExisting("users.txt", txtStaffID.Text.ToLower().Trim(), 0) == true)
                {
                    MessageBox.Show($"User record {txtStaffID.Text.ToLower().Trim()} is already in the system!", da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else if (Validate())
                {
                    //get user data
                    String[] columns = { "STAFF_ID", "EMAIL", "PASSWORD", "NAME", "SURNAME", "GENDER", "PHONE", "POSITION", "DATE_REGISTERED" };
                    String[] arrdata = { txtStaffID.Text.ToLower().Trim(), txtEmail.Text.Trim(), txtPassword.Text, da.CapitalisePhrase(txtFirstname.Text), da.CapitalisePhrase(txtSurname.Text), cboGender.Text, txtPhone.Text.Trim(), cboPosition.Text, dtpDate.Value.ToString("dd/MMM/yyyy") };

                    //save data from class
                    int rows = da.SaveData(@"users.txt", columns, arrdata);

                    //confirm saving with message
                    MessageBox.Show("New user registered successfully !!", da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //clear form controls 
                    btnClear_Click(sender, e);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmRegisterUser_Load(object sender, EventArgs e)
        {
            try
            {
                //form resizing and location setting
                //get the form dimensions 
                System.Drawing.Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
                this.Size = new System.Drawing.Size(workingArea.Width, workingArea.Height);

                //set location of form to upper left corner
                this.Location = new System.Drawing.Point(0, 0);

                //load postion values to dropdown
                da.LoadDropDown(cboPosition, "positions.txt");

                //load gender values
                da.LoadDropDown(cboGender, null, null, null, dict);

                //clear form controls to initialise 
                ClearMyControls();

                //get the new Staff ID
                int newID = da.GetCurrentID("users.txt", 100, 100);
                txtStaffID.Text = newID.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                //clear form controls
                ClearMyControls();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // clear form controls
        private void ClearMyControls()
        {
            try
            {
                //refresh grid
                da.LoadGridData(grid, null, da.ReadFileDataTable("users.txt", false));

                //clear using class method
                da.ClearFormControls(this);

                //get the new Staff ID
                int newID = da.GetCurrentID("users.txt", 100, 100);
                txtStaffID.Text = newID.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void LoadRecordData(String[] recorddata)
        {
            try
            {
                //load control values
                txtStaffID.Text = recorddata[0];
                txtEmail.Text = recorddata[1];
                txtPassword.Text = recorddata[2];
                txtFirstname.Text = recorddata[3];
                txtSurname.Text = recorddata[4];
                cboGender.Text = recorddata[5];
                txtPhone.Text = recorddata[6];
                cboPosition.SelectedValue = recorddata[7];
                dtpDate.Value = Convert.ToDateTime(recorddata[8]);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //get selected row values into array
                String[] recorddata = new string[grid.ColumnCount];
                for (int k = 0; k <= grid.ColumnCount - 1; k++)
                {
                    recorddata[k] = grid.SelectedRows[0].Cells[k].Value.ToString();
                }

                //load selected data
                LoadRecordData(recorddata);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validate())
                {
                    //get user data
                    String[] arrdata = { txtStaffID.Text.ToLower().Trim(), txtEmail.Text.Trim(), txtPassword.Text, txtFirstname.Text, txtSurname.Text, cboGender.Text, txtPhone.Text.Trim(), cboPosition.Text, dtpDate.Value.ToString("dd/MMM/yyyy") };

                    //save data from class
                    int rows = da.UpdateFileRecord("users.txt", arrdata, 0);

                    //confirm saving
                    MessageBox.Show("user details updated successfully !!", da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //clear form controls | simulate btnClear_Click() | refresh grid
                    btnClear_Click(sender, e);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                //check if user ID has been entered
                if (txtStaffID.Text == "")
                {
                    MessageBox.Show("Please enter the User ID before proceeding !!", da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (MessageBox.Show($"Are you sure you want to delete this User record [{txtStaffID.Text}] ?", da.GetSystemTitle(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                //get user data
                String RecordKeyValue = txtStaffID.Text;

                //save data from class
                int rows = da.DeleteFileRecord("users.txt", RecordKeyValue, 0);

                //confirm saving
                MessageBox.Show($"User record [{RecordKeyValue}] deleted successfully !!", da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Information);

                //clear form controls | simulate btnClear_Click() | refresh grid
                btnClear_Click(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                //Close the form
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            try
            {
                //validate first
                if (txtSearchID.Text == "")
                {
                    MessageBox.Show("Please enter the Staff ID before proceeding !!", da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //get user data
                String RecordKeyValue = txtSearchID.Text.ToLower().Trim();

                //search data from class
                String[] RecordData = da.SearchFileRecord("users.txt", RecordKeyValue, 0);

                //check if found
                if (RecordData.Length == 0)
                {
                    MessageBox.Show($"User record [{RecordKeyValue}] was not found, verify search key and try again !!", da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //load record data
                LoadRecordData(RecordData);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public new bool Validate()
        {
            try
            {

                bool isValid = false;
                //check if all values have been all enetered correctly
                if (dv.isPresent(txtStaffID, "Staff ID") &&
                    dv.isPresent(txtEmail, "Email")&&
                    dv.isValidEmail(txtEmail, "Email")&&
                    dv.isPresent(txtPassword,"Password")&&
                    dv.isPresent(txtFirstname, "Firstname") &&
                    dv.isPresent(txtSurname, "Surname") &&
                    dv.isPresentDtp(dtpDate, "Date Recoreded") &&
                    dv.isPresent(txtPhone, "Phone number") &&
                    dv.isPresentCbox(cboGender, "Gender") &&
                    dv.isPresentCbox(cboPosition, "Level"))
                {
                    isValid = true;
                }
                return isValid;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
