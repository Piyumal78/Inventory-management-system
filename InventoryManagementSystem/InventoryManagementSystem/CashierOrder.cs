using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class CashierOrder : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-RN2T9CM\SQLEXPRESS;Initial Catalog=Inventory_managment;Integrated Security=True");
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
            cashierOrder_addBtn.Click += cashierOrder_addBtn_Click; 

            
            printDocument1.PrintPage += printDocument1_PrintPage;
            printDocument1.BeginPrint += printDocument1_BeginPrint;

            
            displayAllAvaliableProducts();
            displayAllCategories();
            IDGenerator();
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
        }

        public void displayAllAvaliableProducts()
        {
            try
            {
                AddProductsData apData = new AddProductsData();
                List<AddProductsData> listData = apData.allAvailableProducts();
                dataGridView2.DataSource = listData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            displayOrders();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        
        public bool checkConnection()
        {
            return connect.State == ConnectionState.Closed;
        }

        public void displayAllCategories()
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                string selectData = "SELECT * FROM Categories";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        cashierOrder_category.Items.Clear();

                        while (reader.Read())
                        {
                            string item = reader.GetString(1);
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
                if (connect.State == ConnectionState.Open)
                    connect.Close();
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
                try
                {
                    if (connect.State == ConnectionState.Closed)
                        connect.Open();

                    string selectData = "SELECT * FROM products WHERE category = @category AND status = @status";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@category", selectedValue);
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
                    MessageBox.Show("Failed Connection: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connect.State == ConnectionState.Open)
                        connect.Close();
                }
            }
        }

        private void cashierOrder_prodID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cashierOrder_prodID.SelectedItem as string;

            if (selectedValue != null)
            {
                try
                {
                    if (connect.State == ConnectionState.Closed)
                        connect.Open();

                    string selectData = "SELECT * FROM products WHERE prod_id = @prod_id AND status = @status";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@prod_id", selectedValue);
                        cmd.Parameters.AddWithValue("@status", "Available");

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    cashierOrder_prodName.Text = reader["prod_name"].ToString();
                                    unitPrice = Convert.ToSingle(reader["price"]);
                                    cashierOrder_price.Text = (unitPrice * (float)cashierOrder_qty.Value).ToString("0.00");
                                }
                            }
                            else
                            {
                                cashierOrder_prodName.Text = "";
                                cashierOrder_price.Text = "";
                                unitPrice = 0;
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
                    if (connect.State == ConnectionState.Open)
                        connect.Close();
                }
            }
        }

        private void cashierOrder_qty_ValueChanged(object sender, EventArgs e)
        {
            cashierOrder_price.Text = (unitPrice * (float)cashierOrder_qty.Value).ToString("0.00");
        }

        
        private void cashierOrder_addBtn_Click(object sender, EventArgs e)
        {
            if (cashierOrder_category.SelectedIndex == -1 ||
                cashierOrder_prodID.SelectedIndex == -1 ||
                string.IsNullOrEmpty(cashierOrder_prodName.Text) ||
                string.IsNullOrEmpty(cashierOrder_price.Text) ||
                cashierOrder_qty.Value == 0)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                float getPrice = 0;
                string selectOrder = "SELECT price FROM products WHERE prod_id = @prodID";
                using (SqlCommand getOrder = new SqlCommand(selectOrder, connect))
                {
                    getOrder.Parameters.AddWithValue("@prodID", cashierOrder_prodID.SelectedItem);

                    using (SqlDataReader reader = getOrder.ExecuteReader())
                    {
                        if (reader.Read() && reader["price"] != DBNull.Value)
                        {
                            getPrice = Convert.ToSingle(reader["price"]);
                        }
                        else
                        {
                            MessageBox.Show("Product not found or invalid price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

              
                if (connect.State == ConnectionState.Open)
                    connect.Close();

                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                string insertData = @"INSERT INTO orders 
                              (customer_id, prod_id, prod_name, category, qty, orig_price, total_price, order_date) 
                              VALUES (@ID, @prodID, @prodName, @cat, @qty, @origPrice, @totalprice, @date)";

                using (SqlCommand insertCmd = new SqlCommand(insertData, connect))
                {
                    float totalP = getPrice * (int)cashierOrder_qty.Value;

                    insertCmd.Parameters.AddWithValue("@ID", idGen);
                    insertCmd.Parameters.AddWithValue("@prodID", cashierOrder_prodID.SelectedItem);
                    insertCmd.Parameters.AddWithValue("@prodName", cashierOrder_prodName.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@cat", cashierOrder_category.SelectedItem);
                    insertCmd.Parameters.AddWithValue("@qty", cashierOrder_qty.Value);
                    insertCmd.Parameters.AddWithValue("@origPrice", getPrice);
                    insertCmd.Parameters.AddWithValue("@totalprice", totalP);
                    insertCmd.Parameters.AddWithValue("@date", DateTime.Today);

                    int rowsAffected = insertCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Order added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        
                        displayOrders();

                        
                        cashierOrder_prodID.SelectedIndex = -1;
                        cashierOrder_prodName.Text = "";
                        cashierOrder_price.Text = "";
                        cashierOrder_qty.Value = 1; 
                    }
                    else
                    {
                        MessageBox.Show("Failed to add order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed connection: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
        }

        public void IDGenerator()
        {
            using (SqlConnection tempConnect = new SqlConnection(@"Data Source=DESKTOP-RN2T9CM\SQLEXPRESS;Initial Catalog=Inventory_managment;Integrated Security=True"))
            {
                try
                {
                    tempConnect.Open();
                    string selectData = "SELECT ISNULL(MAX(customer_id), 0) FROM customers";

                    using (SqlCommand cmd = new SqlCommand(selectData, tempConnect))
                    {
                        object result = cmd.ExecuteScalar();
                        int maxID = result != null ? Convert.ToInt32(result) : 0;
                        idGen = maxID + 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ID generation failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    idGen = 1;
                }
                finally
                {
                    if (tempConnect.State == ConnectionState.Open)
                        tempConnect.Close();
                }
            }
        }

        private void cashierOrder_removeBtn_Click_1(object sender, EventArgs e)
        {
            if (prodID == 0)
            {
                MessageBox.Show("Please select an order to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to remove this order with ID: " + prodID + "?",
                "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (connect.State == ConnectionState.Closed)
                        connect.Open();

                    string deleteData = "DELETE FROM orders WHERE id = @id";
                    using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                    {
                        cmd.Parameters.AddWithValue("@id", prodID);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Order removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            prodID = 0;
                            displayOrders(); 
                        }
                        else
                        {
                            MessageBox.Show("Order not found or already removed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to remove order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connect.State == ConnectionState.Open)
                        connect.Close();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridView1.Rows.Count)
            {
                prodID = 0;
                return;
            }

            try
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                if (row.Cells["id"] != null && row.Cells["id"].Value != null)
                {
                    prodID = Convert.ToInt32(row.Cells["id"].Value);
                }
                else if (row.Cells[0] != null && row.Cells[0].Value != null)
                {
                    prodID = Convert.ToInt32(row.Cells[0].Value);
                }
                else
                {
                    prodID = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                prodID = 0;
            }
        }

        private void clearFields()
        {
            cashierOrder_category.SelectedIndex = -1;
            cashierOrder_prodID.SelectedIndex = -1;
            cashierOrder_prodName.Text = "";
            cashierOrder_price.Text = "";
            cashierOrder_qty.Value = 0;
            cashierOrder_amount.Clear();
            cashierOrder_change.Text = "";
            prodID = 0;
        }

        private void cashierOrder_clearBtn_Click_1(object sender, EventArgs e)
        {
            clearFields();
            displayOrders(); 
        }

        private void cashierOrder_payOrders_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cashierOrder_amount.Text) || dataGridView1.Rows.Count <= 0)
            {
                MessageBox.Show("Please add items to order and enter payment amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
                MessageBox.Show("Insufficient amount entered. Required: " + totalPrice.ToString("0.00"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cashierOrder_change.Text = change.ToString("0.00");

            if (MessageBox.Show("Are you sure you want to process this payment?\n\nTotal: " + totalPrice.ToString("0.00") +
                "\nAmount Paid: " + amountPaid.ToString("0.00") +
                "\nChange: " + change.ToString("0.00"),
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (connect.State == ConnectionState.Closed)
                        connect.Open();

                    string insertData = "INSERT INTO customers(customer_id, total_price, amount, change, order_date) " +
                        "VALUES(@cID, @totalPrice, @amount, @change, @date)";

                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@cID", idGen);
                        cmd.Parameters.AddWithValue("@totalPrice", totalPrice);
                        cmd.Parameters.AddWithValue("@amount", amountPaid);
                        cmd.Parameters.AddWithValue("@change", change);
                        cmd.Parameters.AddWithValue("@date", DateTime.Today);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Payment successful. Thank you!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    IDGenerator();
                    clearFields();
                    displayOrders();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to process payment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connect.State == ConnectionState.Open)
                        connect.Close();
                }
            }
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
                    MessageBox.Show("Insufficient amount entered. Required: " + totalPrice.ToString("0.00"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cashierOrder_change.Text = change.ToString("0.00");
                }
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (dataGridView1 == null || dataGridView1.Rows.Count == 0)
            {
                e.Graphics.DrawString("No data to print", new Font("Arial", 12), Brushes.Black, 100, 100);
                e.HasMorePages = false;
                return;
            }

            float y = 0;
            int headerMargin = 20;
            int tableMargin = 20;

            Font font = new Font("Tahoma", 10);
            Font bold = new Font("Tahoma", 10, FontStyle.Bold);
            Font headerFont = new Font("Tahoma", 16, FontStyle.Bold);
            Font labelFont = new Font("Tahoma", 12, FontStyle.Bold);

            float margin = e.MarginBounds.Top;

            string headerText = "SLASH's Inventory Management System";
            y = margin + headerMargin;
            e.Graphics.DrawString(headerText, headerFont, Brushes.Black, e.MarginBounds.Left, y);
            y += headerFont.GetHeight(e.Graphics) + 10;

            e.Graphics.DrawString("Date: " + DateTime.Now.ToString("dd/MM/yyyy hh:mm tt"), font, Brushes.Black, e.MarginBounds.Left, y);
            e.Graphics.DrawString("Customer ID: " + idGen, font, Brushes.Black, e.MarginBounds.Right - 150, y);
            y += font.GetHeight(e.Graphics) + tableMargin;

            e.Graphics.DrawLine(Pens.Black, e.MarginBounds.Left, y, e.MarginBounds.Right, y);
            y += 10;

            string[] headers = { "Product ID", "Product Name", "Category", "Qty", "Price", "Total" };
            int[] colWidths = { 80, 150, 100, 50, 70, 70 };

            float currentX = e.MarginBounds.Left;
            for (int i = 0; i < headers.Length && i < dataGridView1.Columns.Count; i++)
            {
                e.Graphics.DrawString(headers[i], bold, Brushes.Black, currentX, y);
                currentX += colWidths[i];
            }

            y += bold.GetHeight(e.Graphics) + 5;
            e.Graphics.DrawLine(Pens.Black, e.MarginBounds.Left, y, e.MarginBounds.Right, y);
            y += 10;

            while (rowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                currentX = e.MarginBounds.Left;

                for (int i = 0; i < Math.Min(headers.Length, row.Cells.Count); i++)
                {
                    string value = row.Cells[i].Value?.ToString() ?? "";
                    if (i == 4 || i == 5)
                        value = "$" + value;

                    e.Graphics.DrawString(value, font, Brushes.Black, currentX, y);
                    currentX += colWidths[i];
                }

                y += font.GetHeight(e.Graphics) + 2;
                rowIndex++;

                if (y > e.MarginBounds.Bottom - 150)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            y += 20;
            e.Graphics.DrawLine(Pens.Black, e.MarginBounds.Left, y, e.MarginBounds.Right, y);
            y += 15;

            float labelX = e.MarginBounds.Right - 200;

            e.Graphics.DrawString("Total Price:", labelFont, Brushes.Black, labelX, y);
            e.Graphics.DrawString("$" + totalPrice.ToString("0.00"), labelFont, Brushes.Black, labelX + 100, y);
            y += labelFont.GetHeight(e.Graphics) + 5;

            e.Graphics.DrawString("Amount Paid:", labelFont, Brushes.Black, labelX, y);
            e.Graphics.DrawString("$" + cashierOrder_amount.Text.Trim(), labelFont, Brushes.Black, labelX + 100, y);
            y += labelFont.GetHeight(e.Graphics) + 5;

            e.Graphics.DrawString("Change:", labelFont, Brushes.Black, labelX, y);
            e.Graphics.DrawString("$" + cashierOrder_change.Text.Trim(), labelFont, Brushes.Black, labelX + 100, y);
            y += labelFont.GetHeight(e.Graphics) + 20;

            e.Graphics.DrawString("Thank you for your business!", headerFont, Brushes.Black,
                e.MarginBounds.Left + (e.MarginBounds.Width - e.Graphics.MeasureString("Thank you for your business!", headerFont).Width) / 2, y);

            e.HasMorePages = false;
        }

        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            rowIndex = 0;
        }

      
        public void displayOrders()
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                string selectData = "SELECT id, customer_id, prod_id, prod_name, category, qty, orig_price, total_price, order_date FROM orders WHERE customer_id = @customerID ORDER BY id DESC";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters.AddWithValue("@customerID", idGen);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Refresh(); 

                  
                    float sum = 0;
                    foreach (DataRow row in dataTable.Rows)
                    {
                        if (row["total_price"] != DBNull.Value)
                        {
                            if (float.TryParse(row["total_price"].ToString(), out float price))
                            {
                                sum += price;
                            }
                        }
                    }

                    totalPrice = sum;

                   
                    if (cashierOrder_totalPrice != null)
                    {
                        cashierOrder_totalPrice.Text = totalPrice.ToString("0.00");
                    }

                    
                    Console.WriteLine($"Orders loaded: {dataTable.Rows.Count}, Total Price: {totalPrice}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading orders: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                
                totalPrice = 0;
                if (cashierOrder_totalPrice != null)
                {
                    cashierOrder_totalPrice.Text = "0.00";
                }
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
        }

        private void cashierOrder_receipt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cashierOrder_amount.Text) || dataGridView1.Rows.Count <= 0)
            {
                MessageBox.Show("Please complete an order and enter payment amount first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                rowIndex = 0;
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating receipt: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void cashierOrder_amount_TextChanged(object sender, EventArgs e)
        {
        }

        private void CashierOrder_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}