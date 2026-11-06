using System.Drawing;
using System.Windows.Forms;

namespace Catering_system
{
    partial class ReportsForm
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
            lblType = new Label();
            cmbReportType = new ComboBox();
            btnGenerate = new Button();
            lblOptional = new Label();
            dtpFrom = new DateTimePicker();
            dtpTo = new DateTimePicker();
            dgvReport = new DataGridView();
            lblTotalBookings = new Label();
            lblTotalRevenue = new Label();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(900, 590);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reports";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblType.Location = new Point(35, 35);
            lblType.Name = "lblType";
            lblType.Size = new Size(96, 25);
            lblType.TabIndex = 0;
            lblType.Text = "Report type";
            // 
            // cmbReportType
            // 
            cmbReportType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReportType.FormattingEnabled = true;
            cmbReportType.Location = new Point(155, 32);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(220, 28);
            cmbReportType.TabIndex = 1;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.FromArgb(52, 121, 205);
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.Location = new Point(400, 28);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(125, 38);
            btnGenerate.TabIndex = 2;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // lblOptional
            // 
            lblOptional.AutoSize = true;
            lblOptional.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblOptional.Location = new Point(35, 85);
            lblOptional.Name = "lblOptional";
            lblOptional.Size = new Size(78, 23);
            lblOptional.TabIndex = 3;
            lblOptional.Text = "Optional:";
            // 
            // dtpFrom
            // 
            dtpFrom.Format = DateTimePickerFormat.Custom;
            dtpFrom.CustomFormat = "From dd/MM/yyyy";
            dtpFrom.Location = new Point(125, 82);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(175, 27);
            dtpFrom.TabIndex = 4;
            // 
            // dtpTo
            // 
            dtpTo.Format = DateTimePickerFormat.Custom;
            dtpTo.CustomFormat = "To dd/MM/yyyy";
            dtpTo.Location = new Point(315, 82);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(175, 27);
            dtpTo.TabIndex = 5;
            // 
            // dgvReport
            // 
            dgvReport.AllowUserToAddRows = false;
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReport.BackgroundColor = Color.White;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(35, 140);
            dgvReport.Name = "dgvReport";
            dgvReport.ReadOnly = true;
            dgvReport.RowHeadersWidth = 51;
            dgvReport.RowTemplate.Height = 30;
            dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReport.Size = new Size(830, 270);
            dgvReport.TabIndex = 6;
            // 
            // lblTotalBookings
            // 
            lblTotalBookings.AutoSize = true;
            lblTotalBookings.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalBookings.Location = new Point(35, 435);
            lblTotalBookings.Name = "lblTotalBookings";
            lblTotalBookings.Size = new Size(150, 25);
            lblTotalBookings.TabIndex = 7;
            lblTotalBookings.Text = "Total bookings: 0";
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.AutoSize = true;
            lblTotalRevenue.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalRevenue.Location = new Point(35, 475);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(145, 25);
            lblTotalRevenue.TabIndex = 8;
            lblTotalRevenue.Text = "Total revenue: $0.00";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(95, 95, 95);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(735, 470);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(130, 40);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // controls
            // 
            Controls.Add(btnClose);
            Controls.Add(lblTotalRevenue);
            Controls.Add(lblTotalBookings);
            Controls.Add(dgvReport);
            Controls.Add(dtpTo);
            Controls.Add(dtpFrom);
            Controls.Add(lblOptional);
            Controls.Add(btnGenerate);
            Controls.Add(cmbReportType);
            Controls.Add(lblType);
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblType;
        private ComboBox cmbReportType;
        private Button btnGenerate;
        private Label lblOptional;
        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private DataGridView dgvReport;
        private Label lblTotalBookings;
        private Label lblTotalRevenue;
        private Button btnClose;
    }
}
