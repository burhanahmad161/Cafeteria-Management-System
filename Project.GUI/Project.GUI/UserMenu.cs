using Project.BL;
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
    public partial class UserMenu : Form
    {
        public UserMenu()
        {
            InitializeComponent();
            dataGridView1.DataSource = ProductDL.p1;
        }

        private void DisplayMenu_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ProductDL.p1;
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.HeaderText = "";
            deleteButton.UseColumnTextForButtonValue = true;
            deleteButton.Text = "Add to Cart";
            deleteButton.Width = 60;
            dataGridView1.Columns.Add(deleteButton);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            UserFuctionalities obj = new UserFuctionalities();
            this.Hide();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddingItem obj = new AddingItem();
            this.Hide();
            obj.Show();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        int rate;
        string category;
        private static bool validation(string item)
        {
            bool flag = false;
            if(OrderedProductDL.order.Count != 0)
            {
                for(int i = 0; i < OrderedProductDL.order.Count; i++)
                {
                    if(item == OrderedProductDL.order[i].Name1)
                    {
                      flag = true;
                    }
                }
            }
            else
            {
                for(int i=0;i<OrderedProductDL.order.Count;i++)
                {
                    if(item != OrderedProductDL.order[i].Name1)
                    {
                        flag = false;
                    }
                }
            }
            return flag;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(OrderedProductDL.order.Count > 0)
            {
                DisplayCart obj = new DisplayCart();
                this.Hide();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Cart is empty");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {
                string name = ProductDL.p1[e.RowIndex].ItemName;
                bool flag = validation(name);
                if(flag == false)
                {
                             MessageBox.Show("Item added to cart");
                             int rate = ProductDL.p1[e.RowIndex].ItemRate;
                             string category = ProductDL.p1[e.RowIndex].Category;
                             OrderedProduct obj = new OrderedProduct(name, rate, 1, category);
                             OrderedProductDL.order.Add(obj);  
                }
                else
                {
                    for (int i = 0; i < OrderedProductDL.order.Count; i++)
                    {
                        if (name == OrderedProductDL.order[i].Name1)
                        {
                            OrderedProductDL.order[i].Quantity1++;
                            MessageBox.Show("Quantity increased by 1");
                            break;
                        }
                    }
                }
            }
        }
    }
}
