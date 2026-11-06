using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Catering_system
{
    public partial class MenuListForm : Form
    {
        private readonly List<MenuRecord> menus = new();

        public MenuListForm()
        {
            InitializeComponent();
            LoadMenus();
        }

        private void LoadMenus()
        {
            menus.Clear();
            menus.Add(new MenuRecord(1, "Wedding Gold", 50m, "5 courses"));
            menus.Add(new MenuRecord(2, "Birthday Basic", 20m, "Buffet"));
            menus.Add(new MenuRecord(3, "Corporate Lunch", 30m, "3 courses"));
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            string search = txtSearch.Text.Trim();
            dgvMenus.DataSource = null;
            dgvMenus.DataSource = menus
                .Where(menu => string.IsNullOrWhiteSpace(search) ||
                    menu.Name.Contains(search, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        private MenuRecord? GetSelectedMenu()
        {
            return dgvMenus.CurrentRow?.DataBoundItem as MenuRecord;
        }

        private void btnMenuBuilder_Click(object? sender, EventArgs e)
        {
            try
            {
                using global::menubuilderform.menubuilderform builder = new();
                builder.ShowDialog(this);
                ApplyFilter();
            }
            catch (Exception ex)
            {
                ShowError("open Menu Builder", ex);
            }
        }

        private void btnCategories_Click(object? sender, EventArgs e)
        {
            try
            {
                using menubuilderform.categoryform categories = new();
                categories.ShowDialog(this);
            }
            catch (Exception ex)
            {
                ShowError("open Category Management", ex);
            }
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            try
            {
                MenuRecord? selected = GetSelectedMenu();
                if (selected == null)
                {
                    MessageBox.Show("Select a menu first.", "Menu List", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult answer = MessageBox.Show(
                    $"Delete the menu '{selected.Name}'?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (answer == DialogResult.Yes)
                {
                    menus.Remove(selected);
                    ApplyFilter();
                }
            }
            catch (Exception ex)
            {
                ShowError("delete the menu", ex);
            }
        }

        private void btnClose_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void txtSearch_TextChanged(object? sender, EventArgs e)
        {
            ApplyFilter();
        }

        private static void ShowError(string operation, Exception exception)
        {
            MessageBox.Show(
                $"Unable to {operation}.\n\nDetails: {exception.Message}",
                "Menu List Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private sealed record MenuRecord(int Id, string Name, decimal PricePerGuest, string Description);
    }
}
