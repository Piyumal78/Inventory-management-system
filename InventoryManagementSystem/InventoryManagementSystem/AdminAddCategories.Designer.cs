namespace InventoryManagementSystem
{
    partial class AdminAddCategories
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
            panel1 = new Panel();
            addCategories_clearBtn = new Button();
            addCategories_removeBtn = new Button();
            addCategories_updateBtn = new Button();
            addCategories_addBtn = new Button();
            addCategories_category = new TextBox();
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
            panel1.Controls.Add(addCategories_clearBtn);
            panel1.Controls.Add(addCategories_removeBtn);
            panel1.Controls.Add(addCategories_updateBtn);
            panel1.Controls.Add(addCategories_addBtn);
            panel1.Controls.Add(addCategories_category);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(23, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(325, 653);
            panel1.TabIndex = 2;
            // 
            // addCategories_clearBtn
            // 
            addCategories_clearBtn.BackColor = Color.FromArgb(0, 0, 192);
            addCategories_clearBtn.FlatAppearance.CheckedBackColor = Color.Blue;
            addCategories_clearBtn.FlatAppearance.MouseDownBackColor = Color.Blue;
            addCategories_clearBtn.FlatAppearance.MouseOverBackColor = Color.Blue;
            addCategories_clearBtn.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addCategories_clearBtn.Location = new Point(163, 198);
            addCategories_clearBtn.Name = "addCategories_clearBtn";
            addCategories_clearBtn.Size = new Size(99, 37);
            addCategories_clearBtn.TabIndex = 11;
            addCategories_clearBtn.Text = "Clear";
            addCategories_clearBtn.UseVisualStyleBackColor = false;
            addCategories_clearBtn.Click += addCategories_clearBtn_Click;
            // 
            // addCategories_removeBtn
            // 
            addCategories_removeBtn.BackColor = Color.FromArgb(0, 0, 192);
            addCategories_removeBtn.FlatAppearance.CheckedBackColor = Color.Blue;
            addCategories_removeBtn.FlatAppearance.MouseDownBackColor = Color.Blue;
            addCategories_removeBtn.FlatAppearance.MouseOverBackColor = Color.Blue;
            addCategories_removeBtn.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addCategories_removeBtn.Location = new Point(40, 198);
            addCategories_removeBtn.Name = "addCategories_removeBtn";
            addCategories_removeBtn.Size = new Size(99, 37);
            addCategories_removeBtn.TabIndex = 10;
            addCategories_removeBtn.Text = "Remove";
            addCategories_removeBtn.UseVisualStyleBackColor = false;
            addCategories_removeBtn.Click += addCategories_removeBtn_Click;
            // 
            // addCategories_updateBtn
            // 
            addCategories_updateBtn.BackColor = Color.FromArgb(0, 0, 192);
            addCategories_updateBtn.FlatAppearance.CheckedBackColor = Color.Blue;
            addCategories_updateBtn.FlatAppearance.MouseDownBackColor = Color.Blue;
            addCategories_updateBtn.FlatAppearance.MouseOverBackColor = Color.Blue;
            addCategories_updateBtn.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addCategories_updateBtn.Location = new Point(163, 140);
            addCategories_updateBtn.Name = "addCategories_updateBtn";
            addCategories_updateBtn.Size = new Size(99, 37);
            addCategories_updateBtn.TabIndex = 9;
            addCategories_updateBtn.Text = "Update";
            addCategories_updateBtn.UseVisualStyleBackColor = false;
            addCategories_updateBtn.Click += addCategories_updateBtn_Click;
            // 
            // addCategories_addBtn
            // 
            addCategories_addBtn.BackColor = Color.FromArgb(0, 0, 192);
            addCategories_addBtn.FlatAppearance.CheckedBackColor = Color.Blue;
            addCategories_addBtn.FlatAppearance.MouseDownBackColor = Color.Blue;
            addCategories_addBtn.FlatAppearance.MouseOverBackColor = Color.Blue;
            addCategories_addBtn.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addCategories_addBtn.Location = new Point(40, 140);
            addCategories_addBtn.Name = "addCategories_addBtn";
            addCategories_addBtn.Size = new Size(99, 37);
            addCategories_addBtn.TabIndex = 8;
            addCategories_addBtn.Text = "Add";
            addCategories_addBtn.UseVisualStyleBackColor = false;
            addCategories_addBtn.Click += addCategories_addBtn_Click;
            // 
            // addCategories_category
            // 
            addCategories_category.Location = new Point(28, 75);
            addCategories_category.Name = "addCategories_category";
            addCategories_category.Size = new Size(269, 27);
            addCategories_category.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 49);
            label1.Name = "label1";
            label1.Size = new Size(89, 23);
            label1.TabIndex = 0;
            label1.Text = "Cetagory";
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            label5.Location = new Point(27, 34);
            label5.Name = "label5";
            label5.Size = new Size(126, 22);
            label5.TabIndex = 1;
            label5.Text = "All Categories";
            // 
            // AdminAddCategories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "AdminAddCategories";
            Size = new Size(1026, 707);
            Load += AdminAddCategories_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button addCategories_clearBtn;
        private Button addCategories_removeBtn;
        private Button addCategories_updateBtn;
        private Button addCategories_addBtn;
        private TextBox addCategories_category;
        private Label label1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label5;
    }
}
