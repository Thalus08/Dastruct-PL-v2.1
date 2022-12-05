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
    public partial class year2018 : Form
    {
        SoundPlayer g = new SoundPlayer(Resource2018.RISE_2018);

        public year2018()
        {
            InitializeComponent();
        }

        private void ButtonMute_Click(object sender, EventArgs e)
        {
            g.Stop();
            ButtonMute.Visible = false;
            ButtonPlay.Visible = true;
        }

        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            g.PlayLooping();
            ButtonPlay.Visible = false;
            ButtonMute.Visible = true;
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            g.Stop();
            MainMenu MM = new MainMenu(LoginTab.username);
            this.Close();
            MM.Show();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void year2018_Load(object sender, EventArgs e)
        {
            g.PlayLooping();
            ButtonPlay.Visible = false;
            guna2Panel1.VerticalScroll.Value = 0;
        }
    }
}
