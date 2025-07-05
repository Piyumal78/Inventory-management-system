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
        SqlConnection connect = new SqlConnection(@"Data Source=PIYUMAL\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;Encrypt=False");

        public string CID;
        public string PID;
        public string PName;
        public string Category;
        public string OrigPrice;
        public string QTY;
        public string TotalPrice;
        public string Date;

        public List<OrdersData> allOrdersData()
        {
            List<OrdersData> listData = new List<OrdersData>();

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                }
                catch (Exception ex)
                {

                }
                finally
                {

                }
            }
            
        }

    }
}
