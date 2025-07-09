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
    public partial class CashierMainForm : Form
    {
        public CashierMainForm()
        {
            InitializeComponent();
            //displayUsername();
        }

        //public void displayUsername()
        //{
            
        //    string username = Form1.username.Substring(0, 1).ToUpper() + Form1.username.Substring(1);
        //    user_username.Text = username;
        //}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminDashborad1.Visible = false;
            adminAddProducts1.Visible = false;
            cashierCustomersForm1.Visible = false;
            cashierOrder1.Visible = true;

            CashierOrder coForm = cashierOrder1 as CashierOrder;

            if (coForm != null)
            {
                coForm.refreshData();
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                //string username = Form1.username.Substring(0, 1).ToUpper() + Form1.username.Substring(1);
                //user_username.Text = username;

                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
        }

        private void adminDashborad1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cashierOrder1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            adminDashborad1.Visible = false;
            adminAddProducts1.Visible = false;
            cashierCustomersForm1.Visible = true;
            cashierOrder1.Visible = false;

            CashierCustomersForm ccfForm = cashierCustomersForm1 as CashierCustomersForm;

            if (ccfForm != null)
            {
                ccfForm.refreshData();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminDashborad1.Visible = true;
            adminAddProducts1.Visible = false;
            cashierCustomersForm1.Visible = false;
            cashierOrder1.Visible = false;

            AdminDashborad adForm = adminDashborad1 as AdminDashborad;

            if (adForm != null)
            {
                adForm.refreshData();
            }
        }

        private void addProducts_btn_Click(object sender, EventArgs e)
        {
            adminDashborad1.Visible = false;
            adminAddProducts1.Visible = true;
            cashierCustomersForm1.Visible = false;
            cashierOrder1.Visible = false;

            AdminAddProducts aapForm = adminAddProducts1 as AdminAddProducts;

            if (aapForm != null)
            {
                aapForm.refreshData();
            }
        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
