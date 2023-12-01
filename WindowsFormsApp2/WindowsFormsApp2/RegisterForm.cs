using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

      
        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void buttonreg_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tx1Login.Text) | string.IsNullOrWhiteSpace(tx2PassField.Text))
            {
                MessageBox.Show("Fill in the fields");
            }
            else if (string.IsNullOrWhiteSpace(tx1Login.Text)& string.IsNullOrWhiteSpace(tx2PassField.Text))
            {
                MessageBox.Show("Fill in the fields");
            }
            else
            {
                if (Userxexists())
                    return;


                DB dB = new DB();

                SqlCommand cmd = new SqlCommand("INSERT INTO Users ( Name, Password) VALUES(@login, @password)", dB.GetConnection());
                cmd.Parameters.Add("@login", SqlDbType.VarChar).Value = tx1Login.Text;
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = tx2PassField.Text;

                dB.OpenConnection();

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("The request has been processed");
                }
                else
                {
                    MessageBox.Show("The request has been not processed");
                }

                dB.CloseConnection();
            }
           
        }

        

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Red;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }

        public Boolean Userxexists()
        {
            DB dB = new DB();

            DataTable de = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE Name = @ul", dB.GetConnection());
            cmd.Parameters.Add("@ul", SqlDbType.VarChar).Value = tx1Login.Text;
            

            adapter.SelectCommand = cmd;
            adapter.Fill(de);//заполнение DataTable

            if (de.Rows.Count > 0)
            {
                MessageBox.Show("This login already exists, enter another one");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
