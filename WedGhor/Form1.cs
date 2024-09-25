namespace WedGhor
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void CustomerLoginButton_Click(object sender, EventArgs e)
        {
            CustomerLoginForm CustomerloginForm = new CustomerLoginForm();
            CustomerloginForm.Show();
            this.Hide();
        }

        private void AdminLoginButton_Click(object sender, EventArgs e)
        {
            AdminLoginForm AdminloginForm = new AdminLoginForm();
            AdminloginForm.Show();
            this.Hide();
        }

        private void StaffLoginButton_Click(object sender, EventArgs e)
        {
            StaffLoginForm staffLoginForm = new StaffLoginForm();
            staffLoginForm.Show();
            this.Hide();
        }

        private void Closelabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
