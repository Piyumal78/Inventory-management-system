using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Data;
using System.Data.SqlClient;

=======
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


>>>>>>> e1394d15b6bf62968fdade6b695c0bf011329132
namespace InventoryManagementSystem
{
    internal class CategoriesData
    {
        public int ID { get; set; }
        public string Category { get; set; }
<<<<<<< HEAD
        public string Date { get; set; }

=======
>>>>>>> e1394d15b6bf62968fdade6b695c0bf011329132
        public List<CategoriesData> AllCategoriesData()
        {
            List<CategoriesData> listData = new List<CategoriesData>();

<<<<<<< HEAD
            using (SqlConnection connection = new SqlConnection(@"Data Source=PIYUMAL\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;"))
=======
            using (SqlConnection connection = new SqlConnection(@"Data Source=PIYUMAL\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;Encrypt=False"))
>>>>>>> e1394d15b6bf62968fdade6b695c0bf011329132
            {
                connection.Open();

                string selectData = "SELECT * FROM categories";

                using (SqlCommand cmd = new SqlCommand(selectData, connection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
<<<<<<< HEAD
                        CategoriesData cData = new CategoriesData();
                        cData.ID = (int)reader["id"];
                        cData.Category = reader["category"].ToString();
                        cData.Date = reader["date"].ToString();

                        listData.Add(cData);
=======
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
>>>>>>> e1394d15b6bf62968fdade6b695c0bf011329132
                    }
                }
            }

            return listData;
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> e1394d15b6bf62968fdade6b695c0bf011329132
