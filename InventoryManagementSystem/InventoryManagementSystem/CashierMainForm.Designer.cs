namespace InventoryManagementSystem
{
    partial class CashierMainForm
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
            panel1 = new Panel();
            label1 = new Label();
            close = new Button();
            panel2 = new Panel();
            logout_btn = new Button();
            button10 = new Button();
            order_btn = new Button();
            customers_btn = new Button();
            button12 = new Button();
            addProducts_btn = new Button();
            button7 = new Button();
            button4 = new Button();
            button3 = new Button();
            dashboard_btn = new Button();
            user_username = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            adminDashborad1 = new AdminDashborad();
            adminAddProducts1 = new AdminAddProducts();
            cashierCustomersForm1 = new CashierCustomersForm();
            cashierOrder1 = new CashierOrder();
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
            panel1.Size = new Size(1355, 86);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(39, 21);
            label1.Name = "label1";
            label1.Size = new Size(468, 28);
            label1.TabIndex = 3;
            label1.Text = "Inventory Management System |Cashier's Portal";
            label1.Click += label1_Click;
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
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(134, 182, 246);
            panel2.Controls.Add(logout_btn);
            panel2.Controls.Add(button10);
            panel2.Controls.Add(order_btn);
            panel2.Controls.Add(customers_btn);
            panel2.Controls.Add(button12);
            panel2.Controls.Add(addProducts_btn);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(dashboard_btn);
            panel2.Controls.Add(user_username);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(283, 715);
            panel2.TabIndex = 4;
            // 
            // logout_btn
            // 
            logout_btn.BackColor = Color.FromArgb(128, 128, 255);
            logout_btn.FlatAppearance.BorderSize = 0;
            logout_btn.FlatAppearance.MouseDownBackColor = Color.MediumBlue;
            logout_btn.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            logout_btn.FlatStyle = FlatStyle.Flat;
            logout_btn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            logout_btn.ForeColor = Color.FromArgb(0, 0, 192);
            logout_btn.Location = new Point(12, 658);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(248, 37);
            logout_btn.TabIndex = 18;
            logout_btn.Text = "Logout";
            logout_btn.UseVisualStyleBackColor = false;
            logout_btn.Click += logout_btn_Click;
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
            // order_btn
            // 
            order_btn.FlatAppearance.BorderSize = 0;
            order_btn.FlatAppearance.MouseDownBackColor = Color.Blue;
            order_btn.FlatAppearance.MouseOverBackColor = Color.Blue;
            order_btn.FlatStyle = FlatStyle.Flat;
            order_btn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            order_btn.ForeColor = Color.Blue;
            order_btn.Location = new Point(12, 372);
            order_btn.Name = "order_btn";
            order_btn.Size = new Size(248, 55);
            order_btn.TabIndex = 16;
            order_btn.Text = "Order";
            order_btn.UseVisualStyleBackColor = true;
            order_btn.Click += button1_Click;
            // 
            // customers_btn
            // 
            customers_btn.FlatAppearance.BorderSize = 0;
            customers_btn.FlatAppearance.MouseDownBackColor = Color.Blue;
            customers_btn.FlatAppearance.MouseOverBackColor = Color.Blue;
            customers_btn.FlatStyle = FlatStyle.Flat;
            customers_btn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            customers_btn.ForeColor = Color.Blue;
            customers_btn.Location = new Point(12, 310);
            customers_btn.Name = "customers_btn";
            customers_btn.Size = new Size(248, 55);
            customers_btn.TabIndex = 16;
            customers_btn.Text = "Customers";
            customers_btn.UseVisualStyleBackColor = true;
            customers_btn.Click += button11_Click;
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
            addProducts_btn.Location = new Point(12, 241);
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
            // user_username
            // 
            user_username.AutoSize = true;
            user_username.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            user_username.ForeColor = Color.FromArgb(0, 0, 192);
            user_username.Location = new Point(52, 130);
            user_username.Name = "user_username";
            user_username.Size = new Size(175, 28);
            user_username.TabIndex = 2;
            user_username.Text = "Welcome! Cashier";
            user_username.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(238, 245, 255);
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources._2;
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
            panel3.Controls.Add(adminDashborad1);
            panel3.Controls.Add(adminAddProducts1);
            panel3.Controls.Add(cashierCustomersForm1);
            panel3.Controls.Add(cashierOrder1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(283, 86);
            panel3.Name = "panel3";
            panel3.Size = new Size(1072, 715);
            panel3.TabIndex = 19;
            // 
            // adminDashborad1
            // 
            adminDashborad1.Location = new Point(0, 0);
            adminDashborad1.Name = "adminDashborad1";
            adminDashborad1.Size = new Size(1282, 884);
            adminDashborad1.TabIndex = 4;
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
            cashierCustomersForm1.TabIndex = 4;
            // 
            // cashierOrder1
            // 
            cashierOrder1.Location = new Point(0, 0);
            cashierOrder1.Name = "cashierOrder1";
            cashierOrder1.Size = new Size(1282, 884);
            cashierOrder1.TabIndex = 4;
            // 
            // CashierMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1355, 801);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CashierMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System|Cashier's Portal";
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
        private Button close;
        private Panel panel2;
        private Button logout_btn;
        private Button button10;
        private Button customers_btn;
        private Button button12;
        private Button addProducts_btn;
        private Button button7;
        private Button button4;
        private Button button3;
        private Button dashboard_btn;
        private Label user_username;
        private PictureBox pictureBox1;
        private Button order_btn;
        private Panel panel3;
        private AdminDashborad adminDashborad1;
        private AdminAddProducts adminAddProducts1;
        private CashierCustomersForm cashierCustomersForm1;
        private CashierOrder cashierOrder1;
    }
}