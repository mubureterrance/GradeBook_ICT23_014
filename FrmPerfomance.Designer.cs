namespace GradeBook_ICT23_014
{
    partial class FrmPerfomance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPerfomance));
            btnLoad = new Button();
            label10 = new Label();
            label11 = new Label();
            pictureBox2 = new PictureBox();
            label12 = new Label();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtModuleName = new TextBox();
            txtTotalStudents = new TextBox();
            txtTotalWritten = new TextBox();
            txtTotalPassed = new TextBox();
            txtTotalFailed = new TextBox();
            txtPassRate = new TextBox();
            txtFailRate = new TextBox();
            cboModule = new ComboBox();
            panel1 = new Panel();
            panel3 = new Panel();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLoad.BackColor = Color.DarkSlateGray;
            btnLoad.FlatAppearance.BorderSize = 0;
            btnLoad.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            btnLoad.FlatStyle = FlatStyle.Flat;
            btnLoad.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoad.ForeColor = Color.White;
            btnLoad.Location = new Point(463, 0);
            btnLoad.Margin = new Padding(2, 4, 2, 4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(202, 62);
            btnLoad.TabIndex = 19;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Schoolbook", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(87, 32);
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
            label11.Location = new Point(95, 5);
            label11.Name = "label11";
            label11.Size = new Size(201, 23);
            label11.TabIndex = 29;
            label11.Text = "School of Computing";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 0);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(85, 73);
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Century Schoolbook", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(815, 37);
            label12.Name = "label12";
            label12.Size = new Size(312, 28);
            label12.TabIndex = 31;
            label12.Text = "MODULE PERFOMANCE";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Font = new Font("Century Schoolbook", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(125, 105);
            panel2.Margin = new Padding(2, 4, 2, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1002, 665);
            panel2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.07985F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.92015F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(label7, 0, 6);
            tableLayoutPanel1.Controls.Add(label8, 0, 7);
            tableLayoutPanel1.Controls.Add(txtModuleName, 1, 1);
            tableLayoutPanel1.Controls.Add(txtTotalStudents, 1, 2);
            tableLayoutPanel1.Controls.Add(txtTotalWritten, 1, 3);
            tableLayoutPanel1.Controls.Add(txtTotalPassed, 1, 4);
            tableLayoutPanel1.Controls.Add(txtTotalFailed, 1, 5);
            tableLayoutPanel1.Controls.Add(txtPassRate, 1, 6);
            tableLayoutPanel1.Controls.Add(txtFailRate, 1, 7);
            tableLayoutPanel1.Controls.Add(cboModule, 1, 0);
            tableLayoutPanel1.Font = new Font("Century Schoolbook", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel1.Location = new Point(172, 94);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(690, 424);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(4, 1);
            label1.Name = "label1";
            label1.Size = new Size(194, 35);
            label1.TabIndex = 0;
            label1.Text = "Module Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(4, 53);
            label2.Name = "label2";
            label2.Size = new Size(208, 35);
            label2.TabIndex = 1;
            label2.Text = "Module Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(4, 106);
            label3.Name = "label3";
            label3.Size = new Size(221, 35);
            label3.TabIndex = 2;
            label3.Text = "Total Students";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(4, 159);
            label4.Name = "label4";
            label4.Size = new Size(204, 35);
            label4.TabIndex = 3;
            label4.Text = "Total Written";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(4, 212);
            label5.Name = "label5";
            label5.Size = new Size(193, 35);
            label5.TabIndex = 4;
            label5.Text = "Total Passed";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(4, 265);
            label6.Name = "label6";
            label6.Size = new Size(183, 35);
            label6.TabIndex = 5;
            label6.Text = "Total Failed";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(4, 318);
            label7.Name = "label7";
            label7.Size = new Size(187, 35);
            label7.TabIndex = 6;
            label7.Text = "Pass Rate %";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(4, 371);
            label8.Name = "label8";
            label8.Size = new Size(177, 35);
            label8.TabIndex = 7;
            label8.Text = "Fail Rate %";
            // 
            // txtModuleName
            // 
            txtModuleName.BackColor = Color.SteelBlue;
            txtModuleName.ForeColor = Color.White;
            txtModuleName.Location = new Point(232, 57);
            txtModuleName.Margin = new Padding(3, 4, 3, 4);
            txtModuleName.Name = "txtModuleName";
            txtModuleName.ReadOnly = true;
            txtModuleName.Size = new Size(446, 44);
            txtModuleName.TabIndex = 9;
            txtModuleName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTotalStudents
            // 
            txtTotalStudents.BackColor = Color.SteelBlue;
            txtTotalStudents.ForeColor = Color.White;
            txtTotalStudents.Location = new Point(232, 110);
            txtTotalStudents.Margin = new Padding(3, 4, 3, 4);
            txtTotalStudents.Name = "txtTotalStudents";
            txtTotalStudents.ReadOnly = true;
            txtTotalStudents.Size = new Size(446, 44);
            txtTotalStudents.TabIndex = 10;
            txtTotalStudents.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTotalWritten
            // 
            txtTotalWritten.BackColor = Color.SteelBlue;
            txtTotalWritten.ForeColor = Color.White;
            txtTotalWritten.Location = new Point(232, 163);
            txtTotalWritten.Margin = new Padding(3, 4, 3, 4);
            txtTotalWritten.Name = "txtTotalWritten";
            txtTotalWritten.ReadOnly = true;
            txtTotalWritten.Size = new Size(446, 44);
            txtTotalWritten.TabIndex = 11;
            txtTotalWritten.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTotalPassed
            // 
            txtTotalPassed.BackColor = Color.SteelBlue;
            txtTotalPassed.ForeColor = Color.White;
            txtTotalPassed.Location = new Point(232, 216);
            txtTotalPassed.Margin = new Padding(3, 4, 3, 4);
            txtTotalPassed.Name = "txtTotalPassed";
            txtTotalPassed.ReadOnly = true;
            txtTotalPassed.Size = new Size(446, 44);
            txtTotalPassed.TabIndex = 12;
            txtTotalPassed.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTotalFailed
            // 
            txtTotalFailed.BackColor = Color.SteelBlue;
            txtTotalFailed.ForeColor = Color.White;
            txtTotalFailed.Location = new Point(232, 269);
            txtTotalFailed.Margin = new Padding(3, 4, 3, 4);
            txtTotalFailed.Name = "txtTotalFailed";
            txtTotalFailed.ReadOnly = true;
            txtTotalFailed.Size = new Size(446, 44);
            txtTotalFailed.TabIndex = 13;
            txtTotalFailed.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPassRate
            // 
            txtPassRate.BackColor = Color.SteelBlue;
            txtPassRate.ForeColor = Color.White;
            txtPassRate.Location = new Point(232, 322);
            txtPassRate.Margin = new Padding(3, 4, 3, 4);
            txtPassRate.Name = "txtPassRate";
            txtPassRate.ReadOnly = true;
            txtPassRate.Size = new Size(446, 44);
            txtPassRate.TabIndex = 14;
            txtPassRate.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFailRate
            // 
            txtFailRate.BackColor = Color.SteelBlue;
            txtFailRate.ForeColor = Color.White;
            txtFailRate.Location = new Point(232, 375);
            txtFailRate.Margin = new Padding(3, 4, 3, 4);
            txtFailRate.Name = "txtFailRate";
            txtFailRate.ReadOnly = true;
            txtFailRate.Size = new Size(446, 44);
            txtFailRate.TabIndex = 15;
            txtFailRate.TextAlign = HorizontalAlignment.Center;
            // 
            // cboModule
            // 
            cboModule.BackColor = Color.SteelBlue;
            cboModule.FlatStyle = FlatStyle.Flat;
            cboModule.ForeColor = Color.White;
            cboModule.FormattingEnabled = true;
            cboModule.Location = new Point(232, 5);
            cboModule.Margin = new Padding(3, 4, 3, 4);
            cboModule.Name = "cboModule";
            cboModule.Size = new Size(446, 43);
            cboModule.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 4, 2, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1259, 791);
            panel1.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(btnClose);
            panel3.Controls.Add(btnLoad);
            panel3.Location = new Point(122, 668);
            panel3.Name = "panel3";
            panel3.Size = new Size(1002, 62);
            panel3.TabIndex = 20;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.BackColor = Color.DarkSlateGray;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.Red;
            btnClose.Location = new Point(810, 0);
            btnClose.Margin = new Padding(2, 4, 2, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(145, 62);
            btnClose.TabIndex = 20;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click_1;
            // 
            // FrmPerfomance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1259, 827);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPerfomance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Perfomance";
            Load += FrmPerfomance_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnLoad;
        private Label label10;
        private Label label11;
        private PictureBox pictureBox2;
        private Label label12;
        private Panel panel2;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtModuleName;
        private TextBox txtTotalStudents;
        private TextBox txtTotalWritten;
        private TextBox txtTotalPassed;
        private TextBox txtTotalFailed;
        private TextBox txtPassRate;
        private TextBox txtFailRate;
        private ComboBox cboModule;
        private Panel panel3;
        private Button btnClose;
    }
}