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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WedGhor
{
    public partial class CustomerTrackOrder : Form
    {
        public CustomerTrackOrder()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=SAFWAN;Initial Catalog=WeddingPlanner;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            BookingForm bookingForm = new BookingForm();
            bookingForm.Show();
            this.Hide();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            PaymentForm paymentForm = new PaymentForm();
            paymentForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerPanel customerPanel = new CustomerPanel();
            customerPanel.Show();
            this.Hide();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                try
                {
                    // Open the connection
                    Con.Open();

                    // Query to fetch data from OrderTakenStaffTbl by BookingId
                    string query = "SELECT * FROM OrderTakenStaffTbl WHERE BookingId = @BookingId";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@BookingId", int.Parse(textBox1.Text)); // Parse the booking ID to integer

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        // Bind the result to the DataGridView
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("No booking found with the given Booking ID.");
                        dataGridView1.DataSource = null; // Clear the DataGridView if no record is found
                    }

                    // Close the connection
                    Con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a Booking ID.");
            }
        }

        private void CustomerTrackOrder_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
