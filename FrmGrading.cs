using Microsoft.VisualBasic;
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
    public partial class FrmGrading : Form
    {
        //global form section
        DataAcces da = new DataAcces();
        DataValidate dv = new DataValidate();
        string position = FrmMain.position;

        //current record index - for navigation buttons | k
        int k = -1;
        public FrmGrading()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //validate first
                if (txtGradeID.Text == "")
                {
                    MessageBox.Show("Please enter the Grade ID before proceeding !!", da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //get user data
                String RecordKeyValue = txtGradeID.Text;

                //search data from class
                String[] RecordData = da.SearchFileRecord("settings.txt", RecordKeyValue, 0);

                //check if found
                if (RecordData.Length == 0)
                {
                    MessageBox.Show($"Grade record [{RecordKeyValue}] was not found, verify search key and try again !!", da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void FrmGrading_Load(object sender, EventArgs e)
        {
            try
            {
                //form resizing and location setting
                //get the form dimensions 
                System.Drawing.Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
                this.Size = new System.Drawing.Size(workingArea.Width, workingArea.Height);

                //set location of form to upper left corner
                this.Location = new System.Drawing.Point(0, 0);


                if (position != "Admin")
                {
                    btnSave.Enabled = false;
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;

                }
                //clear form controls 
                btnClear_Click(sender, e);



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
                if (da.IsRecordExisting("settings.txt", txtGradeID.Text, 0) == true)
                {
                    MessageBox.Show($"setting record {txtGradeID.Text} is already in the system!", da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else if (Validate())
                {
                    //get user data
                    String[] columns = { "GRADE_ID", "DATE_RECORDED", "MARK_FROM", "MARK_TO", "GRADE" };
                    String[] arrdata = { txtGradeID.Text, dtpDate.Value.ToString("dd/MMM/yyyy"), txtFrom.Text, txtTo.Text, txtGrade.Text.ToUpper() };

                    //save data from class
                    int rows = da.SaveData(@"settings.txt", columns, arrdata);

                    //confirm saving with message
                    MessageBox.Show("Grading Criteria Updated Successfully!", da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    //get user data
                    String[] arrdata = { txtGradeID.Text, dtpDate.Value.ToString("dd/MMM/yyyy"), txtFrom.Text, txtTo.Text, txtGrade.Text.ToUpper() };

                    //save data from class
                    int rows = da.UpdateFileRecord("settings.txt", arrdata, 0);

                    //confirm saving
                    MessageBox.Show("Grading details updated successfully !!", da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                //get new grading ID
                int newID = da.GetCurrentID("settings.txt", 1, 100);
                txtGradeID.Text = newID.ToString();

                

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
                if (txtGradeID.Text == "")
                {
                    MessageBox.Show("Please enter the Grade ID before proceeding !!", da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (MessageBox.Show($"Are you sure you want to delete this Grade record [{txtGradeID.Text}] ?", da.GetSystemTitle(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                //get user data
                String RecordKeyValue = txtGradeID.Text;

                //save data from class
                int rows = da.DeleteFileRecord("settings.txt", RecordKeyValue, 0);

                //confirm saving
                MessageBox.Show($"Grading record [{RecordKeyValue}] deleted successfully !!", da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        // clear form controls
        private void ClearMyControls()
        {
            try
            {
                //refresh grid
                da.LoadGridData(grid, null, da.ReadFileDataTable("settings.txt", false));

                //clear using class method
                da.ClearFormControls(this);

                //set focus
                txtGradeID.Focus();

                //get new grading ID
                int newID = da.GetCurrentID("settings.txt", 1, 100);
                txtGradeID.Text = newID.ToString();




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
                txtGradeID.Text = recorddata[0];
                dtpDate.Value = Convert.ToDateTime(recorddata[1]);
                txtFrom.Text = recorddata[2];
                txtTo.Text = recorddata[3];
                txtGrade.Text = recorddata[4];

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
                if (dv.isPresent(txtGradeID, "Grade ID") &&
                    dv.isPresentDtp(dtpDate, "Date Recoreded")&&
                    dv.isPresent(txtGrade, "Grade"))
                {

                    //check if numeric values have been enetered
                    if (dv.isValidNumeral(txtFrom, "Mark From", 0, 100) &&
                        dv.isValidNumeral(txtTo, "Mark To", 0, 100))
                    {
                        isValid = true;
                    }

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
