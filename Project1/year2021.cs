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
    public partial class year2021 : Form
    {
        SoundPlayer niba = new SoundPlayer(Resource2021._2021);

        public year2021()
        {
            InitializeComponent();
        }

        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            niba.PlayLooping();
            ButtonPlay.Visible = false;
            ButtonMute.Visible = true;
        }

        private void ButtonMute_Click(object sender, EventArgs e)
        {
            niba.Stop();
            ButtonMute.Visible = false;
            ButtonPlay.Visible = true;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            niba.Stop();
            this.Close();
            MainMenu MM = new MainMenu(LoginTab.username);
            MM.Show();
        }

        private void year2021_Load(object sender, EventArgs e)
        {
            niba.PlayLooping();
            ButtonPlay.Enabled = false;
            guna2Panel1.VerticalScroll.Value = 0;
        }

    }
}
