namespace dcit318_assignment4_10979076
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Retrieve the text from the username and password textboxes
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Display the username and password in a MessageBox
            MessageBox.Show($"Username: {username}\nPassword: {password}", "Login Credentials");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}