namespace GradeBook_ICT23_014
{
    partial class FrmRegisterStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegisterStudent));
            grid = new DataGridView();
            cboModule = new ComboBox();
            dtpDate = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtSurname = new TextBox();
            label3 = new Label();
            txtFirstname = new TextBox();
            label2 = new Label();
            txtStudentID = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            cboProgram = new ComboBox();
            btnSearch = new Button();
            cboLevel = new ComboBox();
            cboGender = new ComboBox();
            label9 = new Label();
            txtCell = new TextBox();
            panel3 = new Panel();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            btnClose = new Button();
            panel1 = new Panel();
            label12 = new Label();
            label10 = new Label();
            label11 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
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
            grid.Location = new Point(0, 311);
            grid.Margin = new Padding(3, 4, 3, 4);
            grid.Name = "grid";
            grid.ReadOnly = true;
            grid.RowHeadersWidth = 51;
            grid.Size = new Size(1262, 368);
            grid.TabIndex = 17;
            grid.CellClick += grid_CellClick;
            // 
            // cboModule
            // 
            cboModule.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cboModule.Font = new Font("Century Schoolbook", 13.8F);
            cboModule.FormattingEnabled = true;
            cboModule.Location = new Point(809, 177);
            cboModule.Margin = new Padding(3, 4, 3, 4);
            cboModule.Name = "cboModule";
            cboModule.Size = new Size(367, 36);
            cboModule.TabIndex = 16;
            // 
            // dtpDate
            // 
            dtpDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dtpDate.Font = new Font("Century Schoolbook", 13.8F);
            dtpDate.Location = new Point(808, 27);
            dtpDate.Margin = new Padding(3, 4, 3, 4);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(367, 35);
            dtpDate.TabIndex = 15;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label8.AutoSize = true;
            label8.Font = new Font("Century Schoolbook", 13.8F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(638, 36);
            label8.Name = "label8";
            label8.Size = new Size(165, 28);
            label8.TabIndex = 14;
            label8.Text = "Date Of Birth:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label7.AutoSize = true;
            label7.Font = new Font("Century Schoolbook", 13.8F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(354, 135);
            label7.Name = "label7";
            label7.Size = new Size(76, 28);
            label7.TabIndex = 12;
            label7.Text = "Level:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.Font = new Font("Century Schoolbook", 13.8F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(79, 181);
            label6.Name = "label6";
            label6.Size = new Size(104, 28);
            label6.TabIndex = 10;
            label6.Text = "Program";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Font = new Font("Century Schoolbook", 13.8F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(718, 135);
            label5.Name = "label5";
            label5.Size = new Size(85, 28);
            label5.TabIndex = 8;
            label5.Text = "Phone:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new Font("Century Schoolbook", 13.8F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(92, 135);
            label4.Name = "label4";
            label4.Size = new Size(91, 28);
            label4.TabIndex = 6;
            label4.Text = "Gender";
            // 
            // txtSurname
            // 
            txtSurname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtSurname.Font = new Font("Century Schoolbook", 13.8F);
            txtSurname.Location = new Point(809, 75);
            txtSurname.Margin = new Padding(3, 4, 3, 4);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(367, 35);
            txtSurname.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 13.8F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(688, 79);
            label3.Name = "label3";
            label3.Size = new Size(115, 28);
            label3.TabIndex = 4;
            label3.Text = "Surname:";
            // 
            // txtFirstname
            // 
            txtFirstname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtFirstname.Font = new Font("Century Schoolbook", 13.8F);
            txtFirstname.Location = new Point(207, 75);
            txtFirstname.Margin = new Padding(3, 4, 3, 4);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(355, 35);
            txtFirstname.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 13.8F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(62, 84);
            label2.Name = "label2";
            label2.Size = new Size(129, 28);
            label2.TabIndex = 2;
            label2.Text = "Firstname:";
            // 
            // txtStudentID
            // 
            txtStudentID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtStudentID.Font = new Font("Century Schoolbook", 13.8F);
            txtStudentID.Location = new Point(206, 27);
            txtStudentID.Margin = new Padding(3, 4, 3, 4);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(355, 35);
            txtStudentID.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 13.8F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(58, 31);
            label1.Name = "label1";
            label1.Size = new Size(136, 28);
            label1.TabIndex = 0;
            label1.Text = "Student ID:";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(cboProgram);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(cboLevel);
            panel2.Controls.Add(cboGender);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(grid);
            panel2.Controls.Add(cboModule);
            panel2.Controls.Add(dtpDate);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtSurname);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtFirstname);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtStudentID);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtCell);
            panel2.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(34, 121);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1262, 688);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // cboProgram
            // 
            cboProgram.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cboProgram.Font = new Font("Century Schoolbook", 13.8F);
            cboProgram.FormattingEnabled = true;
            cboProgram.Location = new Point(206, 177);
            cboProgram.Margin = new Padding(3, 4, 3, 4);
            cboProgram.Name = "cboProgram";
            cboProgram.Size = new Size(355, 36);
            cboProgram.TabIndex = 22;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top;
            btnSearch.BackColor = Color.White;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Century Schoolbook", 13.8F);
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(415, 28);
            btnSearch.Margin = new Padding(2, 4, 2, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(145, 32);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // cboLevel
            // 
            cboLevel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cboLevel.Font = new Font("Century Schoolbook", 13.8F);
            cboLevel.FormattingEnabled = true;
            cboLevel.Location = new Point(431, 129);
            cboLevel.Margin = new Padding(3, 4, 3, 4);
            cboLevel.Name = "cboLevel";
            cboLevel.Size = new Size(130, 36);
            cboLevel.TabIndex = 21;
            // 
            // cboGender
            // 
            cboGender.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cboGender.Font = new Font("Century Schoolbook", 13.8F);
            cboGender.FormattingEnabled = true;
            cboGender.Location = new Point(206, 128);
            cboGender.Margin = new Padding(3, 4, 3, 4);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(142, 36);
            cboGender.TabIndex = 20;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label9.AutoSize = true;
            label9.Font = new Font("Century Schoolbook", 13.8F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(705, 181);
            label9.Name = "label9";
            label9.Size = new Size(98, 28);
            label9.TabIndex = 19;
            label9.Text = "Module:";
            // 
            // txtCell
            // 
            txtCell.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtCell.Font = new Font("Century Schoolbook", 13.8F);
            txtCell.Location = new Point(808, 125);
            txtCell.Margin = new Padding(3, 4, 3, 4);
            txtCell.Name = "txtCell";
            txtCell.Size = new Size(367, 35);
            txtCell.TabIndex = 23;
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
            panel3.Location = new Point(34, 367);
            panel3.Margin = new Padding(2, 4, 2, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1262, 62);
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
            btnClear.Location = new Point(845, 1);
            btnClear.Margin = new Padding(2, 4, 2, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(99, 62);
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
            btnDelete.Location = new Point(974, 0);
            btnDelete.Margin = new Padding(2, 4, 2, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(105, 62);
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
            btnUpdate.Location = new Point(545, 0);
            btnUpdate.Margin = new Padding(2, 4, 2, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(134, 62);
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
            btnSave.Location = new Point(351, 0);
            btnSave.Margin = new Padding(2, 4, 2, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(141, 62);
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
            btnClose.Location = new Point(1101, 1);
            btnClose.Margin = new Padding(2, 4, 2, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(104, 62);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1334, 833);
            panel1.TabIndex = 1;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(961, 37);
            label12.Name = "label12";
            label12.Size = new Size(340, 27);
            label12.TabIndex = 27;
            label12.Text = "STUDENT REGISTRATION";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Schoolbook", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(85, 32);
            label10.Name = "label10";
            label10.Size = new Size(200, 33);
            label10.TabIndex = 26;
            label10.Text = "GRADEBOOK";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(93, 5);
            label11.Name = "label11";
            label11.Size = new Size(201, 23);
            label11.TabIndex = 25;
            label11.Text = "School of Computing";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1, 0);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(85, 73);
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // FrmRegisterStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 920);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FrmRegisterStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register Student";
            Load += FrmRegisterStudent_Load;
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView grid;
        private ComboBox cboModule;
        private DateTimePicker dtpDate;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Label label8;
        private Label label7;
        private TextBox textBox6;
        private Label label6;

        public TextBox txtPhone { get; private set; }

        private TextBox textBox5;
        private Label label5;
        private TextBox textBox4;
        private Label label4;
        private TextBox txtSurname;
        private TextBox textBox3;
        private Label label3;
        private TextBox txtFirstname;
        private TextBox textBox2;
        private Label label2;
        private TextBox txtStudentID;
        private Label label1;
        private Panel panel2;
        private Label label9;
        private Panel panel1;
        private ComboBox cboProgram;
        private ComboBox cboLevel;
        private ComboBox cboGender;
        private Panel panel3;
        private Button btnClear;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
        private Button btnClose;
        private TextBox txtCell;
        private Label label12;
        private Label label10;
        private Label label11;
        private PictureBox pictureBox2;
        //private TextBox txtPhone;
    }
}