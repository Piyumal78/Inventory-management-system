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
        SqlConnection connect = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Inventory;Integrated Security=True;Encrypt=False");
        private int idGen;
        private int prodID = 0;
        private float totalPrice = 0;
        private int rowIndex = 0;

        public CashierOrder()
        {
            InitializeComponent();
            cashierOrder_category.SelectedIndexChanged += cashierOrder_category_SelectedIndexChanged;
            cashierOrder_prodID.SelectedIndexChanged += cashierOrder_prodID_SelectedIndexChanged;
            dataGridView1.CellClick += dataGridView1_CellClick;
            displayAllAvaliableProducts();
            displayAllCategories();
            displayOrders();
            displayTotalPrice();
        }

        public void displayAllAvaliableProducts()
        {
            AddProductsData apData = new AddProductsData();
            List<AddProductsData> listData = apData.allAvailableProducts();
            dataGridView2.DataSource = listData;
        }

        public void displayOrders()
        {
            OrdersData oData = new OrdersData();
            List<OrdersData> listData = oData.allOrdersData();
            dataGridView1.DataSource = listData;
        }

        public void displayAllCategories()
        {
            try
            {
                connect.Open();
                string selectData = "SELECT DISTINCT category FROM products WHERE status = @status";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters.AddWithValue("@status", "Available");
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        cashierOrder_category.Items.Clear();
                        while (reader.Read())
                        {
                            string item = reader["category"].ToString();
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

        private void cashierOrder_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            cashierOrder_prodID.SelectedIndex = -1;
            cashierOrder_prodID.Items.Clear();
            cashierOrder_prodName.Text = "";
            cashierOrder_price.Text = "";
            cashierOrder_qty.Value = 0;

            string selectedCategory = cashierOrder_category.SelectedItem as string;
            if (!string.IsNullOrEmpty(selectedCategory))
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT prod_id FROM products WHERE category = @category AND status = @status";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@category", selectedCategory);
                        cmd.Parameters.AddWithValue("@status", "Available");
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string prodID = reader["prod_id"].ToString();
                                cashierOrder_prodID.Items.Add(prodID);
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

        private void cashierOrder_prodID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProdID = cashierOrder_prodID.SelectedItem as string;
            string selectedCategory = cashierOrder_category.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedProdID) && !string.IsNullOrEmpty(selectedCategory))
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT prod_name, price FROM products WHERE prod_id = @prodID AND category = @category AND status = @status";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@prodID", selectedProdID);
                        cmd.Parameters.AddWithValue("@category", selectedCategory);
                        cmd.Parameters.AddWithValue("@status", "Available");
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                cashierOrder_prodName.Text = reader["prod_name"].ToString();
                                cashierOrder_price.Text = Convert.ToSingle(reader["price"]).ToString("0.00");
                            }
                            else
                            {
                                cashierOrder_prodName.Text = "";
                                cashierOrder_price.Text = "";
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
            else
            {
                cashierOrder_prodName.Text = "";
                cashierOrder_price.Text = "";
            }
        }

        public void displayTotalPrice()
        {
            IDGenerator();

            try
            {
                connect.Open();
                string selectData = "SELECT SUM(total_price) FROM orders WHERE customer_id=@cID";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters.AddWithValue("@cID", idGen);
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        totalPrice = Convert.ToSingle(result);
                        cashierOrder_totalPrice.Text = totalPrice.ToString("0.00");
                    }
                    else
                    {
                        totalPrice = 0;
                        cashierOrder_totalPrice.Text = "0.00";
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

        private void cashierOrder_addBtn_Click(object sender, EventArgs e)
        {
            IDGenerator();

            if (cashierOrder_category.SelectedIndex == -1 || cashierOrder_prodID.SelectedIndex == -1
                || string.IsNullOrEmpty(cashierOrder_prodName.Text) || string.IsNullOrEmpty(cashierOrder_price.Text) || cashierOrder_qty.Value == 0)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                connect.Open();
                float getPrice = float.Parse(cashierOrder_price.Text);

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

                    float totalP = getPrice * (int)cashierOrder_qty.Value;
                    cmd.Parameters.AddWithValue("@totalprice", totalP);

                    cmd.Parameters.AddWithValue("@date", DateTime.Today);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed connection: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }

            displayOrders();
            displayTotalPrice();
        }

        public void IDGenerator()
        {
            using (SqlConnection tempConnect = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Inventory;Integrated Security=True;Encrypt=False"))
            {
                tempConnect.Open();
                string selectData = "SELECT MAX(customer_id) FROM customers";
                using (SqlCommand cmd = new SqlCommand(selectData, tempConnect))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        int temp = Convert.ToInt32(result);
                        idGen = temp == 0 ? 1 : temp + 1;
                    }
                    else
                    {
                        idGen = 1;
                    }
                }
            }
        }

        private void cashierOrder_removeBtn_Click(object sender, EventArgs e)
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
            displayTotalPrice();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Defensive: only proceed if not header or out of bounds
            if (e.RowIndex < 0 || e.RowIndex >= dataGridView1.Rows.Count)
            {
                prodID = 0;
                return;
            }

            var row = dataGridView1.Rows[e.RowIndex];
            var cellValue = row.Cells[0].Value;

            if (cellValue == null || cellValue == DBNull.Value)
            {
                prodID = 0;
                return;
            }

            prodID = Convert.ToInt32(cellValue);
        }

        public void clearFields()
        {
            cashierOrder_category.SelectedIndex = -1;
            cashierOrder_prodID.SelectedIndex = -1;
            cashierOrder_prodName.Text = "";
            cashierOrder_price.Text = "";
            cashierOrder_qty.Value = 0;
            cashierOrder_amount.Text = "";
            cashierOrder_change.Text = "";
        }

        private void cashierOrder_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void cashierOrder_payOrders_Click(object sender, EventArgs e)
        {
            IDGenerator();
            if (string.IsNullOrEmpty(cashierOrder_amount.Text) || dataGridView1.Rows.Count < 1)
            {
                MessageBox.Show("Something went wrong. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
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
            displayTotalPrice();
            cashierOrder_amount.Text = "";
            cashierOrder_change.Text = "";
        }

        private void cashierOrder_amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    float getAmount = Convert.ToSingle(cashierOrder_amount.Text);
                    float getchange = (getAmount - totalPrice);

                    if (getchange < 0)
                    {
                        cashierOrder_amount.Text = "";
                        cashierOrder_change.Text = "";
                    }
                    else
                    {
                        cashierOrder_change.Text = getchange.ToString("0.00");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid amount entered.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cashierOrder_amount.Text = "";
                    cashierOrder_change.Text = "";
                }
            }
        }

        private void cashierOrder_receipt_Click(object sender, EventArgs e)
        {
            displayOrders();
            printDocument1.PrintPage -= printDocument1_PrintPage;
            printDocument1.PrintPage += printDocument1_PrintPage;
            printDocument1.BeginPrint -= printDocument1_BeginPrint;
            printDocument1.BeginPrint += printDocument1_BeginPrint;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            rowIndex = 0;
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            displayTotalPrice();

            float y = 0;
            int count = 0;
            int colWidth = 120;
            int headerMargin = 10;
            int tableMargin = 20;

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

            string[] header = { "CID", "PID", "PName", "Category", "QTY", "OriPrice", "TotalPrice" };

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

            float labelX = e.MarginBounds.Right - e.Graphics.MeasureString("--------------------------------------", labelFont).Width;

            y = e.MarginBounds.Bottom - labelmargin - labelFont.GetHeight(e.Graphics);
            e.Graphics.DrawString("Total Price:\t$" + totalPrice + "\nAmount: \t$" + cashierOrder_amount.Text.Trim()
                + "\n\t\t--------------------------\nChange:\t$" + cashierOrder_change.Text.Trim(), labelFont, Brushes.Black, labelX, y);

            labelmargin = (int)Math.Min(rSpace, -40);

            string labelText = today.ToString();
            y = e.MarginBounds.Bottom - labelmargin - labelFont.GetHeight(e.Graphics);
            e.Graphics.DrawString(labelText, labelFont, Brushes.Black, e.MarginBounds.Right - e.Graphics.MeasureString("------------------", labelFont).Width, y);
        }
    }
}
