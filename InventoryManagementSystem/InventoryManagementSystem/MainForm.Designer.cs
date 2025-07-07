namespace InventoryManagementSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            label1 = new Label();
            close = new Button();
            panel2 = new Panel();
            adminDashborad1 = new AdminDashborad();
            logoutbtn = new Button();
            button10 = new Button();
            customers_btn = new Button();
            button12 = new Button();
            addProducts_btn = new Button();
            button7 = new Button();
            addCategories_btn = new Button();
            addUsers_btn = new Button();
            button4 = new Button();
            button3 = new Button();
            dashboard_btn = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            adminAddCategories1 = new AdminAddCategories();
            adminAddProducts1 = new AdminAddProducts();
            cashierCustomersForm1 = new CashierCustomersForm();
            adminAddUser1 = new AdminAddUser();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(close);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1309, 86);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(39, 21);
            label1.Name = "label1";
            label1.Size = new Size(460, 28);
            label1.TabIndex = 3;
            label1.Text = "Inventory Management System |Admin's Portal";
            // 
            // close
            // 
            close.BackColor = Color.FromArgb(192, 0, 0);
            close.FlatAppearance.BorderColor = Color.Black;
            close.FlatAppearance.BorderSize = 2;
            close.FlatStyle = FlatStyle.Flat;
            close.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close.ForeColor = Color.Transparent;
            close.Location = new Point(1187, 21);
            close.Margin = new Padding(0, 10, 0, 10);
            close.Name = "close";
            close.Size = new Size(99, 36);
            close.TabIndex = 2;
            close.Text = "x";
            close.TextAlign = ContentAlignment.TopCenter;
            close.UseVisualStyleBackColor = false;
            close.Click += close_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(134, 182, 246);
            panel2.Controls.Add(adminDashborad1);
            panel2.Controls.Add(logoutbtn);
            panel2.Controls.Add(button10);
            panel2.Controls.Add(customers_btn);
            panel2.Controls.Add(button12);
            panel2.Controls.Add(addProducts_btn);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(addCategories_btn);
            panel2.Controls.Add(addUsers_btn);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(dashboard_btn);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(283, 709);
            panel2.TabIndex = 1;
            // 
            // adminDashborad1
            // 
            adminDashborad1.Location = new Point(24, 152);
            adminDashborad1.Name = "adminDashborad1";
            adminDashborad1.Size = new Size(1282, 884);
            adminDashborad1.TabIndex = 4;
            // 
            // logoutbtn
            // 
            logoutbtn.BackColor = Color.FromArgb(128, 128, 255);
            logoutbtn.FlatAppearance.BorderSize = 0;
            logoutbtn.FlatAppearance.MouseDownBackColor = Color.MediumBlue;
            logoutbtn.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            logoutbtn.FlatStyle = FlatStyle.Flat;
            logoutbtn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            logoutbtn.ForeColor = Color.FromArgb(0, 0, 192);
            logoutbtn.Location = new Point(12, 658);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(248, 37);
            logoutbtn.TabIndex = 18;
            logoutbtn.Text = "Logout";
            logoutbtn.UseVisualStyleBackColor = false;
            logoutbtn.Click += logoutbtn_Click;
            // 
            // button10
            // 
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatAppearance.MouseDownBackColor = Color.Blue;
            button10.FlatAppearance.MouseOverBackColor = Color.Blue;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.ForeColor = Color.Blue;
            button10.Location = new Point(12, 453);
            button10.Name = "button10";
            button10.Size = new Size(248, 55);
            button10.TabIndex = 17;
            button10.UseVisualStyleBackColor = true;
            // 
            // customers_btn
            // 
            customers_btn.FlatAppearance.BorderSize = 0;
            customers_btn.FlatAppearance.MouseDownBackColor = Color.Blue;
            customers_btn.FlatAppearance.MouseOverBackColor = Color.Blue;
            customers_btn.FlatStyle = FlatStyle.Flat;
            customers_btn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            customers_btn.ForeColor = Color.Blue;
            customers_btn.Location = new Point(12, 412);
            customers_btn.Name = "customers_btn";
            customers_btn.Size = new Size(248, 55);
            customers_btn.TabIndex = 16;
            customers_btn.Text = "Customers";
            customers_btn.UseVisualStyleBackColor = true;
            customers_btn.Click += customers_btn_Click;
            // 
            // button12
            // 
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatAppearance.MouseDownBackColor = Color.Blue;
            button12.FlatAppearance.MouseOverBackColor = Color.Blue;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button12.ForeColor = Color.Blue;
            button12.Location = new Point(12, 491);
            button12.Name = "button12";
            button12.Size = new Size(248, 55);
            button12.TabIndex = 15;
            button12.UseVisualStyleBackColor = true;
            // 
            // addProducts_btn
            // 
            addProducts_btn.FlatAppearance.BorderSize = 0;
            addProducts_btn.FlatAppearance.MouseDownBackColor = Color.Blue;
            addProducts_btn.FlatAppearance.MouseOverBackColor = Color.Blue;
            addProducts_btn.FlatStyle = FlatStyle.Flat;
            addProducts_btn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            addProducts_btn.ForeColor = Color.Blue;
            addProducts_btn.Location = new Point(12, 353);
            addProducts_btn.Name = "addProducts_btn";
            addProducts_btn.Size = new Size(248, 55);
            addProducts_btn.TabIndex = 14;
            addProducts_btn.Text = "Add Product";
            addProducts_btn.UseVisualStyleBackColor = true;
            addProducts_btn.Click += addProducts_btn_Click;
            // 
            // button7
            // 
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseDownBackColor = Color.Blue;
            button7.FlatAppearance.MouseOverBackColor = Color.Blue;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.Blue;
            button7.Location = new Point(12, 333);
            button7.Name = "button7";
            button7.Size = new Size(248, 55);
            button7.TabIndex = 13;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // addCategories_btn
            // 
            addCategories_btn.FlatAppearance.BorderSize = 0;
            addCategories_btn.FlatAppearance.MouseDownBackColor = Color.Blue;
            addCategories_btn.FlatAppearance.MouseOverBackColor = Color.Blue;
            addCategories_btn.FlatStyle = FlatStyle.Flat;
            addCategories_btn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            addCategories_btn.ForeColor = Color.Blue;
            addCategories_btn.Location = new Point(12, 292);
            addCategories_btn.Name = "addCategories_btn";
            addCategories_btn.Size = new Size(248, 55);
            addCategories_btn.TabIndex = 12;
            addCategories_btn.Text = "Add Categories";
            addCategories_btn.UseVisualStyleBackColor = true;
            addCategories_btn.Click += addCategories_btn_Click;
            // 
            // addUsers_btn
            // 
            addUsers_btn.FlatAppearance.BorderSize = 0;
            addUsers_btn.FlatAppearance.MouseDownBackColor = Color.Blue;
            addUsers_btn.FlatAppearance.MouseOverBackColor = Color.Blue;
            addUsers_btn.FlatStyle = FlatStyle.Flat;
            addUsers_btn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            addUsers_btn.ForeColor = Color.Blue;
            addUsers_btn.Location = new Point(12, 240);
            addUsers_btn.Name = "addUsers_btn";
            addUsers_btn.Size = new Size(248, 55);
            addUsers_btn.TabIndex = 11;
            addUsers_btn.Text = "Add Users";
            addUsers_btn.UseVisualStyleBackColor = true;
            addUsers_btn.Click += button6_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.Blue;
            button4.FlatAppearance.MouseOverBackColor = Color.Blue;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Blue;
            button4.Location = new Point(12, 371);
            button4.Name = "button4";
            button4.Size = new Size(248, 55);
            button4.TabIndex = 10;
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Blue;
            button3.FlatAppearance.MouseOverBackColor = Color.Blue;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Blue;
            button3.Location = new Point(12, 240);
            button3.Name = "button3";
            button3.Size = new Size(248, 55);
            button3.TabIndex = 8;
            button3.UseVisualStyleBackColor = true;
            // 
            // dashboard_btn
            // 
            dashboard_btn.FlatAppearance.BorderSize = 0;
            dashboard_btn.FlatAppearance.MouseDownBackColor = Color.Blue;
            dashboard_btn.FlatAppearance.MouseOverBackColor = Color.Blue;
            dashboard_btn.FlatStyle = FlatStyle.Flat;
            dashboard_btn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            dashboard_btn.ForeColor = Color.Blue;
            dashboard_btn.Location = new Point(12, 179);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Size = new Size(248, 55);
            dashboard_btn.TabIndex = 2;
            dashboard_btn.Text = "Dashboard";
            dashboard_btn.UseVisualStyleBackColor = true;
            dashboard_btn.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(52, 130);
            label2.Name = "label2";
            label2.Size = new Size(167, 28);
            label2.TabIndex = 2;
            label2.Text = "Welcome! Admin";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(238, 245, 255);
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(93, 22);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(adminAddUser1);
            panel3.Controls.Add(adminAddCategories1);
            panel3.Controls.Add(adminAddProducts1);
            panel3.Controls.Add(cashierCustomersForm1);
            panel3.Dock = DockStyle.Fill;
            panel3.ForeColor = Color.Black;
            panel3.Location = new Point(283, 86);
            panel3.Name = "panel3";
            panel3.Size = new Size(1026, 709);
            panel3.TabIndex = 2;
            // 
            // adminAddCategories1
            // 
            adminAddCategories1.Location = new Point(0, 0);
            adminAddCategories1.Name = "adminAddCategories1";
            adminAddCategories1.Size = new Size(1282, 884);
            adminAddCategories1.TabIndex = 4;
            // 
            // adminAddProducts1
            // 
            adminAddProducts1.Location = new Point(0, 0);
            adminAddProducts1.Name = "adminAddProducts1";
            adminAddProducts1.Size = new Size(1282, 884);
            adminAddProducts1.TabIndex = 4;
            // 
            // cashierCustomersForm1
            // 
            cashierCustomersForm1.Location = new Point(0, 0);
            cashierCustomersForm1.Name = "cashierCustomersForm1";
            cashierCustomersForm1.Size = new Size(1384, 945);
            cashierCustomersForm1.TabIndex = 0;
            // 
            // adminAddUser1
            // 
            adminAddUser1.Location = new Point(3, 0);
            adminAddUser1.Name = "adminAddUser1";
            adminAddUser1.Size = new Size(1282, 884);
            adminAddUser1.TabIndex = 4;
            adminAddUser1.Load += adminAddUser1_Load_3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1309, 795);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
       
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label2;
        private Button dashboard_btn;
        private Button addProducts_btn;
        private Button button7;
        private Button addCategories_btn;
        private Button addUsers_btn;
        private Button button4;
        private Button button3;
        private Button logoutbtn;
        private Button button10;
        private Button customers_btn;
        private Button button12;
        private Button close;
        private Panel panel3;
        private AdminAddCategories adminAddCategories1;
        private AdminAddProducts adminAddProducts1;
        private CashierCustomersForm cashierCustomersForm1;
        private AdminDashborad adminDashborad1;
        private AdminAddUser adminAddUser1;
    }
}