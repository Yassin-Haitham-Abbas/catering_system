using System.Drawing;
using System.Windows.Forms;

namespace Catering_system
{
    partial class ClientsForm
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
            lblName = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            lblAddress = new Label();
            txtName = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            clientsGrid = new DataGridView();
            titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clientsGrid).BeginInit();
            SuspendLayout();
            // 
            // titlePanel
            // 
            titlePanel.BackColor = Color.FromArgb(63, 47, 150);
            titlePanel.Controls.Add(titleLabel);
            titlePanel.Dock = DockStyle.Top;
            titlePanel.Location = new Point(0, 0);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new Size(1000, 76);
            titlePanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            titleLabel.Dock = DockStyle.Fill;
            titleLabel.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(1000, 76);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Client Management";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labels
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 11F, FontStyle.Italic, GraphicsUnit.Point);
            lblName.Location = new Point(170, 125);
            lblName.Name = "lblName";
            lblName.Size = new Size(63, 25);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 11F, FontStyle.Italic, GraphicsUnit.Point);
            lblPhone.Location = new Point(570, 125);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(65, 25);
            lblPhone.TabIndex = 2;
            lblPhone.Text = "Phone:";
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 11F, FontStyle.Italic, GraphicsUnit.Point);
            lblEmail.Location = new Point(170, 235);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(61, 25);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 11F, FontStyle.Italic, GraphicsUnit.Point);
            lblAddress.Location = new Point(570, 235);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(79, 25);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address:";
            // 
            // text boxes
            // 
            txtName.Location = new Point(160, 158);
            txtName.Name = "txtName";
            txtName.Size = new Size(240, 27);
            txtName.TabIndex = 5;
            txtPhone.Location = new Point(560, 158);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(240, 27);
            txtPhone.TabIndex = 6;
            txtEmail.Location = new Point(160, 268);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(240, 27);
            txtEmail.TabIndex = 7;
            txtAddress.Location = new Point(560, 268);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(240, 27);
            txtAddress.TabIndex = 8;
            // 
            // action buttons
            // 
            btnAdd.BackColor = Color.FromArgb(52, 121, 205);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(105, 345);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 42);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            btnUpdate.BackColor = Color.FromArgb(78, 153, 55);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(315, 345);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 42);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.BackColor = Color.FromArgb(205, 48, 62);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(525, 345);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 42);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            btnClear.BackColor = Color.FromArgb(95, 95, 95);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(735, 345);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 42);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // clientsGrid
            // 
            clientsGrid.AllowUserToAddRows = false;
            clientsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            clientsGrid.BackgroundColor = Color.White;
            clientsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientsGrid.Location = new Point(105, 425);
            clientsGrid.Name = "clientsGrid";
            clientsGrid.RowHeadersWidth = 51;
            clientsGrid.RowTemplate.Height = 29;
            clientsGrid.Size = new Size(780, 190);
            clientsGrid.TabIndex = 13;
            // 
            // ClientsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 670);
            Controls.Add(clientsGrid);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(lblAddress);
            Controls.Add(lblEmail);
            Controls.Add(lblPhone);
            Controls.Add(lblName);
            Controls.Add(titlePanel);
            Name = "ClientsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Client Management";
            titlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)clientsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel titlePanel;
        private Label titleLabel;
        private Label lblName;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblAddress;
        private TextBox txtName;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView clientsGrid;
    }
}
