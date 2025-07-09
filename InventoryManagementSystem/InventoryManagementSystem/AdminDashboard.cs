using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class AdminDashborad : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-RN2T9CM\SQLEXPRESS;Initial Catalog=Inventory_managment;Integrated Security=True");

        public AdminDashborad()
        {
            InitializeComponent();
            this.Load += AdminDashborad_Load;
        }

        private void AdminDashborad_Load(object sender, EventArgs e)
        {
            displayTodaysCustomers();
            displayAllUsers();
            displayAllCustomers();
            displayTodaysIncome();
            displayTotalIncome();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayAllUsers();
            displayAllCustomers();
            displayTodaysIncome();
            displayTotalIncome();
        }

        public void displayTodaysCustomers()
        {
            CustomersData cData = new CustomersData();
            List<CustomersData> listData = cData.allTodayCustomers();

            dataGridView2.DataSource = null;
            dataGridView2.DataSource = listData;

            if (dataGridView2.Columns.Count > 0)
            {
                dataGridView2.Columns["CustomerID"].HeaderText = "Customer_ID";
                dataGridView2.Columns["TotalPrice"].HeaderText = "Total_Price";
                dataGridView2.Columns["Amount"].HeaderText = "Amount";
                dataGridView2.Columns["Change"].HeaderText = "Change";
                dataGridView2.Columns["Date"].HeaderText = "Date";
            }
            dataGridView2.Columns["Date"].HeaderText = "Date";
        }

        public bool checkConnection()
        {
            return connect.State == ConnectionState.Closed;
        }

        public void displayAllUsers()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();
                    string query = "SELECT COUNT(id) FROM users WHERE status = @status";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Active");
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            dashboard_AU.Text = reader[0].ToString();
                        }

                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        public void displayAllCustomers()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();
                    string query = "SELECT COUNT(id) FROM customers";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            dashboard_AC.Text = reader[0].ToString();
                        }

                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        public void displayTodaysIncome()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();
                    string query = "SELECT SUM(total_price) FROM customers WHERE order_date = @date";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@date", DateTime.Today);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            if (reader[0] != DBNull.Value)
                            {
                                decimal total = Convert.ToDecimal(reader[0]);
                                dashboard_TI.Text = "$" + total.ToString("0.00");
                            }
                            else
                            {
                                dashboard_TI.Text = "$0.00";
                            }
                        }

                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        public void displayTotalIncome()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();
                    string query = "SELECT SUM(total_price) FROM customers";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            if (reader[0] != DBNull.Value)
                            {
                                decimal total = Convert.ToDecimal(reader[0]);
                                dashboard_totalIncome.Text = "$" + total.ToString("0.00");
                            }
                            else
                            {
                                dashboard_totalIncome.Text = "$0.00";
                            }
                        }

                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dashboard_TI_Click(object sender, EventArgs e)
        {
            // Optional
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
