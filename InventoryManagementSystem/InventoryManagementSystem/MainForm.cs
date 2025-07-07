using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void sqlDataAdapter2_RowUpdated(object sender, Microsoft.Data.SqlClient.SqlRowUpdatedEventArgs e)
        {

        }

        private void panel3_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adminAddUser1_Load(object sender, EventArgs e)
        {

        }

        private void adminAddUser1_Load_1(object sender, EventArgs e)
        {

        }

        private void adminAddUser2_Load(object sender, EventArgs e)
        {

        }

        private void adminAddProducts1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminDashborad1.Visible = true;
            // adminAddUser.Visible = false;
            adminAddCategories1.Visible = false;
            adminAddProducts1.Visible = false;
            cashierCustomersForm1.Visible = false;


            AdminDashborad adForm = adminDashborad1 as AdminDashborad;

            if (adForm != null)
            {
                adForm.refreshData();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            adminDashborad1.Visible = false;
            // adminAddUser.Visible = true;
            adminAddCategories1.Visible = false;
            adminAddProducts1.Visible = false;
            cashierCustomersForm1.Visible = false;

            //AdminAddUsers aauForm = adminAddUser1 as AdminAddUsers;

            // if (aauForm != null)
            //{
            //    aauForm.refreshData();
            //}
        }

        private void button7_Click(object sender, EventArgs e)
        {
            adminDashborad1.Visible = false;
            // adminAddUser1.Visible = false;
            adminAddCategories1.Visible = false;
            adminAddProducts1.Visible = false;
            cashierCustomersForm1.Visible = false;


        }

        private void addCategories_btn_Click(object sender, EventArgs e)
        {
            adminDashborad1.Visible = false;
            //adminAddUser1.Visible = false;
            adminAddCategories1.Visible = true;
            adminAddProducts1.Visible = false;
            cashierCustomersForm1.Visible = false;

            AdminAddCategories aacForm = adminAddCategories1 as AdminAddCategories;

            if (aacForm != null)
            {
                aacForm.refreshData();
            }
        }

        private void addProducts_btn_Click(object sender, EventArgs e)
        {
            adminDashborad1.Visible = false;
            //adminAddUser1.Visible = false;
            adminAddCategories1.Visible = false;
            adminAddProducts1.Visible = true;
            cashierCustomersForm1.Visible = false;

            AdminAddProducts aapForm = adminAddProducts1 as AdminAddProducts;

            if (aapForm != null)
            {
                aapForm.refreshData();
            }

        }

        private void customers_btn_Click(object sender, EventArgs e)
        {
            adminDashborad1.Visible = false;
            //adminAddUser1.Visible = false;
            adminAddCategories1.Visible = false;
            adminAddProducts1.Visible = false;
            cashierCustomersForm1.Visible = true;

            CashierCustomersForm ccfForm = cashierCustomersForm1 as CashierCustomersForm;

            if (ccfForm != null)
            {
                ccfForm.refreshData();
            }
        }

        private void adminAddUser1_Load_2(object sender, EventArgs e)
        {

        }

        private void adminAddUser1_Load_3(object sender, EventArgs e)
        {

        }
    }
}
