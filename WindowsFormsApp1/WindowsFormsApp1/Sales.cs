using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        private void calculateAndDisplayCostsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double clubsSet = 0, gloves = 0, balls = 0, tshirt = 0, bags=0, rangefinder=0, washer=0, cart=0;

            if (radioButton1.Checked == true)
            {
                if (checkBox1.Checked == true)
                {
                    clubsSet = 27.00;
                }
                if (checkBox2.Checked == true)
                {
                    gloves = 7.00;
                }
                if (checkBox3.Checked == true)
                {
                    balls = 5.00;
                }
                if (checkBox4.Checked == true)
                {
                    bags = 17.00;
                }
                if (checkBox7.Checked == true)
                {
                    cart = 30.00;
                }
                if (checkBox6.Checked == true)
                {
                    rangefinder = 12.00;
                }
                if (checkBox5.Checked == true)
                {
                    tshirt = 7.00;
                }
                if (checkBox8.Checked == true)
                {
                    washer = 5.00;
                }
            }
            else if (radioButton2.Checked == true)
            {
                if (checkBox1.Checked == true)
                {
                    clubsSet = 27.00;
                }
                if (checkBox2.Checked == true)
                {
                    gloves = 7.00;
                }
                if (checkBox3.Checked == true)
                {
                    balls = 5.00;
                }
                if (checkBox4.Checked == true)
                {
                    bags = 17.00;
                }
                if (checkBox7.Checked == true)
                {
                    cart = 30.00;
                }
                if (checkBox6.Checked == true)
                {
                    rangefinder = 12.00;
                }
                if (checkBox5.Checked == true)
                {
                    tshirt = 7.00;
                }
                if (checkBox8.Checked == true)
                {
                    washer = 5.00;
                }
            }
            else if (radioButton3.Checked == true)
            {
                if (checkBox1.Checked == true)
                {
                    clubsSet = 27000.00;
                }
                if (checkBox2.Checked == true)
                {
                    gloves = 7000.00;
                }
                if (checkBox3.Checked == true)
                {
                    balls = 5000.00;
                }
                if (checkBox4.Checked == true)
                {
                    bags = 17000.00;
                }
                if (checkBox7.Checked == true)
                {
                    cart = 30000.00;
                }
                if (checkBox6.Checked == true)
                {
                    rangefinder = 12000.00;
                }
                if (checkBox5.Checked == true)
                {
                    tshirt = 7000.00;
                }
                if (checkBox8.Checked == true)
                {
                    washer = 5000.00;
                }
            }
            double FinalPrice;
            FinalPrice = washer + gloves + balls + tshirt + bags + rangefinder + cart + clubsSet;
            listBox1.Items.Add("The Total Price of selected items is $" + FinalPrice);
        }

        private void clearSelectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            checkBox1.Checked = false;  
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            listBox1.Items.Clear();
          
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
