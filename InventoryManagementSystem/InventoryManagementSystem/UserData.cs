using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace InventoryManagementSystem
{
    internal class UserData
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
        public string Date { get; set; }  // Can also use DateTime if DB column is datetime

        public List<UserData> AllUsersData()
        {
            List<UserData> listData = new List<UserData>();

            using (SqlConnection connection = new SqlConnection(@"Data Source=PIYUMAL\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;Encrypt=False"))
            {
                connection.Open();

                string selectData = "SELECT * FROM users";

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
