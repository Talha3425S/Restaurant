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

namespace RestaurantSystem
{
    public partial class Form1 : Form
    {
        private static string ConnectionString = "Data Source=DESKTOP-5P1UJGK\\SQLEXPRESS;Initial Catalog=RestaurantDBD;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void M_Admin_Click(object sender, EventArgs e)
        {
            adminForm a1 = new adminForm();
            a1.Show();
        }

        private void C_Customer_Click(object sender, EventArgs e)
        {
            customerForm c1 = new customerForm();
            c1.Show();
        }

        private void O_Order_Click(object sender, EventArgs e)
        {
            orderForm o1 = new orderForm();
            o1.Show();
        }

        private void P_Payment_Click(object sender, EventArgs e)
        {
            int orderId = GetLatestOrderId();  
            if (orderId == 0)
            {
                MessageBox.Show("No active order found. Please create an order first." );
                return;
            }

            paymentForm p1 = new paymentForm(orderId);
            p1.Show();
        }

        private int GetLatestOrderId()
        {
            using (SqlConnection connect = new SqlConnection(ConnectionString))
            {
                connect.Open();
                string Getquery = "SELECT TOP 1 OrderID FROM Orders ORDER BY OrderID DESC";
                SqlCommand s1 = new SqlCommand(Getquery, connect);
                object result = s1.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;  
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}