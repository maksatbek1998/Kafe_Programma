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
    /// Логика взаимодействия для Calendar_Window.xaml
    /// </summary>
    public partial class Calendar_Window : Window
    {
        public Calendar_Window()
        {
            InitializeComponent();
        }
        private void Caleddar1_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            this.Close();
        }
    }
}
