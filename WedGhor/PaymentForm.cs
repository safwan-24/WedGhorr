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
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void NagadCb_CheckedChanged(object sender, EventArgs e)
        {
            NagadForm nagadForm = new NagadForm();
            nagadForm.Show();
            this.Hide();
        }

        private void BkashCb_CheckedChanged(object sender, EventArgs e)
        {
            BkashForm bkashForm = new BkashForm();
            bkashForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            CustomerPanel customerPanel = new CustomerPanel();
            customerPanel.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WelcomeForm WelcomeForm = new WelcomeForm();
            WelcomeForm.Show();
            this.Hide();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            
        }
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
