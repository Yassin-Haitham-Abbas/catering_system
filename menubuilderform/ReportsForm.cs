using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Catering_system
{
    public partial class ReportsForm : Form
    {
        private readonly List<BookingReportRecord> bookings = new()
        {
            new BookingReportRecord("Ahmed", "Wedding", 100, "Confirmed", 5000m, new DateTime(2026, 1, 1)),
            new BookingReportRecord("Sara", "Birthday", 30, "Pending", 1200m, new DateTime(2026, 6, 11))
        };

        public ReportsForm()
        {
            InitializeComponent();
            cmbReportType.Items.AddRange(new object[] { "All bookings", "Confirmed", "Pending", "Cancelled" });
            cmbReportType.SelectedIndex = 0;
            dtpFrom.Value = new DateTime(DateTime.Today.Year, 1, 1);
            dtpTo.Value = new DateTime(DateTime.Today.Year, 12, 31);
            ConfigureGrid();
            GenerateReport();
        }

        private void ConfigureGrid()
        {
            dgvReport.AutoGenerateColumns = false;
            dgvReport.AllowUserToAddRows = false;
            dgvReport.ReadOnly = true;
            dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReport.Columns.Add("ClientName", "Client Name");
            dgvReport.Columns.Add("EventName", "Event Name");
            dgvReport.Columns.Add("Guests", "Guests");
            dgvReport.Columns.Add("Status", "Status");
            dgvReport.Columns.Add("TotalPrice", "Total Price");
        }

        private void btnGenerate_Click(object? sender, EventArgs e)
        {
            try
            {
                GenerateReport();
            }
            catch (Exception ex)
            {
                ShowError("generate the report", ex);
            }
        }

        private void GenerateReport()
        {
            if (dtpFrom.Value.Date > dtpTo.Value.Date)
            {
                MessageBox.Show("The From date cannot be later than the To date.", "Reports", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string reportType = cmbReportType.SelectedItem?.ToString() ?? "All bookings";
            DateTime from = dtpFrom.Value.Date;
            DateTime to = dtpTo.Value.Date;

            IEnumerable<BookingReportRecord> filtered = bookings.Where(booking =>
                booking.Date.Date >= from &&
                booking.Date.Date <= to &&
                (reportType == "All bookings" || string.Equals(booking.Status, reportType, StringComparison.OrdinalIgnoreCase)));

            List<BookingReportRecord> rows = filtered.ToList();
            dgvReport.Rows.Clear();
            foreach (BookingReportRecord booking in rows)
            {
                dgvReport.Rows.Add(booking.ClientName, booking.EventName, booking.Guests, booking.Status, booking.TotalPrice.ToString("C"));
            }

            lblTotalBookings.Text = $"Total bookings: {rows.Count}";
            lblTotalRevenue.Text = $"Total revenue: {rows.Sum(booking => booking.TotalPrice):C}";
        }

        private void btnClose_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private static void ShowError(string operation, Exception exception)
        {
            MessageBox.Show($"Unable to {operation}.\n\nDetails: {exception.Message}", "Reports Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private sealed record BookingReportRecord(
            string ClientName,
            string EventName,
            int Guests,
            string Status,
            decimal TotalPrice,
            DateTime Date);
    }
}
