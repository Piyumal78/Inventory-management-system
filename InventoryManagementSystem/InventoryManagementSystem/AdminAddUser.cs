using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class AdminAddUser : UserControl
    {

        private SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-RN2T9CM\SQLEXPRESS;Initial Catalog=Inventory_managment;Integrated Security=True");

        private int selectedUserId = 0;

        public AdminAddUser()
        {
            InitializeComponent();
            displayAllUsersData();
            //dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            //dataGridView1.CellClick += dataGridView1_CellContentClick; // reuse same logic

        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayAllUsersData();
        }
        public void displayAllUsersData()
        {
            try
            {
                UserData uData = new UserData();
                dataGridView1.DataSource = uData.AllUsersData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addUsers_addBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addUsers_username.Text) ||
                string.IsNullOrWhiteSpace(addUsers_password.Text) ||
                addUsers_role.SelectedIndex == -1 ||
                addUsers_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (addUsers_password.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                connect.Open();

                // Check if username exists
                string checkUser = "SELECT COUNT(*) FROM users WHERE username = @username";
                using (SqlCommand cmd = new SqlCommand(checkUser, connect))
                {
                    cmd.Parameters.AddWithValue("@username", addUsers_username.Text.Trim());
                    int userCount = (int)cmd.ExecuteScalar();

                    if (userCount > 0)
                    {
                        MessageBox.Show("Username already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Insert new user
                string insertSql = @"INSERT INTO users (username, password, role, status, date) 
                                   VALUES (@username, @password, @role, @status, @date)";

                using (SqlCommand cmd = new SqlCommand(insertSql, connect))
                {
                    cmd.Parameters.AddWithValue("@username", addUsers_username.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", addUsers_password.Text.Trim());
                    cmd.Parameters.AddWithValue("@role", addUsers_role.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@status", addUsers_status.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearFields();
                        displayAllUsersData();
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
                    connect.Close();
            }
        }
        private int getId = 0;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            //    // Use column index instead of column name
            //    selectedUserId = Convert.ToInt32(row.Cells[0].Value); // 0 = ID column

            //    addUsers_username.Text = row.Cells[1].Value.ToString();
            //    addUsers_password.Text = row.Cells[2].Value.ToString();
            //    addUsers_role.SelectedItem = row.Cells[3].Value.ToString();
            //    addUsers_status.SelectedItem = row.Cells[4].Value.ToString();
            //}
        }

        private void addUsers_updateBtn_Click(object sender, EventArgs e)
        {
            if (selectedUserId == 0)
            {
                MessageBox.Show("Please select a user to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate inputs
            if (string.IsNullOrWhiteSpace(addUsers_username.Text) ||
                string.IsNullOrWhiteSpace(addUsers_password.Text) ||
                addUsers_role.SelectedItem == null ||
                addUsers_status.SelectedItem == null)
            {
                MessageBox.Show("All fields are required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Are you sure you want to update User ID: {selectedUserId}?",
                                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    connect.Open();

                    // Check if username exists for another user
                    string checkUser = "SELECT COUNT(*) FROM users WHERE username = @username AND id != @id";
                    using (SqlCommand cmd = new SqlCommand(checkUser, connect))
                    {
                        cmd.Parameters.AddWithValue("@username", addUsers_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@id", selectedUserId);

                        int count = (int)cmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Username already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string updateData = @"UPDATE users 
                      SET username = @username, password = @password, 
                          role = @role, status = @status
                      WHERE id = @id";


                    using (SqlCommand updateCmd = new SqlCommand(updateData, connect))
                    {
                        updateCmd.Parameters.AddWithValue("@username", addUsers_username.Text.Trim());
                        updateCmd.Parameters.AddWithValue("@password", addUsers_password.Text.Trim()); // 🔐 recommend hashing
                        updateCmd.Parameters.AddWithValue("@role", addUsers_role.SelectedItem.ToString());
                        updateCmd.Parameters.AddWithValue("@status", addUsers_status.SelectedItem.ToString());
                        updateCmd.Parameters.AddWithValue("@updated_at", DateTime.Now);
                        updateCmd.Parameters.AddWithValue("@id", selectedUserId);

                        updateCmd.ExecuteNonQuery();
                        MessageBox.Show("User updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        clearFields();
                        displayAllUsersData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        //private void addUsers_removeBtn_Click(object sender, EventArgs e)
        //{
        //    //if (selectedUserId == 0)
        //    //{
        //    //    MessageBox.Show("Please select a user to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    //    return;
        //    //}

        //    //if (MessageBox.Show($"Are you sure you want to delete User ID: {selectedUserId}?",
        //    //                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //    //{
        //    //    try
        //    //    {
        //    //        connect.Open();

        //    //        string deleteSql = "DELETE FROM users WHERE id = @id";
        //    //        using (SqlCommand cmd = new SqlCommand(deleteSql, connect))
        //    //        {
        //    //            cmd.Parameters.AddWithValue("@id", selectedUserId);

        //    //            int rowsAffected = cmd.ExecuteNonQuery();
        //    //            if (rowsAffected > 0)
        //    //            {
        //    //                MessageBox.Show("User deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    //                clearFields();
        //    //                displayAllUsersData();
        //    //            }
        //    //            else
        //    //            {
        //    //                MessageBox.Show("No user was deleted. Please try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    //            }
        //    //        }
        //    //    }
        //    //    catch (Exception ex)
        //    //    {
        //    //        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    //    }
        //    //    finally
        //    //    {
        //    //        if (connect.State == ConnectionState.Open)
        //    //            connect.Close();
        //    //    }
        //    //}
        //}

        private void clearFields()
        {
            selectedUserId = 0;
            addUsers_username.Clear();
            addUsers_password.Clear();
            addUsers_role.SelectedIndex = -1;
            addUsers_status.SelectedIndex = -1;
        }

        //private void addUsers_clearBtn_Click(object sender, EventArgs e)
        //{
        //    clearFields();
        //}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Use column index instead of column name
                selectedUserId = Convert.ToInt32(row.Cells[0].Value); // 0 = ID column

                addUsers_username.Text = row.Cells[1].Value.ToString();
                addUsers_password.Text = row.Cells[2].Value.ToString();
                addUsers_role.SelectedItem = row.Cells[3].Value.ToString();
                addUsers_status.SelectedItem = row.Cells[4].Value.ToString();
            }
        }

        private void AdminAddUser_Load(object sender, EventArgs e)
        {

        }

        private void addUsers_removeBtn_Click_1(object sender, EventArgs e)
        {
            if (selectedUserId == 0)
            {
                MessageBox.Show("Please select a user to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show($"Are you sure you want to delete User ID: {selectedUserId}?",
                                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    connect.Open();

                    string deleteSql = "DELETE FROM users WHERE id = @id";
                    using (SqlCommand cmd = new SqlCommand(deleteSql, connect))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedUserId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clearFields();
                            displayAllUsersData();
                        }
                        else
                        {
                            MessageBox.Show("No user was deleted. Please try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        connect.Close();
                }
            }
        }

        private void addUsers_clearBtn_Click_1(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}