using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp24
{
    class InsertBlackList
    {
        MySqlConnection connection;
        public InsertBlackList(MySqlConnection connection)
        {
            this.connection = connection;
        }
        public void Insert(Cause cause, string tablename)
        {
            Console.WriteLine("!!!!!!");
            string query = $"Insert into {tablename} " +
                $"(name,cause,causedate) values " +
                $"('{cause.Name}','{cause.Text}','" +
                $"{cause.CauseDate.ToString("yyyy/MM/dd")}');";
            MySqlScript script = new MySqlScript(connection, query);
            script.Execute();
        }
    }
}
