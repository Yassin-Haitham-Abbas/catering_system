using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Catering_system
{
    public partial class ClientsForm : Form
    {
        private readonly List<ClientRecord> clients = new();
        private int nextClientId = 1;
        private int? selectedClientId;

        public ClientsForm()
        {
            InitializeComponent();
            ConfigureGrid();
            ClearFields();
        }

        private void ConfigureGrid()
        {
            clientsGrid.AutoGenerateColumns = false;
            clientsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            clientsGrid.MultiSelect = false;
            clientsGrid.ReadOnly = true;
            clientsGrid.AllowUserToAddRows = false;
            clientsGrid.Columns.Add("ClientID", "ClientID");
            clientsGrid.Columns.Add("FullName", "FullName");
            clientsGrid.Columns.Add("Phone", "Phone");
            clientsGrid.Columns.Add("Email", "Email");
            clientsGrid.Columns.Add("Address", "Address");
            clientsGrid.SelectionChanged += clientsGrid_SelectionChanged;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateFields())
                {
                    return;
                }

                if (IsDuplicateContact())
                {
                    MessageBox.Show("A client with the same phone number or email already exists.", "Client Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ClientRecord client = new()
                {
                    Id = nextClientId++,
                    FullName = txtName.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Address = txtAddress.Text.Trim()
                };

                clients.Add(client);
                RefreshGrid(client.Id);
                ClearFields();
            }
            catch (Exception ex)
            {
                ShowOperationError("add the client", ex);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!TryGetSelectedClient(out ClientRecord? client))
                {
                    MessageBox.Show("Select a client first.", "Client Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                bool hasDuplicateContact = IsDuplicateContact(client.Id);
                if (!ValidateFields() || hasDuplicateContact)
                {
                    if (hasDuplicateContact)
                    {
                        MessageBox.Show("Another client already uses the same phone number or email.", "Client Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    return;
                }

                client.FullName = txtName.Text.Trim();
                client.Phone = txtPhone.Text.Trim();
                client.Email = txtEmail.Text.Trim();
                client.Address = txtAddress.Text.Trim();
                RefreshGrid(client.Id);
                MessageBox.Show("Client updated successfully.", "Client Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ShowOperationError("update the client", ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!TryGetSelectedClient(out ClientRecord? client))
                {
                    MessageBox.Show("Select a client first.", "Client Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult confirmation = MessageBox.Show(
                    $"Delete client '{client.FullName}'?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmation != DialogResult.Yes)
                {
                    return;
                }

                bool removed = clients.Remove(client);
                if (!removed)
                {
                    MessageBox.Show("The selected client could not be found.", "Client Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                RefreshGrid();
                ClearFields();
                MessageBox.Show("Client deleted successfully.", "Client Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ShowOperationError("delete the client", ex);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            clientsGrid.ClearSelection();
        }

        private void clientsGrid_SelectionChanged(object? sender, EventArgs e)
        {
            if (clientsGrid.SelectedRows.Count == 0 || clientsGrid.SelectedRows[0].Index < 0)
            {
                return;
            }

            if (TryReadClientId(clientsGrid.SelectedRows[0], out int clientId))
            {
                ClientRecord? client = clients.FirstOrDefault(item => item.Id == clientId);
                if (client != null)
                {
                    selectedClientId = client.Id;
                    txtName.Text = client.FullName;
                    txtPhone.Text = client.Phone;
                    txtEmail.Text = client.Email;
                    txtAddress.Text = client.Address;
                }
            }
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Enter the client's name.", "Client Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Enter the client's phone number.", "Client Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !txtEmail.Text.Contains('@'))
            {
                MessageBox.Show("Enter a valid email address or leave email empty.", "Client Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            return true;
        }

        private bool TryGetSelectedClient(out ClientRecord? client)
        {
            client = null;

            if (clientsGrid.SelectedRows.Count > 0 && TryReadClientId(clientsGrid.SelectedRows[0], out int gridClientId))
            {
                selectedClientId = gridClientId;
            }

            if (!selectedClientId.HasValue)
            {
                return false;
            }

            client = clients.FirstOrDefault(item => item.Id == selectedClientId.Value);
            return client != null;
        }

        private static bool TryReadClientId(DataGridViewRow row, out int clientId)
        {
            return int.TryParse(Convert.ToString(row.Cells["ClientID"].Value), out clientId);
        }

        private bool IsDuplicateContact(int? ignoredClientId = null)
        {
            string phone = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();

            return clients.Any(client =>
                (!ignoredClientId.HasValue || client.Id != ignoredClientId.Value) &&
                (string.Equals(client.Phone, phone, StringComparison.OrdinalIgnoreCase) ||
                 (!string.IsNullOrWhiteSpace(email) && string.Equals(client.Email, email, StringComparison.OrdinalIgnoreCase))));
        }

        private void RefreshGrid(int? clientIdToSelect = null)
        {
            clientsGrid.Rows.Clear();
            foreach (ClientRecord client in clients)
            {
                clientsGrid.Rows.Add(client.Id, client.FullName, client.Phone, client.Email, client.Address);
            }

            if (clientIdToSelect.HasValue)
            {
                foreach (DataGridViewRow row in clientsGrid.Rows)
                {
                    if (TryReadClientId(row, out int rowClientId) && rowClientId == clientIdToSelect.Value)
                    {
                        row.Selected = true;
                        clientsGrid.CurrentCell = row.Cells["FullName"];
                        selectedClientId = clientIdToSelect.Value;
                        return;
                    }
                }
            }
        }

        private static void ShowOperationError(string operation, Exception exception)
        {
            MessageBox.Show(
                $"Unable to {operation}. Please check the entered information and try again.\n\nDetails: {exception.Message}",
                "Client Management Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void ClearFields()
        {
            selectedClientId = null;
            txtName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            clientsGrid.ClearSelection();
        }

        private sealed class ClientRecord
        {
            public int Id { get; set; }
            public string FullName { get; set; } = string.Empty;
            public string Phone { get; set; } = string.Empty;
            public string Email { get; set; } = string.Empty;
            public string Address { get; set; } = string.Empty;
        }
    }
}
