using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RestaurantSystem
{
    public partial class customerForm : Form
    {
        private static string ConnectionString = "Data Source=DESKTOP-5P1UJGK\\SQLEXPRESS;Initial Catalog=RestaurantDBD;Integrated Security=True";

        public customerForm()
        {
            InitializeComponent();
        }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        private void AvaiableItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Vie_order_Click(object sender, EventArgs e)
        {
        }

        private void Ad_to_order_Click(object sender, EventArgs e)
        {
            if (AvaiableItems.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item first.");
                return;
            }

            int itemId = Convert.ToInt32(AvaiableItems.SelectedRows[0].Cells[0].Value);
            decimal price = Convert.ToDecimal(AvaiableItems.SelectedRows[0].Cells[2].Value);
            int quantity = Convert.ToInt32(Quantity.Text);
            decimal subTotal = price * quantity; 
            int orderId =CreateOrder();  

            using (SqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO OrderDetails (OrderID, ItemID, Quantity, SubTotal) VALUES (@orderId, @itemId, @quantity, @subTotal)";
                    SqlCommand c1 = new SqlCommand(query, connection);
                    c1.Parameters.AddWithValue("@orderId", orderId);
                    c1.Parameters.AddWithValue("@itemId", itemId);
                    c1.Parameters.AddWithValue("@quantity", quantity);
                    c1.Parameters.AddWithValue("@subTotal", subTotal);
                    c1.ExecuteNonQuery();

                    MessageBox.Show("Item added to order successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding to order: " + ex.Message);
                }
            }
        }

        private int CreateOrder()
        {
            int orderId = -1; 

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                 
                string checkOrderQuery = "SELECT TOP 1 OrderID FROM Orders WHERE PaymentStatus = 'Pending' ORDER BY OrderID DESC";
                SqlCommand checkOrderc1 = new SqlCommand(checkOrderQuery, connection);
                object result = checkOrderc1.ExecuteScalar();

                if (result != null)
                {
                    orderId = Convert.ToInt32(result);
                }
                else
                { 
                    string createOrderQuery = "INSERT INTO Orders (TotalAmount, PaymentStatus) OUTPUT INSERTED.OrderID VALUES (0, 'Pending')";
                    SqlCommand createOrders1 = new SqlCommand(createOrderQuery, connection);
                    orderId = (int)createOrders1.ExecuteScalar();
                }
            }

            return orderId;
        }



        private void customerForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connect = GetConnection())
                {
                    connect.Open();
                    string SelectQuery = "SELECT * FROM Items";
                    SqlDataAdapter s1 = new SqlDataAdapter(SelectQuery, connect);
                    DataTable d1 = new DataTable();
                    s1.Fill(d1);
                    AvaiableItems.DataSource = d1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error available items: " + ex.Message);
            }
        }
    }
}
