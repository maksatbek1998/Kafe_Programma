using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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

namespace Kafe.All_Windows
{
    /// <summary>
    /// Логика взаимодействия для Parol_Window.xaml
    /// </summary>
    public partial class Parol_Window : Window
    {
        public Parol_Window()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (Password_text.Password.Length<4)
            {
                Password_text.Password += button.Content.ToString();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Password_text.Password != String.Empty)
            {
                Password_text.Password = Password_text.Password.Substring(0, Password_text.Password.Length - 1);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Password_text.Password = String.Empty;
        }

        private void Password_text_PasswordChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
