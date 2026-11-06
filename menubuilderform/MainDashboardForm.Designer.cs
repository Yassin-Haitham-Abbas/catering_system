namespace Catering_system
{
    partial class MainDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDashboardForm));
            lblBooking = new Label();
            txtBooking = new TextBox();
            btnBooking = new Button();
            btnEvents = new Button();
            txtEvents = new TextBox();
            lblEvents = new Label();
            btnMenu = new Button();
            txtMenu = new TextBox();
            lblMenu = new Label();
            btnReports = new Button();
            txtReports = new TextBox();
            lblReports = new Label();
            btnClients = new Button();
            txtClients = new TextBox();
            lblClients = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblBooking
            // 
            lblBooking.AutoSize = true;
            lblBooking.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBooking.ForeColor = Color.FromArgb(31, 41, 55);
            lblBooking.Location = new Point(46, 133);
            lblBooking.Name = "lblBooking";
            lblBooking.Size = new Size(90, 28);
            lblBooking.TabIndex = 0;
            lblBooking.Text = "Booking";
            // 
            // txtBooking
            // 
            txtBooking.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBooking.ForeColor = Color.FromArgb(31, 41, 55);
            txtBooking.Location = new Point(46, 180);
            txtBooking.Multiline = true;
            txtBooking.Name = "txtBooking";
            txtBooking.ReadOnly = true;
            txtBooking.Size = new Size(150, 87);
            txtBooking.TabIndex = 1;
            txtBooking.Text = "Search, create, and update bookings, menus, guests, and prices.";
            // 
            // btnBooking
            // 
            btnBooking.BackColor = Color.FromArgb(16, 185, 129);
            btnBooking.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBooking.ForeColor = Color.White;
            btnBooking.Location = new Point(46, 291);
            btnBooking.Name = "btnBooking";
            btnBooking.Size = new Size(112, 41);
            btnBooking.TabIndex = 2;
            btnBooking.Text = "Book Now";
            btnBooking.UseVisualStyleBackColor = false;
            // 
            // btnEvents
            // 
            btnEvents.BackColor = Color.FromArgb(16, 185, 129);
            btnEvents.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEvents.ForeColor = Color.White;
            btnEvents.Location = new Point(810, 291);
            btnEvents.Name = "btnEvents";
            btnEvents.Size = new Size(131, 41);
            btnEvents.TabIndex = 5;
            btnEvents.Text = "View Events";
            btnEvents.UseVisualStyleBackColor = false;
            // 
            // txtEvents
            // 
            txtEvents.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEvents.ForeColor = Color.FromArgb(31, 41, 55);
            txtEvents.Location = new Point(801, 180);
            txtEvents.Multiline = true;
            txtEvents.Name = "txtEvents";
            txtEvents.ReadOnly = true;
            txtEvents.Size = new Size(150, 87);
            txtEvents.TabIndex = 4;
            txtEvents.Text = "Schedule, filter, add, or update event details and venues.";
            txtEvents.TextChanged += txtEvents_TextChanged;
            // 
            // lblEvents
            // 
            lblEvents.AutoSize = true;
            lblEvents.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEvents.ForeColor = Color.FromArgb(31, 41, 55);
            lblEvents.Location = new Point(810, 133);
            lblEvents.Name = "lblEvents";
            lblEvents.Size = new Size(74, 28);
            lblEvents.TabIndex = 3;
            lblEvents.Text = "Events";
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.FromArgb(16, 185, 129);
            btnMenu.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenu.ForeColor = Color.White;
            btnMenu.Location = new Point(46, 541);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(196, 34);
            btnMenu.TabIndex = 8;
            btnMenu.Text = "View The Menu";
            btnMenu.UseVisualStyleBackColor = false;
            // 
            // txtMenu
            // 
            txtMenu.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMenu.ForeColor = Color.FromArgb(31, 41, 55);
            txtMenu.Location = new Point(46, 439);
            txtMenu.Multiline = true;
            txtMenu.Name = "txtMenu";
            txtMenu.ReadOnly = true;
            txtMenu.Size = new Size(150, 87);
            txtMenu.TabIndex = 7;
            txtMenu.Text = "Organize categories, dishes, and customize guest menus.";
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenu.Location = new Point(46, 388);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(66, 28);
            lblMenu.TabIndex = 6;
            lblMenu.Text = "Menu";
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.FromArgb(16, 185, 129);
            btnReports.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(810, 555);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(150, 34);
            btnReports.TabIndex = 11;
            btnReports.Text = "View Reports";
            btnReports.UseVisualStyleBackColor = false;
            // 
            // txtReports
            // 
            txtReports.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtReports.ForeColor = Color.FromArgb(31, 41, 55);
            txtReports.Location = new Point(810, 439);
            txtReports.Multiline = true;
            txtReports.Name = "txtReports";
            txtReports.ReadOnly = true;
            txtReports.Size = new Size(150, 87);
            txtReports.TabIndex = 10;
            txtReports.Text = "Check booking breakdowns and total revenue summaries.";
            // 
            // lblReports
            // 
            lblReports.AutoSize = true;
            lblReports.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReports.Location = new Point(810, 400);
            lblReports.Name = "lblReports";
            lblReports.Size = new Size(86, 28);
            lblReports.TabIndex = 9;
            lblReports.Text = "Reports";
            // 
            // btnClients
            // 
            btnClients.BackColor = Color.FromArgb(16, 185, 129);
            btnClients.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClients.ForeColor = Color.White;
            btnClients.Location = new Point(384, 422);
            btnClients.Name = "btnClients";
            btnClients.Size = new Size(212, 41);
            btnClients.TabIndex = 14;
            btnClients.Text = "View Clients ";
            btnClients.UseVisualStyleBackColor = false;
            // 
            // txtClients
            // 
            txtClients.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtClients.ForeColor = Color.FromArgb(31, 41, 55);
            txtClients.Location = new Point(401, 305);
            txtClients.Multiline = true;
            txtClients.Name = "txtClients";
            txtClients.ReadOnly = true;
            txtClients.Size = new Size(150, 87);
            txtClients.TabIndex = 13;
            txtClients.Text = "Add, edit, or delete client profiles in one place.";
            txtClients.TextChanged += txtClients_TextChanged;
            // 
            // lblClients
            // 
            lblClients.AutoSize = true;
            lblClients.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClients.ForeColor = Color.FromArgb(31, 41, 55);
            lblClients.Location = new Point(433, 260);
            lblClients.Name = "lblClients";
            lblClients.Size = new Size(76, 28);
            lblClients.TabIndex = 12;
            lblClients.Text = "Clients";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(401, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // MainDashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 675);
            Controls.Add(pictureBox1);
            Controls.Add(btnClients);
            Controls.Add(txtClients);
            Controls.Add(lblClients);
            Controls.Add(btnReports);
            Controls.Add(txtReports);
            Controls.Add(lblReports);
            Controls.Add(btnMenu);
            Controls.Add(txtMenu);
            Controls.Add(lblMenu);
            Controls.Add(btnEvents);
            Controls.Add(txtEvents);
            Controls.Add(lblEvents);
            Controls.Add(btnBooking);
            Controls.Add(txtBooking);
            Controls.Add(lblBooking);
            Margin = new Padding(4);
            Name = "MainDashboardForm";
            Text = "Main Page";
            Load += MainDashboardForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBooking;
        private TextBox txtBooking;
        private Button btnBooking;
        private Button btnEvents;
        private TextBox txtEvents;
        private Label lblEvents;
        private Button btnMenu;
        private TextBox txtMenu;
        private Label lblMenu;
        private Button btnReports;
        private TextBox txtReports;
        private Label lblReports;
        private Button btnClients;
        private TextBox txtClients;
        private Label lblClients;
        private PictureBox pictureBox1;
    }
}