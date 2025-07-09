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
using Microsoft.Reporting.WinForms;


namespace InventoryManagementSystem
{
    public partial class StockReport : Form
    {
        public StockReport()
        {
            InitializeComponent();
        }
        private string connect = @"Data Source=DESKTOP-RN2T9CM\SQLEXPRESS;Initial Catalog=Inventory_managment;Integrated Security=True;Encrypt=False";
        public class CategoryProductCount
        {
            public string Catogary { get; set; }
            public int NoOfProducts { get; set; }
        }

        private List<CategoryProductCount> GetProductCategoryData()
        {
            var list = new List<CategoryProductCount>();

            using (var conn = new SqlConnection(connect))
            {
                conn.Open();
                string query = "SELECT category AS Catogary, COUNT(*) AS NoOfProducts FROM products GROUP BY category";

                using (var cmd = new SqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new CategoryProductCount
                        {
                            Catogary = reader.GetString(0),
                            NoOfProducts = reader.GetInt32(1)
                        });
                    }
                }
            }

            return list;
        }



        private void StockReport_Load(object sender, EventArgs e)
        {
            var reportViewer = new ReportViewer
            {
                Dock = DockStyle.Fill,
                ProcessingMode = ProcessingMode.Local
            };

            this.Controls.Add(reportViewer);

            // Set the path to your RDLC file
            reportViewer.LocalReport.ReportPath = "C:\\Users\\User\\Desktop\\New folder (3)\\New folder\\Inventory-management-system\\Inventory-management-system\\InventoryManagementSystem\\InventoryManagementSystem\\CategoryStockReport.rdlc";

            // Clear existing data sources
            reportViewer.LocalReport.DataSources.Clear();

            // Add your product category data source
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", GetProductCategoryData()));

            reportViewer.RefreshReport();


        }
    }
}


//namespace InventoryManagementSystem
//{ 
//public partial class StockReport : Form
//{
//    public StockReport()
//    {
//        InitializeComponent();
//    }

//    private void StockReport_Load(object sender, EventArgs e)
//    {
//        ReportViewer reportViewer = new ReportViewer
//        {
//            Dock = DockStyle.Fill,
//            ProcessingMode = ProcessingMode.Local
//        };

//        this.Controls.Add(reportViewer);

//        var data = GetProductCategoryData();
//        MessageBox.Show("Data count: " + data.Count); // TEMP debug

//        reportViewer.LocalReport.ReportPath = @"C:\Users\User\Desktop\New folder (3)\New folder\Inventory-management-system\Inventory-management-system\InventoryManagementSystem\InventoryManagementSystem\CategoryStockReport.rdlc";
//        reportViewer.LocalReport.DataSources.Clear();
//        reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", data));
//        reportViewer.RefreshReport();
//    }

//    private List<CategoryProductCount> GetProductCategoryData()
//    {
//        var list = new List<CategoryProductCount>();
//        using (var conn = new SqlConnection("your_connection_stringstring connect = @\"Data Source=DESKTOP-RN2T9CM\\SQLEXPRESS;Initial Catalog=Inventory_managment;Integrated Security=True;Encrypt=False\";"))
//        {
//            conn.Open();
//            var cmd = new SqlCommand("SELECT category AS Catogary, COUNT(*) AS NoOfProducts FROM products GROUP BY category", conn);
//            var reader = cmd.ExecuteReader();
//            while (reader.Read())
//            {
//                list.Add(new CategoryProductCount
//                {
//                    Catogary = reader.GetString(0),
//                    NoOfProducts = reader.GetInt32(1)
//                });
//            }
//        }
//        return list;
//    }

//    public class CategoryProductCount
//    {
//        public string Catogary { get; set; }
//        public int NoOfProducts { get; set; }
//    }
//}
//}
