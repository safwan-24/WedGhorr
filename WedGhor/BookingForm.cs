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
        private int SetMenu1 = 0;
        private int SetMenu2 = 0;
        private int SetMenu3 = 0;
        private int SetMenu4 = 0;
        private void SetDefaultValues()
        {
            // Set default values for price textboxes
            WaterPrice.Text = "15";
            CokePrice.Text = "25";
            CocktailPrice.Text = "50";
            MuttonPrice.Text = "250";
            ChickenPrice.Text = "220";
            BeefPrice.Text = "280";

            SM1PTb.Text = "420";
            SM2PTb.Text = "400";
            SM3PTb.Text = "580";
            SM4PTb.Text = "520";

            // Make price textboxes uneditable
            WaterPrice.ReadOnly = true;
            CokePrice.ReadOnly = true;
            CocktailPrice.ReadOnly = true;
            MuttonPrice.ReadOnly = true;
            ChickenPrice.ReadOnly = true;
            BeefPrice.ReadOnly = true;

            SM1PTb.ReadOnly = true;
            SM2PTb.ReadOnly = true;
            SM3PTb.ReadOnly = true;
            SM4PTb.ReadOnly = true;

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

            SM2PTb.Enabled = SM2Cb.Checked;
            SM3PTb.Enabled = SM3Cb.Checked;
            SM4PTb.Enabled = SM4Cb.Checked;
            SM1PTb.Enabled = SM1Cb.Checked;


            SM2QTb.Enabled = SM2Cb.Checked;
            SM3QTb.Enabled = SM3Cb.Checked;
            SM4QTb.Enabled = SM4Cb.Checked;
            SM1QTb.Enabled = SM1Cb.Checked;
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
            int totalCost = drinkCost + biriyaniCost + SetMenu1 + SetMenu2 + SetMenu3 + SetMenu4;
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
            int totalCost = drinkCost + biriyaniCost + SetMenu1 + SetMenu2 + SetMenu3 + SetMenu4;

            // Get the selected date and time slot
            DateTime bookingDate = dateTimePicker1.Value.Date;

            // Ensure a slot is selected before proceeding
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a booking slot (Day or Night).");
                return;
            }

            string bookingSlot = comboBox1.SelectedItem.ToString(); // "Day" or "Night"

            // Query to check if the same date and slot are already booked
            string checkQuery = @"SELECT COUNT(*) FROM ViewBookingTbl 
                          WHERE BookingDate = @BookingDate 
                          AND BookingSlot = @BookingSlot";

            try
            {
                Con.Open();

                // Check if the booking already exists
                SqlCommand checkCmd = new SqlCommand(checkQuery, Con);
                checkCmd.Parameters.AddWithValue("@BookingDate", bookingDate);
                checkCmd.Parameters.AddWithValue("@BookingSlot", bookingSlot);

                int existingBookings = (int)checkCmd.ExecuteScalar();

                if (existingBookings > 0)
                {
                    MessageBox.Show("This time slot is already booked. Please try another time.");
                    Con.Close();
                    return; // Exit the method to avoid inserting duplicate booking
                }

                // Proceed to insert the booking if no conflict
                string query = @"INSERT INTO ViewBookingTbl (WaterPrice, WaterQty, CokePrice, CokeQty, CocktailPrice, CocktailQty, 
                                                   MuttonPrice, MuttonQty, ChickenPrice, ChickenQty, BeefPrice, BeefQty, 
                                                   TotalCost, Person, BookingDate, BookingSlot, SM1Qty, SM2Qty, SM3Qty, SM4Qty) 
                         VALUES (@WaterPrice, @WaterQty, @CokePrice, @CokeQty, @CocktailPrice, @CocktailQty, @MuttonPrice, 
                                 @MuttonQty, @ChickenPrice, @ChickenQty, @BeefPrice, @BeefQty, @TotalCost, @Person, 
                                 @BookingDate, @BookingSlot, @SetMenu1, @SetMenu2, @SetMenu3, @SetMenu4);
                         SELECT SCOPE_IDENTITY();";

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
                cmd.Parameters.AddWithValue("@Person", PersonTb.Text.Trim());
                cmd.Parameters.AddWithValue("@BookingDate", bookingDate);
                cmd.Parameters.AddWithValue("@BookingSlot", bookingSlot); // Ensure bookingSlot is not null
                cmd.Parameters.AddWithValue("@SetMenu1", SM1QTb.Text.Trim());
                cmd.Parameters.AddWithValue("@SetMenu2", SM2QTb.Text.Trim());
                cmd.Parameters.AddWithValue("@SetMenu3", SM3QTb.Text.Trim());
                cmd.Parameters.AddWithValue("@SetMenu4", SM4QTb.Text.Trim());

                var bookingId = cmd.ExecuteScalar();

                Con.Close();

                MessageBox.Show($"Booking confirmed successfully! Your Booking ID is {bookingId}. Please keep this ID for future reference.");

                // Transition to another form if necessary
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SM1Button_Click(object sender, EventArgs e)
        {
            if (SM1Cb.Checked && !string.IsNullOrEmpty(SM1PTb.Text) && !string.IsNullOrEmpty(SM1QTb.Text))
            {
                SetMenu1 = Convert.ToInt32(SM1PTb.Text) * Convert.ToInt32(SM1QTb.Text);
            }
            else
            {
                MessageBox.Show("Enter valid numeric values for Menu Price and Quantity");
                return;
            }
            UpdateTotalCost();
        }

        private void SM2Button_Click(object sender, EventArgs e)
        {
            if (SM2Cb.Checked && !string.IsNullOrEmpty(SM2PTb.Text) && !string.IsNullOrEmpty(SM2QTb.Text))
            {
                SetMenu2 = Convert.ToInt32(SM2PTb.Text) * Convert.ToInt32(SM2QTb.Text);
            }
            else
            {
                MessageBox.Show("Enter valid numeric values for Menu Price and Quantity");
                return;
            }
            UpdateTotalCost();
        }

        private void SM3Button_Click(object sender, EventArgs e)
        {
            if (SM3Cb.Checked && !string.IsNullOrEmpty(SM3PTb.Text) && !string.IsNullOrEmpty(SM3QTb.Text))
            {
                SetMenu3 = Convert.ToInt32(SM3PTb.Text) * Convert.ToInt32(SM3QTb.Text);
            }
            else
            {
                MessageBox.Show("Enter valid numeric values for Menu Price and Quantity");
                return;
            }
            UpdateTotalCost();
        }

        private void SM4Button_Click(object sender, EventArgs e)
        {
            if (SM4Cb.Checked && !string.IsNullOrEmpty(SM4PTb.Text) && !string.IsNullOrEmpty(SM4QTb.Text))
            {
                SetMenu4 = Convert.ToInt32(SM4PTb.Text) * Convert.ToInt32(SM4QTb.Text);
            }
            else
            {
                MessageBox.Show("Enter valid numeric values for Menu Price and Quantity");
                return;
            }
            UpdateTotalCost();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SM1PTb.Enabled = SM1Cb.Checked;
            SM1QTb.Enabled = SM1Cb.Checked;

            if (!SM1Cb.Checked)
            {
                SM1PTb.Text = "";
                SM1QTb.Text = "";
            }
        }

        private void SM2Cb_CheckedChanged(object sender, EventArgs e)
        {
            SM2PTb.Enabled = SM2Cb.Checked;
            SM2QTb.Enabled = SM2Cb.Checked;

            if (!SM2Cb.Checked)
            {
                SM2PTb.Text = "";
                SM2QTb.Text = "";
            }
        }

        private void SM3Cb_CheckedChanged(object sender, EventArgs e)
        {
            SM3PTb.Enabled = SM3Cb.Checked;
            SM3QTb.Enabled = SM3Cb.Checked;

            if (!SM3Cb.Checked)
            {
                SM3PTb.Text = "";
                SM3QTb.Text = "";
            }
        }

        private void SM4Cb_CheckedChanged(object sender, EventArgs e)
        {
            SM4PTb.Enabled = SM4Cb.Checked;
            SM4QTb.Enabled = SM4Cb.Checked;

            if (!SM4Cb.Checked)
            {
                SM4PTb.Text = "";
                SM4QTb.Text = "";
            }
        }
    }
}
