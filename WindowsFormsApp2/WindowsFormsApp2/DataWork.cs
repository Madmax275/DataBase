using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class DataWork : Form
    {
        
        public DataWork()
        {
            InitializeComponent();
        }

        public void InsertData(string post, int Indeficator_user)
        {
           
            var db = new DB();
            db.OpenConnection();
            
                db.OpenConnection();
                string query = "INSERT INTO info_emp (Post, Indeficator_user) VALUES (@Post, @Indeficator_user)";
                using (SqlCommand cmd = new SqlCommand(query, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@Post", post);
                    cmd.Parameters.AddWithValue("@Indeficator_user", Indeficator_user);
                    cmd.ExecuteNonQuery();
                }
                db.CloseConnection();
            
        }

        private void DataWork_Load(object sender, EventArgs e)
        {

        }

        private void buttonload_Click(object sender, EventArgs e)
        {

            DB dB = new DB();
            dB.OpenConnection();

            DataTable dt = new DataTable(); // Create a new DataTable

            SqlDataAdapter sda = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("SELECT * FROM info_emp", dB.GetConnection());
            sda.SelectCommand = cmd;
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

            dB.CloseConnection();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {

        }
    }
}
