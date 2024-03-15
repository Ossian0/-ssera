namespace Password2
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

        private void button1_Click(object sender, EventArgs e)
        {
            string password = Settings1.Default.Password;
            string username = Settings1.Default.User1;
            string password2 = Settings1.Default.Password2;
            string username2 = Settings1.Default.User2;
            if ((textBox1.Text == username) && (textBox2.Text == password) || (textBox1.Text== username2) && (textBox2.Text== password2))
            {
                MessageBox.Show("You have succesfully logged in.", "Össera");
                Form2 form2 = new Form2();
                Form1 form1 = new Form1();
                form2.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Wrong Username or password, please Try again.", "Össera logg in");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }
    }
}
