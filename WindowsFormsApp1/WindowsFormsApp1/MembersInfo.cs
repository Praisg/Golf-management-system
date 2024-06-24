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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Members_Info : Form
    {
        public object ConfigurationManager { get; private set; }

        public Members_Info()
        {
            InitializeComponent();
            
        }

        private void Members_Info_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chapman_Golf_club_DataSet.MemberInfo' table. You can move, or remove it, as needed.
            this.memberInfoTableAdapter.Fill(this.chapman_Golf_club_DataSet.MemberInfo);
      txtsearch.Clear();    
        }

        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberInfoBindingSource.MoveNext();
        }

        private void previousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberInfoBindingSource.MovePrevious();
        }

        private void viewLastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberInfoBindingSource.MoveLast();
        }

        private void viewFirstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberInfoBindingSource.MoveFirst();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberInfoBindingSource.RemoveCurrent();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberInfoBindingSource.AddNew();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            { 
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Chapman Golf club .accdb;";
                string tableName = "MemberInfo";
                string memberIdColumnName = "MemberID";
                string nameColumnName = "FirstName";
                string SurnameColumnName = "Surname";
                string AgeColumnName = "Age";
                string GenderColumnName = "Gender";
                string MembershipColumnName = "MemberType";
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string query = $"UPDATE {tableName} SET {nameColumnName}=@name, {SurnameColumnName}=@Surname, {AgeColumnName}=@age,  {GenderColumnName}=@Gender,  {MembershipColumnName}=@membertype WHERE {memberIdColumnName}=@MemberID" +
                        $".";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MemberID", txtID.Text);
                        command.Parameters.AddWithValue("@name", txtName.Text);
                        command.Parameters.AddWithValue("@Surname", txtSurname.Text);
                        command.Parameters.AddWithValue("@id", txtID.Text);
                        command.Parameters.AddWithValue("@age", txtAge.Text);
                        command.Parameters.AddWithValue("@Gender", genderbox.Text);
                        command.Parameters.AddWithValue("@membertype", memberbox.Text);

                        int rowsUpdated = command.ExecuteNonQuery();

                        OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, tableName);

                        if (rowsUpdated > 0)
                        {
                            MessageBox.Show("Record updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No record updated.");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            //Get the search term from the text box
            string searchTerm = txtsearch.Text;

            //Create a new DataTable to hold the search results
            DataTable searchResults = new DataTable();

            //Open a connection to the database
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Chapman Golf club .accdb");

            //Create a command to search for the specified term
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM MemberInfo WHERE FirstName LIKE '%" + searchTerm + "%'", conn);

            //Open the connection and execute the search command
            conn.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            adapter.Fill(searchResults);
            conn.Close();

            //Bind the search results to the DataGridView
            dataGridView1.DataSource = searchResults;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void clearSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtsearch.Text = "";
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);    
        }
    }
}
