namespace InventoryManagementSystem
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            panel1 = new Panel();
            panel4 = new Panel();
            label6 = new Label();
            label7 = new Label();
            pictureBox4 = new PictureBox();
            panel5 = new Panel();
            label4 = new Label();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            label9 = new Label();
            label8 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel6 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            sqlConnection1 = new Microsoft.Data.SqlClient.SqlConnection();
            sqlDataAdapter1 = new Microsoft.Data.SqlClient.SqlDataAdapter();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(33, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 266);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.CornflowerBlue;
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(pictureBox4);
            panel4.Location = new Point(772, 32);
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
            // panel5
            // 
            panel5.BackColor = Color.CornflowerBlue;
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(pictureBox3);
            panel5.Location = new Point(530, 32);
            panel5.Name = "panel5";
            panel5.Size = new Size(227, 198);
            panel5.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(113, 156);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 6;
            label4.Text = "Today's Income";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(128, 27);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 5;
            label5.Text = "$0.00";
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
            // panel3
            // 
            panel3.BackColor = Color.CornflowerBlue;
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(282, 32);
            panel3.Name = "panel3";
            panel3.Size = new Size(227, 198);
            panel3.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(125, 152);
            label9.Name = "label9";
            label9.Size = new Size(94, 20);
            label9.TabIndex = 4;
            label9.Text = "All Customer";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(125, 28);
            label8.Name = "label8";
            label8.Size = new Size(17, 20);
            label8.TabIndex = 3;
            label8.Text = "0";
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = Properties.Resources._6;
            pictureBox2.InitialImage = Properties.Resources._6;
            pictureBox2.Location = new Point(15, 51);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(104, 102);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(30, 32);
            panel2.Name = "panel2";
            panel2.Size = new Size(227, 198);
            panel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 153);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 3;
            label3.Text = "All Users";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 28);
            label2.Name = "label2";
            label2.Size = new Size(17, 20);
            label2.TabIndex = 2;
            label2.Text = "0";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(14, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(label1);
            panel6.Controls.Add(dataGridView1);
            panel6.Location = new Point(33, 319);
            panel6.Name = "panel6";
            panel6.Size = new Size(1029, 386);
            panel6.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(282, 51);
            label1.Name = "label1";
            label1.Size = new Size(205, 28);
            label1.TabIndex = 1;
            label1.Text = "All Today's Cutmoter ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(57, 110);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(929, 268);
            dataGridView1.TabIndex = 0;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // sqlConnection1
            // 
            sqlConnection1.AccessTokenCallback = null;
            sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 709);
            Controls.Add(panel6);
            Controls.Add(panel1);
            Name = "AdminDashboard";
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Panel panel5;
        private Panel panel3;
        private Panel panel2;
        private Panel panel6;
        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox4;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox3;
        private Label label9;
        private Label label8;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Microsoft.Data.SqlClient.SqlConnection sqlConnection1;
        private Microsoft.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
    }
}