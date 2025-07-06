using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace InventoryManagementSystem
{
    internal class AddProductsData
    {


        public int ID { get; set; }//0
        public string? ProdID { get; set; }//1
        public string? ProdName { get; set; }//2
        public string? Category { get; set; }//3
        public string? Price { get; set; }//4
        public string? Stock { get; set; }//5
        public string? ImagePath { get; set; }//6
        public string? Status { get; set; }//7
        public DateTime? Date { get; set; }

        public List<AddProductsData> AllProductsData()
        {
            List<AddProductsData> listData = new List<AddProductsData>();

            using (SqlConnection connection = new SqlConnection(@"Data Source=PIYUMAL\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;Encrypt=False"))
            {
                connection.Open();

                string selectData = "SELECT * FROM products ";

                using (SqlCommand cmd = new SqlCommand(selectData, connection))
                {

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {

                        AddProductsData apData = new AddProductsData();
                        apData.ID = (int)reader["id"];
                        apData.ProdID = reader["prod_id"].ToString();
                        apData.ProdName = reader["prod_name"].ToString();
                        apData.Category = reader["category"].ToString();
                        apData.Price = reader["price"].ToString();
                        apData.Stock = reader["stock"].ToString();
                        apData.ImagePath = reader["image_path"].ToString();
                        apData.Status = reader["status"].ToString();
                        apData.Date = reader["date_insert"] == DBNull.Value
                        ? (DateTime?)null
                        : Convert.ToDateTime(reader["date_insert"]);


                        listData.Add(apData);
                    }
                }
            }


            return listData;
        }
        public List<AddProductsData> allAvailableProducts()
        {
            List<AddProductsData> listData = new List<AddProductsData>();
            using (SqlConnection connection = new SqlConnection(@"Data Source=PIYUMAL\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;Encrypt=False"))
            {
                connection.Open();

                string selectData = "SELECT * FROM products WHERE status=@status";

                using (SqlCommand cmd = new SqlCommand(selectData, connection))
                {
                    cmd.Parameters.AddWithValue("@status", "Available");
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {

                        AddProductsData apData = new AddProductsData();
                        apData.ID = (int)reader["id"];
                        apData.ProdID = reader["prod_id"].ToString();
                        apData.ProdName = reader["prod_name"].ToString();
                        apData.Category = reader["category"].ToString();
                        apData.Price = reader["price"].ToString();
                        apData.Stock = reader["stock"].ToString();
                        apData.ImagePath = reader["image_path"].ToString();
                        apData.Status = reader["status"].ToString();
                        apData.Date = reader["date_insert"] == DBNull.Value
                        ? (DateTime?)null
                        : Convert.ToDateTime(reader["date_insert"]);


                        listData.Add(apData);
                    }
                }
            }
            return listData;
        }
    }
}


