using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Catering_system
{
    public partial class BookingForm : Form
    {
        private readonly List<BookingRecord> bookings = new();

        public BookingForm()
        {
            InitializeComponent();
            LoadBookingOptions();
            UpdateTotalPrice();
        }

        private void LoadBookingOptions()
        {
            cmbClient.Items.AddRange(new object[] { "Select client", "Ahmed", "Client 2", "Client 3" });
            cmbEvent.Items.AddRange(new object[] { "Select event", "Wedding", "Birthday", "Corporate" });
            cmbMenu.Items.AddRange(new object[]
            {
                new MenuOption("Wedding Gold", 50m),
                new MenuOption("Wedding Silver", 35m),
                new MenuOption("Basic Catering", 20m)
            });
            cmbStatus.Items.AddRange(new object[] { "Pending", "Confirmed", "Cancelled" });

            cmbClient.SelectedIndex = 0;
            cmbEvent.SelectedIndex = 0;
            cmbMenu.SelectedIndex = 0;
            cmbStatus.SelectedItem = "Confirmed";
        }

        private void cmbMenu_SelectedIndexChanged(object? sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void numGuests_ValueChanged(object? sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            decimal pricePerGuest = (cmbMenu.SelectedItem as MenuOption)?.PricePerPerson ?? 0m;
            decimal total = pricePerGuest * numGuests.Value;
            lblTotalPrice.Text = $"Total price: {total:C}";
        }

        private void btnSave_Click(object? sender, EventArgs e)
        {
            try
            {
                if (!ValidateBooking())
                {
                    return;
                }

                MenuOption menu = (MenuOption)cmbMenu.SelectedItem!;
                BookingRecord booking = new()
                {
                    Client = cmbClient.Text,
                    Event = cmbEvent.Text,
                    Menu = menu.Name,
                    Guests = (int)numGuests.Value,
                    Status = cmbStatus.Text,
                    TotalPrice = menu.PricePerPerson * numGuests.Value
                };

                bookings.Add(booking);
                MessageBox.Show(
                    $"Booking saved successfully.\nTotal price: {booking.TotalPrice:C}",
                    "Booking",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                ShowError("save the booking", ex);
            }
        }

        private void btnCancel_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool ValidateBooking()
        {
            if (cmbClient.SelectedIndex <= 0)
            {
                MessageBox.Show("Select a client.", "Booking", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbClient.Focus();
                return false;
            }

            if (cmbEvent.SelectedIndex <= 0)
            {
                MessageBox.Show("Select an event.", "Booking", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbEvent.Focus();
                return false;
            }

            if (cmbMenu.SelectedItem is not MenuOption)
            {
                MessageBox.Show("Select a menu.", "Booking", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMenu.Focus();
                return false;
            }

            if (numGuests.Value < 1)
            {
                MessageBox.Show("Guests must be at least one.", "Booking", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numGuests.Focus();
                return false;
            }

            return true;
        }

        private static void ShowError(string operation, Exception exception)
        {
            MessageBox.Show(
                $"Unable to {operation}.\n\nDetails: {exception.Message}",
                "Booking Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private sealed class MenuOption
        {
            public MenuOption(string name, decimal pricePerPerson)
            {
                Name = name;
                PricePerPerson = pricePerPerson;
            }

            public string Name { get; }
            public decimal PricePerPerson { get; }

            public override string ToString() => Name;
        }

        private sealed class BookingRecord
        {
            public string Client { get; set; } = string.Empty;
            public string Event { get; set; } = string.Empty;
            public string Menu { get; set; } = string.Empty;
            public int Guests { get; set; }
            public string Status { get; set; } = string.Empty;
            public decimal TotalPrice { get; set; }
        }
    }
}
