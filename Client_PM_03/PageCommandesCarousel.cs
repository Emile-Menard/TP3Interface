﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_PM
{
    public partial class PageCommandesCarousel : Form
    {
        public PageCommandesCarousel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PageCommandesCarousel_Load(object sender, EventArgs e)
        {
            this.Location = Properties.Settings.Default.LocationCarouselCommandes;
        }

        private void PageCommandesCarousel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.LocationCarouselCommandes = this.Location;
            Properties.Settings.Default.Save();
        }
    }
}
