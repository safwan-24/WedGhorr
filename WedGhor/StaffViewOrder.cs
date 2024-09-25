using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WedGhor
{
    public partial class StaffViewOrder : Form
    {
        public StaffViewOrder()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=SAFWAN;Initial Catalog=WeddingPlanner;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void StaffViewOrder_Load(object sender, EventArgs e)
        {
            populate();
            populateNewTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = ViewOrderDGV.Rows[e.RowIndex];

                // Retrieve data from the selected row
                CokeQtyTb.Text = selectedRow.Cells["CokeQty"].Value?.ToString();
                CocktailQtyTb.Text = selectedRow.Cells["CocktailQty"].Value?.ToString();
                WaterQtyTb.Text = selectedRow.Cells["WaterQty"].Value?.ToString();
                ChickenQtyTb.Text = selectedRow.Cells["ChickenQty"].Value?.ToString();
                MuttonQtyTb.Text = selectedRow.Cells["MuttonQty"].Value?.ToString();
                BeefQtyTb.Text = selectedRow.Cells["BeefQty"].Value?.ToString();
                TotalCostTb.Text = selectedRow.Cells["TotalCost"].Value?.ToString();

                // Retrieve BookingId
                if (int.TryParse(selectedRow.Cells["BookingId"].Value?.ToString(), out int bookingId))
                {
                    OrderKey = bookingId;
                }
                else
                {
                    OrderKey = 0;
                }
            }
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from ViewBookingTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ViewOrderDGV.DataSource = ds.Tables[0];
            Con.Close();
        }


        private void clear()
        {
            MuttonQtyTb.Text = "";
            CokeQtyTb.Text = "";
            OrderKey = 0;
            TotalCostTb.Text = "";
            WaterQtyTb.Text = "";
            CocktailQtyTb.Text = "";
            ChickenQtyTb.Text = "";
            BeefQtyTb.Text = "";
        }
        int OrderKey = 0;

        private void BackBtn_Click(object sender, EventArgs e)
        {
            StaffPanelForm staffPanelForm = new StaffPanelForm();
            staffPanelForm.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            // Check if all required fields are filled
            if (string.IsNullOrWhiteSpace(WaterQtyTb.Text) || string.IsNullOrWhiteSpace(CokeQtyTb.Text) ||
                string.IsNullOrWhiteSpace(CocktailQtyTb.Text) || string.IsNullOrWhiteSpace(MuttonQtyTb.Text) ||
                string.IsNullOrWhiteSpace(ChickenQtyTb.Text) || string.IsNullOrWhiteSpace(BeefQtyTb.Text) ||
                string.IsNullOrWhiteSpace(TotalCostTb.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                // Open the database connection
                Con.Open();

                // Insert data into OrderTakenStaffTbl
                string query = @"INSERT INTO OrderTakenStaffTbl 
                        (WaterQty, CokeQty, CocktailQty, MuttonQty, ChickenQty, BeefQty, TotalCost) 
                        VALUES (@WaterQty, @CokeQty, @CocktailQty, @MuttonQty, @ChickenQty, @BeefQty, @TotalCost)";

                SqlCommand cmd = new SqlCommand(query, Con);

                // Adding the parameters from the TextBoxes
                cmd.Parameters.AddWithValue("@WaterQty", decimal.Parse(WaterQtyTb.Text));
                cmd.Parameters.AddWithValue("@CokeQty", decimal.Parse(CokeQtyTb.Text));
                cmd.Parameters.AddWithValue("@CocktailQty", decimal.Parse(CocktailQtyTb.Text));
                cmd.Parameters.AddWithValue("@MuttonQty", decimal.Parse(MuttonQtyTb.Text));
                cmd.Parameters.AddWithValue("@ChickenQty", decimal.Parse(ChickenQtyTb.Text));
                cmd.Parameters.AddWithValue("@BeefQty", decimal.Parse(BeefQtyTb.Text));
                cmd.Parameters.AddWithValue("@TotalCost", decimal.Parse(TotalCostTb.Text));

                // Execute the insert command
                cmd.ExecuteNonQuery();

                // Close the connection
                Con.Close();

                // Refresh the data in DataGridView2
                populateNewTable();

                // Clear the textboxes
                clear();

                // Confirmation message
                MessageBox.Show("Order has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle any errors
                MessageBox.Show("Error: " + ex.Message);
                Con.Close();
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            // Check if a valid OrderKey (BookingId) is selected
            if (OrderKey == 0)
            {
                MessageBox.Show("Please select an order to edit.");
                return;
            }

            // Check if the textboxes are filled
            if (string.IsNullOrWhiteSpace(MuttonQtyTb.Text) || string.IsNullOrWhiteSpace(CokeQtyTb.Text) ||
                string.IsNullOrWhiteSpace(TotalCostTb.Text) || string.IsNullOrWhiteSpace(WaterQtyTb.Text) ||
                string.IsNullOrWhiteSpace(CocktailQtyTb.Text) || string.IsNullOrWhiteSpace(ChickenQtyTb.Text) ||
                string.IsNullOrWhiteSpace(BeefQtyTb.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            try
            {
                // Open connection
                Con.Open();

                // SQL update query
                string query = @"UPDATE OrderTakenStaffTbl 
                         SET WaterQty=@WaterQty, CokeQty=@CokeQty, CocktailQty=@CocktailQty, 
                             MuttonQty=@MuttonQty, ChickenQty=@ChickenQty, BeefQty=@BeefQty, TotalCost=@TotalCost 
                         WHERE BookingId=@BookingId";

                // Create SQL command
                SqlCommand cmd = new SqlCommand(query, Con);

                // Add parameters
                cmd.Parameters.AddWithValue("@WaterQty", decimal.Parse(WaterQtyTb.Text)); // Convert to decimal
                cmd.Parameters.AddWithValue("@CokeQty", decimal.Parse(CokeQtyTb.Text)); // Convert to decimal
                cmd.Parameters.AddWithValue("@CocktailQty", decimal.Parse(CocktailQtyTb.Text)); // Convert to decimal
                cmd.Parameters.AddWithValue("@MuttonQty", decimal.Parse(MuttonQtyTb.Text)); // Convert to decimal
                cmd.Parameters.AddWithValue("@ChickenQty", decimal.Parse(ChickenQtyTb.Text)); // Convert to decimal
                cmd.Parameters.AddWithValue("@BeefQty", decimal.Parse(BeefQtyTb.Text)); // Convert to decimal
                cmd.Parameters.AddWithValue("@TotalCost", decimal.Parse(TotalCostTb.Text)); // Convert to decimal

                // Set BookingId for the where clause
                cmd.Parameters.AddWithValue("@BookingId", OrderKey);

                // Execute the query
                int rowsAffected = cmd.ExecuteNonQuery();

                // Check if the update was successful
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Order updated successfully.");
                }
                else
                {
                    MessageBox.Show("No changes were made.");
                }

                // Close the connection
                Con.Close();

                // Refresh DataGridView2 with updated data
                populateNewTable();

                // Clear the textboxes
                clear();
            }
            catch (Exception ex)
            {
                // Handle the error and display the message
                MessageBox.Show("Error updating order: " + ex.Message);
                Con.Close();
            }
        }

        private void ResetStaffBtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView2.Rows[e.RowIndex];

                // Populate the textboxes with the data from the selected row
                WaterQtyTb.Text = selectedRow.Cells["WaterQty"].Value?.ToString();
                CokeQtyTb.Text = selectedRow.Cells["CokeQty"].Value?.ToString();
                CocktailQtyTb.Text = selectedRow.Cells["CocktailQty"].Value?.ToString();
                MuttonQtyTb.Text = selectedRow.Cells["MuttonQty"].Value?.ToString();
                ChickenQtyTb.Text = selectedRow.Cells["ChickenQty"].Value?.ToString();
                BeefQtyTb.Text = selectedRow.Cells["BeefQty"].Value?.ToString();
                TotalCostTb.Text = selectedRow.Cells["TotalCost"].Value?.ToString();

                // If you have a BookingId column, retrieve it as well
                if (int.TryParse(selectedRow.Cells["BookingId"].Value?.ToString(), out int bookingId))
                {
                    OrderKey = bookingId;
                }
                else
                {
                    OrderKey = 0; // Reset if BookingId is invalid or missing
                }
            }
        }
        private void populateNewTable()
        {
            try
            {
                Con.Open();
                string query = "SELECT * FROM OrderTakenStaffTbl"; // Select all records from NewTable
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0]; // Bind the data to DataGridView2
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
