using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp24
{
    class Facade
    {
        InsertBlackList insertBlackList;
        SelectAll selectAll;
        BlackListConnector blackListConnector;
        string tablename;
            public Facade(BlackListConnector blackListConnector, string tablename)
        {
            this.tablename = tablename;
            this.blackListConnector = blackListConnector;
            selectAll = new SelectAll(blackListConnector.GetConnection());
            insertBlackList = new InsertBlackList(blackListConnector.GetConnection());
        }
        public DataTable GetTable()
        {
            return selectAll.SelectFromDB(tablename);
        }
        public DataTable InsertTable(Cause cause)
        {
            insertBlackList.Insert(cause, tablename);
            return selectAll.SelectFromDB(tablename);
        }
    }
}
