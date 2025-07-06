using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace InventoryManagementSystem
{
    internal class OrdersData
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Inventory;Integrated Security=True;Connect Timeout=30");

        public int ID { get; set; }
        public string CID { get; set; }
        public string PID { get; set; }
        public string PName { get; set; }
        public string Category { get; set; }
        public string OrigPrice { get; set; }
        public string QTY { get; set; }
        public string TotalPrice { get; set; }
        public string Date { get; set; }

        public List<OrdersData> allOrdersData()
        {
            List<OrdersData> listData = new List<OrdersData>();

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    int custID = 0;
                    string selectCustData = "SELECT MAX(customer_id) FROM orders";

                    using (SqlCommand cmd = new SqlCommand(selectCustData, connect))
                    {
                        object result = cmd.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            int temp = Convert.ToInt32(result);
                            if (temp == 0)
                            {
                                custID = 1;
                            }
                            else
                            {
                                custID = temp;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error ID");
                        }
                    }
                    string selectData = "SELECT * FROM orders WHERE customer_id=@cID";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@cID", custID);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            OrdersData oData = new OrdersData();

                            oData.ID = (int)reader["id"];
                            oData.CID = reader["customer_id"].ToString();
                            oData.PID = reader["prod_id"].ToString();
                            oData.PName = reader["prod_name"].ToString();
                            oData.Category = reader["category"].ToString();
                            oData.OrigPrice = reader["orig_price"].ToString();
                            oData.QTY = reader["qty"].ToString();
                            oData.TotalPrice = reader["total_price"].ToString();
                            oData.Date = reader["order_date"].ToString();

                            listData.Add(oData);
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Connection failed: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listData;
        }

    }
}