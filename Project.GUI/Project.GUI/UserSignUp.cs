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
    public partial class UserSignUp : Form
    {
        public UserSignUp()
        {
            InitializeComponent();
        }

        private void start_Load(object sender, EventArgs e)
        {

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
            int n = textBox2.TextLength;
            if (n >= 8)
            {
                if(checkBox1.Checked)
                {

                    bool flag = UserLoginBL.isvaliduser(textBox3.Text);
                    if (flag == true)
                    {
                        UserLoginBL obj = new UserLoginBL(textBox1.Text, textBox2.Text, textBox2.Text, int.Parse(textBox7.Text), int.Parse(textBox8.Text));
                        UserLoginDL.addIntoFile(obj);
                        UserLoginDL.addIntoList(obj);
                        MessageBox.Show("Successfully Signed Up");
                        UserLoginDL.loadData();
                        start abc = new start();
                        abc.Show();
                    }
                    else
                    {
                        MessageBox.Show("UserName already exist. Please choose another UserName");
                    }
                }
                else
                {
                    MessageBox.Show("Please agree to the given conditions");
                }
            }
            else
            {
                MessageBox.Show("Your password should be grater than or equal to 8 digits");
            }

        }
        private void textBox7_enter(object sender, EventArgs e)
        {
            if (textBox7.Text == "Enter Card Number")
            {
                textBox7.Text = "";
                textBox7.ForeColor = Color.Silver;
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                textBox7.Text = "Enter Card Number";
                textBox7.ForeColor = Color.Silver;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter User Name")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Silver;
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Enter User Name";
                textBox1.ForeColor = Color.Silver;
            }
        }
        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Enter Name")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Silver;
            }
        }
        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Enter Name";
                textBox3.ForeColor = Color.Silver;
            }
        }
        private void textBox8_Enter(object sender, EventArgs e)
        {
            if (textBox8.Text == "Enter Pin")
            {
                textBox8.Text = "";
                textBox8.ForeColor = Color.Silver;
            }
        }
        private void textBox8_Leave(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                textBox8.Text = "Enter Pin";
                textBox8.ForeColor = Color.Silver;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserLoginPage obj = new UserLoginPage();
            obj.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Do you agree that this is the most beautiful application ever?");
        }
    }
}
