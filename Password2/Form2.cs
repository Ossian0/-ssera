using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Net;
using System.Web;
using static System.Net.WebRequestMethods;

namespace Password2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Youtube = "https://www.youtube.com";
            Process.Start(new ProcessStartInfo
            {
                FileName = Youtube,
                UseShellExecute = true
            });

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String Twitch = "https://www.twitch.tv";
            Process.Start(new ProcessStartInfo
            {
                FileName = Twitch,
                UseShellExecute = true
            });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Netflix = "https://www.netflix.com/se/";
            Process.Start(new ProcessStartInfo
            {
                FileName = Netflix,
                UseShellExecute = true
            });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Svtplay = "https://www.svtplay.se";
            Process.Start(new ProcessStartInfo
            {
                FileName = Svtplay,
                UseShellExecute = true
            });
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string Disneyplus = "https://www.disneyplus.com/sv-se";
            Process.Start(new ProcessStartInfo
            {
                FileName = Disneyplus,
                UseShellExecute = true
            });
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string Spotfy = "https://open.spotify.com";
            Process.Start(new ProcessStartInfo
            {
                FileName = Spotfy,
                UseShellExecute = true
            });
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string classroom = "https://classroom.google.com/u/1/?pli=1";
            Process.Start(new ProcessStartInfo
            {
                FileName = classroom,
                UseShellExecute = true
            });
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string instagram = "https://www.instagram.com";
            Process.Start(new ProcessStartInfo
            {
                FileName = instagram,
                UseShellExecute = true
            });
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string facebook = "https://sv-se.facebook.com";
            Process.Start(new ProcessStartInfo
            {
                FileName = facebook,
                UseShellExecute = true
            });
        }
    }
}
