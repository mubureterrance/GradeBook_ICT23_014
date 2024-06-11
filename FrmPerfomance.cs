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
    public partial class FrmPerfomance : Form
    {
        DataAcces da = new DataAcces();
        string filepath = "modules.txt";
        public FrmPerfomance()
        {
            InitializeComponent();
        }

        private void FrmPerfomance_Load(object sender, EventArgs e)
        {
            try
            {
                //form resizing and location setting
                //get the form dimensions 
                System.Drawing.Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
                this.Size = new System.Drawing.Size(workingArea.Width, workingArea.Height);

                //set location of form to upper left corner
                this.Location = new System.Drawing.Point(0, 0);


                //load modules values to dropdown
                da.LoadDropDown(cboModule, "modules.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboModule.SelectedValue != null)
                {
                    //get module name
                    string moduleName = "";
                    //module names valules
                    string[] modules = { "", "Programming with C#", "Web and Multimedia Development", "Systems Development" };

                    string[] moduleCodes = File.ReadAllLines(filepath);
                    int index = -1;

                    foreach (string module in moduleCodes)
                    {
                        index += 1;
                        if (module.ToString() == cboModule.SelectedValue.ToString())
                        {

                            txtModuleName.Text = modules[index];
                            break;
                        }
                    }

                    //get total students doing the module
                    List<dynamic> students = new List<dynamic>(da.ReadFileData("students.txt"));
                    int totalStudents = 0;
                    foreach (dynamic student in students)
                    {
                        if (student[8] == cboModule.SelectedValue.ToString())
                        {
                            totalStudents += 1;
                        }
                    }

                    txtTotalStudents.Text = totalStudents.ToString();

                    //get total students who Wrote this module and have marks recorded 
                    List<dynamic> written = new List<dynamic>(da.ReadFileData("marks.txt"));
                    int totalWritten = 0;
                    int totalFailed = 0;
                    int totalPassed = 0;
                    foreach (dynamic write in written)
                    {
                        if (write[1] == cboModule.SelectedValue.ToString())
                        {
                            totalWritten += 1;
                            if (write[6].Contains("Fail") || write[6].Contains("Supp"))
                            {
                                totalFailed += 1;
                            }
                            else
                            {
                                totalPassed += 1;
                            }

                        }
                    }

                    //int totalWitten = students.Count;
                    txtTotalWritten.Text = totalWritten.ToString();

                    //show total passed and total failed in the textBox
                    txtTotalFailed.Text = totalFailed.ToString();
                    txtTotalPassed.Text = totalPassed.ToString();

                    //compute pass rate and fail rate
                    double passRate = 0;
                    double failRate = 0;
                    if (totalWritten > 0)
                    {
                        passRate = 100 * totalPassed / totalWritten;
                        failRate = 100 * totalFailed / totalWritten;
                    }

                    txtFailRate.Text = Convert.ToInt32(failRate).ToString();
                    txtPassRate.Text = Convert.ToInt32(passRate).ToString();

                }
                else
                {
                    MessageBox.Show("Please select module code from the dropdown list", da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


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

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
