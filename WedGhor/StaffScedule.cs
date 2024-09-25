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
    public partial class StaffScedule : Form
    {
        public StaffScedule()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=SAFWAN;Initial Catalog=WeddingPlanner;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void StaffScedule_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void MorningCb_CheckedChanged(object sender, EventArgs e)
        {
            if (MorningCb.Checked)
            {
                DayCb.Checked = false;
                NightCb.Checked = false;
            }
        }

        private void DayCb_CheckedChanged(object sender, EventArgs e)
        {
            if (DayCb.Checked)
            {
                MorningCb.Checked = false;
                NightCb.Checked = false;
            }
        }

        private void NightCb_CheckedChanged(object sender, EventArgs e)
        {
            if (NightCb.Checked)
            {
                MorningCb.Checked = false;
                DayCb.Checked = false;
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string staffName = StaffNameTb.Text;
            int staffId = int.Parse(StaffIdTb.Text);
            string shiftType = "";
            DateTime shiftTime = DateTime.Now;

            // Determine the shift type based on the checked checkbox
            if (MorningCb.Checked)
            {
                shiftType = "Morning";
            }
            else if (DayCb.Checked)
            {
                shiftType = "Day";
            }
            else if (NightCb.Checked)
            {
                shiftType = "Night";
            }
            else
            {
                MessageBox.Show("Please select a shift type.");
                return;
            }

            try
            {
                Con.Open();
                // Insert into StaffShiftTbl
                string query = "INSERT INTO StaffShiftTbl (StaffId, StaffName, ShiftTime, ShiftType) " +
                               "VALUES (@StaffId, @StaffName, @ShiftTime, @ShiftType)";

                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@StaffId", staffId);
                cmd.Parameters.AddWithValue("@StaffName", staffName);
                cmd.Parameters.AddWithValue("@ShiftTime", shiftTime);
                cmd.Parameters.AddWithValue("@ShiftType", shiftType);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Shift added successfully.");

                Con.Close();

                // Refresh the DataGridView
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                    Con.Close();
            }
        }
        private void LoadData()
        {
            try
            {
                Con.Open();
                string query = "SELECT * FROM StaffShiftTbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                    Con.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            StaffPanelForm form = new StaffPanelForm();
            form.Show();
            this.Hide();
        }

        private void StaffNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void StaffIdTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
