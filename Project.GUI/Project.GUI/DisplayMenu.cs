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
    public partial class DisplayMenu : Form
    {
        public DisplayMenu()
        {
            InitializeComponent();
            dataGridView1.DataSource = ProductDL.p1;
        }

        private void DisplayMenu_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ProductDL.p1;
            //////////////Edit Button///////////////////////////
            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            editButton.FlatStyle = FlatStyle.Popup;
            editButton.HeaderText = "";
            editButton.UseColumnTextForButtonValue = true;
            editButton.Text = "Edit";
            editButton.Width= 60;
            if(dataGridView1.Columns.Contains(editButton.Name = "Edit"))
            {

            }
            else
            {
            dataGridView1.Columns.Add(editButton);
            }

            //////////////Delete Buttom/////////////////////////
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.HeaderText = "";
            deleteButton.UseColumnTextForButtonValue = true;
            deleteButton.Text = "Delete";
            deleteButton.Width = 60;
            dataGridView1.Columns.Add(deleteButton);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AdminFuctionalities obj = new AdminFuctionalities();
            this.Hide();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddingItem obj = new AddingItem();
            this.Hide();
            obj.Show();
        }
            int n;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {
                n = e.RowIndex;
                label2.Hide();
                pictureBox1.Show();
                pictureBox8.Show();
                pictureBox9.Show();
                textBox1.Show();
                textBox2.Show();
                textBox3.Show();
                button2.Show();
                n = e.RowIndex;

            }
            else if(e.ColumnIndex == 4)
            {
                int b = e.RowIndex;
                ProductDL.p1.RemoveAt(b);
                ProductDL.deleteItems_fromFile();
                dataGridView1.Columns.RemoveAt(b);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ProductDL.p1;
                MessageBox.Show("Item Deleted Successfully");
                this.Refresh();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Show();
            pictureBox1.Hide();
            pictureBox8.Hide();
            pictureBox9.Hide();
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            ProductDL.p1[n].ItemName = textBox1.Text;
            ProductDL.p1[n].ItemRate = int.Parse(textBox2.Text);
            ProductDL.p1[n].Category = textBox3.Text;
            button2.Hide();
            this.Refresh();
            ProductDL.UpdateItems_fromFile();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter Item Name")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Silver;
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Enter Item Name";
                textBox1.ForeColor = Color.Silver;
            }
        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Enter Item Rate")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Silver;
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Enter Item Rate";
                textBox2.ForeColor = Color.Silver;
            }
        }
        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Enter Category")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Silver;
            }
        }
        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Enter Category";
                textBox2.ForeColor = Color.Silver;
            }
        }
    }
}
