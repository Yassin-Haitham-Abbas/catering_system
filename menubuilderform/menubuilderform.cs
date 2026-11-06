namespace menubuilderform
{
    public partial class menubuilderform : Form
    {
        private List<MenuItem> _allItems;
        private List<MenuItem> _selectedItems = new();

        public menubuilderform()
        {
            InitializeComponent();

            // fake data for testing
            var main = new Category { Id = 1, Name = "Main" };
            var dessert = new Category { Id = 2, Name = "Dessert" };

            _allItems = new List<MenuItem>
            {
                new MenuItem { Id = 1, Name = "Chicken", PricePerPerson = 8, Category = main },
                new MenuItem { Id = 2, Name = "Rice",    PricePerPerson = 3, Category = main },
                new MenuItem { Id = 3, Name = "Cake",    PricePerPerson = 4, Category = dessert },
            };

            // connect the dropdown to the method below
            cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;

            cboCategory.Items.Add("All");
            cboCategory.Items.Add(main);
            cboCategory.Items.Add(dessert);
            cboCategory.SelectedIndex = 0;
        }

        private void btncategories_Click(object sender, EventArgs e)
        {
            try
            {
                using categoryform categoriesPage = new();
                categoriesPage.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to open Category Management.\n\nDetails: {ex.Message}", "Menu Builder Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // runs when the category dropdown changes
        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshAvailable();
        }

        // fills the left list
        private void RefreshAvailable()
        {
            var cat = cboCategory.SelectedItem as Category;   // null means "All"
            lstavailable.DataSource = _allItems
                .Where(i => cat == null || i.Category.Id == cat.Id)
                .Where(i => !_selectedItems.Contains(i))
                .ToList();
        }

        private void btnadditem_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstavailable.SelectedItem is not MenuItem item)
                {
                    MessageBox.Show("Select an available menu item first.", "Menu Builder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (!_selectedItems.Contains(item))
                {
                    _selectedItems.Add(item);
                }

                RefreshLists();
            }
            catch (Exception ex)
            {
                ShowError("add the menu item", ex);
            }
        }

        private void btnremoveitem_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstselected.SelectedItem is not MenuItem item)
                {
                    MessageBox.Show("Select a menu item to remove first.", "Menu Builder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                _selectedItems.Remove(item);
                RefreshLists();
            }
            catch (Exception ex)
            {
                ShowError("remove the menu item", ex);
            }
        }


        private void RefreshLists()
        {
            RefreshAvailable();
            lstselected.DataSource = null;
            lstselected.DataSource = _selectedItems.ToList();
            lblTotal.Text = $"Total per person: {_selectedItems.Sum(i => i.PricePerPerson):C}";
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtmenuename.Text))
                {
                    MessageBox.Show("Please enter a menu name.", "Menu Builder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtmenuename.Focus();
                    return;
                }

                if (_selectedItems.Count == 0)
                {
                    MessageBox.Show("Add at least one item to the menu.", "Menu Builder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult = DialogResult.OK;
                MessageBox.Show("Menu saved successfully!", "Menu Builder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                ShowError("save the menu", ex);
            }
        }

        private static void ShowError(string operation, Exception exception)
        {
            MessageBox.Show($"Unable to {operation}.\n\nDetails: {exception.Message}", "Menu Builder Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }



}