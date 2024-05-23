using Project.BL;
using Project.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.GUI
{
    public partial class finish : Form
    {
        public finish()
        {
            InitializeComponent();
        }
        private void facebook_button(object sender, EventArgs e)
        {
            MessageBox.Show("Contact us on Facebook at 'Burhan Ahmad'");
        }

        private void twiiter_click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact us on Twitter at 'Burhan Ahmad'");
        }

        private void gmail_button(object sender, EventArgs e)
        {
            MessageBox.Show("Contact us on Gmail at 'burhanahmad1616j@gmail.com'");
        }

        private void insta_button(object sender, EventArgs e)
        {
            MessageBox.Show("Contact us on Instagram at 'burhan_ahmad'");
        }

        private void HomeButton(object sender, EventArgs e)
        {
            this.Hide();
            UserFuctionalities obj = new UserFuctionalities();
            obj.Show();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            begin obj = new begin();
            this.Hide();
            obj.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
