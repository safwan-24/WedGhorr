using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WedGhor
{
    public partial class AdminPannelForm : Form
    {
        public AdminPannelForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ViewBookingBtn_Click(object sender, EventArgs e)
        {
            ViewOrder viewOrder = new ViewOrder();
            viewOrder.Show();
            this.Hide();
        }

        private void ViewCustomerBtn_Click(object sender, EventArgs e)
        {
            CustomerForm form1 = new CustomerForm();
            form1.Show();
            this.Hide();
        }

        private void ViewStaffBtn_Click(object sender, EventArgs e)
        {
            StaffForm form2 = new StaffForm();
            form2.Show();
            this.Hide();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            WelcomeForm welcomeForm = new WelcomeForm();
            welcomeForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminPannelForm_Load(object sender, EventArgs e)
        {

        }
    }
}
