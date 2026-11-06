using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Catering_system
{
    public partial class EventsForm : Form
    {
        private readonly List<EventRecord> events = new();
        private int nextEventId = 1;
        private int? selectedEventId;

        public EventsForm()
        {
            InitializeComponent();
            LoadOptions();
            ConfigureGrid();
            ClearFields();
        }

        private void LoadOptions()
        {
            cmbClient.Items.AddRange(new object[] { "Select client", "Client 1", "Client 2" });
            cmbEventType.Items.AddRange(new object[] { "Wedding", "Birthday", "Corporate", "Other" });
            cmbPackage.Items.AddRange(new object[] { "Basic", "Standard", "Premium" });
            cmbClient.SelectedIndex = 0;
            cmbEventType.SelectedIndex = 0;
            cmbPackage.SelectedIndex = 0;
        }

        private void ConfigureGrid()
        {
            eventsGrid.AutoGenerateColumns = false;
            eventsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            eventsGrid.MultiSelect = false;
            eventsGrid.ReadOnly = true;
            eventsGrid.AllowUserToAddRows = false;
            eventsGrid.Columns.Add("EventID", "EventID");
            eventsGrid.Columns.Add("Client", "Client");
            eventsGrid.Columns.Add("EventType", "Event Type");
            eventsGrid.Columns.Add("EventDate", "Event Date");
            eventsGrid.Columns.Add("Location", "Location");
            eventsGrid.Columns.Add("Guests", "Guests");
            eventsGrid.Columns.Add("Package", "Package");
            eventsGrid.Columns.Add("PricePerPerson", "Price/Person");
            eventsGrid.Columns.Add("Notes", "Notes");
            eventsGrid.Columns.Add("Status", "Status");
            eventsGrid.SelectionChanged += eventsGrid_SelectionChanged;
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                return;
            }

            events.Add(ReadEvent(nextEventId++));
            RefreshGrid();
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!selectedEventId.HasValue)
            {
                MessageBox.Show("Select an event first.", "Event Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidateFields())
            {
                return;
            }

            EventRecord? eventRecord = events.FirstOrDefault(item => item.Id == selectedEventId.Value);
            if (eventRecord == null)
            {
                return;
            }

            EventRecord updated = ReadEvent(eventRecord.Id);
            eventRecord.Client = updated.Client;
            eventRecord.EventType = updated.EventType;
            eventRecord.EventDate = updated.EventDate;
            eventRecord.Location = updated.Location;
            eventRecord.Guests = updated.Guests;
            eventRecord.Package = updated.Package;
            eventRecord.PricePerPerson = updated.PricePerPerson;
            eventRecord.Notes = updated.Notes;
            eventRecord.Status = updated.Status;
            RefreshGrid();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            eventsGrid.ClearSelection();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbPackage_SelectedIndexChanged(object? sender, EventArgs e)
        {
            decimal price = cmbPackage.SelectedItem?.ToString() switch
            {
                "Standard" => 75m,
                "Premium" => 120m,
                _ => 50m
            };

            txtCost.Text = price.ToString("0.00");
        }

        private void eventsGrid_SelectionChanged(object? sender, EventArgs e)
        {
            if (eventsGrid.SelectedRows.Count == 0 || eventsGrid.SelectedRows[0].Index < 0)
            {
                return;
            }

            DataGridViewRow row = eventsGrid.SelectedRows[0];
            selectedEventId = Convert.ToInt32(row.Cells["EventID"].Value);
            cmbClient.Text = Convert.ToString(row.Cells["Client"].Value) ?? string.Empty;
            cmbEventType.Text = Convert.ToString(row.Cells["EventType"].Value) ?? string.Empty;
            dtpEventDate.Value = Convert.ToDateTime(row.Cells["EventDate"].Value);
            txtLocation.Text = Convert.ToString(row.Cells["Location"].Value) ?? string.Empty;
            numGuests.Value = Convert.ToDecimal(row.Cells["Guests"].Value);
            cmbPackage.Text = Convert.ToString(row.Cells["Package"].Value) ?? string.Empty;
            txtCost.Text = Convert.ToString(row.Cells["PricePerPerson"].Value) ?? "0.00";
            txtNotes.Text = Convert.ToString(row.Cells["Notes"].Value) ?? string.Empty;
        }

        private bool ValidateFields()
        {
            if (cmbClient.SelectedIndex <= 0)
            {
                MessageBox.Show("Select a client.", "Event Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbClient.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Enter the event location.", "Event Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLocation.Focus();
                return false;
            }

            return true;
        }

        private EventRecord ReadEvent(int id)
        {
            return new EventRecord
            {
                Id = id,
                Client = cmbClient.Text,
                EventType = cmbEventType.Text,
                EventDate = dtpEventDate.Value,
                Location = txtLocation.Text.Trim(),
                Guests = (int)numGuests.Value,
                Package = cmbPackage.Text,
                PricePerPerson = decimal.TryParse(txtCost.Text, out decimal cost) ? cost : 0m,
                Notes = txtNotes.Text.Trim(),
                Status = "Booked"
            };
        }

        private void RefreshGrid()
        {
            eventsGrid.Rows.Clear();
            foreach (EventRecord eventRecord in events)
            {
                eventsGrid.Rows.Add(eventRecord.Id, eventRecord.Client, eventRecord.EventType,
                    eventRecord.EventDate.ToString("dd/MM/yyyy HH:mm"), eventRecord.Location,
                    eventRecord.Guests, eventRecord.Package, eventRecord.PricePerPerson.ToString("0.00"),
                    eventRecord.Notes, eventRecord.Status);
            }
        }

        private void ClearFields()
        {
            selectedEventId = null;
            if (cmbClient.Items.Count > 0) cmbClient.SelectedIndex = 0;
            if (cmbEventType.Items.Count > 0) cmbEventType.SelectedIndex = 0;
            if (cmbPackage.Items.Count > 0) cmbPackage.SelectedIndex = 0;
            dtpEventDate.Value = DateTime.Now;
            txtLocation.Clear();
            numGuests.Value = 1;
            txtNotes.Clear();
        }

        private sealed class EventRecord
        {
            public int Id { get; set; }
            public string Client { get; set; } = string.Empty;
            public string EventType { get; set; } = string.Empty;
            public DateTime EventDate { get; set; }
            public string Location { get; set; } = string.Empty;
            public int Guests { get; set; }
            public string Package { get; set; } = string.Empty;
            public decimal PricePerPerson { get; set; }
            public string Notes { get; set; } = string.Empty;
            public string Status { get; set; } = string.Empty;
        }
    }
}
