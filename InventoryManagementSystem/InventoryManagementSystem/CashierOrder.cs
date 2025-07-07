using System.Data;
using System.Data.SqlClient;

namespace InventoryManagementSystem
{
    public partial class CashierOrder : UserControl
    {
<<<<<<< Updated upstream
        SqlConnection
        connect = new SqlConnection(@"Data Source=PIYUMAL\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;Encrypt=False");
        public CashierOrder()
        {
            InitializeComponent();
            displayAllAvaliableProducts();
            displayAllCategories();
=======
        SqlConnection connect = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Inventory;Integrated Security=True;Encrypt=False");
        private int idGen;
        private int prodID = 0;
        private float unitPrice = 0;
        private float totalPrice = 0;
        private int rowIndex = 0;

        public CashierOrder()
        {
            InitializeComponent();
            cashierOrder_category.SelectedIndexChanged += cashierOrder_category_SelectedIndexChanged;
            cashierOrder_prodID.SelectedIndexChanged += cashierOrder_prodID_SelectedIndexChanged;
            cashierOrder_qty.ValueChanged += cashierOrder_qty_ValueChanged;
            cashierOrder_amount.KeyDown += cashierOrder_amount_KeyDown;
            cashierOrder_payOrders.Click += cashierOrder_payOrders_Click_1;
            cashierOrder_clearBtn.Click += cashierOrder_clearBtn_Click_1;

            dataGridView1.CellClick += dataGridView1_CellClick;
            displayAllAvaliableProducts();
            displayAllCategories();
            IDGenerator();
<<<<<<< Updated upstream
            displayOrders();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            
            displayAllAvaliableProducts();
            displayAllCategories();
            IDGenerator();
            displayOrders();
>>>>>>> Stashed changes
=======
            displayOrders();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            
            displayAllAvaliableProducts();
            displayAllCategories();
            IDGenerator();
            displayOrders();
>>>>>>> Stashed changes
        }

        public void displayAllAvaliableProducts()
        {
            AddProductsData apData = new AddProductsData();
            List<AddProductsData> listData = apData.allAvailableProducts();

            dataGridView2.DataSource = listData;

        }



        private void label9_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream

=======
            OrdersData oData = new OrdersData();
            List<OrdersData> listData = oData.allOrdersData(idGen); // Pass current customer/session id
            dataGridView1.DataSource = listData;

            // Calculate total price from the list
            float sum = 0;
            foreach (var order in listData)
            {
                sum += order.TotalPrice;
            }
            totalPrice = sum;
            cashierOrder_totalPrice.Text = totalPrice.ToString("0.00");
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //        private void label3_Click(object sender, EventArgs e)
        //        {

        //        }

        //        private void label7_Click(object sender, EventArgs e)
        //        {

        //        }

        //        private void button1_Click(object sender, EventArgs e)
        //        {

        //        }

        //        private void label13_Click(object sender, EventArgs e)
        //        {

        //        }

        //        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //        {

        //        }

        //        private void cashierOrder_addBtn_Click(object sender, EventArgs e)
        //        {

        //        }


        public bool checkConnection()
        {

            if (connect.State == ConnectionState.Closed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //    public void displayAllCategories();
        //            {
        //            if(checkConnection)
        //                {
        //                    try
        //                    {

        //            connect.Open();

        //                string selectData = "SELECT * FROM Categories";

        //           using(SqlCommand cmd = new SqlCommand(selectData, connect))

        //        {
        //              using(SqlDataReader reader=cmd.ExecuteReader())
        //            {


        //    cashierOrder_category.Items.Clear();
        //                    while(){
        //            string item = reader.GetString(1);
        //cashierOrder_category.Items.Add(item);


        //    }
        //    }        

        //            }
        //                    }
        //                    catch (Exception ex)
        //                    {
        //                        MessageBox.Show("Failed Connection:" + ex,"Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                    }
        //                     Finally{


        //        connect.Close();
        //                     }


        //                }


        //            }
        public void displayAllCategories()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT * FROM Categories";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            cashierOrder_category.Items.Clear();

                            while (reader.Read())
                            {
                                string item = reader.GetString(1); // Assumes column 1 is category name
                                cashierOrder_category.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed Connection: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }


        private void cashierOrder_category_SelectedIndexChanged(object sender, EventArgs e)
        {

            cashierOrder_prodID.SelectedIndex = -1;
            cashierOrder_prodID.Items.Clear();
            cashierOrder_prodName.Text = "";
            cashierOrder_price.Text = "";
            cashierOrder_qty.Value = 0;

            string selectedValue = cashierOrder_category.SelectedItem as string;


            if (selectedValue != null)
            {


                if (checkConnection())
                {
                    try
                    {
                        connect.Open();
                        string selectData = $"SELECT * FROM products WHERE category ='{selectedValue}' AND status=@status";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {

                            cmd.Parameters.AddWithValue("@status", "Available");
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string value = reader["prod_id"].ToString();
                                    cashierOrder_prodID.Items.Add(value);
                                }
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed Connection:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {

                        connect.Close();
                    }

                }

            }

        }






        //private void cashierOrder_prodID_SelectedIndexChanged(object sender, EventArgs e)

        //{

        //    string selectedValue = cashierOrder_prodID.SelectedItem as string;

        //    if (checkConnection())
        //    {

        //        if (selectedValue != null)
        //        {

        //            try
        //            {
        //                connect.Open();
        //                string selectData = $"SELECT * FROM products WHERE prod_id='{selectedValue}' AND status=@status";
        //                using (SqlCommand cmd = new SqlCommand(selectData, connect))
        //                {
        //                    cmd.Parameters.AddWithValue("@status", "Ävaliable");
        //                    using (SqlDataAdapter reader = cmd.ExecuteReader())
        //                    {
        //                        while (reader.Read())
        //                        {
        //                            string prodName = reader["prod_name"].Tostring();
        //                            string prodPrice = Convert.ToSingle(reader["price"]);

        //                            cashierOrder_prodName.Text = prodName;
        //                            cashierOrder_price.Text = prodPrice.ToString("0.00");

        //                        }
        //                    }
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show("Failed Connection:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //            finally
        //            {
        //                connect.Close();

        //            }
        //        }
        //    }

        //}



        private void cashierOrder_prodID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cashierOrder_prodID.SelectedItem as string;

            if (selectedValue != null)
            {
                try
                {
                    connect.Open();
                    string selectData = $"SELECT * FROM products WHERE prod_id='{selectedValue}' AND status=@status";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {

                        cmd.Parameters.AddWithValue("@status", "Available"); // ✅ Corrected spelling

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
<<<<<<< Updated upstream
                                string prodName = reader["prod_name"].ToString();
                                float prodPrice = Convert.ToSingle(reader["price"]);

                                cashierOrder_prodName.Text = prodName;
                                cashierOrder_price.Text = prodPrice.ToString("0.00");

=======
                                cashierOrder_prodName.Text = reader["prod_name"].ToString();
                                unitPrice = Convert.ToSingle(reader["price"]);
                                cashierOrder_price.Text = (unitPrice * (float)cashierOrder_qty.Value).ToString("0.00");
                            }
                            else
                            {
                                cashierOrder_prodName.Text = "";
                                cashierOrder_price.Text = "";
                                unitPrice = 0;
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
<<<<<<< Updated upstream
        }

        

        private void cashierOrder_prodName_Click(object sender, EventArgs e)
        {

=======
            else
            {
                cashierOrder_prodName.Text = "";
                cashierOrder_price.Text = "";
                unitPrice = 0;
            }
        }

        private void cashierOrder_qty_ValueChanged(object sender, EventArgs e)
        {
            cashierOrder_price.Text = (unitPrice * (float)cashierOrder_qty.Value).ToString("0.00");
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
        }



        private void cashierOrder_addBtn_Click(object sender, EventArgs e)
        {
            IDGenerator();


            if (cashierOrder_category.SelectedIndex == -1 || cashierOrder_prodID.SelectedIndex == -1
               || cashierOrder_prodName.Text == "" || cashierOrder_price.Text == "" || cashierOrder_qty.Value == 0)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
<<<<<<< Updated upstream
                if (checkConnection())
=======
                connect.Open();
                float getPrice = unitPrice;

                string insertData = "INSERT INTO orders (customer_id, prod_id, prod_name, category, qty, orig_price, total_price, order_date) " +
                    "VALUES(@ID, @prodID, @prodName, @cat, @qty, @origPrice, @totalprice, @date)";
                using (SqlCommand cmd = new SqlCommand(insertData, connect))
>>>>>>> Stashed changes
                {
                    try
                    {
                        connect.Open();

                        float getPrice = 0;
                        string selectOrder = "SELECT * FROM products WHERE prod_id=@prodID";
                        using (SqlCommand getOrder = new SqlCommand(selectOrder, connect))
                        {
                            getOrder.Parameters.AddWithValue("@prodID", cashierOrder_prodID.SelectedItem);

                            using (SqlDataReader reader = getOrder.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    object rawValue = reader["price"];

                                    if (rawValue != DBNull.Value)
                                    {
                                        getPrice = Convert.ToSingle(rawValue);
                                    }
                                }
                            }
                        }

                        string insertData = "INSERT INTO orders (customer_id, prod_id, prod_name, category, qty, orig_price, total_price, order_date) " +
                            "VALUES(@ID, @prodID, @prodName, @cat, @qty, @origPrice, @totalprice, @date)";

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@ID", idGen);
                            cmd.Parameters.AddWithValue("@prodID", cashierOrder_prodID.SelectedItem);
                            cmd.Parameters.AddWithValue("@prodName", cashierOrder_prodName.Text.Trim());
                            cmd.Parameters.AddWithValue("@cat", cashierOrder_category.SelectedItem);
                            cmd.Parameters.AddWithValue("@qty", cashierOrder_qty.Value);
                            cmd.Parameters.AddWithValue("@origPrice", getPrice);

                            float totalP = (getPrice * (int)cashierOrder_qty.Value);

                            cmd.Parameters.AddWithValue("@totalprice", totalP);

                            DateTime today = DateTime.Today;
                            cmd.Parameters.AddWithValue("@date", today);

                            cmd.ExecuteNonQuery();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed connection: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }

<<<<<<< Updated upstream

=======
            displayOrders();
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
        }

        private int idGen;

        public void IDGenerator()
        {
            using (SqlConnection connect = new SqlConnection(@"Data Source=PIYUMAL\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;Encrypt=False"))

            {
                connect.Open();
                
        string selectData = "SELECT MAX(customer_id) FROM customers";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        int temp = Convert.ToInt32(result);

                        if (temp == 0)
                        {
                            idGen = 1;
                        }
                        else
                        {
                            idGen = temp + 1;
                        }
                    }
                    else
                    {
                        idGen = 1;
                    }
                }

<<<<<<< Updated upstream
<<<<<<< Updated upstream
=======
=======
>>>>>>> Stashed changes
        private void cashierOrder_removeBtn_Click_1(object sender, EventArgs e)
        {
            if (prodID == 0)
            {
                MessageBox.Show("Please select an order to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to remove this order with Product ID: "
                    + prodID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        string deleteData = "DELETE FROM orders WHERE id=@id";
                        using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", prodID);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Order removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to remove order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
            displayOrders();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridView1.Rows.Count)
            {
                prodID = 0;
                return;
>>>>>>> Stashed changes
            }

        }


<<<<<<< Updated upstream
<<<<<<< Updated upstream
=======
=======
>>>>>>> Stashed changes
        private void cashierOrder_clearBtn_Click_1(object sender, EventArgs e)
        {
            clearFields();
        }

        private void cashierOrder_payOrders_Click_1(object sender, EventArgs e)
        {
            IDGenerator();
            if (string.IsNullOrEmpty(cashierOrder_amount.Text) || dataGridView1.Rows.Count < 1)
            {
                MessageBox.Show("Something went wrong. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                float amountPaid = 0;
                if (!float.TryParse(cashierOrder_amount.Text, out amountPaid))
                {
                    MessageBox.Show("Invalid amount entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                float change = amountPaid - totalPrice;
                if (change < 0)
                {
                    cashierOrder_change.Text = "";
                    MessageBox.Show("Insufficient amount entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    cashierOrder_change.Text = change.ToString("0.00");
                }

                if (MessageBox.Show("Are you sure you want to pay your Order? ", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        string insertData = "INSERT INTO customers(customer_id, total_price, amount, change, order_date) " +
                            "VALUES(@cID, @totalPrice, @amount, @change, @date)";
                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@cID", idGen);
                            cmd.Parameters.AddWithValue("@totalPrice", cashierOrder_totalPrice.Text);
                            cmd.Parameters.AddWithValue("@amount", cashierOrder_amount.Text);
                            cmd.Parameters.AddWithValue("@change", cashierOrder_change.Text);
                            cmd.Parameters.AddWithValue("@date", DateTime.Today);
                            cmd.ExecuteNonQuery();

                            clearFields();

                            MessageBox.Show("Payment successful. Thank you!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to process payment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
            displayOrders();
        }

        private void cashierOrder_amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                float amountPaid = 0;
                if (!float.TryParse(cashierOrder_amount.Text, out amountPaid))
                {
                    MessageBox.Show("Invalid amount entered.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cashierOrder_amount.Text = "";
                    cashierOrder_change.Text = "";
                    return;
                }

                float change = amountPaid - totalPrice;
                if (change < 0)
                {
                    cashierOrder_change.Text = "";
                    MessageBox.Show("Insufficient amount entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cashierOrder_change.Text = change.ToString("0.00");
                }
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {


            float y = 0;
            int count = 0;
            int colWidth = 120;
            int headerMargin = 10;
            int tableMargin = 10;

            Font font = new Font("Tahoma", 12);
            Font bold = new Font("Tahoma", 12, FontStyle.Bold);
            Font headerFont = new Font("Tahoma", 14, FontStyle.Bold);
            Font labelFont = new Font("Tahoma", 14, FontStyle.Bold);

            float margin = e.MarginBounds.Top;

            StringFormat alignCenter = new StringFormat();
            alignCenter.Alignment = StringAlignment.Center;
            alignCenter.LineAlignment = StringAlignment.Center;

            string headerText = "MarcoMan's Inventory Management System";
            y = (margin + count * headerFont.GetHeight(e.Graphics) + headerMargin);
            e.Graphics.DrawString(headerText, headerFont, Brushes.Black, e.MarginBounds.Left + (dataGridView1.ColumnCount / 2) * colWidth, y, alignCenter);

            count++;

            y += tableMargin;

            string[] header = { "ID", "CID", "PID", "PName", "Category", "OrigPrice", "QTY" };

            for (int q = 0; q < header.Length; q++)
            {
                y = margin + count * bold.GetHeight(e.Graphics) + tableMargin;
                e.Graphics.DrawString(header[q], bold, Brushes.Black, e.MarginBounds.Left + q * colWidth, y, alignCenter);
            }
            count++;

            float rSpace = e.MarginBounds.Bottom - y;

            while (rowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                for (int q = 0; q < dataGridView1.Columns.Count; q++)
                {
                    string cellValue = row.Cells[q].Value?.ToString() ?? string.Empty;
                    e.Graphics.DrawString(cellValue, font, Brushes.Black, e.MarginBounds.Left + q * colWidth, y, alignCenter);
                }
                count++;
                rowIndex++;

                if (y + font.GetHeight(e.Graphics) > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
                else
                {
                    e.HasMorePages = false;
                }
            }
            int labelmargin = (int)Math.Min(rSpace, 200);

            DateTime today = DateTime.Now;

            float labelX = e.MarginBounds.Right - e.Graphics.MeasureString("------------------", labelFont).Width;

            y = e.MarginBounds.Bottom - labelmargin - labelFont.GetHeight(e.Graphics);
            e.Graphics.DrawString("Total Price:\t$" + totalPrice + "\nAmount: \t$" + cashierOrder_amount.Text.Trim()
                + "\n\t\t------------------\nChange:\t$" + cashierOrder_change.Text.Trim(), labelFont, Brushes.Black, labelX, y);

            labelmargin = (int)Math.Min(rSpace, -40);

            string labelText = today.ToString();
            y = e.MarginBounds.Bottom - labelmargin - labelFont.GetHeight(e.Graphics);
            e.Graphics.DrawString(labelText, labelFont, Brushes.Black, e.MarginBounds.Right - e.Graphics.MeasureString("------------------", labelFont).Width, y);
        }

        private void cashierOrder_receipt_Click(object sender, EventArgs e)
        {
            if (cashierOrder_amount.Text == "" || dataGridView2.Rows.Count < 0)
            {
                MessageBox.Show("Please order first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                printDocument1.BeginPrint += new PrintEventHandler(printDocument1_BeginPrint);

                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            rowIndex = 0;
        }

        
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
    }
}
