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
            dataGridView1 = new DataGridView();
            panel4 = new Panel();
            label6 = new Label();
            label7 = new Label();
            pictureBox4 = new PictureBox();
            panel6 = new Panel();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            panel5 = new Panel();
            label5 = new Label();
            label8 = new Label();
            pictureBox3 = new PictureBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            pictureBox5 = new PictureBox();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
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
            panel1.Size = new Size(1309, 88);
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
            panel2.Location = new Point(0, 88);
            panel2.Name = "panel2";
            panel2.Size = new Size(283, 707);
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
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel9);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(283, 88);
            panel3.Name = "panel3";
            panel3.Size = new Size(1026, 707);
            panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(929, 268);
            dataGridView1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.CornflowerBlue;
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(pictureBox4);
            panel4.Location = new Point(755, 32);
            panel4.Name = "panel4";
            panel4.Size = new Size(227, 198);
            panel4.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(129, 156);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 6;
            label6.Text = "Total Income";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(144, 27);
            label7.Name = "label7";
            label7.Size = new Size(44, 20);
            label7.TabIndex = 5;
            label7.Text = "$0.00";
            // 
            // pictureBox4
            // 
            pictureBox4.ErrorImage = (Image)resources.GetObject("pictureBox4.ErrorImage");
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.InitialImage = (Image)resources.GetObject("pictureBox4.InitialImage");
            pictureBox4.Location = new Point(21, 51);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(104, 102);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(dataGridView1);
            panel6.Location = new Point(7, 295);
            panel6.Name = "panel6";
            panel6.Size = new Size(1012, 389);
            panel6.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(126, 28);
            label4.Name = "label4";
            label4.Size = new Size(17, 20);
            label4.TabIndex = 2;
            label4.Text = "0";
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = (Image)resources.GetObject("pictureBox2.ErrorImage");
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(14, 52);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(104, 102);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.CornflowerBlue;
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(pictureBox3);
            panel5.Location = new Point(508, 32);
            panel5.Name = "panel5";
            panel5.Size = new Size(227, 198);
            panel5.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(113, 156);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 6;
            label5.Text = "Today's Income";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(128, 27);
            label8.Name = "label8";
            label8.Size = new Size(44, 20);
            label8.TabIndex = 5;
            label8.Text = "$0.00";
            // 
            // pictureBox3
            // 
            pictureBox3.ErrorImage = (Image)resources.GetObject("pictureBox3.ErrorImage");
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.InitialImage = (Image)resources.GetObject("pictureBox3.InitialImage");
            pictureBox3.Location = new Point(16, 51);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(104, 102);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(126, 153);
            label9.Name = "label9";
            label9.Size = new Size(66, 20);
            label9.TabIndex = 3;
            label9.Text = "All Users";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(125, 152);
            label10.Name = "label10";
            label10.Size = new Size(94, 20);
            label10.TabIndex = 4;
            label10.Text = "All Customer";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(125, 28);
            label11.Name = "label11";
            label11.Size = new Size(17, 20);
            label11.TabIndex = 3;
            label11.Text = "0";
            // 
            // pictureBox5
            // 
            pictureBox5.ErrorImage = null;
            pictureBox5.Image = Properties.Resources._6;
            pictureBox5.InitialImage = Properties.Resources._6;
            pictureBox5.Location = new Point(15, 51);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(104, 102);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.CornflowerBlue;
            panel7.Controls.Add(label10);
            panel7.Controls.Add(label11);
            panel7.Controls.Add(pictureBox5);
            panel7.Location = new Point(263, 32);
            panel7.Name = "panel7";
            panel7.Size = new Size(227, 198);
            panel7.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.BackColor = Color.CornflowerBlue;
            panel8.Controls.Add(label9);
            panel8.Controls.Add(label4);
            panel8.Controls.Add(pictureBox2);
            panel8.Location = new Point(15, 32);
            panel8.Name = "panel8";
            panel8.Size = new Size(227, 198);
            panel8.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Controls.Add(panel4);
            panel9.Controls.Add(panel5);
            panel9.Controls.Add(panel7);
            panel9.Controls.Add(panel8);
            panel9.Location = new Point(7, 23);
            panel9.Name = "panel9";
            panel9.Size = new Size(1012, 266);
            panel9.TabIndex = 5;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
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
        private Panel panel6;
        private DataGridView dataGridView1;
        private Panel panel9;
        private Panel panel4;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox4;
        private Panel panel5;
        private Label label5;
        private Label label8;
        private PictureBox pictureBox3;
        private Panel panel7;
        private Label label10;
        private Label label11;
        private PictureBox pictureBox5;
        private Panel panel8;
        private Label label9;
        private Label label4;
        private PictureBox pictureBox2;
    }
}