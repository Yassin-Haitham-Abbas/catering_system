using System.Drawing;
using System.Windows.Forms;

namespace Catering_system
{
    partial class EventsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            titlePanel = new Panel();
            titleLabel = new Label();
            lblClient = new Label();
            lblEventType = new Label();
            lblEventDate = new Label();
            lblLocation = new Label();
            lblGuests = new Label();
            lblPackage = new Label();
            lblCost = new Label();
            lblNotes = new Label();
            cmbClient = new ComboBox();
            cmbEventType = new ComboBox();
            dtpEventDate = new DateTimePicker();
            txtLocation = new TextBox();
            numGuests = new NumericUpDown();
            cmbPackage = new ComboBox();
            txtCost = new TextBox();
            txtNotes = new TextBox();
            btnBook = new Button();
            btnClear = new Button();
            btnUpdate = new Button();
            btnCancel = new Button();
            eventsGrid = new DataGridView();
            titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numGuests).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eventsGrid).BeginInit();
            SuspendLayout();
            // 
            // titlePanel
            // 
            titlePanel.BackColor = Color.FromArgb(63, 47, 150);
            titlePanel.Controls.Add(titleLabel);
            titlePanel.Dock = DockStyle.Top;
            titlePanel.Location = new Point(0, 0);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new Size(1080, 76);
            titlePanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            titleLabel.Dock = DockStyle.Fill;
            titleLabel.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(1080, 76);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Event Management";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labels
            // 
            lblClient.AutoSize = true;
            lblClient.Font = new Font("Segoe UI", 11F, FontStyle.Italic, GraphicsUnit.Point);
            lblClient.Location = new Point(45, 105);
            lblClient.Name = "lblClient";
            lblClient.Size = new Size(66, 25);
            lblClient.TabIndex = 1;
            lblClient.Text = "Client:";
            lblEventType.AutoSize = true;
            lblEventType.Font = new Font("Segoe UI", 11F, FontStyle.Italic, GraphicsUnit.Point);
            lblEventType.Location = new Point(45, 155);
            lblEventType.Name = "lblEventType";
            lblEventType.Size = new Size(111, 25);
            lblEventType.TabIndex = 2;
            lblEventType.Text = "Event Type:";
            lblEventDate.AutoSize = true;
            lblEventDate.Font = new Font("Segoe UI", 11F, FontStyle.Italic, GraphicsUnit.Point);
            lblEventDate.Location = new Point(45, 205);
            lblEventDate.Name = "lblEventDate";
            lblEventDate.Size = new Size(108, 25);
            lblEventDate.TabIndex = 3;
            lblEventDate.Text = "Event Date:";
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI", 11F, FontStyle.Italic, GraphicsUnit.Point);
            lblLocation.Location = new Point(45, 255);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(84, 25);
            lblLocation.TabIndex = 4;
            lblLocation.Text = "Location:";
            lblGuests.AutoSize = true;
            lblGuests.Font = new Font("Segoe UI", 11F, FontStyle.Italic, GraphicsUnit.Point);
            lblGuests.Location = new Point(570, 105);
            lblGuests.Name = "lblGuests";
            lblGuests.Size = new Size(70, 25);
            lblGuests.TabIndex = 5;
            lblGuests.Text = "Guests:";
            lblPackage.AutoSize = true;
            lblPackage.Font = new Font("Segoe UI", 11F, FontStyle.Italic, GraphicsUnit.Point);
            lblPackage.Location = new Point(570, 155);
            lblPackage.Name = "lblPackage";
            lblPackage.Size = new Size(81, 25);
            lblPackage.TabIndex = 6;
            lblPackage.Text = "Package:";
            lblCost.AutoSize = true;
            lblCost.Font = new Font("Segoe UI", 11F, FontStyle.Italic, GraphicsUnit.Point);
            lblCost.Location = new Point(570, 205);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(56, 25);
            lblCost.TabIndex = 7;
            lblCost.Text = "Cost:";
            lblNotes.AutoSize = true;
            lblNotes.Font = new Font("Segoe UI", 11F, FontStyle.Italic, GraphicsUnit.Point);
            lblNotes.Location = new Point(570, 255);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(65, 25);
            lblNotes.TabIndex = 8;
            lblNotes.Text = "Notes:";
            // 
            // input controls
            // 
            cmbClient.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClient.FormattingEnabled = true;
            cmbClient.Location = new Point(170, 102);
            cmbClient.Name = "cmbClient";
            cmbClient.Size = new Size(280, 28);
            cmbClient.TabIndex = 9;
            cmbEventType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEventType.FormattingEnabled = true;
            cmbEventType.Location = new Point(170, 152);
            cmbEventType.Name = "cmbEventType";
            cmbEventType.Size = new Size(280, 28);
            cmbEventType.TabIndex = 10;
            dtpEventDate.Format = DateTimePickerFormat.Custom;
            dtpEventDate.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpEventDate.Location = new Point(170, 202);
            dtpEventDate.Name = "dtpEventDate";
            dtpEventDate.Size = new Size(280, 27);
            dtpEventDate.TabIndex = 11;
            txtLocation.Location = new Point(170, 252);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(280, 27);
            txtLocation.TabIndex = 12;
            numGuests.Location = new Point(700, 102);
            numGuests.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numGuests.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numGuests.Name = "numGuests";
            numGuests.Size = new Size(180, 27);
            numGuests.TabIndex = 13;
            numGuests.Value = new decimal(new int[] { 1, 0, 0, 0 });
            cmbPackage.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPackage.FormattingEnabled = true;
            cmbPackage.Location = new Point(700, 152);
            cmbPackage.Name = "cmbPackage";
            cmbPackage.Size = new Size(180, 28);
            cmbPackage.TabIndex = 14;
            cmbPackage.SelectedIndexChanged += cmbPackage_SelectedIndexChanged;
            txtCost.Location = new Point(700, 202);
            txtCost.Name = "txtCost";
            txtCost.ReadOnly = true;
            txtCost.Size = new Size(180, 27);
            txtCost.TabIndex = 15;
            txtCost.Text = "0.00";
            txtNotes.Location = new Point(700, 252);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(280, 75);
            txtNotes.TabIndex = 16;
            // 
            // action buttons
            // 
            btnBook.BackColor = Color.FromArgb(38, 67, 230);
            btnBook.FlatStyle = FlatStyle.Flat;
            btnBook.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnBook.ForeColor = Color.White;
            btnBook.Location = new Point(95, 360);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(155, 42);
            btnBook.TabIndex = 17;
            btnBook.Text = "Book";
            btnBook.UseVisualStyleBackColor = false;
            btnBook.Click += btnBook_Click;
            btnClear.BackColor = Color.FromArgb(95, 95, 95);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(315, 360);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(155, 42);
            btnClear.TabIndex = 18;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            btnUpdate.BackColor = Color.FromArgb(78, 153, 55);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(535, 360);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(155, 42);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            btnCancel.BackColor = Color.FromArgb(172, 44, 64);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(755, 360);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(155, 42);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // eventsGrid
            // 
            eventsGrid.AllowUserToAddRows = false;
            eventsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            eventsGrid.BackgroundColor = Color.White;
            eventsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            eventsGrid.Location = new Point(45, 435);
            eventsGrid.Name = "eventsGrid";
            eventsGrid.RowHeadersWidth = 51;
            eventsGrid.RowTemplate.Height = 29;
            eventsGrid.Size = new Size(990, 180);
            eventsGrid.TabIndex = 21;
            // 
            // EventsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 660);
            Controls.Add(eventsGrid);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(btnClear);
            Controls.Add(btnBook);
            Controls.Add(txtNotes);
            Controls.Add(txtCost);
            Controls.Add(cmbPackage);
            Controls.Add(numGuests);
            Controls.Add(txtLocation);
            Controls.Add(dtpEventDate);
            Controls.Add(cmbEventType);
            Controls.Add(cmbClient);
            Controls.Add(lblNotes);
            Controls.Add(lblCost);
            Controls.Add(lblPackage);
            Controls.Add(lblGuests);
            Controls.Add(lblLocation);
            Controls.Add(lblEventDate);
            Controls.Add(lblEventType);
            Controls.Add(lblClient);
            Controls.Add(titlePanel);
            Name = "EventsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Event Management";
            titlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numGuests).EndInit();
            ((System.ComponentModel.ISupportInitialize)eventsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel titlePanel;
        private Label titleLabel;
        private Label lblClient;
        private Label lblEventType;
        private Label lblEventDate;
        private Label lblLocation;
        private Label lblGuests;
        private Label lblPackage;
        private Label lblCost;
        private Label lblNotes;
        private ComboBox cmbClient;
        private ComboBox cmbEventType;
        private DateTimePicker dtpEventDate;
        private TextBox txtLocation;
        private NumericUpDown numGuests;
        private ComboBox cmbPackage;
        private TextBox txtCost;
        private TextBox txtNotes;
        private Button btnBook;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnCancel;
        private DataGridView eventsGrid;
    }
}
