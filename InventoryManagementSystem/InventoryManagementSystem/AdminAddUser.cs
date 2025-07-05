using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class AdminAddUser : UserControl
    {
        private SqlConnection connect = new SqlConnection(@"Data Source=PIYUMAL\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;Encrypt=False");
        private int selectedUserId = 0;

        public AdminAddUser()
        {
            InitializeComponent();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                selectedUserId = Convert.ToInt32(row.Cells["ID"].Value);
                addUsers_username.Text = row.Cells["Username"].Value.ToString();
                addUsers_password.Text = row.Cells["Password"].Value.ToString();
                addUsers_role.SelectedItem = row.Cells["Role"].Value.ToString();
                addUsers_status.SelectedItem = row.Cells["Status"].Value.ToString();
            }
        }

        private void addUsers_updateBtn_Click(object sender, EventArgs e)
        {
            if (selectedUserId == 0)
            {
                MessageBox.Show("Please select a user to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                connect.Open();

                // Check if username exists (excluding current user)
                string checkUser = "SELECT COUNT(*) FROM users WHERE username = @username AND id != @id";
                using (SqlCommand cmd = new SqlCommand(checkUser, connect))
                {
                    cmd.Parameters.AddWithValue("@username", addUsers_username.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", selectedUserId);

                    int userCount = (int)cmd.ExecuteScalar();
                    if (userCount > 0)
                    {
                        MessageBox.Show("Username already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Update user
                string updateSql = @"UPDATE users SET username = @username, password = @password, 
                                   role = @role, status = @status, date = @date 
                                   WHERE id = @id";

                using (SqlCommand cmd = new SqlCommand(updateSql, connect))
                {
                    cmd.Parameters.AddWithValue("@username", addUsers_username.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", addUsers_password.Text.Trim());
                    cmd.Parameters.AddWithValue("@role", addUsers_role.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@status", addUsers_status.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@id", selectedUserId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void addUsers_removeBtn_Click(object sender, EventArgs e)
        {
            if (selectedUserId == 0)
            {
                MessageBox.Show("Please select a user to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this user?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void clearFields()
        {
            selectedUserId = 0;
            addUsers_username.Clear();
            addUsers_password.Clear();
            addUsers_role.SelectedIndex = -1;
            addUsers_status.SelectedIndex = -1;
        }

        private void addUsers_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}