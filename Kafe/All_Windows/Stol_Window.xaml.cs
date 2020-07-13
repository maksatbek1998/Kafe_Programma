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
    /// Логика взаимодействия для Stol_Window.xaml
    /// </summary>
    public partial class Stol_Window : Window
    {
        public Stol_Window()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Parol_Window parol_Window = new Parol_Window();
            parol_Window.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Grid grid1 = new Grid();
                TextBlock textBlock = new TextBlock();
                textBlock.Style= (Style)this.TryFindResource("Stol_Button_Text");
                textBlock.Text = "Пустой";
                Button button = new Button();
                button.Style = (Style)this.TryFindResource("Button_Dynamik_Stol");
                button.Content = i.ToString();
                grid1.Children.Add(button);
                grid1.Children.Add(textBlock);
                Stol_Panel.Children.Add(grid1);
            }
        }
    }
}
