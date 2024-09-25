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
    public partial class PaidCustomer : Form
    {
        public PaidCustomer()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=SAFWAN;Initial Catalog=WeddingPlanner;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void LoadCustomerData()
        {
            try
            {
                Con.Open();
                string query = "SELECT ConfirmationId, CustomerEmail, Confirmed, ConfirmationDate, BkashPayment, NagadPayment FROM CustomerConfirmTbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt; // Bind the DataTable to DataGridView1
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PaidCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaffPanelForm sf = new StaffPanelForm();   
            sf.Show();
            this.Hide();
        }
    }
}
