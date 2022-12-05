using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class year2014 : Form
    {
        SoundPlayer bruh = new SoundPlayer(Resource2014._2014);

        public year2014()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            bruh.Stop();
            MainMenu MM = new MainMenu(LoginTab.username);
            this.Close();
            MM.Show();
        }

        private void ButtonMute_Click(object sender, EventArgs e)
        {
            bruh.Stop();
            ButtonPlay.Visible = true;
            ButtonMute.Visible = false;
        }

        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            bruh.PlayLooping();
            ButtonMute.Visible = true;
            ButtonPlay.Visible = false;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void year2014_Load(object sender, EventArgs e)
        {
            bruh.PlayLooping();
            ButtonPlay.Visible = false;

            guna2Panel1.VerticalScroll.Value = 0;
        }
    }
}
