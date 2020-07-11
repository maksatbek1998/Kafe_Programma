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
    /// Логика взаимодействия для User_Ofissiant.xaml
    /// </summary>
    public partial class User_Ofissiant : UserControl
    {
        public User_Ofissiant()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Arhiv_Check arhiv_Check = new Arhiv_Check();
            arhiv_Check.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Sostavit_Otchet sostavit_Otchet = new Sostavit_Otchet();
            sostavit_Otchet.ShowDialog();
        }
    }
}
