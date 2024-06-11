namespace GradeBook_ICT23_014
{
    partial class FrmRegisterUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegisterUser));
            panel1 = new Panel();
            label13 = new Label();
            btnSearch = new Button();
            txtSearchID = new TextBox();
            label12 = new Label();
            label10 = new Label();
            label11 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            cboGender = new ComboBox();
            label9 = new Label();
            panel3 = new Panel();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            btnClose = new Button();
            grid = new DataGridView();
            cboPosition = new ComboBox();
            dtpDate = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            txtPhone = new TextBox();
            label6 = new Label();
            txtSurname = new TextBox();
            label5 = new Label();
            txtFirstname = new TextBox();
            label4 = new Label();
            txtPassword = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            txtStaffID = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label13);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearchID);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1298, 770);
            panel1.TabIndex = 303030;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Century Schoolbook", 13.8F);
            label13.Location = new Point(827, 82);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(103, 28);
            label13.TabIndex = 34;
            label13.Text = "Staff ID:";
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = Color.White;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Century Schoolbook", 13.8F);
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(1156, 80);
            btnSearch.Margin = new Padding(2, 3, 2, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(115, 33);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearchID
            // 
            txtSearchID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearchID.Font = new Font("Century Schoolbook", 13.8F);
            txtSearchID.Location = new Point(934, 79);
            txtSearchID.Margin = new Padding(2, 3, 2, 3);
            txtSearchID.Name = "txtSearchID";
            txtSearchID.Size = new Size(337, 35);
            txtSearchID.TabIndex = 0;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Century Schoolbook", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(992, 29);
            label12.Name = "label12";
            label12.Size = new Size(281, 28);
            label12.TabIndex = 31;
            label12.Text = "USER REGISTRATION";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Schoolbook", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(76, 24);
            label10.Name = "label10";
            label10.Size = new Size(200, 33);
            label10.TabIndex = 30;
            label10.Text = "GRADEBOOK";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(83, 4);
            label11.Name = "label11";
            label11.Size = new Size(201, 23);
            label11.TabIndex = 29;
            label11.Text = "School of Computing";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(74, 55);
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(cboGender);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(grid);
            panel2.Controls.Add(cboPosition);
            panel2.Controls.Add(dtpDate);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtPhone);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtSurname);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtFirstname);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtStaffID);
            panel2.Controls.Add(label1);
            panel2.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(25, 120);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1248, 635);
            panel2.TabIndex = 101010;
            panel2.Paint += panel2_Paint;
            // 
            // cboGender
            // 
            cboGender.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cboGender.Font = new Font("Century Schoolbook", 13.8F);
            cboGender.FormattingEnabled = true;
            cboGender.Location = new Point(819, 173);
            cboGender.Margin = new Padding(2, 3, 2, 3);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(365, 36);
            cboGender.TabIndex = 60;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label9.AutoSize = true;
            label9.Font = new Font("Century Schoolbook", 13.8F);
            label9.Location = new Point(709, 179);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(97, 28);
            label9.TabIndex = 19;
            label9.Text = "Gender:";
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
            panel3.Location = new Point(0, 289);
            panel3.Margin = new Padding(2, 3, 2, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1248, 62);
            panel3.TabIndex = 202020;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClear.BackColor = Color.DarkSlateGray;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold);
            btnClear.Location = new Point(839, 1);
            btnClear.Margin = new Padding(2, 3, 2, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(108, 62);
            btnClear.TabIndex = 300;
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
            btnDelete.Location = new Point(975, 1);
            btnDelete.Margin = new Padding(2, 3, 2, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(108, 62);
            btnDelete.TabIndex = 400;
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
            btnUpdate.Location = new Point(625, 0);
            btnUpdate.Margin = new Padding(2, 3, 2, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(117, 62);
            btnUpdate.TabIndex = 200;
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
            btnSave.Location = new Point(423, 1);
            btnSave.Margin = new Padding(2, 3, 2, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 62);
            btnSave.TabIndex = 100;
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
            btnClose.Location = new Point(1105, 1);
            btnClose.Margin = new Padding(2, 3, 2, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 62);
            btnClose.TabIndex = 500;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // grid
            // 
            grid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.BackgroundColor = SystemColors.ActiveCaption;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid.Location = new Point(2, 365);
            grid.Margin = new Padding(2, 3, 2, 3);
            grid.Name = "grid";
            grid.ReadOnly = true;
            grid.RowHeadersWidth = 51;
            grid.Size = new Size(1244, 261);
            grid.TabIndex = 800;
            grid.CellClick += grid_CellClick;
            // 
            // cboPosition
            // 
            cboPosition.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cboPosition.Font = new Font("Century Schoolbook", 13.8F);
            cboPosition.FormattingEnabled = true;
            cboPosition.Location = new Point(819, 226);
            cboPosition.Margin = new Padding(2, 3, 2, 3);
            cboPosition.Name = "cboPosition";
            cboPosition.Size = new Size(365, 36);
            cboPosition.TabIndex = 70;
            // 
            // dtpDate
            // 
            dtpDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dtpDate.Font = new Font("Century Schoolbook", 13.8F);
            dtpDate.Location = new Point(820, 17);
            dtpDate.Margin = new Padding(2, 3, 2, 3);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(365, 35);
            dtpDate.TabIndex = 80;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label8.AutoSize = true;
            label8.Font = new Font("Century Schoolbook", 13.8F);
            label8.Location = new Point(591, 22);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(215, 28);
            label8.TabIndex = 14;
            label8.Text = "Registration Date: ";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label7.AutoSize = true;
            label7.Font = new Font("Century Schoolbook", 13.8F);
            label7.Location = new Point(701, 231);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(105, 28);
            label7.TabIndex = 12;
            label7.Text = "Position:";
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtPhone.Font = new Font("Century Schoolbook", 13.8F);
            txtPhone.Location = new Point(244, 178);
            txtPhone.Margin = new Padding(2, 3, 2, 3);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(289, 35);
            txtPhone.TabIndex = 50;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.Font = new Font("Century Schoolbook", 13.8F);
            label6.Location = new Point(61, 183);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(179, 28);
            label6.TabIndex = 10;
            label6.Text = "Phone Number:";
            // 
            // txtSurname
            // 
            txtSurname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtSurname.Font = new Font("Century Schoolbook", 13.8F);
            txtSurname.Location = new Point(819, 69);
            txtSurname.Margin = new Padding(2, 3, 2, 3);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(365, 35);
            txtSurname.TabIndex = 40;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Font = new Font("Century Schoolbook", 13.8F);
            label5.Location = new Point(691, 76);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(115, 28);
            label5.TabIndex = 8;
            label5.Text = "Surname:";
            // 
            // txtFirstname
            // 
            txtFirstname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtFirstname.Font = new Font("Century Schoolbook", 13.8F);
            txtFirstname.Location = new Point(246, 69);
            txtFirstname.Margin = new Padding(2, 3, 2, 3);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(289, 35);
            txtFirstname.TabIndex = 30;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new Font("Century Schoolbook", 13.8F);
            label4.Location = new Point(113, 76);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(129, 28);
            label4.TabIndex = 6;
            label4.Text = "Firstname:";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtPassword.Font = new Font("Century Schoolbook", 13.8F);
            txtPassword.Location = new Point(819, 121);
            txtPassword.Margin = new Padding(2, 3, 2, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(365, 35);
            txtPassword.TabIndex = 20;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 13.8F);
            label3.Location = new Point(685, 124);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(121, 28);
            label3.TabIndex = 4;
            label3.Text = "Password:";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtEmail.Font = new Font("Century Schoolbook", 13.8F);
            txtEmail.Location = new Point(246, 121);
            txtEmail.Margin = new Padding(2, 3, 2, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(289, 35);
            txtEmail.TabIndex = 10;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 13.8F);
            label2.Location = new Point(160, 124);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 28);
            label2.TabIndex = 2;
            label2.Text = "Email:";
            // 
            // txtStaffID
            // 
            txtStaffID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtStaffID.BackColor = SystemColors.GradientInactiveCaption;
            txtStaffID.Font = new Font("Century Schoolbook", 13.8F);
            txtStaffID.Location = new Point(244, 19);
            txtStaffID.Margin = new Padding(2, 3, 2, 3);
            txtStaffID.Name = "txtStaffID";
            txtStaffID.ReadOnly = true;
            txtStaffID.Size = new Size(289, 35);
            txtStaffID.TabIndex = 10000;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 13.8F);
            label1.Location = new Point(137, 22);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 28);
            label1.TabIndex = 0;
            label1.Text = "Staff ID:";
            // 
            // FrmRegisterUser
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1298, 827);
            Controls.Add(panel1);
            Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FrmRegisterUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register User";
            WindowState = FormWindowState.Maximized;
            Load += FrmRegisterUser_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label8;
        private Label label7;
        private TextBox txtPhone;
        private Label label6;
        private TextBox txtSurname;
        private Label label5;
        private TextBox txtFirstname;
        private Label label4;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtStaffID;
        private Label label1;
        private ComboBox cboPosition;
        private DateTimePicker dtpDate;
        private DataGridView grid;
        private Panel panel3;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
        private Button btnClose;
        private Button btnSearch;
        private Button btnClear;
        private ComboBox cboGender;
        private Label label9;
        private Label label12;
        private Label label10;
        private Label label11;
        private PictureBox pictureBox2;
        private Label label13;
        private TextBox txtSearchID;
    }
}