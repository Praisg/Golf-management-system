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
    public partial class welcomepage : Form
    {
        public welcomepage()
        {
            InitializeComponent();
        }

        private void proceedToLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Loginpage Loginpage = new Loginpage();
            Loginpage.Show();
        }

        private void viewGolfClubInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GolfInfo golfInfo = new GolfInfo();
            golfInfo.Show();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Members_Info members_Info = new Members_Info();
            members_Info.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Show();
        }
    }
}
