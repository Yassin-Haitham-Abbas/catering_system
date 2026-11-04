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
            var name = txtCategoryName.Text.Trim();

            if (name == "")
            {
                MessageBox.Show("Please enter a category name.");
                return;
            }

            if (_categories.Any(c => c.Name.ToLower() == name.ToLower()))
            {
                MessageBox.Show("This category already exists.");
                return;
            }

            _categories.Add(new Category { Id = _nextId++, Name = name });
            RefreshList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstcategories.SelectedItem is Category c)
            {
                var name = txtCategoryName.Text.Trim();
                if (name == "")
                {
                    MessageBox.Show("Please enter a category name.");
                    return;
                }
                c.Name = name;
                RefreshList();
            }
            else
            {
                MessageBox.Show("Select a category first.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstcategories.SelectedItem is Category c)
            {
                _categories.Remove(c);
                RefreshList();
            }
            else
            {
                MessageBox.Show("Select a category first.");
            }
        }

        private void lstcategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstcategories.SelectedItem is Category c)
            {
                txtCategoryName.Text = c.Name;
            }
        }


    }

}
