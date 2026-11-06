namespace Catering_system
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            lblUserName = new Label();
            lblPassword = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            pictureBox = new PictureBox();
            lblPhone = new Label();
            lblGmail = new Label();
            txtPhone = new TextBox();
            txtGmail = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(280, 147);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(97, 23);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "User Name";
            lblUserName.Click += label1_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(280, 400);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(85, 23);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            lblPassword.Click += lblPassword_Click;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 11F);
            txtUserName.Location = new Point(280, 189);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(250, 32);
            txtUserName.TabIndex = 2;
            txtUserName.TextChanged += txtUserName_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(280, 440);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(250, 32);
            txtPassword.TabIndex = 3;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(16, 185, 129);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(344, 498);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(105, 39);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // pictureBox
            // 
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.Location = new Point(329, 12);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(120, 120);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 6;
            pictureBox.TabStop = false;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(280, 237);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(135, 23);
            lblPhone.TabIndex = 7;
            lblPhone.Text = "Phone Number ";
            lblPhone.Click += lblPhone_Click;
            // 
            // lblGmail
            // 
            lblGmail.AutoSize = true;
            lblGmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGmail.Location = new Point(280, 328);
            lblGmail.Name = "lblGmail";
            lblGmail.Size = new Size(57, 23);
            lblGmail.TabIndex = 8;
            lblGmail.Text = "Gmail";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 11F);
            txtPhone.Location = new Point(280, 272);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(250, 32);
            txtPhone.TabIndex = 9;
            // 
            // txtGmail
            // 
            txtGmail.Font = new Font("Segoe UI", 11F);
            txtGmail.Location = new Point(280, 365);
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(250, 32);
            txtGmail.TabIndex = 10;
            txtGmail.TextChanged += txtGmail_TextChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 577);
            Controls.Add(txtGmail);
            Controls.Add(txtPhone);
            Controls.Add(lblGmail);
            Controls.Add(lblPhone);
            Controls.Add(pictureBox);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Cursor = Cursors.Hand;
            ForeColor = Color.FromArgb(51, 65, 85);
            Name = "MainForm";
            Text = "Login Page";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserName;
        private Label lblPassword;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnLogin;
        private PictureBox pictureBox;
        private Label lblPhone;
        private Label lblGmail;
        private TextBox txtPhone;
        private TextBox txtGmail;

        // Add this method to the MainForm partial class to resolve CS0103 for lblPhone_Click
        private void lblPhone_Click(object sender, EventArgs e)
        {
            // You can add any desired logic here, or leave it empty if not needed.
        }
    }
}
