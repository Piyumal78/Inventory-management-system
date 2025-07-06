using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace InventoryManagementSystem
{
    internal class UserData
    {
        public int ID { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
        public string? Status { get; set; }
        public DateTime? Date { get; set; }

        public List<UserData> AllUsersData()
        {
            List<UserData> listData = new List<UserData>();

            using (SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Inventory;Integrated Security=True;Encrypt=False"))
            {
                connection.Open();

                string selectData = "SELECT * FROM users";

                using (SqlCommand cmd = new SqlCommand(selectData, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UserData uData = new UserData
                            {
                                ID = Convert.ToInt32(reader["id"]),
                                Username = reader["username"] == DBNull.Value ? string.Empty : reader["username"].ToString(),
                                Password = reader["password"] == DBNull.Value ? string.Empty : reader["password"].ToString(),
                                Role = reader["role"] == DBNull.Value ? string.Empty : reader["role"].ToString(),
                                Status = reader["status"] == DBNull.Value ? string.Empty : reader["status"].ToString(),
                                Date = reader["date"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(reader["date"])
                            };


                            listData.Add(uData);
                        }
                    }
                }
            }

            return listData;
        }
    }
}