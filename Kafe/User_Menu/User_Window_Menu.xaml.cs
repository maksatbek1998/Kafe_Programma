using Kafe.All_Windows;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kafe.User_Menu
{
    /// <summary>
    /// Логика взаимодействия для User_Window_Menu.xaml
    /// </summary>
    public partial class User_Window_Menu : UserControl
    {
        public User_Window_Menu()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Stol_Window stol_Window = new Stol_Window();
            stol_Window.ShowDialog();
        }
    }
}
