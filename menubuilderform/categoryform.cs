using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menubuilderform
{
    public partial class categoryform : Form
    {

        private List<Category> _categories = new();
        private int _nextId = 1;

        public categoryform()
        {
            InitializeComponent();
        }

        private void categoryform_Load(object sender, EventArgs e)
        {

        }

        private void RefreshList()
        {
            lstcategories.DataSource = null;
            lstcategories.DataSource = _categories.ToList();
            txtCategoryName.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtCategoryName.Text.Trim();
                if (!ValidateName(name))
                {
                    return;
                }

                if (_categories.Any(c => string.Equals(c.Name, name, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("This category already exists.", "Category Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _categories.Add(new Category { Id = _nextId++, Name = name });
                RefreshList();
            }
            catch (Exception ex)
            {
                ShowError("add the category", ex);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstcategories.SelectedItem is not Category category)
                {
                    MessageBox.Show("Select a category first.", "Category Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string name = txtCategoryName.Text.Trim();
                if (!ValidateName(name))
                {
                    return;
                }

                if (_categories.Any(c => c.Id != category.Id && string.Equals(c.Name, name, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("This category already exists.", "Category Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                category.Name = name;
                RefreshList();
                MessageBox.Show("Category updated successfully.", "Category Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ShowError("update the category", ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstcategories.SelectedItem is not Category category)
                {
                    MessageBox.Show("Select a category first.", "Category Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult confirmation = MessageBox.Show(
                    $"Delete category '{category.Name}'?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmation != DialogResult.Yes)
                {
                    return;
                }

                if (!_categories.Remove(category))
                {
                    MessageBox.Show("The selected category could not be found.", "Category Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                RefreshList();
                MessageBox.Show("Category deleted successfully.", "Category Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ShowError("delete the category", ex);
            }
        }

        private void lstcategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstcategories.SelectedItem is Category c)
            {
                txtCategoryName.Text = c.Name;
            }
        }

        private bool ValidateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter a category name.", "Category Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCategoryName.Focus();
                return false;
            }

            if (name.Length > 100)
            {
                MessageBox.Show("Category names must be 100 characters or fewer.", "Category Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCategoryName.Focus();
                return false;
            }

            return true;
        }

        private static void ShowError(string operation, Exception exception)
        {
            MessageBox.Show(
                $"Unable to {operation}.\n\nDetails: {exception.Message}",
                "Category Management Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }


    }

}
