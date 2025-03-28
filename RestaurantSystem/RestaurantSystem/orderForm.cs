using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RestaurantSystem
{
    public partial class orderForm : Form
    {
        private static string ConnectionString = "Data Source=DESKTOP-5P1UJGK\\SQLEXPRESS;Initial Catalog=RestaurantDBD;Integrated Security=True";
        private int currentOrderId = 1;

        public orderForm()
        {
            InitializeComponent();
        }

        private void orderForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(ConnectionString))
            {
                connect.Open();
                string SelectQuery = @"SELECT od.OrderDetailID, i.ItemName, od.Quantity, od.SubTotal 
                 FROM OrderDetails od
                 JOIN Items i ON od.ItemID = i.ItemID 
                 WHERE od.OrderID = @orderId";


                SqlDataAdapter da = new SqlDataAdapter(SelectQuery, connect);
                da.SelectCommand.Parameters.AddWithValue("@orderId", currentOrderId);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DisplaySelectedOrder.DataSource = dt;
            }
            UpdateTotalAmount();
        }

         
        private void DisplaySelectedOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
        }

        private void R_Order_Click(object sender, EventArgs e)
        {
            if (DisplaySelectedOrder.SelectedRows.Count > 0)
            {
                int orderDetailId = Convert.ToInt32(DisplaySelectedOrder.SelectedRows[0].Cells["OrderDetailID"].Value);

                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM OrderDetails WHERE OrderDetailID = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", orderDetailId);
                    cmd.ExecuteNonQuery();
                }

                 
                UpdateTotalAmount();
            }
            else
            {
                MessageBox.Show("Please select an order item to remove.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void C_Order_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(ConnectionString))
            {
                connect.Open();
                string UpdateQuery = "UPDATE Orders SET TotalAmount = (SELECT SUM(SubTotal) FROM OrderDetails WHERE OrderID = @orderId) WHERE OrderID = @orderId";
                SqlCommand s1 = new SqlCommand(UpdateQuery, connect);
                s1.Parameters.AddWithValue("@orderId", currentOrderId);
                s1.ExecuteNonQuery();
            }

            MessageBox.Show("Order Confirmed!");
             
            paymentForm p1 = new paymentForm(currentOrderId);
            p1.ShowDialog();
        }

        private void U_Order_Click(object sender, EventArgs e)
        {
            UpdateTotalAmount();
        }

        private void UpdateTotalAmount()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in DisplaySelectedOrder.Rows)
            {
                total += Convert.ToDecimal(row.Cells["SubTotal"].Value);
            }
            label1.Text = "Total: $" + total.ToString("0.00");
        }

        private void btnRemoveOrderItem_Click(object sender, EventArgs e)
        {
            if (DisplaySelectedOrder.SelectedRows.Count > 0)
            {
                int orderDetailId = Convert.ToInt32(DisplaySelectedOrder.SelectedRows[0].Cells["OrderDetailID"].Value);

                using (SqlConnection connect = new SqlConnection(ConnectionString))
                {
                    connect.Open();
                    string DeleteQuery = "DELETE FROM OrderDetails WHERE OrderDetailID = @id";
                    SqlCommand s1 = new SqlCommand(DeleteQuery, connect);
                    s1.Parameters.AddWithValue("@id", orderDetailId);
                    s1.ExecuteNonQuery();
                }
                 
                UpdateTotalAmount();
            }
            else
            {
                MessageBox.Show("Please select an order item to remove.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

    }
}
