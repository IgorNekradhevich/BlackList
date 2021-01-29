using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp24
{
     class BlackListConnector
    {

        MySqlConnection mySqlConnection;
       static BlackListConnector instance;
        private BlackListConnector()
        {
            mySqlConnection = new MySqlConnection
               ("Server=localhost;Pwd=root;Uid=root;Database=blacklist;");
            mySqlConnection.Open();
        }
        public MySqlConnection GetConnection()
        {
            return mySqlConnection;
        }
      static  public BlackListConnector GetInstance()
        {
            if (instance==null)
            {
                instance = new BlackListConnector();
            }
            return instance;
        }

    }
}
