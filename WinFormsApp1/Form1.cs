namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "user" && txtpassword.Text == "1234")
            {
                MessageBox.Show("Login Successfull");
            }
            else {
                MessageBox.Show("Login Failed");
            }

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtpassword.Clear();
        }
    }
}
