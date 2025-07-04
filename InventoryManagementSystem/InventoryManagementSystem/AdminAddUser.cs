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
    public partial class AdminAddUser : UserControl
    {
        public AdminAddUser()
        {
            InitializeComponent();
            displayAllUsersData();
        }

        SqlConnection connect = new SqlConnection(@"Data Source=PIYUMAL\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;Encrypt=False");

        public void displayAllUsersData()
        {
            UserData uData = new UserData();
            List<UserData> listData = uData.AllUsersData();
            dataGridView1.DataSource = listData;
        }

        private void addUsers_addBtn_Click(object sender, EventArgs e)
        {
            if (addUsers_username.Text == "" || addUsers_password.Text == "" || addUsers_role.SelectedIndex == -1
                || addUsers_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkconnection())
                {
                    try
                    {
                        connect.Open();
                        string checkUsername = "SELECT * FROM users WHERE username=@usern";
                        using (SqlCommand cmd = new SqlCommand(checkUsername, connect))
                        {
                            cmd.Parameters.AddWithValue("@usern", addUsers_username.Text.Trim());
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(addUsers_username.Text.Trim() + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (addUsers_password.Text.Length < 8)
                            {
                                MessageBox.Show("Invalid Password, at least 8 characters are needed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO users(username,password,role,status,date)" +
                                    "VALUES(@usern,@pass,@role,@status,@date)";
                                using (SqlCommand insertCmd = new SqlCommand(insertData, connect))
                                {
                                    insertCmd.Parameters.AddWithValue("@usern", addUsers_username.Text.Trim());
                                    insertCmd.Parameters.AddWithValue("@pass", addUsers_password.Text.Trim());
                                    insertCmd.Parameters.AddWithValue("@role", addUsers_role.SelectedItem.ToString());
                                    insertCmd.Parameters.AddWithValue("@status", addUsers_status.SelectedItem.ToString());
                                    insertCmd.Parameters.AddWithValue("@date", DateTime.Now);

                                    int rowsAffected = insertCmd.ExecuteNonQuery();
                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        clearFields();
                                        displayAllUsersData();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Failed to add user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        public bool checkconnection()
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
                return true;
            }
            else
            {
                return false;
            }
        }

        private void AdminAddUser_Load(object sender, EventArgs e)
        {
            // Optional initialization code can go here
        }

        public void clearFields()
        {
            addUsers_username.Text = "";
            addUsers_password.Text = "";
            addUsers_role.SelectedIndex = -1;
            addUsers_status.SelectedIndex = -1;
            getID = 0;
        }

        private void addUsers_updateBtn_Click(object sender, EventArgs e)
        {
            if (getID == 0)
            {
                MessageBox.Show("Please select a user to update", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (addUsers_username.Text == "" || addUsers_password.Text == "" || addUsers_role.SelectedIndex == -1
                  || addUsers_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to update this user?", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkconnection())
                    {
                        try
                        {
                            connect.Open();
                            string checkUsername = "SELECT * FROM users WHERE username=@usern AND id != @id";
                            using (SqlCommand cmd = new SqlCommand(checkUsername, connect))
                            {
                                cmd.Parameters.AddWithValue("@usern", addUsers_username.Text.Trim());
                                cmd.Parameters.AddWithValue("@id", getID);
                                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                                DataTable table = new DataTable();
                                adapter.Fill(table);

                                if (table.Rows.Count > 0)
                                {
                                    MessageBox.Show(addUsers_username.Text.Trim() + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else if (addUsers_password.Text.Length < 8)
                                {
                                    MessageBox.Show("Invalid Password, at least 8 characters are needed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    string updateData = "UPDATE users SET username=@usern, " +
                                        "password=@pass, role=@role, status=@status, date=@date WHERE id=@id";

                                    using (SqlCommand updateCmd = new SqlCommand(updateData, connect))
                                    {
                                        updateCmd.Parameters.AddWithValue("@usern", addUsers_username.Text.Trim());
                                        updateCmd.Parameters.AddWithValue("@pass", addUsers_password.Text.Trim());
                                        updateCmd.Parameters.AddWithValue("@role", addUsers_role.SelectedItem.ToString());
                                        updateCmd.Parameters.AddWithValue("@status", addUsers_status.SelectedItem.ToString());
                                        updateCmd.Parameters.AddWithValue("@date", DateTime.Now);
                                        updateCmd.Parameters.AddWithValue("@id", getID);

                                        int rowsAffected = updateCmd.ExecuteNonQuery();
                                        if (rowsAffected > 0)
                                        {
                                            MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            clearFields();
                                            displayAllUsersData();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Failed to update user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
            }
        }

        private int getID = 0;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = Convert.ToInt32(row.Cells[0].Value);
                addUsers_username.Text = row.Cells[1].Value.ToString();
                addUsers_password.Text = row.Cells[2].Value.ToString();
                addUsers_role.SelectedItem = row.Cells[3].Value.ToString();
                addUsers_status.SelectedItem = row.Cells[4].Value.ToString();
            }
        }

        private void addUsers_removeBtn_Click(object sender, EventArgs e)
        {
            if (getID == 0)
            {
                MessageBox.Show("Please select a user to delete", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this user?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (checkconnection())
                {
                    try
                    {
                        connect.Open();
                        string deleteData = "DELETE FROM users WHERE id=@id";
                        using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", getID);
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearFields();
                                displayAllUsersData();
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void addUsers_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}