using Guna.Charts.WinForms;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class year2011 : Form
    {

        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources._2011);

        public year2011()
        {
            InitializeComponent();
        }

        // ANTI-TEARING
        
        private void panel1_Scroll(object sender, ScrollEventArgs e)
        {
            guna2Panel1.Invalidate();

            if (e.Type == ScrollEventType.First)
            {
                LockWindowUpdate(this.Handle);
            }
            else
            {
                LockWindowUpdate(IntPtr.Zero);
                guna2Panel1.Update();
                if (e.Type != ScrollEventType.Last) LockWindowUpdate(this.Handle);
            }
        }
        
        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_EX_COMPOSITED = 0x02000000;
                var cp = base.CreateParams;
                cp.ExStyle |= WS_EX_COMPOSITED;
                return cp;
            }
        }
        
        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool LockWindowUpdate(IntPtr hWnd);



        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            simpleSound.Stop();
            MainMenu MM = new MainMenu(LoginTab.username);
            this.Close();
            MM.Show();
        }

        private void year2011_Load(object sender, EventArgs e)
        {
            simpleSound.PlayLooping();
            ButtonPlay.Visible = false;

            guna2Panel1.VerticalScroll.Value = 0;
        }

        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            
            simpleSound.PlayLooping();
            ButtonMute.Visible = true;
            ButtonPlay.Visible = false;
        }

        private void ButtonMute_Click(object sender, EventArgs e)
        {
            simpleSound.Stop();
            ButtonPlay.Visible = true;
            ButtonMute.Visible = false;
        }
   
    }
}
