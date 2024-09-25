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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void populate()
        {
            Con.Open();
            string query = "SELECT id AS [Customer ID], Custusername AS [Customer Name], email AS [Email], Custpassword AS [Password] FROM CustomerLogin";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CustomerDGV.DataSource = ds.Tables[0];
            Con.Close();
        }


        int custkey = 0;
        SqlConnection Con = new SqlConnection(@"Data Source=SAFWAN;Initial Catalog=WeddingPlanner;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void AddStaffBtn_Click(object sender, EventArgs e)
        {
            if (CustNameTb.Text == "" || CustEmailTb.Text == "" || CustPasswordTb.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "INSERT INTO CustomerLogin (Custusername, email, Custpassword, date_created) VALUES (@Custusername, @Email, @Password, @DateCreated)";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@Custusername", CustNameTb.Text);
                    cmd.Parameters.AddWithValue("@Email", CustEmailTb.Text);
                    cmd.Parameters.AddWithValue("@Password", CustPasswordTb.Text);
                    cmd.Parameters.AddWithValue("@DateCreated", DateTime.Now); // Add current date
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Successfully Added");
                    Con.Close();
                    populate();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CustomerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CustomerDGV.SelectedRows.Count > 0 && e.RowIndex >= 0)
            {
                // Now set the 'custkey' to the selected row's Customer ID (id column)
                custkey = Convert.ToInt32(CustomerDGV.SelectedRows[0].Cells[0].Value.ToString());  // Customer ID

                // Set textboxes for Customer Name, Email, and Password
                CustNameTb.Text = CustomerDGV.SelectedRows[0].Cells[1].Value.ToString();  // Customer Name
                CustEmailTb.Text = CustomerDGV.SelectedRows[0].Cells[2].Value.ToString(); // Email
                CustPasswordTb.Text = CustomerDGV.SelectedRows[0].Cells[3].Value.ToString(); // Password
            }
        }
        private void clear()
        {
            CustNameTb.Text = "";
            CustEmailTb.Text = "";
            CustPasswordTb.Text = "";
            custkey = 0;
        }

        private void ResetStaffBtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void DeleteStaffBtn_Click(object sender, EventArgs e)
        {
            if (custkey == 0)
            {
                MessageBox.Show("Select a customer to delete.");
            }
            else
            {
                try
                {
                    Con.Open();
                    // Update the query to delete from the CustomerLogin table
                    string query = "DELETE FROM CustomerLogin WHERE id=@CustId";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@CustId", custkey);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer deleted successfully.");
                    Con.Close();
                    populate();  // Refresh the DataGridView
                    clear();     // Clear the input fields
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EditCustomerBtn_Click(object sender, EventArgs e)
        {
            if (custkey == 0)
            {
                MessageBox.Show("Please select a customer to edit.");
                return;
            }

            if (CustNameTb.Text == "" || CustEmailTb.Text == "" || CustPasswordTb.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "UPDATE CustomerLogin SET Custusername=@Custusername, email=@Email, Custpassword=@Password WHERE id=@CustId";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@Custusername", CustNameTb.Text);
                    cmd.Parameters.AddWithValue("@Email", CustEmailTb.Text);
                    cmd.Parameters.AddWithValue("@Password", CustPasswordTb.Text);
                    cmd.Parameters.AddWithValue("@CustId", custkey);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Successfully Updated");
                    Con.Close();
                    populate();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminPannelForm uf = new AdminPannelForm();
            uf.Show();
            this.Hide();
        }
    }
}
