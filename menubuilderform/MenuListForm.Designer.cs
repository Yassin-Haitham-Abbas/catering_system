using System.Drawing;
using System.Windows.Forms;

namespace Catering_system
{
    partial class MenuListForm
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
            lblTitle = new Label();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnMenuBuilder = new Button();
            btnCategories = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            dgvMenus = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMenus).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.FromArgb(63, 47, 150);
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(900, 75);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Menu List";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(55, 105);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(61, 23);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(125, 102);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(275, 27);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnMenuBuilder
            // 
            btnMenuBuilder.BackColor = Color.FromArgb(52, 121, 205);
            btnMenuBuilder.FlatStyle = FlatStyle.Flat;
            btnMenuBuilder.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenuBuilder.ForeColor = Color.White;
            btnMenuBuilder.Location = new Point(55, 410);
            btnMenuBuilder.Name = "btnMenuBuilder";
            btnMenuBuilder.Size = new Size(180, 42);
            btnMenuBuilder.TabIndex = 3;
            btnMenuBuilder.Text = "Menu Builder";
            btnMenuBuilder.UseVisualStyleBackColor = false;
            btnMenuBuilder.Click += btnMenuBuilder_Click;
            // 
            // btnCategories
            // 
            btnCategories.BackColor = Color.FromArgb(63, 47, 150);
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCategories.ForeColor = Color.White;
            btnCategories.Location = new Point(265, 410);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(180, 42);
            btnCategories.TabIndex = 4;
            btnCategories.Text = "Categories";
            btnCategories.UseVisualStyleBackColor = false;
            btnCategories.Click += btnCategories_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(205, 48, 62);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(475, 410);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 42);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(95, 95, 95);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(655, 410);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(150, 42);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // dgvMenus
            // 
            dgvMenus.AllowUserToAddRows = false;
            dgvMenus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMenus.BackgroundColor = Color.White;
            dgvMenus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMenus.Location = new Point(55, 155);
            dgvMenus.MultiSelect = false;
            dgvMenus.Name = "dgvMenus";
            dgvMenus.ReadOnly = true;
            dgvMenus.RowHeadersWidth = 51;
            dgvMenus.RowTemplate.Height = 30;
            dgvMenus.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMenus.Size = new Size(750, 220);
            dgvMenus.TabIndex = 7;
            // 
            // MenuListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(900, 500);
            Controls.Add(dgvMenus);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnCategories);
            Controls.Add(btnMenuBuilder);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(lblTitle);
            Name = "MenuListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu List";
            ((System.ComponentModel.ISupportInitialize)dgvMenus).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnMenuBuilder;
        private Button btnCategories;
        private Button btnDelete;
        private Button btnClose;
        private DataGridView dgvMenus;
    }
}
