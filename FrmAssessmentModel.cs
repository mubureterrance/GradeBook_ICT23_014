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
    public partial class FrmAssessmentModel : Form
    {
        //global form section
        DataAcces da = new DataAcces();
        DataValidate dv = new DataValidate();
        string position = FrmMain.position;
        public FrmAssessmentModel()
        {
            InitializeComponent();
        }

        private void FrmAssessmentModel_Load(object sender, EventArgs e)
        {
            try
            {
                //form resizing and location setting
                //get the form dimensions 
                System.Drawing.Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
                this.Size = new System.Drawing.Size(workingArea.Width, workingArea.Height);

                //set location of form to upper left corner
                this.Location = new System.Drawing.Point(0, 0);

                //get current assessment model ID
                int newID = da.GetCurrentID("assessmentmoel", 100, 100);



                if (position != "Admin")
                {
                    btnSave.Enabled = false;
                    
                }
                LoadRecordData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validate())
                {
                    //get user data
                    String[] columns = { "ID", "DATE_RECORDED", "ASSESSMENT_TEST", "ASSIGNMENT", "COURSE_WORK", "FINAL_EXAM" };
                    String[] arrdata = { txtAssessID.Text, dtpDate.Value.ToString("dd/MMM/yyyy"), txtTest.Text, txtAssignment.Text, txtCourseWork.Text, txtFinalExam.Text };

                    //save data from class
                    int rows = da.OverWriteFile(@"assessmentmodel.txt", columns, arrdata);

                    //confirm saving with message
                    MessageBox.Show("Assessment Model Saved Successful!", da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //update form controls
                    LoadRecordData();
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
                ClearMyControls();
            }
            catch(Exception ex)
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

        private void ClearMyControls()
        {
            try
            {
                //refresh grid
               // da.LoadGridData(grid, null, da.ReadFileDataTable("assessmentmodel.txt", false));

                //clear using class method
                da.ClearFormControls(this);

                //set focus
                txtAssessID.Focus();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LoadRecordData()
        {
            try
            {
                string[] readFile = da.ReadFileText(@"assessmentmodel.txt");
                //load control values
                txtAssessID.Text = readFile[0];
                dtpDate.Value = Convert.ToDateTime(readFile[1]);
                txtTest.Text = readFile[2];
                txtAssignment.Text = readFile[3];
                txtCourseWork.Text = readFile[4];
                txtFinalExam.Text = readFile[5];
                

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //method to validate data entries
        public bool Validate()
        {
            try
            {
                bool isValid = false;
                //check if model id and date values have been enetered
                if (dv.isPresent(txtAssessID, "Model ID"))
                {

                    //check if numeric values have been enetered
                    if (dv.isValidNumeral(txtTest, "Assessment Test", 0, 100) &&
                        dv.isValidNumeral(txtAssignment, "Assignment", 0, 100) &&
                        dv.isValidNumeral(txtCourseWork, "CourseWork", 0, 100) &&
                        dv.isValidNumeral(txtFinalExam, "Final Exam", 0, 100))
                    {
                        isValid = true;
                    }

                }
                return isValid;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
