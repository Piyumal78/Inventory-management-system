using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace InventoryManagementSystem
{
    internal class OrdersData
    {
        SqlConnection connect = new SqlConnection(@"Data Source=PIYUMAL\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;Encrypt=False");


        public int ID { get; set; }
        public string CID { get; set; }
        public string PID { get; set; }
        public string PName { get; set; }
        public string Category { get; set; }
        public float OrigPrice { get; set; }
        public int QTY { get; set; }
        public float TotalPrice { get; set; }
        public string Date { get; set; }


        // Fetch all orders for a specific customer_id
        public List<OrdersData> allOrdersData(int customerId)
        {
            List<OrdersData> listData = new List<OrdersData>();

            try
            {
                connect.Open();
                string selectData = "SELECT * FROM orders WHERE customer_id=@cID";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {


                    cmd.Parameters.AddWithValue("@cID", customerId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            OrdersData oData = new OrdersData();

                            oData.ID = reader["id"] != DBNull.Value ? Convert.ToInt32(reader["id"]) : 0;
                            oData.CID = reader["customer_id"].ToString();
                            oData.PID = reader["prod_id"].ToString();
                            oData.PName = reader["prod_name"].ToString();
                            oData.Category = reader["category"].ToString();
                            oData.OrigPrice = reader["orig_price"] != DBNull.Value ? Convert.ToSingle(reader["orig_price"]) : 0;
                            oData.QTY = reader["qty"] != DBNull.Value ? Convert.ToInt32(reader["qty"]) : 0;
                            oData.TotalPrice = reader["total_price"] != DBNull.Value ? Convert.ToSingle(reader["total_price"]) : 0;
                            oData.Date = reader["order_date"].ToString();

                            listData.Add(oData);
                        }
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
            return listData;

        }

        // Optional: Helper to get latest customer_id if you still want that
        public int GetLatestCustomerId()
        {
            int custID = 0;
            try
            {
                connect.Open();
                string selectCustData = "SELECT MAX(customer_id) FROM orders";
                using (SqlCommand cmd = new SqlCommand(selectCustData, connect))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        custID = Convert.ToInt32(result);
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
            return custID;
        }
    }
}
