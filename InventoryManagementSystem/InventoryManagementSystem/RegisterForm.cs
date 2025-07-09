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
    public partial class RegisterForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-RN2T9CM\SQLEXPRESS;Initial Catalog=Inventory_managment;Integrated Security=True");

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrWhiteSpace(register_username.Text) ||
                string.IsNullOrWhiteSpace(register_password.Text) ||
                string.IsNullOrWhiteSpace(register_cPassword.Text))
            {
                MessageBox.Show("Please fill all empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate password length
            if (register_password.Text.Length < 8)
            {
                MessageBox.Show("Invalid Password, at least 8 characters are needed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate password match
            if (register_password.Text.Trim() != register_cPassword.Text.Trim())
            {
                MessageBox.Show("Password does not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Proceed with registration
            RegisterUser();
        }

        private void RegisterUser()
        {
            if (checkconnection())
            {
                try
                {
                    connect.Open();

                    // Check if username already exists
                    string checkUsername = "SELECT COUNT(*) FROM users WHERE username = @usern";
                    using (SqlCommand cmd = new SqlCommand(checkUsername, connect))
                    {
                        cmd.Parameters.AddWithValue("@usern", register_username.Text.Trim());

                        int userCount = (int)cmd.ExecuteScalar();

                        if (userCount > 0)
                        {
                            MessageBox.Show(register_username.Text.Trim() + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Insert new user - FIXED: Corrected SQL syntax
                    string insertData = "INSERT INTO users (username, password, role, status, date) VALUES (@usern, @pass, @role, @status, @date)";
                    using (SqlCommand insertD = new SqlCommand(insertData, connect))
                    {
                        insertD.Parameters.AddWithValue("@usern", register_username.Text.Trim());
                        insertD.Parameters.AddWithValue("@pass", register_password.Text.Trim());
                        insertD.Parameters.AddWithValue("@role", "Cashier");
                        insertD.Parameters.AddWithValue("@status", "Approval");
                        insertD.Parameters.AddWithValue("@date", DateTime.Today);

                        int rowsAffected = insertD.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Clear form fields
                            ClearFields();

                            // Navigate to login form
                            Form1 loginForm = new Form1();
                            loginForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Registration failed. Please try again.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("Database error: " + sqlEx.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connect.State == ConnectionState.Open)
                        connect.Close();
                }
            }
            else
            {
                MessageBox.Show("Database connection is already open. Please try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearFields()
        {
            register_username.Text = "";
            register_password.Text = "";
            register_cPassword.Text = "";
            register_showPass.Checked = false;
        }

        public bool checkconnection()
        {
            return connect.State == ConnectionState.Closed;
        }

        private void login_lable_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // Initialize form settings
            register_password.PasswordChar = '*';
            register_cPassword.PasswordChar = '*';
        }

        private void register_showPass_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showPass.Checked ? '\0' : '*';
            register_cPassword.PasswordChar = register_showPass.Checked ? '\0' : '*';
        }

        // Additional validation method
        private bool ValidateInput()
        {
            // Username validation
            if (register_username.Text.Trim().Length < 3)
            {
                MessageBox.Show("Username must be at least 3 characters long", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Password strength validation (optional enhancement)
            string password = register_password.Text;
            if (!password.Any(char.IsDigit))
            {
                MessageBox.Show("Password must contain at least one number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Form closing event to ensure proper cleanup
        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connect != null && connect.State == ConnectionState.Open)
            {
                connect.Close();
            }
        }
    }
}