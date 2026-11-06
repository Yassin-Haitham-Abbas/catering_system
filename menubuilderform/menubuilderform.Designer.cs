using System.Drawing;
using System.Windows.Forms;

namespace menubuilderform
{
    partial class menubuilderform
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleLabel = new Label();
            lblmenuname = new Label();
            txtmenuename = new TextBox();
            lblcategory = new Label();
            cboCategory = new ComboBox();
            lstavailable = new ListBox();
            btnadditem = new Button();
            btnremoveitem = new Button();
            lstselected = new ListBox();
            lblTotal = new Label();
            btnsave = new Button();
            btncancel = new Button();
            btncategories = new Button();
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
            titleLabel.Size = new Size(700, 75);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Menu Builder";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblmenuname
            // 
            lblmenuname.AutoSize = true;
            lblmenuname.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblmenuname.Location = new Point(45, 110);
            lblmenuname.Name = "lblmenuname";
            lblmenuname.Size = new Size(98, 20);
            lblmenuname.TabIndex = 1;
            lblmenuname.Text = "Menu name:";
            // 
            // txtmenuename
            // 
            txtmenuename.Location = new Point(170, 107);
            txtmenuename.Name = "txtmenuename";
            txtmenuename.Size = new Size(125, 27);
            txtmenuename.Size = new Size(260, 27);
            txtmenuename.TabIndex = 2;
            // 
            // lblcategory
            // 
            lblcategory.AutoSize = true;
            lblcategory.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcategory.Location = new Point(45, 165);
            lblcategory.Name = "lblcategory";
            lblcategory.Size = new Size(74, 20);
            lblcategory.TabIndex = 3;
            lblcategory.Text = "Category:";
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.Location = new Point(170, 162);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(260, 28);
            cboCategory.TabIndex = 4;
            // 
            // lstavailable
            // 
            lstavailable.FormattingEnabled = true;
            lstavailable.BackColor = Color.White;
            lstavailable.Location = new Point(45, 235);
            lstavailable.Name = "lstavailable";
            lstavailable.Size = new Size(220, 184);
            lstavailable.TabIndex = 5;
            // 
            // btnadditem
            // 
            btnadditem.Location = new Point(261, 217);
            btnadditem.Name = "btnadditem";
            btnadditem.Size = new Size(70, 38);
            btnadditem.TabIndex = 6;
            btnadditem.Text = ">>";
            btnadditem.UseVisualStyleBackColor = false;
            btnadditem.Click += btnadditem_Click;
            // 
            // btnremoveitem
            // 
            btnremoveitem.Location = new Point(261, 279);
            btnremoveitem.Name = "btnremoveitem";
            btnremoveitem.Size = new Size(70, 38);
            btnremoveitem.TabIndex = 7;
            btnremoveitem.Text = "<<";
            btnremoveitem.UseVisualStyleBackColor = false;
            btnremoveitem.Click += btnremoveitem_Click;
            // 
            // lstselected
            // 
            lstselected.FormattingEnabled = true;
            lstselected.BackColor = Color.White;
            lstselected.Location = new Point(390, 235);
            lstselected.Name = "lstselected";
            lstselected.Size = new Size(250, 184);
            lstselected.TabIndex = 8;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.FromArgb(63, 47, 150);
            lblTotal.Location = new Point(45, 440);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(161, 20);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "Total per person: $0.00";
            // 
            // btnsave
            // 
            btnsave.BackColor = Color.FromArgb(78, 153, 55);
            btnsave.FlatStyle = FlatStyle.Flat;
            btnsave.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsave.ForeColor = Color.White;
            btnsave.Location = new Point(45, 490);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(140, 40);
            btnsave.TabIndex = 10;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // btncancel
            // 
            btncancel.BackColor = Color.FromArgb(95, 95, 95);
            btncancel.FlatStyle = FlatStyle.Flat;
            btncancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncancel.ForeColor = Color.White;
            btncancel.Location = new Point(205, 490);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(140, 40);
            btncancel.TabIndex = 11;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = false;
            btncancel.Click += btncancel_Click;
            // 
            // btncategories
            // 
            btncategories.BackColor = Color.FromArgb(63, 47, 150);
            btncategories.FlatStyle = FlatStyle.Flat;
            btncategories.ForeColor = Color.White;
            btncategories.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncategories.Location = new Point(365, 490);
            btncategories.Name = "btncategories";
            btncategories.Size = new Size(160, 40);
            btncategories.TabIndex = 12;
            btncategories.Text = "Categories";
            btncategories.UseVisualStyleBackColor = false;
            btncategories.Click += btncategories_Click;
            // 
            // menubuilderform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(700, 570);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Controls.Add(titleLabel);
            Controls.Add(btncancel);
            Controls.Add(btnsave);
            Controls.Add(btncategories);
            Controls.Add(lblTotal);
            Controls.Add(lstselected);
            Controls.Add(btnremoveitem);
            Controls.Add(btnadditem);
            Controls.Add(lstavailable);
            Controls.Add(cboCategory);
            Controls.Add(lblcategory);
            Controls.Add(txtmenuename);
            Controls.Add(lblmenuname);
            Name = "menubuilderform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Builder";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblmenuname;
        private Label titleLabel;
        private TextBox txtmenuename;
        private Label lblcategory;
        private ComboBox cboCategory;
        private ListBox lstavailable;
        private Button btnadditem;
        private Button btnremoveitem;
        private ListBox lstselected;
        private Label lblTotal;
        private Button btnsave;
        private Button btncancel;
        private Button btncategories;
    }
}
