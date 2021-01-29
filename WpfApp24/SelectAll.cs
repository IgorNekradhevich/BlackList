using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp24
{
    class SelectAll
    {
        MySqlConnection connection;
        public SelectAll(MySqlConnection connection)
        {
            this.connection = connection;
        }
        public DataTable SelectFromDB ( string tablename )
        {
            MySqlDataAdapter adapter
                = new MySqlDataAdapter($"Select * from {tablename}",
                connection);
            DataTable result = new DataTable();
            adapter.Fill(result);
            return result;
        }
    }
}
