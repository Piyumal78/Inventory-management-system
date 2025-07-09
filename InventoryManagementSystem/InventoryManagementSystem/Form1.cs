using System.Data;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    public partial class Form1 : Form
    {

        public static string username;
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-RN2T9CM\SQLEXPRESS;Initial Catalog=Inventory_managment;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_lable_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }
        public bool checkconnection()
        {
            if (connect.State == ConnectionState.Closed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //private void login_btn_Click(object sender, EventArgs e)
        //{
        //    if (login_username.Text == "" || login_password.Text == "")
        //    {
        //        MessageBox.Show("Please fill in both username and password.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    if (checkconnection())
        //    {
        //        try
        //        {
        //            connect.Open();
        //            string checkUsername = "SELECT COUNT(*)  FROM users WHERE username=@usern AND password=@pass  ";
        //            using (SqlCommand cmd = new SqlCommand(checkUsername, connect))
        //            {
        //                cmd.Parameters.AddWithValue("@usern", login_username.Text.Trim());
        //                cmd.Parameters.AddWithValue("@pass", login_password.Text.Trim());
        //                cmd.Parameters.AddWithValue("@status", "Active");

        //                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //                DataTable table = new DataTable();
        //                adapter.Fill(table);


        //                int rowCount = (int)cmd.ExecuteScalar();
        //                if (table.Rows.Count > 0)

        //                {
        //                    string seletRole = "SELECT role FROM users WHERE username=@usern AND password=@pass";

        //                    MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //                    using (SqlCommand getRole = new SqlCommand(seletRole, connect))
        //                    {
        //                        {
        //                            getRole.Parameters.AddWithValue("@usern", login_username.Text.Trim());
        //                            getRole.Parameters.AddWithValue("@pass", login_password.Text.Trim());
        //                            string userRole = getRole.ExecuteScalar() as string;

        //                            MessageBox.Show("Welcome " + userRole, "Role Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //                            if (userRole == "Admin")
        //                            {
        //                                MainForm mForm = new MainForm();
        //                                // Redirect to the Admin Dashboard
        //                                mForm.Show();
        //                                this.Hide();
        //                            }
        //                            else if (userRole == "Cashier")
        //                            {
        //                                // Redirect to the Cashier Dashboard
        //                                CashierMainForm cashierMainForm = new CashierMainForm();
        //                                cashierMainForm.Show();
        //                                this.Hide();
        //                            }
        //                        }
        //                        // Redirect to the main application form
        //                        MainForm mainForm = new MainForm();
        //                        mainForm.Show();
        //                        this.Hide();
        //                    }
        //                }


        //                else
        //                {
        //                    MessageBox.Show("Invalid Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                }

        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        finally
        //        {
        //            connect.Close();
        //        }
        //    }
        //}

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (login_username.Text == "" || login_password.Text == "")
            {
                MessageBox.Show("Please fill in both username and password.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                string query = "SELECT role FROM users WHERE username = @usern AND password = @pass AND status = 'Active'";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", login_password.Text.Trim());

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string userRole = result.ToString();

                        MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show("Welcome " + userRole, "Role Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (userRole == "Admin")
                        {
                            MainForm mForm = new MainForm();
                            mForm.Show();
                            this.Hide();
                        }
                        else if (userRole == "Cashier")
                        {
                            CashierMainForm cashierMainForm = new CashierMainForm();
                            cashierMainForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Unknown user role: " + userRole, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
