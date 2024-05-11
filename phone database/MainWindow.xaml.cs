using Dapper;
using Microsoft.Data.Sqlite;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace phone_database
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SqliteConnection conn = new SqliteConnection();
        public MainWindow()
        {
            conn.Open();

            conn.Execute("create table organizations (id integer primary key not null, name text not null, inn varchar(10) not null, ur_addr text not null, addr text not null)");
            conn.Execute("create table employees (id integer primary key not null, firstname text not null, lastname text not null, surname text, birthdate datetime not null, pass_num varchar(4) not null, pass_series varchar(6) not null)");


            









            InitializeComponent();
        }
    }
}