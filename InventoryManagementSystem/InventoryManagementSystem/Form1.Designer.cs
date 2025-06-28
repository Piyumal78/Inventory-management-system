namespace InventoryManagementSystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            login_showPass = new CheckBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            login_btn = new Button();
            login_password = new TextBox();
            login_username = new TextBox();
            label3 = new Label();
            register_lable = new Label();
            label1 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(180, 212, 255);
            panel1.Controls.Add(login_showPass);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(login_btn);
            panel1.Controls.Add(login_password);
            panel1.Controls.Add(login_username);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(register_lable);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(74, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(640, 481);
            panel1.TabIndex = 0;
            // 
            // login_showPass
            // 
            login_showPass.AutoSize = true;
            login_showPass.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_showPass.Location = new Point(310, 333);
            login_showPass.Name = "login_showPass";
            login_showPass.Size = new Size(174, 25);
            login_showPass.TabIndex = 9;
            login_showPass.Text = "Show Password";
            login_showPass.UseVisualStyleBackColor = true;
            login_showPass.CheckedChanged += login_showPass_CheckedChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._lock;
            pictureBox3.InitialImage = null;
            pictureBox3.Location = new Point(144, 284);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(61, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(144, 217);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(61, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(238, 245, 255);
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(264, 33);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.FromArgb(64, 64, 64);
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.ForeColor = SystemColors.ButtonHighlight;
            login_btn.Location = new Point(144, 374);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(340, 37);
            login_btn.TabIndex = 5;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // login_password
            // 
            login_password.Location = new Point(224, 284);
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(260, 34);
            login_password.TabIndex = 4;
            // 
            // login_username
            // 
            login_username.Location = new Point(224, 217);
            login_username.Name = "login_username";
            login_username.Size = new Size(260, 34);
            login_username.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(118, 446);
            label3.Name = "label3";
            label3.Size = new Size(184, 20);
            label3.TabIndex = 2;
            label3.Text = "Have no account yet?";
            // 
            // register_lable
            // 
            register_lable.AutoSize = true;
            register_lable.Cursor = Cursors.Hand;
            register_lable.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_lable.ForeColor = Color.SteelBlue;
            register_lable.Location = new Point(411, 446);
            register_lable.Name = "register_lable";
            register_lable.Size = new Size(120, 20);
            register_lable.TabIndex = 1;
            register_lable.Text = "Register here";
            register_lable.Click += register_lable_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(224, 159);
            label1.Name = "label1";
            label1.Size = new Size(175, 27);
            label1.TabIndex = 0;
            label1.Text = "Login Account";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(738, 9);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(53, 45);
            button1.TabIndex = 1;
            button1.Text = "x";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(134, 182, 246);
            ClientSize = new Size(814, 568);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label3;
        private Label register_lable;
        private Label label1;
        private TextBox login_username;
        private Button login_btn;
        private TextBox login_password;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private CheckBox login_showPass;
    }
}
