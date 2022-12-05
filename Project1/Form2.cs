using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class MainMenu : Form
    {



        public MainMenu(string user)
        {
            InitializeComponent();
            if (user == "Guest")
            {
                UsernameShowGuest.Show();
                Username.Hide();
            }
            else
            {
                UsernameShowGuest.Hide();
                Username.Text = LoginTab.username;
                Username.Show();
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }


        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginTab LT = new LoginTab();
            LT.Show();
        }

        private void Button2011_Click(object sender, EventArgs e)
        {
            this.Hide();
            year2011 yr2011 = new year2011();
            yr2011.Show();
        }

        private void Button2013_Click(object sender, EventArgs e)
        {
            this.Hide();
            year2013 yr2013 = new year2013();
            yr2013.Show();
        }

        private void Button2012_Click(object sender, EventArgs e)
        {
            this.Hide();
            year2012 yr2012 = new year2012();
            yr2012.Show();
        }

        private void Button2014_Click(object sender, EventArgs e)
        {
            this.Hide();
            year2014 yr2014 = new year2014();
            yr2014.Show();
        }

        private void Button2015_Click(object sender, EventArgs e)
        {
            this.Hide();
            year2015 yr2015 = new year2015();
            yr2015.Show();
        }

        private void Button2016_Click(object sender, EventArgs e)
        {
            this.Hide();
            year2016 yr2016 = new year2016();
            yr2016.Show();
        }

        private void Button2017_Click(object sender, EventArgs e)
        {
            this.Hide();
            year2017 yr2017 = new year2017();
            yr2017.Show();
        }

        private void Button2018_Click(object sender, EventArgs e)
        {
            this.Hide();
            year2018 yr2018 = new year2018();
            yr2018.Show();
        }

        private void Button2019_Click(object sender, EventArgs e)
        {
            this.Hide();
            year2019 yr2019 = new year2019();
            yr2019.Show();
        }

        private void Button2020_Click(object sender, EventArgs e)
        {
            this.Hide();
            year2020 yr2020 = new year2020();
            yr2020.Show();
        }

        private void Button2021_Click(object sender, EventArgs e)
        {
            this.Hide();
            year2021 yr2021 = new year2021();
            yr2021.Show();
        }

        private void Button2022_Click(object sender, EventArgs e)
        {
            this.Hide();
            year2022 yr2022 = new year2022();
            yr2022.Show();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonEasterEgg_Click(object sender, EventArgs e)
        {
            this.Hide();
            EasterEgg egg = new EasterEgg();
            egg.Show();
        }
    }
}