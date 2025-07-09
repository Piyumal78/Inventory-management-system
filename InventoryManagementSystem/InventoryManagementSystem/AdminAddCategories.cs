using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class AdminAddCategories : UserControl
    {
        // Connection string to the database
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-RN2T9CM\SQLEXPRESS;Initial Catalog=Inventory_managment;Integrated Security=True");

        public AdminAddCategories()
        {
            InitializeComponent();
            displayAllCategoriesData();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            
            displayAllCategoriesData();
        }

        public void displayAllCategoriesData()
        {
            try
            {
                CategoriesData cData = new CategoriesData();
                dataGridView1.DataSource = cData.AllCategoriesData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading category data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addCategories_addBtn_Click(object sender, EventArgs e)
        {
            if (addCategories_addBtn.Text == "")
            {
                MessageBox.Show("Please enter a category name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        string checkCat = "SELECT * FROM categories WHERE category = @cat";

                        using (SqlCommand cmd = new SqlCommand(checkCat, connect))
                        {
                            cmd.Parameters.AddWithValue("@cat", addCategories_category.Text.Trim());
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show("Category already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertCat = "INSERT INTO categories (category, date) VALUES (@cat, @date)";
                                using (SqlCommand insertCmd = new SqlCommand(insertCat, connect))
                                {
                                    insertCmd.Parameters.AddWithValue("@cat", addCategories_category.Text.Trim());
                                    insertCmd.Parameters.AddWithValue("@date", DateTime.Today);

                                    insertCmd.ExecuteNonQuery();
                                    clearFields();  // Clear the input fields after successful insertion
                                    displayAllCategoriesData();
                                    MessageBox.Show("Category added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (connect.State == ConnectionState.Open)
                        {
                            connect.Close();
                        }
                    }
                }
            }
        }


        public bool checkConnection()
        {
            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();  // connection opened here
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void clearFields()
        {
            addCategories_category.Text = "";

        }
        private void addCategories_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }
        private int getID = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                getID = Convert.ToInt32(row.Cells[0].Value); // Assuming the first column is the ID
                addCategories_category.Text = row.Cells[1].Value.ToString(); // Assuming the second column is the category name

            }

        }

        private void addCategories_updateBtn_Click(object sender, EventArgs e)
        {
            if (addCategories_category.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a category name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MessageBox.Show("Are you sure want to Update Cat ID:" + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            string updateData = "UPDATE categories SET category = @cat WHERE id=@id";
                            using (SqlCommand updateCmd = new SqlCommand(updateData, connect))
                            {
                                updateCmd.Parameters.AddWithValue("@cat", addCategories_category.Text.Trim());
                                updateCmd.Parameters.AddWithValue("@id", getID);

                                updateCmd.ExecuteNonQuery();
                                clearFields();  // Clear the input fields after successful update
                                displayAllCategoriesData();
                                MessageBox.Show("Category updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            if (connect.State == ConnectionState.Open)
                            {
                                connect.Close();
                            }
                        }
                    }
                }
            }
        }

        private void addCategories_removeBtn_Click(object sender, EventArgs e)
        {
            if (addCategories_category.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a category name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MessageBox.Show("Are you sure want to Remove Cat ID:" + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {

                            string removeData = "DELETE FROM categories WHERE id=@id ";
                            using (SqlCommand deleteCmd = new SqlCommand(removeData, connect))
                            {

                                deleteCmd.Parameters.AddWithValue("@id", getID);

                                deleteCmd.ExecuteNonQuery();
                                clearFields();  // Clear the input fields after successful insertion
                                displayAllCategoriesData();
                                MessageBox.Show("Category Removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            if (connect.State == ConnectionState.Open)
                            {
                                connect.Close();
                            }
                        }
                    }

                }
            }
        }

        private void AdminAddCategories_Load(object sender, EventArgs e)
        {

        }
    }
}