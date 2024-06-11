namespace GradeBook_ICT23_014
{
    partial class FrmGrading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGrading));
            panel3 = new Panel();
            btnClear = new Button();
            btnSearch = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            btnClose = new Button();
            grid = new DataGridView();
            panel2 = new Panel();
            dtpDate = new DateTimePicker();
            label5 = new Label();
            txtGrade = new TextBox();
            txtTo = new TextBox();
            txtFrom = new TextBox();
            txtGradeID = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label12 = new Label();
            label10 = new Label();
            label11 = new Label();
            pictureBox2 = new PictureBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.DarkSlateGray;
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(btnSearch);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnUpdate);
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(btnClose);
            panel3.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel3.Location = new Point(0, 162);
            panel3.Margin = new Padding(2, 3, 2, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1261, 62);
            panel3.TabIndex = 18;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClear.BackColor = Color.DarkSlateGray;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Location = new Point(878, -1);
            btnClear.Margin = new Padding(2, 3, 2, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(88, 62);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DarkSlateGray;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(185, 3);
            btnSearch.Margin = new Padding(2, 3, 2, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(109, 62);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.DarkSlateGray;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(985, 0);
            btnDelete.Margin = new Padding(2, 3, 2, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(98, 62);
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
            btnUpdate.Location = new Point(536, -1);
            btnUpdate.Margin = new Padding(2, 3, 2, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(124, 62);
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
            btnSave.Location = new Point(373, 1);
            btnSave.Margin = new Padding(2, 3, 2, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(105, 62);
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
            btnClose.ForeColor = Color.Red;
            btnClose.Location = new Point(1104, 1);
            btnClose.Margin = new Padding(2, 3, 2, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 62);
            btnClose.TabIndex = 0;
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
            grid.Location = new Point(2, 229);
            grid.Margin = new Padding(2, 3, 2, 3);
            grid.Name = "grid";
            grid.ReadOnly = true;
            grid.RowHeadersWidth = 51;
            grid.Size = new Size(1257, 274);
            grid.TabIndex = 17;
            grid.CellClick += grid_CellClick;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(dtpDate);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtGrade);
            panel2.Controls.Add(txtTo);
            panel2.Controls.Add(txtFrom);
            panel2.Controls.Add(txtGradeID);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(grid);
            panel2.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(43, 130);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1261, 506);
            panel2.TabIndex = 0;
            // 
            // dtpDate
            // 
            dtpDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dtpDate.Font = new Font("Century Schoolbook", 13.8F);
            dtpDate.Location = new Point(243, 77);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(371, 35);
            dtpDate.TabIndex = 28;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Font = new Font("Century Schoolbook", 13.8F);
            label5.Location = new Point(243, 49);
            label5.Name = "label5";
            label5.Size = new Size(169, 28);
            label5.TabIndex = 27;
            label5.Text = "Date Recorded";
            // 
            // txtGrade
            // 
            txtGrade.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtGrade.Font = new Font("Century Schoolbook", 13.8F);
            txtGrade.Location = new Point(1006, 79);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(176, 35);
            txtGrade.TabIndex = 26;
            // 
            // txtTo
            // 
            txtTo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtTo.Font = new Font("Century Schoolbook", 13.8F);
            txtTo.Location = new Point(842, 79);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(100, 35);
            txtTo.TabIndex = 25;
            // 
            // txtFrom
            // 
            txtFrom.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtFrom.Font = new Font("Century Schoolbook", 13.8F);
            txtFrom.Location = new Point(678, 79);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(100, 35);
            txtFrom.TabIndex = 24;
            // 
            // txtGradeID
            // 
            txtGradeID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtGradeID.BackColor = SystemColors.GradientInactiveCaption;
            txtGradeID.Font = new Font("Century Schoolbook", 13.8F);
            txtGradeID.Location = new Point(79, 79);
            txtGradeID.Name = "txtGradeID";
            txtGradeID.ReadOnly = true;
            txtGradeID.Size = new Size(114, 35);
            txtGradeID.TabIndex = 23;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new Font("Century Schoolbook", 13.8F);
            label4.Location = new Point(1005, 49);
            label4.Name = "label4";
            label4.Size = new Size(78, 28);
            label4.TabIndex = 22;
            label4.Text = "Grade";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 13.8F);
            label3.Location = new Point(839, 49);
            label3.Name = "label3";
            label3.Size = new Size(111, 28);
            label3.TabIndex = 21;
            label3.Text = "Grade To";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 13.8F);
            label2.Location = new Point(659, 48);
            label2.Name = "label2";
            label2.Size = new Size(141, 28);
            label2.TabIndex = 20;
            label2.Text = "Grade From";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 13.8F);
            label1.Location = new Point(77, 49);
            label1.Name = "label1";
            label1.Size = new Size(111, 28);
            label1.TabIndex = 19;
            label1.Text = "Grade ID";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1346, 656);
            panel1.TabIndex = 1;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(1036, 33);
            label12.Name = "label12";
            label12.Size = new Size(268, 27);
            label12.TabIndex = 31;
            label12.Text = "GRADING CRITERIA";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Schoolbook", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(76, 27);
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
            label11.Location = new Point(83, 7);
            label11.Name = "label11";
            label11.Size = new Size(201, 23);
            label11.TabIndex = 29;
            label11.Text = "School of Computing";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(74, 55);
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // FrmGrading
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 725);
            Controls.Add(panel1);
            Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmGrading";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grading Criteria";
            Load += FrmGrading_Load;
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button btnClear;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
        private Button btnClose;
        private DataGridView grid;
        private Panel panel2;
        private Panel panel1;
        private TextBox txtGradeID;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtGrade;
        private TextBox txtTo;
        private TextBox txtFrom;
        private DateTimePicker dtpDate;
        private Label label5;
        private Label label12;
        private Label label10;
        private Label label11;
        private PictureBox pictureBox2;
    }
}