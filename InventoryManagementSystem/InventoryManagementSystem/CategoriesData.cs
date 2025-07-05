using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace InventoryManagementSystem
{
    internal class CategoriesData
    {
        public int ID { get; set; }
        public string Category { get; set; }
        public List<CategoriesData> AllCategoriesData()
        {
            List<CategoriesData> listData = new List<CategoriesData>();

            using (SqlConnection connection = new SqlConnection(@"Data Source=PIYUMAL\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;Encrypt=False"))
            {
                connection.Open();

                string selectData = "SELECT * FROM categories";

                using (SqlCommand cmd = new SqlCommand(selectData, connection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        UserData uData = new UserData
                        {
                            ID = Convert.ToInt32(reader["id"]),
                            Username = reader["username"].ToString(),
                            Password = reader["password"].ToString(),
                            Role = reader["role"].ToString(),
                            Status = reader["status"].ToString(),
                            Date = reader["date"].ToString()
                        };

                        listData.Add(uData);
                    }
                }
            }

            return listData;
        }
    }
}
