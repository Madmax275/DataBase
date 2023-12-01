using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Red;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }
        Point lastPoint;
        private void Mainpanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Mainpanel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            string loginuser = tx1Login.Text;
            string password = tx2PassField.Text;

            DB dB = new DB();
            
            DataTable de = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE Name = @ul AND Password = @up", dB.GetConnection());
            cmd.Parameters.Add("@ul", SqlDbType.VarChar).Value = loginuser;
            cmd.Parameters.Add("@up", SqlDbType.VarChar).Value = password;

            adapter.SelectCommand = cmd;
            adapter.Fill(de);//заполнение DataTable

            if(de.Rows.Count > 0)
            {
                MessageBox.Show("Connection succes");

                Form form = new DataWork();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Connection failed");
            }
        }

        private void buttonRegistr_Click(object sender, EventArgs e)
        {
            Form form = new RegisterForm();
            form.ShowDialog();
        }
    }
}
