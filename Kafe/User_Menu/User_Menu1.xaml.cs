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
    /// Логика взаимодействия для User_Menu1.xaml
    /// </summary>
    public partial class User_Menu1 : UserControl
    {
        public User_Menu1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Klaviatura klaviatura = new Klaviatura();
            klaviatura.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Razdelit_Window razdelit_Window = new Razdelit_Window();
            razdelit_Window.ShowDialog();
        }
    }
}
