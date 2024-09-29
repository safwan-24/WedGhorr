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
    public partial class ViewOrder : Form
    {
        public ViewOrder()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=SAFWAN;Initial Catalog=WeddingPlanner;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void ViewOrder_Load(object sender, EventArgs e)
        {
            populate();
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

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (OrderKey == 0)
            {
                MessageBox.Show("Select The Order To be Deleted");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "Delete from ViewBookingTbl where BookingId=" + OrderKey + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Deleted Successfully");
                    Con.Close();
                    populate();
                    clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (OrderKey == 0)
            {
                MessageBox.Show("Please select an Order to edit.");
                return;
            }

            if (string.IsNullOrWhiteSpace(MuttonQtyTb.Text) || string.IsNullOrWhiteSpace(CokeQtyTb.Text) || string.IsNullOrWhiteSpace(TotalCostTb.Text) || string.IsNullOrWhiteSpace(WaterQtyTb.Text) || string.IsNullOrWhiteSpace(CocktailQtyTb.Text) || string.IsNullOrWhiteSpace(ChickenQtyTb.Text) || string.IsNullOrWhiteSpace(BeefQtyTb.Text))
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "UPDATE ViewBookingTbl SET CokeQty=@CokeQty, MuttonQty=@MuttonQty, CocktailQty=@CocktailQty, WaterQty=@WaterQty, ChickenQty=@ChickenQty, BeefQty=@BeefQty, TotalCost=@TotalCost WHERE BookingId=@BookingId";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@CokeQty", decimal.Parse(CokeQtyTb.Text)); // Convert to decimal
                    cmd.Parameters.AddWithValue("@MuttonQty", decimal.Parse(MuttonQtyTb.Text)); // Convert to decimal
                    cmd.Parameters.AddWithValue("@WaterQty", decimal.Parse(WaterQtyTb.Text)); // Convert to decimal
                    cmd.Parameters.AddWithValue("@CocktailQty", decimal.Parse(CocktailQtyTb.Text)); // Convert to decimal
                    cmd.Parameters.AddWithValue("@ChickenQty", decimal.Parse(ChickenQtyTb.Text)); // Convert to decimal
                    cmd.Parameters.AddWithValue("@BeefQty", decimal.Parse(BeefQtyTb.Text)); // Convert to decimal
                    cmd.Parameters.AddWithValue("@TotalCost", decimal.Parse(TotalCostTb.Text)); // Convert to decimal
                    cmd.Parameters.AddWithValue("@BookingId", OrderKey);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    Con.Close();
                    populate();
                    clear();

                    // Display a confirmation message
                    MessageBox.Show("Order has been updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminPannelForm mainForm = new AdminPannelForm();
            mainForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckProfitButton_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(TotalCostTb.Text, out decimal totalCost))
            {
                // Calculate 5% of the total cost
                decimal profit = totalCost * 0.10m;

                // Display the result in textBox1
                textBox1.Text = profit.ToString("F2"); // Format to 2 decimal places
            }
            else
            {
                MessageBox.Show("Please enter a valid total cost.");
            }
        }
    }
}
