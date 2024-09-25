using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WedGhor
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }
        SqlConnection connect = new SqlConnection(@"Data Source=SAFWAN;Initial Catalog=WeddingPlanner;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");


        private void SignUpButton2_Click(object sender, EventArgs e)
        {
            if (SignupEmailTextBox.Text == "" || SignupUserNametextBox.Text == ""
  || SignupPasswordTextBox.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        String checkUsername = "SELECT * FROM CustomerLogin WHERE Custusername = '"
                            + SignupUserNametextBox.Text.Trim() + "'"; // CustomerLoginTbl is our table name

                        using (SqlCommand checkUser = new SqlCommand(checkUsername, connect))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show(SignupUserNametextBox.Text + " is already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO CustomerLogin (email, Custusername, Custpassword, date_created) " +
     "VALUES(@email, @Custusername, @Custpassword,@date)";


                                DateTime date = DateTime.Today;

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@email", SignupEmailTextBox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@Custusername", SignupUserNametextBox.Text.Trim());

                                    cmd.Parameters.AddWithValue("@Custpassword", SignupPasswordTextBox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date", date);


                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // TO SWITCH THE FORM 
                                    CustomerLoginForm lForm = new CustomerLoginForm();
                                    lForm.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }

            }
        }

        private void BackToWelcomeButton_Click(object sender, EventArgs e)
        {
            CustomerLoginForm loginForm = new CustomerLoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }
    }
}
