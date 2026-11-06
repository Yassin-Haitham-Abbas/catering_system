using System.Drawing;
using System.Windows.Forms;

namespace Catering_system
{
    partial class BookingForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblClient = new Label();
            lblEvent = new Label();
            lblMenu = new Label();
            lblGuests = new Label();
            lblStatus = new Label();
            cmbClient = new ComboBox();
            cmbEvent = new ComboBox();
            cmbMenu = new ComboBox();
            numGuests = new NumericUpDown();
            lblTotalPrice = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            cmbStatus = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numGuests).BeginInit();
            SuspendLayout();
            // 
            // BookingForm
            // 
            BackColor = Color.WhiteSmoke;
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            lblClient.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClient.ForeColor = Color.DarkSlateBlue;
            lblClient.Location = new Point(40, 62);
            lblClient.Name = "lblClient";
            lblClient.Size = new Size(62, 23);
            lblClient.TabIndex = 0;
            lblClient.Text = "Client:";
            // 
            // lblEvent
            // 
            lblEvent.AutoSize = true;
            lblEvent.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEvent.ForeColor = Color.DarkSlateBlue;
            lblEvent.Location = new Point(40, 143);
            lblEvent.Name = "lblEvent";
            lblEvent.Size = new Size(59, 23);
            lblEvent.TabIndex = 1;
            lblEvent.Text = "Event:";
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenu.ForeColor = Color.DarkSlateBlue;
            lblMenu.Location = new Point(40, 224);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(60, 23);
            lblMenu.TabIndex = 2;
            lblMenu.Text = "Menu:";
            // 
            // lblGuests
            // 
            lblGuests.AutoSize = true;
            lblGuests.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGuests.ForeColor = Color.DarkSlateBlue;
            lblGuests.Location = new Point(40, 317);
            lblGuests.Name = "lblGuests";
            lblGuests.Size = new Size(67, 23);
            lblGuests.TabIndex = 3;
            lblGuests.Text = "Guests:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.DarkSlateBlue;
            lblStatus.Location = new Point(219, 317);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(65, 23);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status:";
            // 
            // cmbClient
            // 
            cmbClient.FormattingEnabled = true;
            cmbClient.Location = new Point(40, 97);
            cmbClient.Name = "cmbClient";
            cmbClient.Size = new Size(330, 33);
            cmbClient.TabIndex = 6;
            // 
            // cmbEvent
            // 
            cmbEvent.FormattingEnabled = true;
            cmbEvent.Location = new Point(40, 182);
            cmbEvent.Name = "cmbEvent";
            cmbEvent.Size = new Size(330, 33);
            cmbEvent.TabIndex = 7;
            // 
            // cmbMenu
            // 
            cmbMenu.FormattingEnabled = true;
            cmbMenu.Location = new Point(40, 262);
            cmbMenu.Name = "cmbMenu";
            cmbMenu.Size = new Size(330, 33);
            cmbMenu.TabIndex = 8;
            cmbMenu.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMenu.SelectedIndexChanged += cmbMenu_SelectedIndexChanged;
            // 
            // numGuests
            // 
            numGuests.Location = new Point(40, 360);
            numGuests.Name = "numGuests";
            numGuests.Size = new Size(149, 31);
            numGuests.TabIndex = 9;
            numGuests.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numGuests.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numGuests.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numGuests.ValueChanged += numGuests_ValueChanged;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPrice.ForeColor = Color.DarkSlateBlue;
            lblTotalPrice.Location = new Point(40, 422);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(93, 23);
            lblTotalPrice.TabIndex = 10;
            lblTotalPrice.Text = "TotalPrice:";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LimeGreen;
            btnSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(40, 536);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Brown;
            btnCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(276, 536);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(219, 359);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(151, 33);
            cmbStatus.TabIndex = 13;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // BookingForm
            // 
            ClientSize = new Size(505, 610);
            Controls.Add(cmbStatus);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblTotalPrice);
            Controls.Add(numGuests);
            Controls.Add(cmbMenu);
            Controls.Add(cmbEvent);
            Controls.Add(cmbClient);
            Controls.Add(lblStatus);
            Controls.Add(lblGuests);
            Controls.Add(lblMenu);
            Controls.Add(lblEvent);
            Controls.Add(lblClient);
            Name = "BookingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Booking";
            ((System.ComponentModel.ISupportInitialize)numGuests).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblGuests;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.ComboBox cmbEvent;
        private System.Windows.Forms.ComboBox cmbMenu;
        private System.Windows.Forms.NumericUpDown numGuests;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbStatus;
    }
}