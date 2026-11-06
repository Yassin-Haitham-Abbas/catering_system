using System;
using System.Windows.Forms;

namespace Catering_system
{
    public partial class MainDashboardForm : Form
    {
        public MainDashboardForm()
        {
            InitializeComponent();

            // Connect buttons to their click events
            btnBooking.Click -= btnBooking_Click;
            btnBooking.Click += btnBooking_Click;

            btnMenu.Click -= btnMenu_Click;
            btnMenu.Click += btnMenu_Click;

            btnClients.Click -= btnClients_Click;
            btnClients.Click += btnClients_Click;

            btnEvents.Click -= btnEvents_Click;
            btnEvents.Click += btnEvents_Click;

            btnReports.Click -= btnReports_Click;
            btnReports.Click += btnReports_Click;
        }

        // Open selected form and return to dashboard when closed
        private void OpenPage(Form page)
        {
            this.Hide();

            page.FormClosed += (sender, e) =>
            {
                this.Show();
            };

            page.Show();
        }

        // Booking Button
        private void btnBooking_Click(object sender, EventArgs e)
        {
            OpenPage(new BookingForm());
        }

        // Menu Button
        private void btnMenu_Click(object sender, EventArgs e)
        {
            OpenPage(new MenuListForm());
        }

        // Clients Button
        private void btnClients_Click(object sender, EventArgs e)
        {
            OpenPage(new ClientsForm());
        }

        // Events Button
        private void btnEvents_Click(object sender, EventArgs e)
        {
            OpenPage(new EventsForm());
        }

        // Reports Button
        private void btnReports_Click(object sender, EventArgs e)
        {
            OpenPage(new ReportsForm());
        }

        private void txtClients_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEvents_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainDashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}
