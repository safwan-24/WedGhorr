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
    public partial class StaffPanelForm : Form
    {
        public StaffPanelForm()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            CompanyForm companyForm = new CompanyForm();
            companyForm.Show();
            this.Hide();
        }

        private void ViewBookingBtn_Click(object sender, EventArgs e)
        {
            StaffViewOrder staffViewOrder = new StaffViewOrder();
            staffViewOrder.Show();
            this.Hide();
        }

        private void VipBtn_Click(object sender, EventArgs e)
        {
            PaidCustomer paidCustomer = new PaidCustomer();
            paidCustomer.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ViewSceduleBtn_Click(object sender, EventArgs e)
        {
            StaffScedule sta = new StaffScedule();
            sta.Show();
            this.Hide();
        }
    }
}
