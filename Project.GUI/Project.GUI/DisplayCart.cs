using Project.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project.GUI
{
    public partial class DisplayCart : Form
    {
        public DisplayCart()
        {
            InitializeComponent();
            dataGridView1.DataSource = OrderedProductDL.order;
        }

        private void DisplayMenu_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = OrderedProductDL.order;

            //////////////////+ button/////////////////////////
            DataGridViewButtonColumn increase = new DataGridViewButtonColumn();
            increase.FlatStyle = FlatStyle.Popup;
            increase.HeaderText = "";
            increase.UseColumnTextForButtonValue = true;
            increase.Text = "+";
            increase.Width = 20;
            dataGridView1.Columns.Add(increase);
            /////////////////- button/////////////////////////
            DataGridViewButtonColumn decrease = new DataGridViewButtonColumn();
            decrease.FlatStyle = FlatStyle.Popup;
            decrease.HeaderText = "";
            decrease.UseColumnTextForButtonValue = true;
            decrease.Text = "-";
            decrease.Width = 20;
            dataGridView1.Columns.Add(decrease);
            //////////////Delete Buttom/////////////////////////
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.HeaderText = "";
            deleteButton.UseColumnTextForButtonValue = true;
            deleteButton.Text = "Remove";
            deleteButton.Width = 60;
            dataGridView1.Columns.Add(deleteButton);
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            UserFuctionalities obj = new UserFuctionalities();
            this.Hide();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(OrderedProductDL.order.Count > 0)
            {
                this.Hide();
                CheckOut obj = new CheckOut();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Cart is empty");
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                int b = e.RowIndex;
                OrderedProductDL.order[b].Quantity1++;
                this.Refresh();
            }
            if (e.ColumnIndex == 5)
            {
                int b = e.RowIndex;
                if(OrderedProductDL.order[b].Quantity1 > 1)
                {
                OrderedProductDL.order[b].Quantity1--;
                    this.Refresh();
                }
                else if(OrderedProductDL.order[b].Quantity1 == 1)
                {
                    OrderedProductDL.order.RemoveAt(b);
                    dataGridView1.Columns.RemoveAt(b);
                    this.Refresh();
                }
            }
            if (e.ColumnIndex == 6)
            {
                int b = e.RowIndex;
                OrderedProductDL.order.RemoveAt(b);
                dataGridView1.Columns.RemoveAt(b);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = OrderedProductDL.order;
                MessageBox.Show("Item Removed from cart");
                DisplayCart obj = new DisplayCart();
                this.Hide();
                obj.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
