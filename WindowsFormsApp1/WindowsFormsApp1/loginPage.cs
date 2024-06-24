using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Loginpage : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataReader dr;
        private OleDbTransaction sql;

        public Loginpage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            welcomepage welcomepage = new welcomepage();
            welcomepage.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Loginpage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chapman_Golf_club_DataSet.login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.chapman_Golf_club_DataSet.login);
            txtpassword.Clear();
            txtuser.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtuser.Text;
            string password = txtpassword.Text;
            
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Chapman Golf club .accdb;
Persist Security Info=False;";

            // Open the connection to the database
            conn.Open();

            // Create a query to retrieve the user's data from the database
            string query = "SELECT * FROM login WHERE Username = @Username AND Password = @Password";
            OleDbCommand cmd = new OleDbCommand(query, conn);

            // Set the parameters for the query
            cmd.Parameters.AddWithValue("@Username", txtuser.Text);
            cmd.Parameters.AddWithValue("@Password", txtpassword.Text);

            // Execute the query and retrieve the user's data
            OleDbDataReader reader = cmd.ExecuteReader();

            // Check if the user exists in the database
            if (reader.HasRows)
            {
                // The user exists, log them in
                MessageBox.Show("Login successful!");
                selection selection = new selection();
                selection.Show();
            }
            else
            {
                // The user doesn't exist, show an error message
                MessageBox.Show("Invalid username or password.");
            }

            // Close the database connection
            conn.Close();
        }
    }
}
