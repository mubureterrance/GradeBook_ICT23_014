namespace GradeBook_ICT23_014
{
    partial class FrmCaptureMarks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCaptureMarks));
            panel1 = new Panel();
            label12 = new Label();
            label11 = new Label();
            label13 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            btnClose = new Button();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            txtModuleMark = new TextBox();
            txtGrade = new TextBox();
            label7 = new Label();
            txtTest = new TextBox();
            label9 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtAssignment = new TextBox();
            txtFinalExam = new TextBox();
            groupBox1 = new GroupBox();
            txtGender = new TextBox();
            label15 = new Label();
            txtLastname = new TextBox();
            txtFirstname = new TextBox();
            label14 = new Label();
            label2 = new Label();
            cboStudentID = new ComboBox();
            btnSearch = new Button();
            label1 = new Label();
            label10 = new Label();
            cboStaffID = new ComboBox();
            cboModule = new ComboBox();
            grid = new DataGridView();
            dtpDate = new DateTimePicker();
            label8 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1777, 923);
            panel1.TabIndex = 2;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(1370, 36);
            label12.Name = "label12";
            label12.Size = new Size(366, 27);
            label12.TabIndex = 31;
            label12.Text = "CAPTURE STUDENT MARKS";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Schoolbook", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(86, 33);
            label11.Name = "label11";
            label11.Size = new Size(200, 33);
            label11.TabIndex = 30;
            label11.Text = "GRADEBOOK";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(94, 7);
            label13.Name = "label13";
            label13.Size = new Size(201, 23);
            label13.TabIndex = 29;
            label13.Text = "School of Computing";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(2, 1);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(85, 73);
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.DarkSlateGray;
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnUpdate);
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(btnClose);
            panel3.Location = new Point(34, 394);
            panel3.Margin = new Padding(2, 4, 2, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1705, 57);
            panel3.TabIndex = 23;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClear.BackColor = Color.DarkSlateGray;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(1308, 1);
            btnClear.Margin = new Padding(2, 4, 2, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(90, 57);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.DarkSlateGray;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold);
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(1421, 0);
            btnDelete.Margin = new Padding(2, 4, 2, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(101, 57);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkSlateGray;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(519, 1);
            btnUpdate.Margin = new Padding(2, 4, 2, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(127, 57);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkSlateGray;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(345, 1);
            btnSave.Margin = new Padding(2, 4, 2, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 57);
            btnSave.TabIndex = 19;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.DarkSlateGray;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold);
            btnClose.ForeColor = Color.Red;
            btnClose.Location = new Point(1544, 1);
            btnClose.Margin = new Padding(2, 4, 2, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(90, 57);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(cboStaffID);
            panel2.Controls.Add(cboModule);
            panel2.Controls.Add(grid);
            panel2.Controls.Add(dtpDate);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label3);
            panel2.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(34, 82);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1705, 837);
            panel2.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.Controls.Add(txtModuleMark);
            groupBox2.Controls.Add(txtGrade);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtTest);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtAssignment);
            groupBox2.Controls.Add(txtFinalExam);
            groupBox2.Location = new Point(1160, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(508, 281);
            groupBox2.TabIndex = 39;
            groupBox2.TabStop = false;
            groupBox2.Text = "Module Marks";
            // 
            // txtModuleMark
            // 
            txtModuleMark.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtModuleMark.BackColor = SystemColors.Info;
            txtModuleMark.Font = new Font("Century Schoolbook", 13.8F);
            txtModuleMark.Location = new Point(255, 181);
            txtModuleMark.Margin = new Padding(3, 4, 3, 4);
            txtModuleMark.Name = "txtModuleMark";
            txtModuleMark.ReadOnly = true;
            txtModuleMark.Size = new Size(213, 35);
            txtModuleMark.TabIndex = 40;
            txtModuleMark.TextAlign = HorizontalAlignment.Center;
            // 
            // txtGrade
            // 
            txtGrade.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtGrade.BackColor = SystemColors.Info;
            txtGrade.Font = new Font("Century Schoolbook", 13.8F);
            txtGrade.Location = new Point(255, 232);
            txtGrade.Margin = new Padding(3, 4, 3, 4);
            txtGrade.Name = "txtGrade";
            txtGrade.ReadOnly = true;
            txtGrade.Size = new Size(213, 35);
            txtGrade.TabIndex = 41;
            txtGrade.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label7.AutoSize = true;
            label7.Font = new Font("Century Schoolbook", 13.8F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(64, 235);
            label7.Name = "label7";
            label7.Size = new Size(170, 28);
            label7.TabIndex = 39;
            label7.Text = "Module Grade:";
            // 
            // txtTest
            // 
            txtTest.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtTest.Font = new Font("Century Schoolbook", 13.8F);
            txtTest.Location = new Point(254, 31);
            txtTest.Margin = new Padding(3, 4, 3, 4);
            txtTest.Name = "txtTest";
            txtTest.Size = new Size(214, 35);
            txtTest.TabIndex = 38;
            txtTest.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label9.AutoSize = true;
            label9.Font = new Font("Century Schoolbook", 13.8F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(70, 185);
            label9.Name = "label9";
            label9.Size = new Size(163, 28);
            label9.TabIndex = 36;
            label9.Text = "Module Mark:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.Font = new Font("Century Schoolbook", 13.8F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(86, 83);
            label6.Name = "label6";
            label6.Size = new Size(145, 28);
            label6.TabIndex = 35;
            label6.Text = "Assignment:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Font = new Font("Century Schoolbook", 13.8F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(87, 133);
            label5.Name = "label5";
            label5.Size = new Size(142, 28);
            label5.TabIndex = 34;
            label5.Text = "Final Exam:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new Font("Century Schoolbook", 13.8F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(41, 35);
            label4.Name = "label4";
            label4.Size = new Size(199, 28);
            label4.TabIndex = 33;
            label4.Text = "Assessment Test:";
            // 
            // txtAssignment
            // 
            txtAssignment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtAssignment.Font = new Font("Century Schoolbook", 13.8F);
            txtAssignment.Location = new Point(255, 79);
            txtAssignment.Margin = new Padding(3, 4, 3, 4);
            txtAssignment.Name = "txtAssignment";
            txtAssignment.Size = new Size(213, 35);
            txtAssignment.TabIndex = 32;
            txtAssignment.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFinalExam
            // 
            txtFinalExam.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtFinalExam.Font = new Font("Century Schoolbook", 13.8F);
            txtFinalExam.Location = new Point(255, 129);
            txtFinalExam.Margin = new Padding(3, 4, 3, 4);
            txtFinalExam.Name = "txtFinalExam";
            txtFinalExam.Size = new Size(213, 35);
            txtFinalExam.TabIndex = 37;
            txtFinalExam.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtGender);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(txtLastname);
            groupBox1.Controls.Add(txtFirstname);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cboStudentID);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(39, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(476, 281);
            groupBox1.TabIndex = 38;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Details";
            // 
            // txtGender
            // 
            txtGender.BackColor = SystemColors.Info;
            txtGender.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGender.Location = new Point(144, 219);
            txtGender.Name = "txtGender";
            txtGender.ReadOnly = true;
            txtGender.Size = new Size(307, 35);
            txtGender.TabIndex = 46;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Schoolbook", 13.8F);
            label15.ForeColor = Color.White;
            label15.Location = new Point(4, 222);
            label15.Name = "label15";
            label15.Size = new Size(91, 28);
            label15.TabIndex = 45;
            label15.Text = "Gender";
            // 
            // txtLastname
            // 
            txtLastname.BackColor = SystemColors.Info;
            txtLastname.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastname.Location = new Point(144, 163);
            txtLastname.Name = "txtLastname";
            txtLastname.ReadOnly = true;
            txtLastname.Size = new Size(307, 35);
            txtLastname.TabIndex = 44;
            // 
            // txtFirstname
            // 
            txtFirstname.BackColor = SystemColors.Info;
            txtFirstname.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstname.Location = new Point(145, 100);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.ReadOnly = true;
            txtFirstname.Size = new Size(307, 35);
            txtFirstname.TabIndex = 43;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Schoolbook", 13.8F);
            label14.ForeColor = Color.White;
            label14.Location = new Point(4, 163);
            label14.Name = "label14";
            label14.Size = new Size(119, 28);
            label14.TabIndex = 42;
            label14.Text = "Lastname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 13.8F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 102);
            label2.Name = "label2";
            label2.Size = new Size(123, 28);
            label2.TabIndex = 41;
            label2.Text = "Firstname";
            // 
            // cboStudentID
            // 
            cboStudentID.Font = new Font("Century Schoolbook", 13.8F);
            cboStudentID.FormattingEnabled = true;
            cboStudentID.Location = new Point(146, 36);
            cboStudentID.Margin = new Padding(3, 4, 3, 4);
            cboStudentID.Name = "cboStudentID";
            cboStudentID.Size = new Size(208, 36);
            cboStudentID.TabIndex = 40;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DarkSlateGray;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Century Schoolbook", 13.8F);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(359, 37);
            btnSearch.Margin = new Padding(2, 4, 2, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 36);
            btnSearch.TabIndex = 39;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 13.8F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(4, 42);
            label1.Name = "label1";
            label1.Size = new Size(136, 28);
            label1.TabIndex = 38;
            label1.Text = "Student ID:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label10.AutoSize = true;
            label10.Font = new Font("Century Schoolbook", 13.8F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(588, 164);
            label10.Name = "label10";
            label10.Size = new Size(103, 28);
            label10.TabIndex = 28;
            label10.Text = "Staff ID:";
            // 
            // cboStaffID
            // 
            cboStaffID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cboStaffID.Font = new Font("Century Schoolbook", 13.8F);
            cboStaffID.FormattingEnabled = true;
            cboStaffID.Location = new Point(716, 158);
            cboStaffID.Margin = new Padding(3, 4, 3, 4);
            cboStaffID.Name = "cboStaffID";
            cboStaffID.Size = new Size(365, 36);
            cboStaffID.TabIndex = 27;
            // 
            // cboModule
            // 
            cboModule.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cboModule.Font = new Font("Century Schoolbook", 13.8F);
            cboModule.FormattingEnabled = true;
            cboModule.Location = new Point(716, 34);
            cboModule.Margin = new Padding(3, 4, 3, 4);
            cboModule.Name = "cboModule";
            cboModule.Size = new Size(365, 36);
            cboModule.TabIndex = 22;
            // 
            // grid
            // 
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeRows = false;
            grid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.BackgroundColor = SystemColors.ActiveCaption;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid.GridColor = SystemColors.GradientActiveCaption;
            grid.Location = new Point(-3, 377);
            grid.Margin = new Padding(3, 4, 3, 4);
            grid.Name = "grid";
            grid.ReadOnly = true;
            grid.RowHeadersWidth = 51;
            grid.Size = new Size(1705, 455);
            grid.TabIndex = 17;
            grid.CellClick += grid_CellClick;
            // 
            // dtpDate
            // 
            dtpDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dtpDate.Font = new Font("Century Schoolbook", 13.8F);
            dtpDate.Location = new Point(716, 96);
            dtpDate.Margin = new Padding(3, 4, 3, 4);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(366, 35);
            dtpDate.TabIndex = 15;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label8.AutoSize = true;
            label8.Font = new Font("Century Schoolbook", 13.8F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(529, 100);
            label8.Name = "label8";
            label8.Size = new Size(175, 28);
            label8.TabIndex = 14;
            label8.Text = "Date Recorded:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 13.8F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(596, 36);
            label3.Name = "label3";
            label3.Size = new Size(98, 28);
            label3.TabIndex = 4;
            label3.Text = "Module:";
            // 
            // FrmCaptureMarks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1777, 958);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FrmCaptureMarks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCaptureMarks";
            Load += FrmCaptureMarks_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
        private Button btnClose;
        private Panel panel2;
        private ComboBox cboModule;
        private DataGridView grid;
        private DateTimePicker dtpDate;
        private Label label8;
        private Label label3;
        private Label label10;
        private ComboBox cboStaffID;
        private Label label12;
        private Label label11;
        private Label label13;
        private PictureBox pictureBox2;
        private GroupBox groupBox1;
        private TextBox txtGender;
        private Label label15;
        private TextBox txtLastname;
        private TextBox txtFirstname;
        private Label label14;
        private Label label2;
        private ComboBox cboStudentID;
        private Button btnSearch;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtModuleMark;
        private TextBox txtGrade;
        private Label label7;
        private TextBox txtTest;
        private Label label9;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtAssignment;
        private TextBox txtFinalExam;
    }
}