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
    public partial class year2022 : Form
    {
        SoundPlayer bruh = new SoundPlayer(Resource2022.STAR_WALKIN_2022);

        public year2022()
        {
            InitializeComponent();
        }

        private void year2022_Load(object sender, EventArgs e)
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
            this.Close();
            MainMenu r = new MainMenu(LoginTab.username);
            r.Show();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
