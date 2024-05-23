using Microsoft.Win32;
using Project.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project.GUI
{
    public partial class CheckOut : Form
    {
        public CheckOut()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            double foodBill = 0;
            double beverageBill = 0;
            double beverageDiscount = 0;
            double foodDiscount = 0;
            pictureBox1.Hide();
            pictureBox3.Hide();
            label2.Hide();
            label3.Hide();
            DiscountDL.DataTransfer();
            foreach (double q in DiscountDL.food)
            {
                foodBill = foodBill + q;
                FoodDiscount abc = new FoodDiscount();
                foodDiscount = foodDiscount + abc.calculateTax(foodBill);
            }
            foreach (double q in DiscountDL.drinks)
            {
                beverageBill = beverageBill + q;
                BeverageDiscount abc = new BeverageDiscount();
                beverageDiscount = beverageDiscount + abc.calculateTax(beverageBill);
            }
            double totalBill = foodBill + beverageBill;
            MenuDL.FinalBill = totalBill - (foodDiscount + beverageDiscount);
            label5.Text = "Your bill is ruppes " + MenuDL.FinalBill.ToString() + "/-";
            label1.Text = "You were given discount of " + (foodDiscount+beverageDiscount).ToString() + "/-";
            label1.Show();
            label5.Show();
            textBox1.Show();
            button1.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DisplayCart obj = new DisplayCart();
            this.Hide();
            obj.Show();
        }
        private void Pass_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter amout of money recieved here")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.White;
            }
        }

        private void Pass_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Enter amout of money recieved here";
                textBox1.ForeColor = Color.White;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(int.Parse(textBox1.Text) != null)
            {
                if( double.Parse(textBox1.Text) > 0 && double.Parse(textBox1.Text) >  MenuDL.FinalBill)
                {
                    finish obj = new finish();
                    obj.Show();
                }
                else
                {
                    MessageBox.Show("Your amount is not enough.Please pay your complete bill");
                }
            }
            else
            {
                MessageBox.Show("Please enter the amount");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            double foodBill = 0;
            double beverageBill = 0;
            double beverageDiscount = 0;
            double foodDiscount = 0;
            pictureBox1.Hide();
            pictureBox3.Hide();
            label2.Hide();
            label3.Hide();
            DiscountDL.DataTransfer();
            foreach (double q in DiscountDL.food)
            {
                foodBill = foodBill + q;
                FoodDiscount abc = new FoodDiscount();
                foodDiscount = foodDiscount + abc.calculateTax(foodBill);
            }
            foreach (double q in DiscountDL.drinks)
            {
                beverageBill = beverageBill + q;
                BeverageDiscount abc = new BeverageDiscount();
                beverageDiscount = beverageDiscount + abc.calculateTax(beverageBill);
            }
            double totalBill = foodBill + beverageBill;
            MenuDL.FinalBill = totalBill - (foodDiscount + beverageDiscount);
            label5.Text = "Your bill is ruppes " + MenuDL.FinalBill.ToString() + "/-";
            label1.Text = "You were given discount of " + (foodDiscount + beverageDiscount).ToString() + "/-";
            label1.Show();
            label5.Show();
            textBox1.Show();
            button1.Show();
        }
    }
}
