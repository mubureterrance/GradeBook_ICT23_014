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
    public partial class FrmStudentsDetails : Form
    {
        //instatiate DataAccess class
        DataAcces da = new DataAcces();

        public FrmStudentsDetails()
        {
            InitializeComponent();
        }

        private void FrmStudentsDetails_Load(object sender, EventArgs e)
        {
            try
            {
                //form resizing and location setting
                //get the form dimensions 
                System.Drawing.Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
                this.Size = new System.Drawing.Size(workingArea.Width, workingArea.Height);

                //set location of form to upper left corner
                this.Location = new System.Drawing.Point(0, 0);

                //load grid
                grid.DataSource = da.GetStudentDetails("students.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, da.GetSystemTitle(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
