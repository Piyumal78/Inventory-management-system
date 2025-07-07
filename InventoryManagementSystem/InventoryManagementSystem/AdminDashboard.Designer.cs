namespace InventoryManagementSystem
{
    partial class AdminDashborad
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashborad));
            panel4 = new Panel();
            label6 = new Label();
            dashboard_totalIncome = new Label();
            pictureBox4 = new PictureBox();
            panel6 = new Panel();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            dashboard_AU = new Label();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            label4 = new Label();
            dashboard_TI = new Label();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            label9 = new Label();
            dashboard_AC = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.CornflowerBlue;
            panel4.Controls.Add(label6);
            panel4.Controls.Add(dashboard_totalIncome);
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
            // dashboard_totalIncome
            // 
            dashboard_totalIncome.AutoSize = true;
            dashboard_totalIncome.Location = new Point(144, 27);
            dashboard_totalIncome.Name = "dashboard_totalIncome";
            dashboard_totalIncome.Size = new Size(44, 20);
            dashboard_totalIncome.TabIndex = 5;
            dashboard_totalIncome.Text = "$0.00";
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
            panel6.Controls.Add(dataGridView2);
            panel6.Controls.Add(label1);
            panel6.Location = new Point(7, 295);
            panel6.Name = "panel6";
            panel6.Size = new Size(1002, 389);
            panel6.TabIndex = 6;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(15, 136);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(967, 585);
            dataGridView2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(326, 29);
            label1.Name = "label1";
            label1.Size = new Size(216, 28);
            label1.TabIndex = 1;
            label1.Text = "All Today's Customers ";
            // 
            // dashboard_AU
            // 
            dashboard_AU.AutoSize = true;
            dashboard_AU.Location = new Point(126, 28);
            dashboard_AU.Name = "dashboard_AU";
            dashboard_AU.Size = new Size(17, 20);
            dashboard_AU.TabIndex = 2;
            dashboard_AU.Text = "0";
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
            // panel5
            // 
            panel5.BackColor = Color.CornflowerBlue;
            panel5.Controls.Add(label4);
            panel5.Controls.Add(dashboard_TI);
            panel5.Controls.Add(pictureBox3);
            panel5.Location = new Point(508, 32);
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
            // dashboard_TI
            // 
            dashboard_TI.AutoSize = true;
            dashboard_TI.Location = new Point(128, 27);
            dashboard_TI.Name = "dashboard_TI";
            dashboard_TI.Size = new Size(44, 20);
            dashboard_TI.TabIndex = 5;
            dashboard_TI.Text = "$0.00";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 153);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 3;
            label3.Text = "All Users";
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
            // dashboard_AC
            // 
            dashboard_AC.AutoSize = true;
            dashboard_AC.Location = new Point(125, 28);
            dashboard_AC.Name = "dashboard_AC";
            dashboard_AC.Size = new Size(17, 20);
            dashboard_AC.TabIndex = 3;
            dashboard_AC.Text = "0";
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
            // panel3
            // 
            panel3.BackColor = Color.CornflowerBlue;
            panel3.Controls.Add(label9);
            panel3.Controls.Add(dashboard_AC);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(263, 32);
            panel3.Name = "panel3";
            panel3.Size = new Size(227, 198);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(dashboard_AU);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(15, 32);
            panel2.Name = "panel2";
            panel2.Size = new Size(227, 198);
            panel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(7, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(1012, 266);
            panel1.TabIndex = 5;
            // 
            // AdminDashborad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel6);
            Controls.Add(panel1);
            Name = "AdminDashborad";
            Size = new Size(1026, 707);
            Load += AdminDashborad_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel4;
        private Label label6;
        private Label dashboard_totalIncome;
        private PictureBox pictureBox4;
        private Panel panel6;
        private Label label1;
        private Label dashboard_AU;
        private PictureBox pictureBox1;
        private Panel panel5;
        private Label label4;
        private Label dashboard_TI;
        private PictureBox pictureBox3;
        private Label label3;
        private Label label9;
        private Label dashboard_AC;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private DataGridView dataGridView2;
    }
}
