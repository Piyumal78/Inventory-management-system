namespace InventoryManagementSystem
{
    partial class CashierOrder
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
            panel1 = new Panel();
            label5 = new Label();
            cashierOrder_clearBtn = new Button();
            cashierOrder_removeBtn = new Button();
            cashierOrder_addBtn = new Button();
            cashierOrder_qty = new NumericUpDown();
            cashierOrder_prodID = new ComboBox();
            label3 = new Label();
            cashierOrder_category = new ComboBox();
            cashierOrder_price = new Label();
            label6 = new Label();
            label8 = new Label();
            cashierOrder_prodName = new Label();
            label4 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            panel3 = new Panel();
            label14 = new Label();
            cashierOrder_receipt = new Button();
            cashierOrder_payOrders = new Button();
            cashierOrder_amount = new TextBox();
            dataGridView1 = new DataGridView();
            label13 = new Label();
            label9 = new Label();
            cashierOrder_change = new Label();
            cashierOrder_totalPrice = new Label();
            label11 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cashierOrder_qty).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cashierOrder_clearBtn);
            panel1.Controls.Add(cashierOrder_removeBtn);
            panel1.Controls.Add(cashierOrder_addBtn);
            panel1.Controls.Add(cashierOrder_qty);
            panel1.Controls.Add(cashierOrder_prodID);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cashierOrder_category);
            panel1.Controls.Add(cashierOrder_price);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(cashierOrder_prodName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(3, 388);
            panel1.Name = "panel1";
            panel1.Size = new Size(675, 345);
            panel1.TabIndex = 0;
<<<<<<< Updated upstream
            panel1.Paint += panel1_Paint;
=======
>>>>>>> Stashed changes
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(5, 10);
            label5.Name = "label5";
            label5.Size = new Size(220, 27);
            label5.TabIndex = 1;
            label5.Text = "Select Your Orders";
            // 
            // cashierOrder_clearBtn
            // 
            cashierOrder_clearBtn.BackColor = Color.FromArgb(0, 0, 192);
            cashierOrder_clearBtn.FlatAppearance.CheckedBackColor = Color.Blue;
            cashierOrder_clearBtn.FlatAppearance.MouseDownBackColor = Color.Blue;
            cashierOrder_clearBtn.FlatAppearance.MouseOverBackColor = Color.Blue;
            cashierOrder_clearBtn.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashierOrder_clearBtn.Location = new Point(428, 249);
            cashierOrder_clearBtn.Name = "cashierOrder_clearBtn";
            cashierOrder_clearBtn.Size = new Size(126, 51);
            cashierOrder_clearBtn.TabIndex = 11;
            cashierOrder_clearBtn.Text = " Clear";
            cashierOrder_clearBtn.UseVisualStyleBackColor = false;
            // 
            // cashierOrder_removeBtn
            // 
            cashierOrder_removeBtn.BackColor = Color.FromArgb(0, 0, 192);
            cashierOrder_removeBtn.FlatAppearance.CheckedBackColor = Color.Blue;
            cashierOrder_removeBtn.FlatAppearance.MouseDownBackColor = Color.Blue;
            cashierOrder_removeBtn.FlatAppearance.MouseOverBackColor = Color.Blue;
            cashierOrder_removeBtn.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashierOrder_removeBtn.Location = new Point(233, 249);
            cashierOrder_removeBtn.Name = "cashierOrder_removeBtn";
            cashierOrder_removeBtn.Size = new Size(122, 51);
            cashierOrder_removeBtn.TabIndex = 10;
            cashierOrder_removeBtn.Text = "Remove";
            cashierOrder_removeBtn.UseVisualStyleBackColor = false;
            cashierOrder_removeBtn.Click += cashierOrder_removeBtn_Click_1;
            // 
            // cashierOrder_addBtn
            // 
            cashierOrder_addBtn.BackColor = Color.FromArgb(0, 0, 192);
            cashierOrder_addBtn.FlatAppearance.CheckedBackColor = Color.Blue;
            cashierOrder_addBtn.FlatAppearance.MouseDownBackColor = Color.Blue;
            cashierOrder_addBtn.FlatAppearance.MouseOverBackColor = Color.Blue;
            cashierOrder_addBtn.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashierOrder_addBtn.Location = new Point(34, 249);
            cashierOrder_addBtn.Name = "cashierOrder_addBtn";
            cashierOrder_addBtn.Size = new Size(134, 51);
            cashierOrder_addBtn.TabIndex = 9;
            cashierOrder_addBtn.Text = "Add";
            cashierOrder_addBtn.UseVisualStyleBackColor = false;
            cashierOrder_addBtn.Click += cashierOrder_addBtn_Click;
            // 
            // cashierOrder_qty
            // 
            cashierOrder_qty.Location = new Point(457, 134);
            cashierOrder_qty.Name = "cashierOrder_qty";
            cashierOrder_qty.Size = new Size(185, 27);
            cashierOrder_qty.TabIndex = 3;
            // 
            // cashierOrder_prodID
            // 
            cashierOrder_prodID.FormattingEnabled = true;
            cashierOrder_prodID.Location = new Point(459, 50);
            cashierOrder_prodID.Name = "cashierOrder_prodID";
            cashierOrder_prodID.Size = new Size(185, 28);
            cashierOrder_prodID.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.Location = new Point(350, 53);
            label3.Name = "label3";
            label3.Size = new Size(113, 25);
            label3.TabIndex = 1;
            label3.Text = "Product ID";
            // 
            // cashierOrder_category
            // 
            cashierOrder_category.FormattingEnabled = true;
            cashierOrder_category.Location = new Point(122, 56);
            cashierOrder_category.Name = "cashierOrder_category";
            cashierOrder_category.Size = new Size(180, 28);
            cashierOrder_category.TabIndex = 2;
            cashierOrder_category.SelectedIndexChanged += cashierOrder_category_SelectedIndexChanged;
            // 
            // cashierOrder_price
            // 
            cashierOrder_price.AutoSize = true;
            cashierOrder_price.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            cashierOrder_price.Location = new Point(204, 213);
            cashierOrder_price.Name = "cashierOrder_price";
            cashierOrder_price.Size = new Size(107, 25);
            cashierOrder_price.TabIndex = 1;
            cashierOrder_price.Text = "Category:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label6.Location = new Point(51, 213);
            label6.Name = "label6";
            label6.Size = new Size(103, 25);
            label6.TabIndex = 1;
<<<<<<< Updated upstream
            label6.Text = "Proce($):";
=======
            label6.Text = "Price($):";
>>>>>>> Stashed changes
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label8.Location = new Point(360, 134);
            label8.Name = "label8";
            label8.Size = new Size(100, 25);
            label8.TabIndex = 1;
            label8.Text = "Quantity:";
            // 
            // cashierOrder_prodName
            // 
            cashierOrder_prodName.AutoSize = true;
            cashierOrder_prodName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            cashierOrder_prodName.Location = new Point(164, 136);
            cashierOrder_prodName.Name = "cashierOrder_prodName";
            cashierOrder_prodName.Size = new Size(107, 25);
            cashierOrder_prodName.TabIndex = 1;
            cashierOrder_prodName.Text = "Category:";
<<<<<<< Updated upstream
            cashierOrder_prodName.Click += cashierOrder_prodName_Click;
=======
>>>>>>> Stashed changes
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label4.Location = new Point(5, 134);
            label4.Name = "label4";
            label4.Size = new Size(155, 25);
            label4.TabIndex = 1;
            label4.Text = "Product Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.Location = new Point(3, 57);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 1;
            label2.Text = "Category:";
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dataGridView2);
            panel2.Location = new Point(3, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(665, 341);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 17);
            label1.Name = "label1";
            label1.Size = new Size(222, 27);
            label1.TabIndex = 1;
            label1.Text = "Avaliable Products";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(3, 63);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(672, 282);
            dataGridView2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label14);
            panel3.Controls.Add(cashierOrder_receipt);
            panel3.Controls.Add(cashierOrder_payOrders);
            panel3.Controls.Add(cashierOrder_amount);
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(cashierOrder_change);
            panel3.Controls.Add(cashierOrder_totalPrice);
            panel3.Controls.Add(label11);
            panel3.Location = new Point(684, 19);
            panel3.Name = "panel3";
            panel3.Size = new Size(363, 703);
            panel3.TabIndex = 0;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(22, 20);
            label14.Name = "label14";
            label14.Size = new Size(125, 27);
            label14.TabIndex = 2;
            label14.Text = "All Orders";
            // 
            // cashierOrder_receipt
            // 
            cashierOrder_receipt.BackColor = Color.FromArgb(0, 0, 192);
            cashierOrder_receipt.FlatAppearance.CheckedBackColor = Color.Blue;
            cashierOrder_receipt.FlatAppearance.MouseDownBackColor = Color.Blue;
            cashierOrder_receipt.FlatAppearance.MouseOverBackColor = Color.Blue;
            cashierOrder_receipt.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashierOrder_receipt.Location = new Point(22, 632);
            cashierOrder_receipt.Name = "cashierOrder_receipt";
            cashierOrder_receipt.Size = new Size(277, 51);
            cashierOrder_receipt.TabIndex = 11;
            cashierOrder_receipt.Text = "Receipt";
            cashierOrder_receipt.UseVisualStyleBackColor = false;
<<<<<<< Updated upstream
=======
            cashierOrder_receipt.Click += cashierOrder_receipt_Click;
>>>>>>> Stashed changes
            // 
            // cashierOrder_payOrders
            // 
            cashierOrder_payOrders.BackColor = Color.FromArgb(0, 0, 192);
            cashierOrder_payOrders.FlatAppearance.CheckedBackColor = Color.Blue;
            cashierOrder_payOrders.FlatAppearance.MouseDownBackColor = Color.Blue;
            cashierOrder_payOrders.FlatAppearance.MouseOverBackColor = Color.Blue;
            cashierOrder_payOrders.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashierOrder_payOrders.ForeColor = SystemColors.ButtonHighlight;
            cashierOrder_payOrders.Location = new Point(22, 578);
            cashierOrder_payOrders.Name = "cashierOrder_payOrders";
            cashierOrder_payOrders.Size = new Size(277, 48);
            cashierOrder_payOrders.TabIndex = 10;
            cashierOrder_payOrders.Text = "Pay Orders";
            cashierOrder_payOrders.UseVisualStyleBackColor = false;
            // 
            // cashierOrder_amount
            // 
            cashierOrder_amount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashierOrder_amount.Location = new Point(153, 462);
            cashierOrder_amount.Name = "cashierOrder_amount";
            cashierOrder_amount.Size = new Size(178, 34);
            cashierOrder_amount.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(333, 274);
            dataGridView1.TabIndex = 0;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label13.Location = new Point(59, 536);
            label13.Name = "label13";
            label13.Size = new Size(95, 25);
            label13.TabIndex = 1;
            label13.Text = "Change:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label9.Location = new Point(11, 382);
            label9.Name = "label9";
            label9.Size = new Size(151, 25);
            label9.TabIndex = 1;
            label9.Text = "Total Price($):";
<<<<<<< Updated upstream
            label9.Click += label9_Click;
=======
>>>>>>> Stashed changes
            // 
            // cashierOrder_change
            // 
            cashierOrder_change.AutoSize = true;
            cashierOrder_change.Font = new Font("Arial", 12F);
            cashierOrder_change.Location = new Point(181, 538);
            cashierOrder_change.Name = "cashierOrder_change";
            cashierOrder_change.Size = new Size(49, 23);
            cashierOrder_change.TabIndex = 1;
            cashierOrder_change.Text = "0.00";
            // 
            // cashierOrder_totalPrice
            // 
            cashierOrder_totalPrice.AutoSize = true;
            cashierOrder_totalPrice.Font = new Font("Arial", 12F);
            cashierOrder_totalPrice.Location = new Point(181, 382);
            cashierOrder_totalPrice.Name = "cashierOrder_totalPrice";
            cashierOrder_totalPrice.Size = new Size(49, 23);
            cashierOrder_totalPrice.TabIndex = 1;
            cashierOrder_totalPrice.Text = "0.00";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label11.Location = new Point(36, 468);
            label11.Name = "label11";
            label11.Size = new Size(121, 25);
            label11.TabIndex = 1;
            label11.Text = "Amount($):";
            // 
            // CashierOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "CashierOrder";
            Size = new Size(1026, 707);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cashierOrder_qty).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Panel panel3;
        private Label label1;
        private DataGridView dataGridView2;
        private Label label2;
        private ComboBox cashierOrder_prodID;
        private Label label3;
        private ComboBox cashierOrder_category;
        private Label cashierOrder_price;
        private Label label6;
        private Label label8;
        private Label cashierOrder_prodName;
        private Label label4;
        private NumericUpDown cashierOrder_qty;
        private Button cashierOrder_clearBtn;
        private Button cashierOrder_removeBtn;
        private Button cashierOrder_addBtn;
        private TextBox cashierOrder_amount;
        private Label label13;
        private Label label9;
        private Label cashierOrder_change;
        private Label cashierOrder_totalPrice;
        private Label label11;
        private Label label14;
        private Button cashierOrder_receipt;
        private Button cashierOrder_payOrders;
        private Label label5;
    }
}
