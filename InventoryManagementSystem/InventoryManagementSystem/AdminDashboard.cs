using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace InventoryManagementSystem
{
    public partial class AdminDashborad : UserControl
    {

        SqlConnection connect = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Inventory;Integrated Security=True;");
        public AdminDashborad()
        {
            InitializeComponent();
            this.Load += AdminDashborad_Load;

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
        private void AdminDashborad_Load(object sender, EventArgs e)
        {
            // Your initialization code here
        }



        public void displayTodaysCustomers()
        {
            CustomersData cData = new CustomersData();

            List<CustomersData> listData = cData.allTodayCustomers();

            dataGridView2.DataSource = listData;
        }

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

        public void displayAllUsers()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT(id) FROM users WHERE status = @status";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Active");

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashboard_AU.Text = count.ToString();
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    string selectData = "SELECT COUNT(id) FROM customers";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Active");

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashboard_AC.Text = count.ToString();
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    string selectData = "SELECT SUM(total_price) FROM customers WHERE order_date=@date";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        DateTime today = DateTime.Today;
                        string getToday = today.ToString("yyyy-MM-dd");

                        cmd.Parameters.AddWithValue("@date", getToday);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            object value = reader[0];

                            if (value != DBNull.Value)
                            {
                                int count = Convert.ToInt32(reader[0]);
                                dashboard_TI.Text = "$"+ count.ToString("0.00");
                            }
                            reader.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    string selectData = "SELECT SUM(total_price) FROM customers";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                       

                    

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {



                            int count = Convert.ToInt32(reader[0]);
                            dashboard_totalIncome.Text = "$" + count.ToString("0.00");
                        }
                        reader.Close();
                    }
                    }
                
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }



        }



    }
}
