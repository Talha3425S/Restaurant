using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RestaurantSystem
{
    public partial class adminForm : Form
    {
        private static string ConnectionString = "Data Source=DESKTOP-5P1UJGK\\SQLEXPRESS;Initial Catalog=RestaurantDBD;Integrated Security=True";

        public adminForm()
        {
            InitializeComponent(); 
        }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }


        private void Ad_Item_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connect = GetConnection())
                using (SqlCommand s1 = new SqlCommand(
                    "INSERT INTO Items (ItemName, Price) VALUES (@name, @price)", connect))
                {
                    connect.Open();
                    s1.Parameters.AddWithValue("@name", itemName.Text);
                    s1.Parameters.AddWithValue("@price", Convert.ToDecimal(itemPrice.Text));
                    s1.ExecuteNonQuery();

                    // Optional: Show success message
                    MessageBox.Show("Item added successfully");

                    // Optional: Refresh the items grid
                    adminForm_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding item: " + ex.Message);
            }
        }
        private void adminForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection connect = GetConnection())
            {
                connect.Open();
                string SelectQuery = "SELECT * FROM Items";
                SqlDataAdapter s1 = new SqlDataAdapter(SelectQuery, connect);
                DataTable d1 = new DataTable();
                s1.Fill(d1);
                DisplayItems.DataSource = d1;
            } 
        }

        private void Re_Item_Click(object sender, EventArgs e)
        {
            if (DisplayItems.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item.");
                return;
            }

            int itemId = Convert.ToInt32(DisplayItems.SelectedRows[0].Cells[0].Value);
             
            if (MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection connect = GetConnection())
                {
                    connect.Open();
                    string deleteQuery = "DELETE FROM Items WHERE ItemID = @id";
                    SqlCommand s1 = new SqlCommand(deleteQuery, connect);
                    s1.Parameters.AddWithValue("@id", itemId);
                    s1.ExecuteNonQuery(); 
                    MessageBox.Show("Item deleted successfully!");
                     
                    adminForm_Load(sender, e);
                }
            }
        }
             

        private void Upd_Item_Click(object sender, EventArgs e)
        {
            if (DisplayItems.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item first.");
                return;
            }

            int itemId = Convert.ToInt32(DisplayItems.SelectedRows[0].Cells[0].Value);
          
            using (SqlConnection connect = GetConnection())
                {
                    connect.Open();
                    string updateQuery = "UPDATE Items SET ItemName = @name, Price = @price WHERE ItemID = @id";
                    SqlCommand s1= new SqlCommand(updateQuery ,connect);
                    s1.Parameters.AddWithValue("@name", itemName.Text);
                    s1.Parameters.AddWithValue("@price", Convert.ToDecimal(itemPrice.Text));
                    s1.Parameters.AddWithValue("@id", itemId);
                    s1.ExecuteNonQuery();
                } 
            }
             

        private void DisplayItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
