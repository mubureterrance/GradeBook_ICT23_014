namespace GradeBook_ICT23_014
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            cboShow = new CheckBox();
            btnforgot = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnLogin = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 686);
            panel1.TabIndex = 200;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Schoolbook", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(78, 25);
            label5.Name = "label5";
            label5.Size = new Size(200, 33);
            label5.TabIndex = 4;
            label5.Text = "GRADEBOOK";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(85, 5);
            label4.Name = "label4";
            label4.Size = new Size(201, 23);
            label4.TabIndex = 3;
            label4.Text = "School of Computing";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(5, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 60);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(cboShow);
            panel2.Controls.Add(btnforgot);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnLogin);
            panel2.Location = new Point(194, 116);
            panel2.Name = "panel2";
            panel2.Size = new Size(529, 548);
            panel2.TabIndex = 100;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(230, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 68);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // cboShow
            // 
            cboShow.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboShow.AutoSize = true;
            cboShow.Font = new Font("Century Schoolbook", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboShow.ForeColor = Color.White;
            cboShow.Location = new Point(292, 369);
            cboShow.Name = "cboShow";
            cboShow.RightToLeft = RightToLeft.Yes;
            cboShow.Size = new Size(150, 25);
            cboShow.TabIndex = 30;
            cboShow.Text = "show password";
            cboShow.UseVisualStyleBackColor = true;
            cboShow.CheckedChanged += cboShow_CheckedChanged;
            // 
            // btnforgot
            // 
            btnforgot.Anchor = AnchorStyles.Top;
            btnforgot.BackColor = Color.SteelBlue;
            btnforgot.FlatAppearance.BorderSize = 0;
            btnforgot.FlatAppearance.MouseOverBackColor = Color.RosyBrown;
            btnforgot.FlatStyle = FlatStyle.Flat;
            btnforgot.Font = new Font("Century Schoolbook", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnforgot.ForeColor = Color.Navy;
            btnforgot.Location = new Point(92, 485);
            btnforgot.Name = "btnforgot";
            btnforgot.Size = new Size(350, 52);
            btnforgot.TabIndex = 50;
            btnforgot.Text = "Forgot your password?";
            btnforgot.UseVisualStyleBackColor = false;
            btnforgot.Click += btnforgot_Click;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Location = new Point(92, 327);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(350, 36);
            txtPassword.TabIndex = 20;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUsername.Location = new Point(92, 252);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(350, 36);
            txtUsername.TabIndex = 10;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(92, 304);
            label3.Name = "label3";
            label3.Size = new Size(98, 23);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(92, 229);
            label2.Name = "label2";
            label2.Size = new Size(105, 23);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(179, 147);
            label1.Name = "label1";
            label1.Size = new Size(172, 28);
            label1.TabIndex = 1;
            label1.Text = "USER LOGIN";
            label1.Click += label1_Click;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top;
            btnLogin.BackColor = Color.DarkSlateGray;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.Navy;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(92, 418);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(350, 51);
            btnLogin.TabIndex = 40;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(15F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 774);
            Controls.Add(panel1);
            Font = new Font("Century Schoolbook", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GradeBook Login";
            Load += FrmLogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnforgot;
        private PictureBox pictureBox1;
        private CheckBox cboShow;
        private Button btnLogin;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label4;
    }
}