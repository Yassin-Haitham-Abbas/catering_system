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
            SuspendLayout();
            // 
            // lblmenuname
            // 
            lblmenuname.AutoSize = true;
            lblmenuname.Location = new Point(24, 24);
            lblmenuname.Name = "lblmenuname";
            lblmenuname.Size = new Size(98, 20);
            lblmenuname.TabIndex = 0;
            lblmenuname.Text = "menu name  :";
            // 
            // txtmenuename
            // 
            txtmenuename.Location = new Point(132, 24);
            txtmenuename.Name = "txtmenuename";
            txtmenuename.Size = new Size(125, 27);
            txtmenuename.TabIndex = 1;
            // 
            // lblcategory
            // 
            lblcategory.AutoSize = true;
            lblcategory.Location = new Point(24, 96);
            lblcategory.Name = "lblcategory";
            lblcategory.Size = new Size(74, 20);
            lblcategory.TabIndex = 2;
            lblcategory.Text = "category :";
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(132, 96);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(151, 28);
            cboCategory.TabIndex = 3;
            // 
            // lstavailable
            // 
            lstavailable.FormattingEnabled = true;
            lstavailable.Location = new Point(24, 181);
            lstavailable.Name = "lstavailable";
            lstavailable.Size = new Size(152, 164);
            lstavailable.TabIndex = 4;
            // 
            // btnadditem
            // 
            btnadditem.Location = new Point(261, 217);
            btnadditem.Name = "btnadditem";
            btnadditem.Size = new Size(49, 29);
            btnadditem.TabIndex = 5;
            btnadditem.Text = ">>";
            btnadditem.UseVisualStyleBackColor = true;
            btnadditem.Click += btnadditem_Click;
            // 
            // btnremoveitem
            // 
            btnremoveitem.Location = new Point(261, 279);
            btnremoveitem.Name = "btnremoveitem";
            btnremoveitem.Size = new Size(49, 27);
            btnremoveitem.TabIndex = 6;
            btnremoveitem.Text = "<<";
            btnremoveitem.UseVisualStyleBackColor = true;
            btnremoveitem.Click += btnremoveitem_Click;
            // 
            // lstselected
            // 
            lstselected.FormattingEnabled = true;
            lstselected.Location = new Point(388, 181);
            lstselected.Name = "lstselected";
            lstselected.Size = new Size(150, 164);
            lstselected.TabIndex = 7;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(24, 378);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(161, 20);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "total per person : $0.00";
            // 
            // btnsave
            // 
            btnsave.Location = new Point(177, 417);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(94, 29);
            btnsave.TabIndex = 9;
            btnsave.Text = "save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // btncancel
            // 
            btncancel.Location = new Point(311, 417);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(94, 29);
            btncancel.TabIndex = 10;
            btncancel.Text = "cancel";
            btncancel.UseVisualStyleBackColor = true;
            btncancel.Click += btncancel_Click;
            // 
            // menubuilderform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 453);
            Controls.Add(btncancel);
            Controls.Add(btnsave);
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
            Text = "menu builder ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblmenuname;
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
    }
}
