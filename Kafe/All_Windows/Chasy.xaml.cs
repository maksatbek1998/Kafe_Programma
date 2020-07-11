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
    /// Логика взаимодействия для Chasy.xaml
    /// </summary>
    public partial class Chasy : Window
    {
        public Chasy()
        {
            InitializeComponent();
        }
        //string[] Hourse = { "00","01","02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22" };
        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int Hor = Convert.ToInt32(Hourse_Text.Text);
            if (Hor==00)
            {
                Hourse_Text.Text = "23";
            }
            else
            {
                Hor--;
                if (Hor<10)
                {
                    Hourse_Text.Text ="0"+Hor.ToString();
                }
                else
                {
                    Hourse_Text.Text = Hor.ToString();
                }
            }
        }
    }
}
