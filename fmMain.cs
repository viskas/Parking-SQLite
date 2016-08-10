using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Parking
{
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();
        }

        private void nCarType_Click(object sender, EventArgs e)
        {
            var f = new fmCarType();
            f.ShowDialog();
            f.Dispose();
        }

        private void nCarColor_Click(object sender, EventArgs e)
        {
            var f = new fmCarColor();
            f.ShowDialog();
            f.Dispose();
        }

        private void nLocation_Click(object sender, EventArgs e)
        {
            var f = new fmLocation();
            f.ShowDialog();
            f.Dispose();
        }

        private void nCar_Click(object sender, EventArgs e)
        {
            var f = new fmCar();
            f.ShowDialog();
            f.Dispose();
        }

        private void nPrice_Click(object sender, EventArgs e)
        {
            var f = new fmPrice();
            f.ShowDialog();
            f.Dispose();
        }

        private void nPeople_Click(object sender, EventArgs e)
        {
            var f = new fmPeople();
            f.ShowDialog();
            f.Dispose();
        }

        private void nRegistartion_Click(object sender, EventArgs e)
        {
            var f = new fmParking();
            f.ShowDialog();
            f.Dispose();
        }

        private void nHistory_Click(object sender, EventArgs e)
        {
            var f = new fmHistory();
            f.ShowDialog();
            f.Dispose();
        }
    }
}
