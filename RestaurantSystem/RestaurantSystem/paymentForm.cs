using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RestaurantSystem
{
    public partial class paymentForm : Form
    {
        private static string ConnectionString = "Data Source=DESKTOP-5P1UJGK\\SQLEXPRESS;Initial Catalog=RestaurantDBD;Integrated Security=True";
        private int orderId; 
        public paymentForm(int orderId)
        {
            InitializeComponent();
            this.orderId = orderId;  
        }

        private void paymentForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open(); 
                string query = "SELECT OrderID, TotalAmount FROM Orders WHERE OrderID = @id";
                using (SqlCommand s1 = new SqlCommand(query, conn))
                {
                    s1.Parameters.AddWithValue("@id", orderId);
                    using (SqlDataReader reader = s1.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            labelOrder.Text = "Order ID: " + reader["OrderID"].ToString();
                            labelTotal.Text = "Total: $" + reader["TotalAmount"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Order not found!");
                            this.Close();  
                        }
                    }
                }
            }
        }
         private void labelTotal_Click(object sender, EventArgs e)
        {

        }

        private void labelOrder_Click(object sender, EventArgs e)
        {

        }
        private void PaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void M_payment_Click(object sender, EventArgs e)
        {
            if (PaymentMethod.SelectedItem == null)
            {
                MessageBox.Show("Please select a payment method.");
                return;
            }

            string paymentMethod = PaymentMethod.SelectedItem.ToString();

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "UPDATE Orders SET PaymentStatus = 'Paid', PaymentMethod = @method WHERE OrderID = @id";
                
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@method", paymentMethod);
                    cmd.Parameters.AddWithValue("@id", orderId);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Payment Successful!");
            this.Close();

        }

    }
}


