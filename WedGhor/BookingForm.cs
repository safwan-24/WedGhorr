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
    public partial class BookingForm : Form
    {
        public BookingForm()
        {
            InitializeComponent();
            SetDefaultValues();
        }
        private int drinkCost = 0;
        private int biriyaniCost = 0;
        private void SetDefaultValues()
        {
            // Set default values for price textboxes
            WaterPrice.Text = "15";
            CokePrice.Text = "25";
            CocktailPrice.Text = "50";
            MuttonPrice.Text = "250";
            ChickenPrice.Text = "220";
            BeefPrice.Text = "280";

            // Make price textboxes uneditable
            WaterPrice.ReadOnly = true;
            CokePrice.ReadOnly = true;
            CocktailPrice.ReadOnly = true;
            MuttonPrice.ReadOnly = true;
            ChickenPrice.ReadOnly = true;
            BeefPrice.ReadOnly = true;

            // Set initial state of WaterPrice and WaterQty controls
            WaterPrice.Enabled = WaterCb.Checked;
            WaterQty.Enabled = WaterCb.Checked;
            CokePrice.Enabled = CokeCb.Checked;
            CokeQty.Enabled = CokeCb.Checked;
            CocktailPrice.Enabled = CocktailCb.Checked;
            CocktailQty.Enabled = CocktailCb.Checked;
            MuttonPrice.Enabled = MuttonCb.Checked;
            MuttonQty.Enabled = MuttonCb.Checked;
            ChickenPrice.Enabled = ChickenCb.Checked;
            ChickenQty.Enabled = ChickenCb.Checked;
            BeefPrice.Enabled = BeefCb.Checked;
            BeefQty.Enabled = BeefCb.Checked;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            BeefPrice.Enabled = BeefCb.Checked;
            BeefQty.Enabled = BeefCb.Checked;
            // Clear text of CokePrice and CokeQty when CheckBox is unchecked
            if (!BeefCb.Checked)
            {
                BeefPrice.Text = "";
                BeefQty.Text = "";
            }
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=SAFWAN;Initial Catalog=WeddingPlanner;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void WaterCb_CheckedChanged(object sender, EventArgs e)
        {
            WaterPrice.Enabled = WaterCb.Checked;
            WaterQty.Enabled = WaterCb.Checked;
            if (!WaterCb.Checked)
            {
                WaterPrice.Text = "";
                WaterQty.Text = "";
            }
        }

        private void label25_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CokeCb_CheckedChanged(object sender, EventArgs e)
        {
            CokePrice.Enabled = CokeCb.Checked;
            CokeQty.Enabled = CokeCb.Checked;
            // Clear text of CokePrice and CokeQty when CheckBox is unchecked
            if (!CokeCb.Checked)
            {
                CokePrice.Text = "";
                CokeQty.Text = "";
            }
        }

        private void CocktailCb_CheckedChanged(object sender, EventArgs e)
        {
            CocktailPrice.Enabled = CocktailCb.Checked;
            CocktailQty.Enabled = CocktailCb.Checked;

            if (!CocktailCb.Checked)
            {
                CocktailPrice.Text = "";
                CocktailQty.Text = "";
            }
        }

        private void MuttonCb_CheckedChanged(object sender, EventArgs e)
        {
            MuttonPrice.Enabled = MuttonCb.Checked;
            MuttonQty.Enabled = MuttonCb.Checked;
            // Clear text of CokePrice and CokeQty when CheckBox is unchecked
            if (!MuttonCb.Checked)
            {
                MuttonPrice.Text = "";
                MuttonQty.Text = "";
            }
        }

        private void ChickenCb_CheckedChanged(object sender, EventArgs e)
        {
            ChickenPrice.Enabled = ChickenCb.Checked;
            ChickenQty.Enabled = ChickenCb.Checked;
            // Clear text of CokePrice and CokeQty when CheckBox is unchecked
            if (!ChickenCb.Checked)
            {
                ChickenPrice.Text = "";
                ChickenQty.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int water = 0, coke = 0, cocktail = 0;
            if (WaterCb.Checked && !string.IsNullOrEmpty(WaterPrice.Text) && !string.IsNullOrEmpty(WaterQty.Text))
            {
                if (int.TryParse(WaterPrice.Text, out int waterPrice) && int.TryParse(WaterQty.Text, out int waterQty))
                {
                    water = waterPrice * waterQty;
                }
                else
                {
                    MessageBox.Show("Enter valid numeric values for Water Price and Quantity");
                    return;
                }
            }

            if (CokeCb.Checked && !string.IsNullOrEmpty(CokePrice.Text) && !string.IsNullOrEmpty(CokeQty.Text))
            {
                if (int.TryParse(CokePrice.Text, out int cokePrice) && int.TryParse(CokeQty.Text, out int cokeQty))
                {
                    coke = cokePrice * cokeQty;
                }
                else
                {
                    MessageBox.Show("Enter valid numeric values for Coke Price and Quantity");
                    return;
                }
            }

            if (CocktailCb.Checked && !string.IsNullOrEmpty(CocktailPrice.Text) && !string.IsNullOrEmpty(CocktailQty.Text))
            {
                if (int.TryParse(CocktailPrice.Text, out int cocktailPrice) && int.TryParse(CocktailQty.Text, out int cocktailQty))
                {
                    cocktail = cocktailPrice * cocktailQty;
                }
                else
                {
                    MessageBox.Show("Enter valid numeric values for Cocktail Price and Quantity");
                    return;
                }
            }

            // Update drink cost and recalculate total cost
            drinkCost = water + coke + cocktail;
            DrinkCostLbl.Text = drinkCost.ToString();
            UpdateTotalCost();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int mutton = 0, chicken = 0, beef = 0;
            if (MuttonCb.Checked && !string.IsNullOrEmpty(MuttonPrice.Text) && !string.IsNullOrEmpty(MuttonQty.Text))
            {
                mutton = Convert.ToInt32(MuttonPrice.Text) * Convert.ToInt32(MuttonQty.Text);
            }

            if (ChickenCb.Checked && !string.IsNullOrEmpty(ChickenPrice.Text) && !string.IsNullOrEmpty(ChickenQty.Text))
            {
                chicken = Convert.ToInt32(ChickenPrice.Text) * Convert.ToInt32(ChickenQty.Text);
            }

            if (BeefCb.Checked && !string.IsNullOrEmpty(BeefPrice.Text) && !string.IsNullOrEmpty(BeefQty.Text))
            {
                beef = Convert.ToInt32(BeefPrice.Text) * Convert.ToInt32(BeefQty.Text);
            }

            // Update biriyani cost and recalculate total cost
            biriyaniCost = mutton + chicken + beef;
            BiriyaniCostLbl.Text = biriyaniCost.ToString();
            UpdateTotalCost();
        }

        private void UpdateTotalCost()
        {
            int totalCost = drinkCost + biriyaniCost;
            GridTotalTb.Text = totalCost.ToString();
        }



        private void CustIdCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AddBookingBtn_Click(object sender, EventArgs e)
        {
            int drinkCost = Convert.ToInt32(DrinkCostLbl.Text);
            int biriyaniCost = Convert.ToInt32(BiriyaniCostLbl.Text);
            int totalCost = drinkCost + biriyaniCost;

            // Insert into database and retrieve BookingId using SCOPE_IDENTITY()
            string query = @"INSERT INTO ViewBookingTbl (WaterPrice, WaterQty, CokePrice, CokeQty, CocktailPrice, CocktailQty, 
                                                MuttonPrice, MuttonQty, ChickenPrice, ChickenQty, BeefPrice, BeefQty, 
                                                TotalCost, Person) 
                     VALUES (@WaterPrice, @WaterQty, @CokePrice, @CokeQty, @CocktailPrice, @CocktailQty, @MuttonPrice, 
                             @MuttonQty, @ChickenPrice, @ChickenQty, @BeefPrice, @BeefQty, @TotalCost, @Person);
                     SELECT SCOPE_IDENTITY();";

            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand(query, Con);

                cmd.Parameters.AddWithValue("@WaterPrice", WaterPrice.Text.Trim());
                cmd.Parameters.AddWithValue("@WaterQty", WaterQty.Text.Trim());
                cmd.Parameters.AddWithValue("@CokePrice", CokePrice.Text.Trim());
                cmd.Parameters.AddWithValue("@CokeQty", CokeQty.Text.Trim());
                cmd.Parameters.AddWithValue("@CocktailPrice", CocktailPrice.Text.Trim());
                cmd.Parameters.AddWithValue("@CocktailQty", CocktailQty.Text.Trim());
                cmd.Parameters.AddWithValue("@MuttonPrice", MuttonPrice.Text.Trim());
                cmd.Parameters.AddWithValue("@MuttonQty", MuttonQty.Text.Trim());
                cmd.Parameters.AddWithValue("@ChickenPrice", ChickenPrice.Text.Trim());
                cmd.Parameters.AddWithValue("@ChickenQty", ChickenQty.Text.Trim());
                cmd.Parameters.AddWithValue("@BeefPrice", BeefPrice.Text.Trim());
                cmd.Parameters.AddWithValue("@BeefQty", BeefQty.Text.Trim());
                cmd.Parameters.AddWithValue("@TotalCost", totalCost);

                if (string.IsNullOrWhiteSpace(PersonTb.Text))
                {
                    MessageBox.Show("Please enter the number of persons.");
                    return;
                }

                cmd.Parameters.AddWithValue("@Person", PersonTb.Text.Trim());

                // Execute the query and retrieve the BookingId
                var bookingId = cmd.ExecuteScalar();

                Con.Close();

                // Show BookingId in message box
                MessageBox.Show($"Booking confirmed successfully! Your Booking ID is {bookingId}. Please keep this ID for future reference.");

                CustomerPanel customerPanel = new CustomerPanel();
                customerPanel.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Con.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            CustomerPanel customerPanel = new CustomerPanel();
            customerPanel.Show();
            this.Hide();
        }

    }
}
