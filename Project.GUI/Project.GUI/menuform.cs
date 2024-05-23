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
    public partial class menuform : Form
    {
        public menuform()
        {
            InitializeComponent();
            dataGridView1.DataSource = GivenRatingDL.ratings;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuform_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GivenRatingDL.ratings;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            begin obj = new begin();
            obj.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            AdminFuctionalities obj = new AdminFuctionalities();
            this.Hide();
            obj.Show();
        }
    }
}
