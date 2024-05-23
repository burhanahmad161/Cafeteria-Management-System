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
    public partial class UserFuctionalities : Form
    {
        public UserFuctionalities()
        {
            InitializeComponent();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            start obj = new start();
            this.Hide();
            obj.Show();
        }
        private void label1_Click_1(object sender, EventArgs e)
        {
            UserMenu obj = new UserMenu();
            this.Hide();
            obj.Show();
        }
        private void label5_Click_1(object sender, EventArgs e)
        {
            GivingRating obj = new GivingRating();
            obj.Show();
        }
    }
}
