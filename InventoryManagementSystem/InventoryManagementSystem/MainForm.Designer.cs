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
            logoutbtn = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button5 = new Button();
            button7 = new Button();
            button8 = new Button();
            button6 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            adminAddCategories1 = new AdminAddCategories();
            adminAddUser2 = new AdminAddUser();
            adminAddUser1 = new AdminAddUser();
            adminDashborad1 = new AdminDashborad();
            adminAddProducts1 = new AdminAddProducts();
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
            panel2.Controls.Add(logoutbtn);
            panel2.Controls.Add(button10);
            panel2.Controls.Add(button11);
            panel2.Controls.Add(button12);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(283, 709);
            panel2.TabIndex = 1;
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
            // button11
            // 
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatAppearance.MouseDownBackColor = Color.Blue;
            button11.FlatAppearance.MouseOverBackColor = Color.Blue;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            button11.ForeColor = Color.Blue;
            button11.Location = new Point(12, 412);
            button11.Name = "button11";
            button11.Size = new Size(248, 55);
            button11.TabIndex = 16;
            button11.Text = "Customers";
            button11.UseVisualStyleBackColor = true;
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
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.Blue;
            button5.FlatAppearance.MouseOverBackColor = Color.Blue;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            button5.ForeColor = Color.Blue;
            button5.Location = new Point(12, 353);
            button5.Name = "button5";
            button5.Size = new Size(248, 55);
            button5.TabIndex = 14;
            button5.Text = "Add Product";
            button5.UseVisualStyleBackColor = true;
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
            // button8
            // 
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatAppearance.MouseDownBackColor = Color.Blue;
            button8.FlatAppearance.MouseOverBackColor = Color.Blue;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            button8.ForeColor = Color.Blue;
            button8.Location = new Point(12, 292);
            button8.Name = "button8";
            button8.Size = new Size(248, 55);
            button8.TabIndex = 12;
            button8.Text = "Add Categories";
            button8.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseDownBackColor = Color.Blue;
            button6.FlatAppearance.MouseOverBackColor = Color.Blue;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            button6.ForeColor = Color.Blue;
            button6.Location = new Point(12, 231);
            button6.Name = "button6";
            button6.Size = new Size(248, 55);
            button6.TabIndex = 11;
            button6.Text = "Add Users";
            button6.UseVisualStyleBackColor = true;
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
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Blue;
            button2.FlatAppearance.MouseOverBackColor = Color.Blue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            button2.ForeColor = Color.Blue;
            button2.Location = new Point(12, 179);
            button2.Name = "button2";
            button2.Size = new Size(248, 55);
            button2.TabIndex = 2;
            button2.Text = "Dashboard";
            button2.UseVisualStyleBackColor = true;
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
            panel3.Controls.Add(adminAddProducts1);
            panel3.Controls.Add(adminAddCategories1);
            panel3.Controls.Add(adminAddUser2);
            panel3.Controls.Add(adminAddUser1);
            panel3.Controls.Add(adminDashborad1);
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
            adminAddCategories1.TabIndex = 3;
            // 
            // adminAddUser2
            // 
            adminAddUser2.Location = new Point(258, 231);
            adminAddUser2.Name = "adminAddUser2";
            adminAddUser2.Size = new Size(1282, 884);
            adminAddUser2.TabIndex = 2;
            // 
            // adminAddUser1
            // 
            adminAddUser1.Location = new Point(0, -4);
            adminAddUser1.Name = "adminAddUser1";
            adminAddUser1.Size = new Size(1036, 713);
            adminAddUser1.TabIndex = 1;
            adminAddUser1.Load += adminAddUser1_Load_1;
            // 
            // adminDashborad1
            // 
            adminDashborad1.Location = new Point(0, 0);
            adminDashborad1.Name = "adminDashborad1";
            adminDashborad1.Size = new Size(1023, 701);
            adminDashborad1.TabIndex = 0;
            // 
            // adminAddProducts1
            // 
            adminAddProducts1.Location = new Point(0, 0);
            adminAddProducts1.Name = "adminAddProducts1";
            adminAddProducts1.Size = new Size(1282, 884);
            adminAddProducts1.TabIndex = 4;
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
        private Button button2;
        private Button button5;
        private Button button7;
        private Button button8;
        private Button button6;
        private Button button4;
        private Button button3;
        private Button logoutbtn;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button close;
        private Panel panel3;
        private AdminDashborad adminDashborad1;
        private AdminAddUser adminAddUser2;
        private AdminAddUser adminAddUser1;
        private AdminAddCategories adminAddCategories1;
        private AdminAddProducts adminAddProducts1;
    }
}