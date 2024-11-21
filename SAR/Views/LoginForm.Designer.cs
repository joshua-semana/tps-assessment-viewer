namespace SAR
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            txtStudentNumber = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            label3 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 224F, FontStyle.Bold, GraphicsUnit.Pixel);
            label1.ForeColor = Color.SlateBlue;
            label1.Location = new Point(0, -21);
            label1.Name = "label1";
            label1.Size = new Size(520, 297);
            label1.TabIndex = 1;
            label1.Text = "TPS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 60F, FontStyle.Bold, GraphicsUnit.Pixel);
            label2.ForeColor = Color.SlateBlue;
            label2.Location = new Point(38, 244);
            label2.Name = "label2";
            label2.Size = new Size(744, 81);
            label2.TabIndex = 2;
            label2.Text = "THE PHILIPPINE SCHOOL";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Building;
            pictureBox1.Location = new Point(0, 34);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1320, 1046);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // txtStudentNumber
            // 
            txtStudentNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStudentNumber.BorderStyle = BorderStyle.FixedSingle;
            txtStudentNumber.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtStudentNumber.Location = new Point(150, 456);
            txtStudentNumber.Margin = new Padding(3, 3, 3, 18);
            txtStudentNumber.Name = "txtStudentNumber";
            txtStudentNumber.Size = new Size(300, 39);
            txtStudentNumber.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPassword.Location = new Point(150, 545);
            txtPassword.Margin = new Padding(3, 3, 3, 32);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(300, 39);
            txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.BackColor = Color.MidnightBlue;
            btnLogin.FlatAppearance.BorderColor = Color.MidnightBlue;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Pixel);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(150, 619);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(300, 40);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            label3.Location = new Point(150, 424);
            label3.Margin = new Padding(3, 0, 3, 4);
            label3.Name = "label3";
            label3.Size = new Size(143, 25);
            label3.TabIndex = 3;
            label3.Text = "Student Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            label4.Location = new Point(150, 513);
            label4.Margin = new Padding(3, 0, 3, 4);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 4;
            label4.Text = "Password";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.TPS_Logo;
            pictureBox2.Location = new Point(150, 150);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(300, 114);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Pixel);
            label5.Location = new Point(227, 285);
            label5.Margin = new Padding(3, 0, 3, 4);
            label5.Name = "label5";
            label5.Size = new Size(156, 30);
            label5.TabIndex = 6;
            label5.Text = "Hello, TPSian!";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            label6.Location = new Point(150, 319);
            label6.Margin = new Padding(3, 0, 3, 4);
            label6.Name = "label6";
            label6.Size = new Size(300, 54);
            label6.TabIndex = 7;
            label6.Text = "Do you want to see your records?\r\nEnter your credentials below";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            label7.Location = new Point(150, 979);
            label7.Margin = new Padding(3, 0, 3, 4);
            label7.Name = "label7";
            label7.Size = new Size(300, 54);
            label7.TabIndex = 8;
            label7.Text = "\"Leader in Academic Excellence and Values Formation\"";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtStudentNumber);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1320, 0);
            panel1.Margin = new Padding(0, 3, 3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 1080);
            panel1.TabIndex = 0;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1920, 1080);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox txtStudentNumber;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel1;
    }
}
