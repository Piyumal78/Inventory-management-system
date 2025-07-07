using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace InventoryManagementSystem
{
    public partial class AdminAddProducts : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=PIYUMAL\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;Encrypt=False");
        public AdminAddProducts()
        {
            InitializeComponent();
            displayCategories();
            displayAllProducts();
        }


        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayCategories();
            displayAllProducts();
        }
        public void displayAllProducts()
        {
            AddProductsData apData = new AddProductsData();
            List<AddProductsData> listData = apData.AllProductsData();

            DataGridView1.DataSource = listData;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public bool checkEmtyFields()
        {
            if (addProducts_prodID.Text == "" || addProducts_prodName.Text == "" || addProducts_category.SelectedIndex == -1
                 || addProducts_price.Text == "" || addProducts_stock.Text == "" || addProducts_status.SelectedIndex == -1
                 || addProducts_imageView.Image == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void displayCategories()
        {

            if (checkConnection())
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT * FROM categories";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        addProducts_category.Items.Clear();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                addProducts_category.Items.Add(reader["category"].ToString());
                            }
                        }

                    }
                }




                catch (Exception ex)
                {
                    MessageBox.Show("Error loading categories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void addProducts_addBtn_Click(object sender, EventArgs e)
        {
            if (checkEmtyFields())
            {
                MessageBox.Show("Empty fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        string selectData = "SELECT * FROM products WHERE prod_id = @productID";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@productID", addProducts_prodID.Text.Trim());
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show("Product ID: " + addProducts_prodID.Text.Trim() + " is already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {

                                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                                string relativePath = @"..\..\..\images\products\" + addProducts_prodID.Text.Trim() + ".jpg";

                                string path = Path.Combine(baseDirectory, relativePath);

                                string directory = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directory))
                                {
                                    Directory.CreateDirectory(directory);
                                }

                                File.Copy(addProducts_imageView.ImageLocation, path, true);

                                string insertData = @"INSERT INTO products 
                                  (prod_id, prod_name, category, price, stock, image_path, status, date_insert)
                                   VALUES 
                                (@prodID, @prodName, @cat, @price, @stock, @path, @status, @date)";

                                using (SqlCommand insertCmd = new SqlCommand(insertData, connect))
                                {
                                    insertCmd.Parameters.AddWithValue("@prodID", addProducts_prodID.Text.Trim());
                                    insertCmd.Parameters.AddWithValue("@prodName", addProducts_prodName.Text.Trim());
                                    insertCmd.Parameters.AddWithValue("@cat", addProducts_category.SelectedItem.ToString());
                                    insertCmd.Parameters.AddWithValue("@price", Convert.ToDecimal(addProducts_price.Text.Trim()));
                                    insertCmd.Parameters.AddWithValue("@stock", Convert.ToInt32(addProducts_stock.Text.Trim()));
                                    insertCmd.Parameters.AddWithValue("@path", path);
                                    insertCmd.Parameters.AddWithValue("@status", addProducts_status.SelectedItem.ToString());



                                    DateTime today = DateTime.Today;
                                    insertCmd.Parameters.AddWithValue("@date", today);

                                    connect.Open();
                                    insertCmd.ExecuteNonQuery();
                                    clearFields();
                                    displayAllProducts();

                                    connect.Close();
                                    MessageBox.Show("Product added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Database connection error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        public bool checkConnection()
        {
            if (connect.State != ConnectionState.Open)
            {

                return true;

            }
            else
            {
                return false;
            }
        }

        private void addProducts_importBtn_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files(*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                string imagePath = "";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    addProducts_imageView.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void clearFields()
        {
            addProducts_prodID.Text = "";
            addProducts_prodName.Text = "";
            addProducts_category.SelectedIndex = -1;
            addProducts_price.Text = "";
            addProducts_stock.Text = "";
            addProducts_status.SelectedIndex = -1;
            addProducts_imageView.Image = null;
            getID = 0; // Reset the ID for new entries
        }
        private void addProducts_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }
        private int getID = 0;
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = DataGridView1.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;

                addProducts_prodID.Text = row.Cells[1].Value.ToString();
                addProducts_prodName.Text = row.Cells[2].Value.ToString();
                addProducts_category.SelectedItem = row.Cells[3].Value.ToString();
                addProducts_price.Text = row.Cells[4].Value.ToString();
                addProducts_stock.Text = row.Cells[5].Value.ToString();

                string imagepath = row.Cells[6].Value.ToString();
                try
                {
                    if (imagepath != null)
                    {
                        addProducts_imageView.Image = Image.FromFile(imagepath);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                addProducts_status.SelectedItem = row.Cells[7].Value.ToString();

            }
        }

        private void addProducts_updateBtn_Click(object sender, EventArgs e)
        {
            if (checkEmtyFields())
            {
                MessageBox.Show("Empty fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (MessageBox.Show("Are you sure you want to update Product ID: " + addProducts_prodID.Text.Trim() + "?",
             "Confirmation Message",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    if (!checkConnection())
                    {

                        try
                        {
                            connect.Open();

                            //string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                            string updateData = "UPDATE products SET prod_id=@prodID,prod_name = @prodName" +
                               ", category = @cat, price = @price, stock = @stock,status = @status WHERE id = @id";

                            using (SqlCommand updateCmd = new SqlCommand(updateData, connect))
                            {
                                updateCmd.Parameters.AddWithValue("@prodID", addProducts_prodID.Text.Trim());
                                updateCmd.Parameters.AddWithValue("@prodName", addProducts_prodName.Text.Trim());
                                updateCmd.Parameters.AddWithValue("@cat", addProducts_category.SelectedItem);
                                updateCmd.Parameters.AddWithValue("@price", addProducts_price.Text.Trim());
                                updateCmd.Parameters.AddWithValue("@stock", addProducts_stock.Text.Trim());
                                updateCmd.Parameters.AddWithValue("@status", addProducts_status.SelectedItem);
                                updateCmd.Parameters.AddWithValue("@id", getID);

                                //string relativePath = @"..\..\..\images\products\" + addProducts_prodID.Text.Trim() + ".jpg";
                                //string path = Path.Combine(baseDirectory, relativePath);
                                //string directoryPath = Path.GetDirectoryName(path);


                                //if (!Directory.Exists(directoryPath))
                                //{
                                //    Directory.CreateDirectory(directoryPath);
                                //}
                                //if (addProducts_imageView.Image != null)
                                //{
                                //    File.Copy(addProducts_imageView.Image.Dispose();
                                //}
                                //if (File.Exists(path))
                                //{
                                //    try
                                //    {
                                //        using (FileStream fs = new FileStream(path, File.Open.FileAccess.ReadWrite, FileShare.None))
                                //        {

                                //        }
                                //        File.Delete(path);
                                //    }
                                //    catch (IOException ex)
                                //    {
                                //        MessageBox.Show("Error saving image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                //        return;
                                //    }
                                //}

                                //updateCmd.Parameters.AddWithValue("@path", path);




                                updateCmd.ExecuteNonQuery();

                                clearFields();
                                displayAllProducts();


                                MessageBox.Show("Product updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            }
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show("Error updating product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }

            }
        }

        private void addProducts_removeBtn_Click(object sender, EventArgs e)
        {
            if (checkEmtyFields())
            {
                MessageBox.Show("Empty fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Delete Product ID: " + addProducts_prodID.Text.Trim() + "?",
                     "Confirmation Message",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    if (!checkConnection())
                    {

                        try
                        {
                            if (connect.State != ConnectionState.Open)
                            {
                                connect.Open();

                                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                                string deleteData = "DELETE FROM products WHERE id=@id";

                                using (SqlCommand deleteCmd = new SqlCommand(deleteData, connect))
                                {

                                    deleteCmd.Parameters.AddWithValue("@id", getID);


                                    deleteCmd.ExecuteNonQuery();

                                    clearFields();
                                    displayAllProducts();


                                    MessageBox.Show(" Delete successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error updating product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }

            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
