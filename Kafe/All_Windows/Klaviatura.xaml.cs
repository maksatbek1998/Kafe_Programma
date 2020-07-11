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

namespace Kafe.All_Windows
{
    /// <summary>
    /// Логика взаимодействия для Klaviatura.xaml
    /// </summary>
    public partial class Klaviatura : Window
    {
        public Klaviatura()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            textbox1.Text += button.Content.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            textbox1.Text = String.Empty;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text!=String.Empty)
            {
                textbox1.Text = textbox1.Text.Substring(0, textbox1.Text.Length - 1);
            }
        }
    }
}
