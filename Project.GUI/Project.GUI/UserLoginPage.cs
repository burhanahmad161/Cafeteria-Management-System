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
    public partial class UserLoginPage : Form
    {
        public UserLoginPage()
        {
            InitializeComponent();
        }

        private void start_Load(object sender, EventArgs e)
        {

        }
        private void UserName(object sender, EventArgs e)
        {
            if(textBox1.Text == "Enter User Name")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void UserName_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Enter User Name";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void Pass_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Enter Password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Silver;
            }
        }

        private void Pass_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Enter Password";
                textBox2.ForeColor = Color.Silver;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UserSignUp obj = new UserSignUp();
            obj.Show();
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
            begin obj = new begin();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool decision = UserLoginBL.signin(textBox1.Text, textBox2.Text);
            if (decision == true)
            {
                MessageBox.Show("Welcome User");
                this.Hide();
                UserFuctionalities obj = new UserFuctionalities();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
