namespace InventoryManagementSystem
{
    partial class AdminAddProducts
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
            DataGridView1 = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            addProducts_clearBtn = new Button();
            addProducts_removeBtn = new Button();
            addProducts_updateBtn = new Button();
            addProducts_addBtn = new Button();
            addProducts_importBtn = new Button();
            panel3 = new Panel();
            addProducts_imageView = new PictureBox();
            addProducts_status = new ComboBox();
            label7 = new Label();
            addProducts_stock = new TextBox();
            label6 = new Label();
            addProducts_price = new TextBox();
            label5 = new Label();
            addProducts_category = new ComboBox();
            label4 = new Label();
            addProducts_prodName = new TextBox();
            label3 = new Label();
            addProducts_prodID = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addProducts_imageView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(DataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(25, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(985, 272);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // DataGridView1
            // 
            DataGridView1.AllowUserToAddRows = false;
            DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            DataGridView1.Location = new Point(17, 58);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.ReadOnly = true;
            DataGridView1.RowHeadersVisible = false;
            DataGridView1.RowHeadersWidth = 51;
            DataGridView1.Size = new Size(944, 196);
            DataGridView1.TabIndex = 3;
            DataGridView1.CellClick += DataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 13);
            label1.Name = "label1";
            label1.Size = new Size(127, 28);
            label1.TabIndex = 1;
            label1.Text = "All Products";
            // 
            // panel2
            // 
            panel2.Controls.Add(addProducts_clearBtn);
            panel2.Controls.Add(addProducts_removeBtn);
            panel2.Controls.Add(addProducts_updateBtn);
            panel2.Controls.Add(addProducts_addBtn);
            panel2.Controls.Add(addProducts_importBtn);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(addProducts_status);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(addProducts_stock);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(addProducts_price);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(addProducts_category);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(addProducts_prodName);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(addProducts_prodID);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(25, 341);
            panel2.Name = "panel2";
            panel2.Size = new Size(985, 306);
            panel2.TabIndex = 1;
            // 
            // addProducts_clearBtn
            // 
            addProducts_clearBtn.BackColor = Color.Blue;
            addProducts_clearBtn.FlatAppearance.BorderSize = 0;
            addProducts_clearBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            addProducts_clearBtn.FlatAppearance.MouseOverBackColor = Color.Blue;
            addProducts_clearBtn.FlatStyle = FlatStyle.Flat;
            addProducts_clearBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addProducts_clearBtn.ForeColor = Color.Black;
            addProducts_clearBtn.Location = new Point(592, 223);
            addProducts_clearBtn.Name = "addProducts_clearBtn";
            addProducts_clearBtn.Size = new Size(94, 29);
            addProducts_clearBtn.TabIndex = 18;
            addProducts_clearBtn.Text = "Clear";
            addProducts_clearBtn.UseVisualStyleBackColor = false;
            addProducts_clearBtn.Click += addProducts_clearBtn_Click;
            // 
            // addProducts_removeBtn
            // 
            addProducts_removeBtn.BackColor = Color.Blue;
            addProducts_removeBtn.FlatAppearance.BorderSize = 0;
            addProducts_removeBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            addProducts_removeBtn.FlatAppearance.MouseOverBackColor = Color.Blue;
            addProducts_removeBtn.FlatStyle = FlatStyle.Flat;
            addProducts_removeBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addProducts_removeBtn.ForeColor = Color.Black;
            addProducts_removeBtn.Location = new Point(456, 223);
            addProducts_removeBtn.Name = "addProducts_removeBtn";
            addProducts_removeBtn.Size = new Size(94, 29);
            addProducts_removeBtn.TabIndex = 17;
            addProducts_removeBtn.Text = "Remove";
            addProducts_removeBtn.UseVisualStyleBackColor = false;
            addProducts_removeBtn.Click += addProducts_removeBtn_Click;
            // 
            // addProducts_updateBtn
            // 
            addProducts_updateBtn.BackColor = Color.Blue;
            addProducts_updateBtn.FlatAppearance.BorderSize = 0;
            addProducts_updateBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            addProducts_updateBtn.FlatAppearance.MouseOverBackColor = Color.Blue;
            addProducts_updateBtn.FlatStyle = FlatStyle.Flat;
            addProducts_updateBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addProducts_updateBtn.ForeColor = Color.Black;
            addProducts_updateBtn.Location = new Point(293, 223);
            addProducts_updateBtn.Name = "addProducts_updateBtn";
            addProducts_updateBtn.Size = new Size(94, 29);
            addProducts_updateBtn.TabIndex = 17;
            addProducts_updateBtn.Text = "Update";
            addProducts_updateBtn.UseVisualStyleBackColor = false;
            addProducts_updateBtn.Click += addProducts_updateBtn_Click;
            // 
            // addProducts_addBtn
            // 
            addProducts_addBtn.BackColor = Color.Blue;
            addProducts_addBtn.FlatAppearance.BorderSize = 0;
            addProducts_addBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            addProducts_addBtn.FlatAppearance.MouseOverBackColor = Color.Blue;
            addProducts_addBtn.FlatStyle = FlatStyle.Flat;
            addProducts_addBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addProducts_addBtn.ForeColor = Color.Black;
            addProducts_addBtn.Location = new Point(166, 223);
            addProducts_addBtn.Name = "addProducts_addBtn";
            addProducts_addBtn.Size = new Size(94, 29);
            addProducts_addBtn.TabIndex = 16;
            addProducts_addBtn.Text = "Add";
            addProducts_addBtn.UseVisualStyleBackColor = false;
            addProducts_addBtn.Click += addProducts_addBtn_Click;
            // 
            // addProducts_importBtn
            // 
            addProducts_importBtn.BackColor = Color.Blue;
            addProducts_importBtn.FlatAppearance.BorderSize = 0;
            addProducts_importBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            addProducts_importBtn.FlatAppearance.MouseOverBackColor = Color.Blue;
            addProducts_importBtn.FlatStyle = FlatStyle.Flat;
            addProducts_importBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addProducts_importBtn.ForeColor = Color.Black;
            addProducts_importBtn.Location = new Point(840, 152);
            addProducts_importBtn.Name = "addProducts_importBtn";
            addProducts_importBtn.Size = new Size(94, 29);
            addProducts_importBtn.TabIndex = 15;
            addProducts_importBtn.Text = "Import";
            addProducts_importBtn.UseVisualStyleBackColor = false;
            addProducts_importBtn.Click += addProducts_importBtn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkGray;
            panel3.Controls.Add(addProducts_imageView);
            panel3.Location = new Point(807, 16);
            panel3.Name = "panel3";
            panel3.Size = new Size(154, 130);
            panel3.TabIndex = 14;
            // 
            // addProducts_imageView
            // 
            addProducts_imageView.Location = new Point(0, 0);
            addProducts_imageView.Name = "addProducts_imageView";
            addProducts_imageView.Size = new Size(154, 130);
            addProducts_imageView.SizeMode = PictureBoxSizeMode.StretchImage;
            addProducts_imageView.TabIndex = 0;
            addProducts_imageView.TabStop = false;
            // 
            // addProducts_status
            // 
            addProducts_status.FormattingEnabled = true;
            addProducts_status.Items.AddRange(new object[] { "Available", "Not Available" });
            addProducts_status.Location = new Point(522, 123);
            addProducts_status.Name = "addProducts_status";
            addProducts_status.Size = new Size(236, 28);
            addProducts_status.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(434, 123);
            label7.Name = "label7";
            label7.Size = new Size(60, 23);
            label7.TabIndex = 12;
            label7.Text = "Status:";
            // 
            // addProducts_stock
            // 
            addProducts_stock.Location = new Point(522, 67);
            addProducts_stock.Name = "addProducts_stock";
            addProducts_stock.Size = new Size(236, 27);
            addProducts_stock.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(434, 71);
            label6.Name = "label6";
            label6.Size = new Size(54, 23);
            label6.TabIndex = 10;
            label6.Text = "Stock:";
            // 
            // addProducts_price
            // 
            addProducts_price.Location = new Point(522, 15);
            addProducts_price.Name = "addProducts_price";
            addProducts_price.Size = new Size(236, 27);
            addProducts_price.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(434, 19);
            label5.Name = "label5";
            label5.Size = new Size(82, 23);
            label5.TabIndex = 8;
            label5.Text = "Price(Rs.):";
            // 
            // addProducts_category
            // 
            addProducts_category.FormattingEnabled = true;
            addProducts_category.Location = new Point(151, 118);
            addProducts_category.Name = "addProducts_category";
            addProducts_category.Size = new Size(236, 28);
            addProducts_category.TabIndex = 7;
            addProducts_category.SelectedIndexChanged += addProducts_category_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 123);
            label4.Name = "label4";
            label4.Size = new Size(83, 23);
            label4.TabIndex = 6;
            label4.Text = "Category:";
            label4.Click += label4_Click;
            // 
            // addProducts_prodName
            // 
            addProducts_prodName.Location = new Point(151, 67);
            addProducts_prodName.Name = "addProducts_prodName";
            addProducts_prodName.Size = new Size(236, 27);
            addProducts_prodName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 71);
            label3.Name = "label3";
            label3.Size = new Size(125, 23);
            label3.TabIndex = 4;
            label3.Text = "Product Name:";
            // 
            // addProducts_prodID
            // 
            addProducts_prodID.Location = new Point(151, 15);
            addProducts_prodID.Name = "addProducts_prodID";
            addProducts_prodID.Size = new Size(236, 27);
            addProducts_prodID.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 15);
            label2.Name = "label2";
            label2.Size = new Size(96, 23);
            label2.TabIndex = 2;
            label2.Text = "Product ID:";
            // 
            // AdminAddProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminAddProducts";
            Size = new Size(1026, 707);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)addProducts_imageView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label4;
        private TextBox addProducts_prodName;
        private Label label3;
        private TextBox addProducts_prodID;
        private Label label2;
        private Panel panel3;
        private ComboBox addProducts_status;
        private Label label7;
        private TextBox addProducts_stock;
        private Label label6;
        private TextBox addProducts_price;
        private Label label5;
        private ComboBox addProducts_category;
        private Button addProducts_importBtn;
        private PictureBox addProducts_imageView;
        private Button addProducts_clearBtn;
        private Button addProducts_removeBtn;
        private Button addProducts_updateBtn;
        private Button addProducts_addBtn;
        private DataGridView DataGridView1;
    }
}
