using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using System.Diagnostics;

namespace Kafe.User_Menu
{
    /// <summary>
    /// Логика взаимодействия для NaKuxne.xaml
    /// </summary>
    public partial class NaKuxne : UserControl
    {
        public MySqlConnection connection = new MySqlConnection("datasource=192.168.0.101; port=3306;Initial Catalog='u_system';username=Maksatbek;password=708141998m;CharSet=utf8;");
        public NaKuxne()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            string s = "SELECT marka,kurs,data FROM cars";
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = s;
            cmd.ExecuteNonQuery();
            DataTable dta1 = new DataTable();
            MySqlDataAdapter dataadap = new MySqlDataAdapter(cmd);
            dataadap.Fill(dta1);
            Datagrid_Kuxne.ItemsSource = dta1.DefaultView;
            connection.Close();
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start(@"osk.exe");
            Komentary komentary = new Komentary();
            komentary.Owner = Application.Current.MainWindow;
            komentary.ShowDialog();
           
        }
    }
}
