using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeBook_ICT23_014
{
    public partial class FrmCaptureMarks : Form
    {
        //global form section
        DataAcces da = new DataAcces();
        DataValidate dv = new DataValidate();
        string user = FrmMain.username;
        
        //module valules
        string[] modules = { "ABC104", "CSE103", "CSE105" };
        //add gender values
        string position = FrmMain.position;
        public FrmCaptureMarks()
        {
            InitializeComponent();
        }
        
        //search button uses the student ID to retrive student details
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                //validate first
                if (cboStudentID.Text.Trim().ToLower() == "")
                {
                    MessageBox.Show("Please enter the Student ID before proceeding !!", da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //btnClear_Click(sender, e);
                //get user data
                String RecordKeyValue = cboStudentID.Text.ToLower().ToLower();

                //search data from class
                String[] RecordData = da.SearchFileRecord("students.txt", RecordKeyValue, 0);


                //check if found
                if (RecordData.Length == 0)
                {
                    MessageBox.Show($"Mark record [{RecordKeyValue}] was not found, verify search key and try again !!", da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                btnClear_Click(sender, e);
                //load record data
                LoadSearchData(RecordData);


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
                //check if all updated data entries 
                if (Validate())
                {
                    //get marks from user
                    double[] marks = { Convert.ToDouble(txtTest.Text.Trim()), Convert.ToDouble(txtAssignment.Text.Trim()), Convert.ToDouble(txtFinalExam.Text.Trim()) };

                    int modulemark = ComputeModuleMark(marks);
                    DetermineGrade(modulemark);

                    //get user data
                    String[] arrdata = { cboStudentID.Text.Trim().ToLower(), cboModule.Text.Trim(), txtTest.Text.Trim(), txtAssignment.Text.Trim(), txtFinalExam.Text.Trim(), txtModuleMark.Text.Trim(), txtGrade.Text.Trim(), dtpDate.Value.ToString("dd/MMM/yyyy"), cboStaffID.Text.Trim() };

                    //save data from class
                    int rows = da.UpdateFileRecord("marks.txt", arrdata, 0);

                    //confirm saving
                    MessageBox.Show("Student Marks updated successfully!", da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                if (cboStudentID.Text.Trim().ToLower() == "")
                {
                    MessageBox.Show("Please enter the Student ID before proceeding!", da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (MessageBox.Show($"Are you sure you want to delete this Student Marks record [{cboStudentID.Text.ToLower()}] ?", da.GetSystemTitle(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                //get user data
                String RecordKeyValue = cboStudentID.Text.ToLower().Trim();

                //save data from class
                int rows = da.DeleteFileRecord("marks.txt", RecordKeyValue, 0);

                //confirm saving
                MessageBox.Show($"Student Marks record [{RecordKeyValue}] deleted successfully!", da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Information);

                //clear form controls | simulate btnClear_Click() | refresh grid
                btnClear_Click(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //close the form
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

                btnSearch_Click(sender, e);
                //load selected data
                LoadRecordData(recorddata);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCaptureMarks_Load(object sender, EventArgs e)
        {
            try
            {
                //disable save, update and delete buttons for unathorised users
                btnSave.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;

                //authoriser the Admin and the lecturer to makes changes to student marks
                if (position == "Lecturer" || position == "Admin")
                {
                    btnSave.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                }

                //form resizing and location setting
                //get the form dimensions 
                System.Drawing.Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
                this.Size = new System.Drawing.Size(workingArea.Width, workingArea.Height);

                //set location of form to upper left corner
                this.Location = new System.Drawing.Point(0, 0);

                //load modules values to dropdown
                da.LoadDropDown(cboModule, "modules.txt");

                //load student id values to dropdown
                DataTable Studentdt = da.ReadFileDataTable("students.txt");
                da.LoadDropDown(cboStudentID, Studentdt, "Student_ID", "Student_ID");

                //load staff id values to dropdown
                DataTable Staffdt = da.ReadFileDataTable("users.txt");
                da.LoadDropDown(cboStaffID, Staffdt, "STAFF_ID", "STAFF_ID");
                //set staff id as current user
                //cboStaffID.Text = user;

                //clear form controls to initialise 
                ClearMyControls();
                                
                //set focus
                cboStudentID.Focus();
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
                //check if student ID for this module has already been recorded in the system to avoid dublicates
                if (da.IsRecordExisting("marks.txt", cboStudentID.Text.Trim(), 0) == true && da.IsRecordExisting("marks.txt", cboModule.Text.Trim(), 1) == true)
                {
                    MessageBox.Show($"Mark record for {cboStudentID.Text.ToLower()} for the Module {cboModule.Text.Trim()} is already in the system!", da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else if (Validate())
                {
                    //---------------Calculate Module mark using assessment model------------------------------

                    //get marks from user
                    double[] marks = { Convert.ToDouble(txtTest.Text.Trim()), Convert.ToDouble(txtAssignment.Text), Convert.ToDouble(txtFinalExam.Text) };

                    int modulemark = ComputeModuleMark(marks);
                    DetermineGrade(modulemark);

                    //--------------Save data to marks file---------------------------------------------------
                    //get user data
                    String[] columns = { "STUDENT_ID", "MODULE", "ASSESSMENT_TEST", "ASSIGNMENT", "FINAL_EXAM", "MODULE_MARK", "GRADE", "DATE_RECORDED", "STAFF_ID" };
                    String[] arrdata = { cboStudentID.Text.ToLower().Trim(), cboModule.Text.Trim(), txtTest.Text.Trim(), txtAssignment.Text.Trim(), txtFinalExam.Text.Trim(), txtModuleMark.Text.Trim(), txtGrade.Text.Trim(), dtpDate.Value.ToString("dd/MMM/yyyy"), cboStaffID.Text.Trim() };

                    //save data from class
                    int rows = da.SaveData(@"marks.txt", columns, arrdata);

                    //confirm saving with message
                    MessageBox.Show("Student Marks Recorded Successful!", da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //clear form controls 
                    btnClear_Click(sender, e);
                }

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
                da.LoadGridData(grid, null, da.ReadFileDataTable("marks.txt", false));

                //clear using class method
                da.ClearFormControls(this);

                //set focus
                cboStaffID.Focus();
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
                cboStudentID.SelectedValue = recorddata[0];
                cboModule.SelectedValue = recorddata[1];
                txtTest.Text = recorddata[2];
                txtAssignment.Text = recorddata[3];
                txtFinalExam.Text = recorddata[4];
                txtModuleMark.Text = recorddata[5];
                txtGrade.Text = recorddata[6];
                dtpDate.Value = Convert.ToDateTime(recorddata[7]);
                cboStaffID.SelectedValue = recorddata[8];


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //determine moduleMark and grade
        public int ComputeModuleMark(double[] marks)
        {
            try
            {
                //get assessment model weights from file
                string[] tableWeights = da.ReadFileText("assessmentmodel.txt");

                //weight the marks 
                double test = marks[0] * Convert.ToDouble(tableWeights[2]) / 100;
                double assignment = marks[1] * Convert.ToDouble(tableWeights[3]) / 100;
                double courseWork = (test + assignment) * Convert.ToDouble(tableWeights[4]) / 100;
                double FinalExam = marks[2] * Convert.ToDouble(tableWeights[5]) / 100;
                //calculate module mark
                int moduleMark = Convert.ToInt32(courseWork + FinalExam);

                //populate textbox with module value
                txtModuleMark.Text = moduleMark.ToString();
                return moduleMark;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DetermineGrade(int moduleMark)
        {
            //dertermine student's grade
            var gradingSettings = da.GetGradingCriteria("settings.txt");

            //variables to fold the students grade
            string grade = "";


            //search the correct grading according to module mark
            for (int k = 0; k < gradingSettings.Count; k++)
            {
                if (moduleMark <= gradingSettings[k].MARK_TO)
                {
                    grade = gradingSettings[k].GRADE;
                    break;
                }
            }

            //assign to text boxes
            txtGrade.Text = grade;
        }

        //method to validate data entries
        public new bool Validate()
        {
            try
            {

                bool isValid = false;
                //check if all dropbox values have been all enetered correctly
                if (dv.isPresentCbox(cboStudentID, "Student ID") &&
                    dv.isPresentCbox(cboModule, "Module") &&
                    dv.isPresentCbox(cboStaffID, "Staff ID") &&
                    dv.isPresentDtp(dtpDate, "Date Recoreded"))
                {

                    //check if numeric values have been enetered
                    if (dv.isValidNumeral(txtTest, "Assessment Test", 0, 100) &&
                        dv.isValidNumeral(txtAssignment, "Assignment", 0, 100) &&
                        dv.isValidNumeral(txtFinalExam, "Final Exam", 0, 100))
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

        private void LoadSearchData(String[] recorddata)
        {
            try
            {
                //load control values
                cboStudentID.SelectedValue = recorddata[0];
                txtFirstname.Text = recorddata[1];
                txtLastname.Text = recorddata[2];
                txtGender.Text = recorddata[3];



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
