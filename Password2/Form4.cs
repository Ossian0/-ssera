using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings1.Default.User2 = textBox1.Text;
            Settings1.Default.Password2 = textBox2.Text;

            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
