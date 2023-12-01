using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class DB
    {
        private static string lineconn = "Data Source=WIN-54193PQ182O\\SQLEXPRESS;User ID = Admin;password = 123;Initial Catalog = WorkBase;Integrated Security=False;Encrypt=False";
        
        SqlConnection conn = new SqlConnection(lineconn);

        public void OpenConnection()
        {
            
            if(conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
                //MessageBox.Show("open");
            }
        }

        public void CloseConnection()
        {

            if (conn.State == System.Data.ConnectionState.Open)
            {
               conn.Close();
            }
        }
        public SqlConnection GetConnection()
        {
            return conn;  
        }
    }
}
