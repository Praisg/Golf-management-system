using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class selection : Form
    {
        public selection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Members_Info members_Info = new Members_Info();
            members_Info.Show();
            selection selection = new selection();
            selection.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Show();
            selection selection = new selection();
            selection.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Loginpage loginpage = new Loginpage();
            loginpage.Show();
            selection selection = new selection();
            selection.Hide();
        }
    }
}
