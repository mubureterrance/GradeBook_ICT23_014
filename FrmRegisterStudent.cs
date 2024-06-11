using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeBook_ICT23_014
{
    public partial class FrmRegisterStudent : Form
    {
        //global form section
        DataAcces da = new DataAcces();
        DataValidate dv = new DataValidate();

        //program values
        string[] programs = { "ABC", "ICT" };
        //module valules
        string[] modules = { "ABC104", "CSE103", "CSE105" };
        //add gender values
        Dictionary<String, String> dict = new Dictionary<string, string>()
        {
            ["F"] = "Female",
            ["M"] = "Male"
        };
        public FrmRegisterStudent()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //validate first
                if (txtStudentID.Text == "")
                {
                    MessageBox.Show("Please enter the Student ID before proceeding !!", da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //get user data
                String RecordKeyValue = txtStudentID.Text.ToLower();

                //search data from class
                String[] RecordData = da.SearchFileRecord("students.txt", RecordKeyValue, 0);

                //check if found
                if (RecordData.Length == 0)
                {
                    MessageBox.Show($"Student record [{RecordKeyValue}] was not found, verify search key and try again !!", da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //check if student ID is already in the system to avoid dublicates
                if (da.IsRecordExisting("students.txt", txtStudentID.Text.ToLower().Trim(), 0) == true)
                {
                    MessageBox.Show($"Student record {txtStudentID.Text.ToLower()} is already in the system!", da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else if (Validate())
                {
                    //get user data
                    String[] columns = { "STUDENT_ID", "FIRSTNAME", "SURNAME", "GENDER", "DOB", "PHONE", "PROGRAM", "LEVEL", "MODULE" };
                    String[] arrdata = { txtStudentID.Text.Trim().ToLower(), da.CapitalisePhrase(txtFirstname.Text), da.CapitalisePhrase(txtSurname.Text), cboGender.Text, dtpDate.Value.ToString("dd/MMM/yyyy"), txtCell.Text, cboProgram.Text, cboLevel.Text, cboModule.Text };

                    //save data from class
                    int rows = da.SaveData(@"students.txt", columns, arrdata);

                    //confirm saving with message
                    MessageBox.Show("New Student Registration Successful!", da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //clear form controls 
                    btnClear_Click(sender, e);
                }
                
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
                    //get input from the form
                    String[] arrdata = { txtStudentID.Text.Trim().ToLower(), da.CapitalisePhrase(txtFirstname.Text), da.CapitalisePhrase(txtSurname.Text), cboGender.Text, dtpDate.Value.ToString("dd/MMM/yyyy"), txtCell.Text, cboProgram.Text, cboLevel.Text, cboModule.Text };

                    //save data from class
                    int rows = da.UpdateFileRecord("students.txt", arrdata, 0);

                    //confirm saving
                    MessageBox.Show("Student details updated successfully!", da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //clear form controls | simulate btnClear_Click() | refresh grid
                    btnClear_Click(sender, e);
                }

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                //check if user ID has been entered
                if (txtStudentID.Text == "")
                {
                    MessageBox.Show("Please enter the Student ID before proceeding!", da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (MessageBox.Show($"Are you sure you want to delete this Student record [{txtStudentID.Text}] ?", da.GetSystemTitle(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                //get user data
                String RecordKeyValue = txtStudentID.Text;

                //save data from class
                int rows = da.DeleteFileRecord("students.txt", RecordKeyValue, 0);

                //confirm saving
                MessageBox.Show($"Student record [{RecordKeyValue}] deleted successfully!", da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                this.Close();
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

        private void FrmRegisterStudent_Load(object sender, EventArgs e)
        {
            try
            {
                //form resizing and location setting
                //get the form dimensions 
                System.Drawing.Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
                this.Size = new System.Drawing.Size(workingArea.Width, workingArea.Height);

                //set location of form to upper left corner
                this.Location = new System.Drawing.Point(0, 0);

                //load programs values to dropdown
                da.LoadDropDown(cboProgram, "programs.txt");

                //load modules values to dropdown
                da.LoadDropDown(cboModule, "modules.txt");

                //load programs values to dropdown
                da.LoadDropDown(cboLevel, "levels.txt");

                //load gender values
                da.LoadDropDown(cboGender, null, null, null, dict);

                //clear form controls to initialise 
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
                da.LoadGridData(grid, null, da.ReadFileDataTable("students.txt", false));

                //clear using class method
                da.ClearFormControls(this);

                //set focus
                txtStudentID.Focus();
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
                txtStudentID.Text = recorddata[0];
                txtFirstname.Text = recorddata[1];
                txtSurname.Text = recorddata[2];
                cboGender.Text = recorddata[3];
                dtpDate.Value = Convert.ToDateTime(recorddata[4]);
                txtCell.Text = recorddata[5];
                cboProgram.SelectedValue = recorddata[6];
                cboLevel.SelectedValue = recorddata[7];
                cboModule.SelectedValue = recorddata[8];
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //method to validate data entries
        public new bool Validate()
        {
            try
            {

                bool isValid = false;
                
                    //check if all values have been all enetered correctly
                    if (dv.isPresent(txtStudentID, "Student ID") &&
                    dv.isPresent(txtFirstname, "Firstname") &&
                    dv.isPresent(txtSurname, "Surname") &&
                    dv.isPresentDtp(dtpDate, "Date Recoreded")&&
                    dv.isPresent(txtCell, "Phone number")&&
                    dv.isPresentCbox(cboGender, "Gender")&&
                    dv.isPresentCbox(cboLevel, "Level") &&
                    dv.isPresentCbox(cboProgram, "Program") &&
                    dv.isPresentCbox(cboModule, "Module"))
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

        
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
