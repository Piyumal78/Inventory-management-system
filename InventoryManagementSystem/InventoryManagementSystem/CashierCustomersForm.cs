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
    public partial class CashierCustomersForm : UserControl
    {
        public CashierCustomersForm()
        {
            InitializeComponent();
            displayAllCustomersData();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            
            displayAllCustomersData();
        }

        public void displayAllCustomersData()
        {
            try
            {
                CustomersData cData = new CustomersData();
                List<CustomersData> listData = cData.allTodayCustomers();
                dataGridView2.DataSource = listData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customer data: " + ex.Message);
            }
        }

       


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
