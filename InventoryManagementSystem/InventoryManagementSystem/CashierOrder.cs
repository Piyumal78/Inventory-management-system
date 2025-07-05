using Microsoft.IdentityModel.Tokens;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace InventoryManagementSystem
{
    public partial class CashierOrder : UserControl
    {
        SqlConnection
        connect = new SqlConnection(@"Data Source=PIYUMAL\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;Encrypt=False");
        public CashierOrder()
        {
            InitializeComponent();
            displayAllAvaliableProducts();
            displayAllCategories();
        }

        public void displayAllAvaliableProducts()
        {
            AddProductsData apData = new AddProductsData();
            List<AddProductsData> listData = apData.AllAvaliableProductData();

            dataGridView2.DataSource = listData;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cashierOrder_addBtn_Click(object sender, EventArgs e)
        {

        }


        public bool checkConnection()
        {
            SqlConnection connect = new SqlConnection(@"Data Source=PIYUMAL\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;Encrypt=False");
            if (connect.State == ConnectionState.Closed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void displayAllCategories();
        {
        if(checkConnection)
            {
                try
                {
                  
        connect.Open();

            string selectData = "SELECT * FROM Categories";

       using(SqlCommand cmd = new SqlCommand(selectData, connect))
    
    {
          using(SqlDataReader reader=cmd.ExecuteReader())
        {


cashierOrder_category.Items.Clear();
                while(){
        string item = reader.GetString(1);
    cashierOrder_category.Items.Add(item);


}
}        
        
        }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed Connection:" + ex,"Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                 Finally{
    

    connect.Close();
}

    
                     




            }
        
        
        }

        private void cashierOrder_category_SelectedIndexChanged(object sender, EventArgs e)
        {

    cashierOrder_prodID.SelectedIndex = -1;
    cashierOrder_prodID.Items.Clear();
    cashierOrder_prodName.Text = "";
    cashierOrder_price.Text = "";
    cashierOrder_qty.Value= 0;

    string selectedValue = cashierOrder_category.SelectedItem as string;


    if (selectedValue != null) {


        if (checkConnection())
        {
            try
            {
                connect.Open();
                string selectData = $"SELECT * FROM products WHERE category ='{selectedValue}' AND status=@status";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {

                    cmd.Parameters.AddWithValue("@status", "Available");
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string value = reader["prod_id"].ToString();
                            cashierOrder_prodID.Items.Add(value)
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed Connection:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {

                connect.Close();
            }

        }
        
    
    
    
    }



}

PrivateKeyStatus void cashierOrder_prodID_SelectedIndexChanged(object sender , EventArgs e){
    
string selectedValue = cashierOrder_prodID.SelectedItem as string;

if(checkConnection())
{

    if(selectedValue!=null)
    {

        try
        {
            Connect.Open();
            string selectData = $"SELECT * FROM products WHERE prod_id='{selectedValue}' AND status=@status";
            using (SqlCommand cmd = new SqlCommand(selectData,connect))
            {
                cmd.Parameters.AddWithValue("@status", "Ävaliable");
                using (SqlDataAdapter reader=cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        string prodName = reader["prod_name"].Tostring();
                        string prodPrice =Convert.ToSingle(reader["price"]);

                        cashierOrder_prodName.Text= prodName;
                        cashierOrder_price.Text= prodPrice.ToString("0.00");

                    }
                }
            }
        }catch(Exception ex)
        {
            MessageBox.Show("Failed Connection:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            Connect.Close();

        }
    }
}

}


private void cashierOrder_addBtn_Click(object sender, EventArgs e)
{
IDGenerator();

    
if (cashierOrder_category.SelectedIndex == -1 || cashierOrder_prodID.SelectedIndex == -1
   || cashierOrder_prodName.Text == "" || cashierOrder_price.Text == "" || cashierOrder_qty.Value == 0)
    {
        MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    else
    {
        if (checkConnection())
        {
            try
            {
                connect.Open();

                float getPrice = 0;
                string selectOrder = "SELECT * FROM products WHERE prod_id=@prodID";
                using (SqlCommand getOrder = new SqlCommand(selectOrder, connect))
                {
                    getOrder.Parameters.AddWithValue("@prodID", cashierOrder_prodID.SelectedItem);

                    using (SqlDataReader reader = getOrder.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            object rawValue = reader["price"];

                            if (rawValue != DBNull.Value)
                            {
                                getPrice = Convert.ToSingle(rawValue);
                            }
                        }
                    }
                }

                string insertData = "INSERT INTO orders (customer_id, prod_id, prod_name, category, qty, orig_price, total_price, order_date) " +
                    "VALUES(@ID, @prodID, @prodName, @cat, @qty, @origPrice, @totalprice, @date)";

                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                {
                    cmd.Parameters.AddWithValue("@ID", idGen);
                    cmd.Parameters.AddWithValue("@prodID", cashierOrder_prodID.SelectedItem);
                    cmd.Parameters.AddWithValue("@prodName", cashierOrder_prodName.Text.Trim());
                    cmd.Parameters.AddWithValue("@cat", cashierOrder_category.SelectedItem);
                    cmd.Parameters.AddWithValue("@qty", cashierOrder_qty.Value);
                    cmd.Parameters.AddWithValue("@origPrice", getPrice);

                    float totalP = (getPrice * (int)cashierOrder_qty.Value);

                    cmd.Parameters.AddWithValue("@totalprice", totalP);

                    DateTime today = DateTime.Today;
                    cmd.Parameters.AddWithValue("@date", today);

                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed connection: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }
    }


}

Private int idGen;

public void IDGenerator()
{
    using (SqlConnection connect = new SqlConnection(@"Data Source=PIYUMAL\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;Encrypt=False");)
   {
        Connect.Open();
        ```
string selectData = "SELECT MAX(customer_id) FROM customers";

        using (SqlCommand cmd = new SqlCommand(selectData, connect))
        {
            object result = cmd.ExecuteScalar();

            if (result != DBNull.Value)
            {
                int temp = Convert.ToInt32(result);

                if (temp == 0)
                {
                    idGen = 1;
                }
                else
                {
                    idGen = temp + 1;
                }
            }
            else
            {
                IDGen = 1;
            }
        }

    }

}


    }
}
