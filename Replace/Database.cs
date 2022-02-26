using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Replace
{
    public class Database
    {
        string connectionString = @"Data Source=SONY\SQLEXPRESSNEW;Initial Catalog=Users;Persist Security Info=True;User ID=sa;Password=*********";

        public void ShowTable(string sql, DataGridView dataGridView)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView.DataSource = ds.Tables[0];
                    connection.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Возникла ошибка: " + exception);
            }
        }

        public void SqlQuery(string sql)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Возникла ошибка: " + exception);
            }
        }
    }
}
