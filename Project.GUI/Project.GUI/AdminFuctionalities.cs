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
    public partial class AdminFuctionalities : Form
    {
        public AdminFuctionalities()
        {
            InitializeComponent();
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            begin obj = new begin();
            this.Hide();
            obj.Show();
        }
        private void AdminFuctionalities_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
        {
            DisplayMenu obj = new DisplayMenu();
            this.Hide();
            obj.Show();
        }
        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuform obj = new menuform();
            obj.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            AllUsers obj = new AllUsers();
            this.Hide();
            obj.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            AllAdmins obj = new AllAdmins();
            this.Hide();
            obj.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
