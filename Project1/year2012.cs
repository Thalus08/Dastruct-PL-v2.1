using Guna.UI2.WinForms;
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
    public partial class year2012 : Form
    {

        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources._2012);

        public year2012()
        {
            InitializeComponent();
        }

        private void ButtonMute_Click(object sender, EventArgs e)
        {
            simpleSound.Stop();
            ButtonPlay.Visible = true;
            ButtonMute.Visible = false;
        }

        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            simpleSound.PlayLooping();
            ButtonMute.Visible = true;
            ButtonPlay.Visible = false;
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            simpleSound.Stop();
            MainMenu MM = new MainMenu(LoginTab.username);
            this.Close();
            MM.Show();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void year2012_Load(object sender, EventArgs e)
        {
            simpleSound.PlayLooping();
            ButtonPlay.Visible = false;

            guna2Panel1.VerticalScroll.Value = 0;
        }


    }
}
