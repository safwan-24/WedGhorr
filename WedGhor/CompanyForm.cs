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
    public partial class CompanyForm : Form
    {
        public CompanyForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            StaffPanelForm sf = new StaffPanelForm();
            sf.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            StaffPanelForm sf = new StaffPanelForm();
            sf.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            StaffPanelForm sf = new StaffPanelForm();
            sf.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            StaffPanelForm sf = new StaffPanelForm();
            sf.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaffLoginForm sf = new StaffLoginForm();
            sf.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            StaffPanelForm sf = new StaffPanelForm();
            sf.Show();
            this.Hide();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            StaffPanelForm sf = new StaffPanelForm();
            sf.Show();
            this.Hide();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            StaffPanelForm sf = new StaffPanelForm();
            sf.Show();
            this.Hide();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            StaffPanelForm sf = new StaffPanelForm();
            sf.Show();
            this.Hide();
        }
    }
}
