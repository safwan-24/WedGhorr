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
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=SAFWAN;Initial Catalog=WeddingPlanner;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DeleteStaffBtn_Click(object sender, EventArgs e)
        {
            if (Staffkey == 0)
            {
                MessageBox.Show("Select The Staff To be Deleted");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "Delete from staff where sid=" + Staffkey + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff Deleted Succesfully");
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
        private void populate()
        {
            Con.Open();
            string query = "select * from staff";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            StaffDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        int Staffkey = 0;
        private void clear()
        {
            StaffNameTb.Text = "";
            StaffPassTb.Text = "";
            Staffkey = 0;
            StaffPhoneTb.Text = "";
            
        }

        private void AddStaffBtn_Click(object sender, EventArgs e)
        {
            if (StaffNameTb.Text == "" || StaffPassTb.Text == "" || StaffPhoneTb.Text == "" )
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    Con.Open();
                    // Updated to match your SQL table structure
                    string query = "insert into staff (semail, susername, spassword, date_created) values(@semail, @susername, @spassword, @date_created)";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@semail", StaffPhoneTb.Text);  // Assuming 'semail' is StaffPhoneTb
                    cmd.Parameters.AddWithValue("@susername", StaffNameTb.Text);  // Assuming 'susername' is StaffNameTb
                    cmd.Parameters.AddWithValue("@spassword", StaffPassTb.Text);  // Assuming 'spassword' is StaffPassTb
                    cmd.Parameters.AddWithValue("@date_created", DateTime.Now);   // Automatically sets the date to current time
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff Successfully Added");
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

        private void EditStaffBtn_Click(object sender, EventArgs e)
        {
            if (Staffkey == 0)
            {
                MessageBox.Show("Please select a staff member to edit.");
                return;
            }

            if (StaffNameTb.Text == "" || StaffPhoneTb.Text == "" || StaffPassTb.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    Con.Open();
                    // Updated to match your SQL table structure
                    string query = "UPDATE staff SET semail=@semail, susername=@susername, spassword=@spassword WHERE sid=@StaffId";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@semail", StaffPhoneTb.Text);  // Assuming 'semail' is StaffPhoneTb
                    cmd.Parameters.AddWithValue("@susername", StaffNameTb.Text);  // Assuming 'susername' is StaffNameTb
                    cmd.Parameters.AddWithValue("@spassword", StaffPassTb.Text);  // Assuming 'spassword' is StaffPassTb
                    cmd.Parameters.AddWithValue("@StaffId", Staffkey);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff Successfully Updated");
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

        private void ResetStaffBtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void StaffDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (StaffDGV.SelectedRows.Count > 0 && e.RowIndex >= 0)
            {
                StaffNameTb.Text = StaffDGV.SelectedRows[0].Cells[1].Value.ToString();
                StaffPhoneTb.Text = StaffDGV.SelectedRows[0].Cells[2].Value.ToString();
                StaffPassTb.Text = StaffDGV.SelectedRows[0].Cells[3].Value.ToString();


                if (StaffPhoneTb.Text == "")
                {
                    Staffkey = 0;
                }
                else
                {
                    Staffkey = Convert.ToInt32(StaffDGV.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminPannelForm ufor = new AdminPannelForm();
            ufor.Show();
            this.Hide();
        }
    }
}
