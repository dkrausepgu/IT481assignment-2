using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Form1_Load() called...");
            connectioncheck.Text = "Startup...";
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Delta Home\source\repos\WindowsFormsApp2\WindowsFormsApp2\northwnd.mdf;Integrated Security=True;Connect Timeout=30";
                connection.Open();
                connectioncheck.Text = "Connection Successful";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, " + ex);
            }

        }
        private void updatedb_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Delta Home\Desktop\northwnd.mdf; Integrated Security = True;";
            connection.Open();
            command.Connection = connection;
            command.CommandText = "insert into customers (ID, Company) values('" + idtext.Text + "' , '" + compnametext.Text + "')";
            command.ExecuteNonQuery();
            MessageBox.Show("Data Saved");
            connection.Close();
        }

        private void viewdb_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Delta Home\Desktop\northwnd.mdf; Integrated Security = True;";
            connection.Open();
            command.Connection = connection;
            command.CommandText = "select * from Customers";
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void countrec_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Delta Home\Desktop\northwnd.mdf; Integrated Security = True;";
            connection.Open();
            command.Connection = connection;
            command.CommandText = "select count(*) from Customers";
            int count = (int)command.ExecuteScalar();
            numrec.Text = count.ToString();
        }


    }
}
