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
    public partial class year2019 : Form
    {
        SoundPlayer bruh = new SoundPlayer(Resource2019.Phoenix_2019);

        public year2019()
        {
            InitializeComponent();
        }

        private void year2019_Load(object sender, EventArgs e)
        {
            bruh.PlayLooping();
            ButtonPlay.Visible = false;
            guna2Panel1.VerticalScroll.Value = 0;
        }

        private void ButtonMute_Click(object sender, EventArgs e)
        {
            bruh.Stop();
            ButtonMute.Visible = false;
            ButtonPlay.Visible = true;
        }

        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            bruh.PlayLooping();
            ButtonPlay.Visible = false;
            ButtonMute.Visible = true;
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            bruh.Stop();
            MainMenu MM = new MainMenu(LoginTab.username);
            this.Close();
            MM.Show();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
