namespace InventoryManagementSystem
{
    partial class AdminAddUser
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            addUsers_clearBtn = new Button();
            addUsers_removeBtn = new Button();
            addUsers_updateBtn = new Button();
            addUsers_addBtn = new Button();
            addUsers_status = new ComboBox();
            label4 = new Label();
            addUsers_role = new ComboBox();
            label3 = new Label();
            addUsers_password = new TextBox();
            label2 = new Label();
            addUsers_username = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(addUsers_clearBtn);
            panel1.Controls.Add(addUsers_removeBtn);
            panel1.Controls.Add(addUsers_updateBtn);
            panel1.Controls.Add(addUsers_addBtn);
            panel1.Controls.Add(addUsers_status);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(addUsers_role);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(addUsers_password);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(addUsers_username);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(23, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(325, 653);
            panel1.TabIndex = 2;
            // 
            // addUsers_clearBtn
            // 
            addUsers_clearBtn.BackColor = Color.FromArgb(0, 0, 192);
            addUsers_clearBtn.FlatAppearance.CheckedBackColor = Color.Blue;
            addUsers_clearBtn.FlatAppearance.MouseDownBackColor = Color.Blue;
            addUsers_clearBtn.FlatAppearance.MouseOverBackColor = Color.Blue;
            addUsers_clearBtn.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addUsers_clearBtn.Location = new Point(151, 399);
            addUsers_clearBtn.Name = "addUsers_clearBtn";
            addUsers_clearBtn.Size = new Size(99, 37);
            addUsers_clearBtn.TabIndex = 11;
            addUsers_clearBtn.Text = "Clear";
            addUsers_clearBtn.UseVisualStyleBackColor = false;
            // 
            // addUsers_removeBtn
            // 
            addUsers_removeBtn.BackColor = Color.FromArgb(0, 0, 192);
            addUsers_removeBtn.FlatAppearance.CheckedBackColor = Color.Blue;
            addUsers_removeBtn.FlatAppearance.MouseDownBackColor = Color.Blue;
            addUsers_removeBtn.FlatAppearance.MouseOverBackColor = Color.Blue;
            addUsers_removeBtn.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addUsers_removeBtn.Location = new Point(28, 399);
            addUsers_removeBtn.Name = "addUsers_removeBtn";
            addUsers_removeBtn.Size = new Size(99, 37);
            addUsers_removeBtn.TabIndex = 10;
            addUsers_removeBtn.Text = "Remove";
            addUsers_removeBtn.UseVisualStyleBackColor = false;
            // 
            // addUsers_updateBtn
            // 
            addUsers_updateBtn.BackColor = Color.FromArgb(0, 0, 192);
            addUsers_updateBtn.FlatAppearance.CheckedBackColor = Color.Blue;
            addUsers_updateBtn.FlatAppearance.MouseDownBackColor = Color.Blue;
            addUsers_updateBtn.FlatAppearance.MouseOverBackColor = Color.Blue;
            addUsers_updateBtn.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addUsers_updateBtn.Location = new Point(151, 341);
            addUsers_updateBtn.Name = "addUsers_updateBtn";
            addUsers_updateBtn.Size = new Size(99, 37);
            addUsers_updateBtn.TabIndex = 9;
            addUsers_updateBtn.Text = "Update";
            addUsers_updateBtn.UseVisualStyleBackColor = false;
            addUsers_updateBtn.Click += addUsers_updateBtn_Click;
            // 
            // addUsers_addBtn
            // 
            addUsers_addBtn.BackColor = Color.FromArgb(0, 0, 192);
            addUsers_addBtn.FlatAppearance.CheckedBackColor = Color.Blue;
            addUsers_addBtn.FlatAppearance.MouseDownBackColor = Color.Blue;
            addUsers_addBtn.FlatAppearance.MouseOverBackColor = Color.Blue;
            addUsers_addBtn.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addUsers_addBtn.Location = new Point(28, 341);
            addUsers_addBtn.Name = "addUsers_addBtn";
            addUsers_addBtn.Size = new Size(99, 37);
            addUsers_addBtn.TabIndex = 8;
            addUsers_addBtn.Text = "Add";
            addUsers_addBtn.UseVisualStyleBackColor = false;
            addUsers_addBtn.Click += addUsers_addBtn_Click;
            // 
            // addUsers_status
            // 
            addUsers_status.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addUsers_status.FormattingEnabled = true;
            addUsers_status.Items.AddRange(new object[] { "Active", "InActive", "Approval" });
            addUsers_status.Location = new Point(28, 295);
            addUsers_status.Name = "addUsers_status";
            addUsers_status.Size = new Size(269, 31);
            addUsers_status.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(28, 269);
            label4.Name = "label4";
            label4.Size = new Size(63, 23);
            label4.TabIndex = 6;
            label4.Text = "Status";
            // 
            // addUsers_role
            // 
            addUsers_role.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addUsers_role.FormattingEnabled = true;
            addUsers_role.Items.AddRange(new object[] { "Admin", "Cashier" });
            addUsers_role.Location = new Point(28, 222);
            addUsers_role.Name = "addUsers_role";
            addUsers_role.Size = new Size(269, 31);
            addUsers_role.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(28, 196);
            label3.Name = "label3";
            label3.Size = new Size(49, 23);
            label3.TabIndex = 4;
            label3.Text = "Role";
            // 
            // addUsers_password
            // 
            addUsers_password.Location = new Point(28, 142);
            addUsers_password.Name = "addUsers_password";
            addUsers_password.Size = new Size(269, 27);
            addUsers_password.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 116);
            label2.Name = "label2";
            label2.Size = new Size(90, 23);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // addUsers_username
            // 
            addUsers_username.Location = new Point(28, 75);
            addUsers_username.Name = "addUsers_username";
            addUsers_username.Size = new Size(269, 27);
            addUsers_username.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 49);
            label1.Name = "label1";
            label1.Size = new Size(99, 23);
            label1.TabIndex = 0;
            label1.Text = "UserName";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(368, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(635, 653);
            panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(27, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(605, 560);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(27, 34);
            label5.Name = "label5";
            label5.Size = new Size(132, 22);
            label5.TabIndex = 1;
            label5.Text = "All User's Data";
            // 
            // AdminAddUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "AdminAddUser";
            Size = new Size(1026, 707);
            Load += AdminAddUser_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button addUsers_clearBtn;
        private Button addUsers_removeBtn;
        private Button addUsers_updateBtn;
        private Button addUsers_addBtn;
        private ComboBox addUsers_status;
        private Label label4;
        private ComboBox addUsers_role;
        private Label label3;
        private TextBox addUsers_password;
        private Label label2;
        private TextBox addUsers_username;
        private Label label1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label5;
    }
}
