using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using Kafe.User_Menu;
using Kafe.All_Windows;

namespace Kafe
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public MySqlConnection connection = new MySqlConnection("datasource=192.168.0.100; port=3306;Initial Catalog='u_system';username=Maksatbek;password=708141998m;CharSet=utf8;");
        private void Stol_Button_Click(object sender, RoutedEventArgs e)
        {
            Popup_US.PlacementTarget = Stol_Button;
            Popup_US.Placement = PlacementMode.Bottom;
            if (Popup_US.IsOpen == false)
            {                
                Popup_US.IsOpen = true;
            }
            else
            {
                Popup_US.IsOpen = false;
            }
        }
  
        private void Check_Button_Click(object sender, RoutedEventArgs e)
        {
            Popup_Check.PlacementTarget = Check_Button;
            Popup_Check.Placement = PlacementMode.Bottom;
            if (Popup_Check.IsOpen == false)
            {
                Popup_Check.IsOpen = true;
            }
            else
            {
                Popup_Check.IsOpen = false;
            }
        }

        private void Ofissiant_Button_Click(object sender, RoutedEventArgs e)
        {
            Popup_Ofissiant.PlacementTarget = Ofissiant_Button;
            Popup_Ofissiant.Placement = PlacementMode.Bottom;
            if (Popup_Ofissiant.IsOpen == false)
            {
                Popup_Ofissiant.IsOpen = true;
            }
            else
            {
                Popup_Ofissiant.IsOpen = false;
            }
        }

        private void Menu_Button_Click(object sender, RoutedEventArgs e)
        {
            Popup_Menu.PlacementTarget = Menu_Button;
            Popup_Menu.Placement = PlacementMode.Bottom;
            if (Popup_Menu.IsOpen == false)
            {
                Popup_Menu.IsOpen = true;
            }
            else
            {
                Popup_Menu.IsOpen = false;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
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
            dataGridView1.ItemsSource = dta1.DefaultView;
            connection.Close();
        }

        private void Otpravit_Kuxne_Click(object sender, RoutedEventArgs e)
        {
            Popup_Kuxne.PlacementTarget = Prog_Border;
            Popup_Kuxne.Placement = PlacementMode.Center;
            if (Popup_Kuxne.IsOpen == false)
            {
                Popup_Kuxne.IsOpen = true;
            }
            else
            {
                Popup_Kuxne.IsOpen = false;
            }
        }

        private void Kuxne_Otmena_Click(object sender, RoutedEventArgs e)
        {
            Popup_Kuxne.IsOpen = false;
        }

        private void Button_Oplatit_Click(object sender, RoutedEventArgs e)
        {
            Oplatit oplatit = new Oplatit();
            oplatit.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Parol_Window parol_Window = new Parol_Window();
            parol_Window.Show();
        }

        private void Net_Button_Click(object sender, RoutedEventArgs e)
        {
            Popup_US.IsOpen = false;
        }
    }
}
