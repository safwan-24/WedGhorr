﻿using System;
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
    public partial class BkashForm : Form
    {
        public BkashForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=SAFWAN;Initial Catalog=WeddingPlanner;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BkashForm_Load(object sender, EventArgs e)
        {

        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            string mobileNumber = MobileNumberTb.Text.Trim();
            string CustomerEmail = CustIdTb.Text.Trim(); // Get the customer ID

            // Check if the mobile number is not 11 digits
            if (mobileNumber.Length != 11)
            {
                MessageBox.Show("Please enter a correct 11-digit mobile number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Check if CustomerEmailTb is empty
            else if (string.IsNullOrEmpty(CustomerEmail))
            {
                MessageBox.Show("Customer ID cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    // Insert customer confirmation into the database
                    Con.Open();
                    string query = "INSERT INTO CustomerConfirmTbl (CustomerEmail, Confirmed, BkashPayment) VALUES (@CustomerEmail, @Confirmed, @BkashPayment)";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@CustomerEmail", CustomerEmail);
                    cmd.Parameters.AddWithValue("@Confirmed", 1); // Assuming 1 means confirmed
                    cmd.Parameters.AddWithValue("@BkashPayment", "Yes"); // Set BkashPayment to "Yes"
                    cmd.ExecuteNonQuery();
                    Con.Close();

                    // If the mobile number is 11 digits, show the confirmation message
                    MessageBox.Show("Thank you for ordering from WedGhor.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Navigate to the welcome form
                    WelcomeForm welcomeForm = new WelcomeForm();
                    welcomeForm.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            PaymentForm paymentForm = new PaymentForm();
            paymentForm.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
