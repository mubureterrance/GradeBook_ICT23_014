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
    public partial class FrmMain : Form
    {
        //global form section
        DataAcces da = new DataAcces();
        public static string userFullname = "";
        public static string userID = "";
        public static string username = "";
        public static string position = "";
        public FrmMain()
        {
            InitializeComponent();
        }

        //public FrmMain(string user)
        //{
        //    InitializeComponent();
        //    username = user;
        //}

        private void btnRegUser_Click(object sender, EventArgs e)
        {
            try
            {
                Form frm = new FrmRegisterUser();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRegStudent_Click(object sender, EventArgs e)
        {
            try
            {
                Form frm = new FrmRegisterStudent();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnGrading_Click(object sender, EventArgs e)
        {
            try
            {
                Form frm = new FrmGrading();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAssessModel_Click(object sender, EventArgs e)
        {
            try
            {
                Form frm = new FrmAssessmentModel();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
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

        private void btnCaptureMarks_Click(object sender, EventArgs e)
        {
            try
            {
                Form frm = new FrmCaptureMarks();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnViewResults_Click(object sender, EventArgs e)
        {
            try
            {
                Form frm = new FrmViewResults();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {

                //form resizing and location setting
                //get the form dimensions 
                System.Drawing.Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
                this.Size = new System.Drawing.Size(workingArea.Width, workingArea.Height);

                //set location of form to upper left corner
                this.Location = new System.Drawing.Point(0, 0);

                //btnRegUser.Location = 350, 
                //btnRegUser.Location.Y = 
                btnRegUser.Enabled = false;
                btnRegStudent.Enabled = false;
                recordMarksToolStripMenuItem.Enabled = false;
                userToolStripMenuItem.Enabled = false;
                studentToolStripMenuItem.Enabled = false;
                uSERDETAILSToolStripMenuItem.Enabled = false;

                txtWelcome.Text = userFullname;

                if (username == "admin@scis.bw")
                {
                    btnRegUser.Enabled = true;
                    btnRegStudent.Enabled = true;
                    studentToolStripMenuItem.Enabled = true;
                    userToolStripMenuItem.Enabled = true;
                    recordMarksToolStripMenuItem.Enabled = true;
                    uSERDETAILSToolStripMenuItem.Enabled = true;
                }

                if (username == "registrar@scis.bw")
                {
                    btnRegStudent.Enabled = true;
                    studentToolStripMenuItem.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnPerfomance_Click(object sender, EventArgs e)
        {
            try
            {
                Form frm = new FrmPerfomance();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Environment.Exit(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                btnRegUser_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rESULTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                btnViewResults_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void modulePerfomanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                btnPerfomance_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                btnRegStudent_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uSERDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form frm = new FrmUserDetails();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sTUDENTSDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form frm = new FrmStudentsDetails();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void assessmentModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                btnAssessModel_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gradingCriteriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                btnGrading_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void recordMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                btnCaptureMarks_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //confirm system close 
        private bool ConfirmClose()
        {
            try
            {
                //give user option to cancel or confirm systen close
                return MessageBox.Show("Are you sure you want to close the system?", da.GetSystemTitle(), MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

                if (!ConfirmClose())
                {
                    //if user doesn't want to close system cancel event
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void FrmMain_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                this.Text = da.GetSystemTitle();
                StatusLabel1.Text = $"Username: {username}";
                StatusLabelReady.Text = "Ready...";
                StatusLabelDateTime.Text = DateTime.Now.ToString("g");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRegUser_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                StatusLabel.Text = "[Administator control] >> register or update User details";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnRegUser_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                StatusLabel.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnRegStudent_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                StatusLabel.Text = "[Registrar control] >> register or update Student details";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnRegStudent_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                StatusLabel.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnGrading_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                StatusLabel.Text = "[Administrator control] >> update module mark grading criteria settings";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnGrading_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                StatusLabel.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnAssessModel_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                StatusLabel.Text = "[Administrator control] >> update marks assessment model weights";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnAssessModel_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                StatusLabel.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnCaptureMarks_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                StatusLabel.Text = "[Lecturer control] >> record or update student marks";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnCaptureMarks_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                StatusLabel.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnViewResults_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                StatusLabel.Text = "[User control] >> Display all student's marks";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnViewResults_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                StatusLabel.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnPerfomance_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                StatusLabel.Text = "[User control] >> View module perfomance statistics";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                StatusLabel.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnExit_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                StatusLabel.Text = "[User control] >> Exit system";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void exitSystemToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                btnExit_MouseMove(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void userToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                btnRegUser_MouseMove(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void exitSystemToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                btnExit_MouseLeave(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void userToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                btnRegUser_MouseLeave(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void studentToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                btnRegStudent_MouseMove(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void studentToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                btnRegStudent_MouseLeave(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void recordMarksToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                btnCaptureMarks_MouseMove(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void recordMarksToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                btnCaptureMarks_MouseLeave(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void assessmentModelToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            btnAssessModel_MouseLeave(sender, e);
        }

        private void assessmentModelToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            btnAssessModel_MouseMove(sender, e);
        }

        private void gradingCriteriaToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            btnGrading_MouseMove(sender, e);
        }

        private void gradingCriteriaToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            btnGrading_MouseLeave(sender, e);
        }

        private void uSERDETAILSToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                StatusLabel.Text = "[Administrator control] >> [View Only] >> User details";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void uSERDETAILSToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            StatusLabel.Text = string.Empty;
        }

        private void sTUDENTSDETAILSToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                StatusLabel.Text = "[User control] >> [View Only] >> Student details";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void sTUDENTSDETAILSToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            StatusLabel.Text = string.Empty;
        }

        private void rESULTSToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            btnViewResults_MouseMove(sender, e);
        }

        private void rESULTSToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            btnViewResults_MouseLeave(sender, e);
        }

        private void modulePerfomanceToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            btnPerfomance_MouseMove(sender, e);
        }

        private void btnPerfomance_MouseLeave(object sender, EventArgs e)
        {
            StatusLabel.Text = string.Empty;
        }

        private void modulePerfomanceToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            btnPerfomance_MouseLeave(sender, e);
        }
    }
}
