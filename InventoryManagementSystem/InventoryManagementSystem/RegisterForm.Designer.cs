namespace InventoryManagementSystem
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            button1 = new Button();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            register_cPassword = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            register_btn = new Button();
            register_password = new TextBox();
            register_username = new TextBox();
            label3 = new Label();
            login_lable = new Label();
            label1 = new Label();
            register_showPass = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(752, 9);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(53, 45);
            button1.TabIndex = 3;
            button1.Text = "x";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(180, 212, 255);
            panel1.Controls.Add(register_showPass);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(register_cPassword);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(register_btn);
            panel1.Controls.Add(register_password);
            panel1.Controls.Add(register_username);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(login_lable);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(88, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(640, 481);
            panel1.TabIndex = 2;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources._lock;
            pictureBox4.InitialImage = null;
            pictureBox4.Location = new Point(144, 322);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(61, 34);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // register_cPassword
            // 
            register_cPassword.Location = new Point(224, 322);
            register_cPassword.Name = "register_cPassword";
            register_cPassword.PasswordChar = '*';
            register_cPassword.Size = new Size(260, 34);
            register_cPassword.TabIndex = 9;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._lock;
            pictureBox3.InitialImage = null;
            pictureBox3.Location = new Point(144, 268);
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
            pictureBox2.Location = new Point(144, 210);
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
            pictureBox1.Image = Properties.Resources.img1;
            pictureBox1.Location = new Point(264, 33);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // register_btn
            // 
            register_btn.BackColor = Color.FromArgb(64, 64, 64);
            register_btn.FlatStyle = FlatStyle.Flat;
            register_btn.ForeColor = SystemColors.ButtonHighlight;
            register_btn.Location = new Point(144, 393);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(340, 37);
            register_btn.TabIndex = 5;
            register_btn.Text = "Sign Up";
            register_btn.UseVisualStyleBackColor = false;
            register_btn.Click += login_btn_Click;
            // 
            // register_password
            // 
            register_password.Location = new Point(224, 268);
            register_password.Name = "register_password";
            register_password.PasswordChar = '*';
            register_password.Size = new Size(260, 34);
            register_password.TabIndex = 4;
            // 
            // register_username
            // 
            register_username.Location = new Point(224, 210);
            register_username.Name = "register_username";
            register_username.Size = new Size(260, 34);
            register_username.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(110, 444);
            label3.Name = "label3";
            label3.Size = new Size(184, 20);
            label3.TabIndex = 2;
            label3.Text = "Have no account yet?";
            // 
            // login_lable
            // 
            login_lable.AutoSize = true;
            login_lable.Cursor = Cursors.Hand;
            login_lable.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_lable.ForeColor = Color.Navy;
            login_lable.Location = new Point(415, 444);
            login_lable.Name = "login_lable";
            login_lable.Size = new Size(106, 20);
            login_lable.TabIndex = 1;
            login_lable.Text = "Sign In here";
            login_lable.Click += login_lable_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(205, 155);
            label1.Name = "label1";
            label1.Size = new Size(208, 27);
            label1.TabIndex = 0;
            label1.Text = "Register Account";
            // 
            // register_showPass
            // 
            register_showPass.AutoSize = true;
            register_showPass.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_showPass.Location = new Point(310, 362);
            register_showPass.Name = "register_showPass";
            register_showPass.Size = new Size(174, 25);
            register_showPass.TabIndex = 11;
            register_showPass.Text = "Show Password";
            register_showPass.UseVisualStyleBackColor = true;
            register_showPass.CheckedChanged += register_showPass_CheckedChanged;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(134, 182, 246);
            ClientSize = new Size(814, 568);
            Controls.Add(button1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button register_btn;
        private TextBox register_password;
        private TextBox register_username;
        private Label label3;
        private Label login_lable;
        private Label label1;
        private PictureBox pictureBox4;
        private TextBox register_cPassword;
        private CheckBox register_showPass;
    }
}