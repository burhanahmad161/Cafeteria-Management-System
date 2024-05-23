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
    public partial class begin : Form
    {
        public begin()
        {
            InitializeComponent();
        }

        private void start_Load(object sender, EventArgs e)
        {

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
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            start obj = new start();
            obj.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            UserLoginPage obj = new UserLoginPage();
            obj.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
