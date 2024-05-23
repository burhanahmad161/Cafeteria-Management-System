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
    public partial class AllAdmins : Form
    {
        public AllAdmins()
        {
            InitializeComponent();
            dataGridView1.DataSource = AdminLoginDL.adminDetails;
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            AdminFuctionalities obj = new AdminFuctionalities();
            this.Hide();
            obj.Show();
        }
        private void AllAdmins_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = AdminLoginDL.adminDetails;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminSignUp obj = new AdminSignUp();
            this.Hide();
            obj.Show();
        }
    }
}
