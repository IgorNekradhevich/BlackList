using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Windows;

namespace WpfApp24
{
    class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        void Update(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        Cause myCause;
        DataTable table;
        Facade facade;
        BlackListConnector connector;


        void insert(object x)
        {
            facade.InsertTable(myCause);
            Table = facade.GetTable();
        }

        public MyCommand ButtonClick
        {
            get {
                return new MyCommand(insert ); 
            }
        }
        public ViewModel()
        {
            myCause = new Cause();
            connector = BlackListConnector.GetInstance();
            facade = new Facade(connector, "list");
            Table = facade.GetTable();
          
        }

        public DataTable Table
        {
            get { return table; }
            set { 
                table = value;
                Update("Table");
            }
        }
        public Cause MyCause
        {
            get { return myCause; }
            set { 
                myCause = value;
                Update("MyCause");
            }
        }
    }
}
