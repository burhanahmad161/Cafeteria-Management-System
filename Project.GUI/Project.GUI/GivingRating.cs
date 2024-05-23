using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.DL;

namespace Project.GUI
{
    public partial class GivingRating : Form
    {
        public GivingRating()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text =="Enter your name")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Silver;
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Enter your name";
                textBox1.ForeColor = Color.Silver;
            }
        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Please enter a rating between 1 and 5")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Silver;
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Please enter a rating between 1 and 5";
                textBox2.ForeColor = Color.Silver;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(int.Parse(textBox2.Text) > 0 && int.Parse(textBox2.Text) < 6)
            {
                GivenRatingDL.storeReview(textBox1.Text, int.Parse(textBox2.Text));
                MessageBox.Show("Review added Successfully");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Enter a rating between 1 and 5");
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            UserFuctionalities obj = new UserFuctionalities();
            this.Hide();
            obj.Show();
        }
    }
}
