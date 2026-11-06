using System.Drawing;
using System.Windows.Forms;

namespace menubuilderform
{
    partial class categoryform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleLabel = new Label();
            label1 = new Label();
            txtCategoryName = new TextBox();
            lstcategories = new ListBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.FromArgb(63, 47, 150);
            titleLabel.Dock = DockStyle.Top;
            titleLabel.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(620, 75);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Category Management";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 115);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 1;
            label1.Text = "Category name:";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(185, 112);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(125, 27);
            txtCategoryName.TabIndex = 2;
            // 
            // lstcategories
            // 
            lstcategories.FormattingEnabled = true;
            lstcategories.BackColor = Color.White;
            lstcategories.Location = new Point(45, 175);
            lstcategories.Name = "lstcategories";
            lstcategories.Size = new Size(261, 164);
            lstcategories.Size = new Size(330, 204);
            lstcategories.TabIndex = 3;
            lstcategories.SelectedIndexChanged += lstcategories_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(52, 121, 205);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(415, 175);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.Size = new Size(150, 42);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(78, 153, 55);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(415, 235);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.Size = new Size(150, 42);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(205, 48, 62);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(415, 295);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.Size = new Size(150, 42);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // categoryform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(620, 450);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Controls.Add(titleLabel);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(lstcategories);
            Controls.Add(txtCategoryName);
            Controls.Add(label1);
            Name = "categoryform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Category Management";
            Load += categoryform_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label titleLabel;
        private TextBox txtCategoryName;
        private ListBox lstcategories;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
    }
}