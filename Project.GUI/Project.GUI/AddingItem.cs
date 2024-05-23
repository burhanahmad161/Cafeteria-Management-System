using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.BL;
using Project.DL;

namespace Project.GUI
{
    public partial class AddingItem : Form
    {
        public AddingItem()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text =="Enter Item Name")
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
        private void GivingRating_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(int.Parse(textBox2.Text)>0)
            {
                if(textBox3.Text != "Food" || textBox3.Text != "Drink")
                {
                    AddingItem obj2 = new AddingItem();
                    ProductBL obj = new ProductBL(textBox1.Text,int.Parse(textBox2.Text),textBox3.Text);
                    ProductDL.addIntoList(obj);
                    ProductDL.addIntoFile(obj);
                    MessageBox.Show("Item Added successfully");
                    this.Hide();
                    obj2.Refresh();

                }
                else
                {
                    MessageBox.Show("Enter valid category i.e Food or Drink");
                }
            }
            else
            {
                MessageBox.Show("Enter valid price");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DisplayMenu pbj = new DisplayMenu();
            this.Hide();
            pbj.Show();
        }
    }
}
