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
    public partial class EasterEgg : Form
    {
        SoundPlayer bruh = new SoundPlayer(ResourceEasterEgg.Devil_May_Cry_5___Bury_the_Light__Boss_Theme_Special_Edition___128kbit_AAC_);
        SoundPlayer nahida = new SoundPlayer(ResourceEasterEgg.Nahida_Theme_Music_EXTENDED___Boundless_Bliss__tnbee_mix____Genshin_Impact__152kbit_Opus_);

        public EasterEgg()
        {
            InitializeComponent();
        }

        private void EasterEgg_Load(object sender, EventArgs e)
        {
            bruh.PlayLooping();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            bruh.Stop();
            nahida.Stop();
            this.Hide();
            MainMenu MM = new MainMenu(LoginTab.username);
            MM.Show();
        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            bruh.Stop();
            nahida.PlayLooping();
        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {
            nahida.Stop();
            bruh.PlayLooping();
        }
    }
}
