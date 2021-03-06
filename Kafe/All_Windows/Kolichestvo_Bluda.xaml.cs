﻿using System;
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
    /// Логика взаимодействия для Kolichestvo_Bluda.xaml
    /// </summary>
    public partial class Kolichestvo_Bluda : Window
    {
        public Kolichestvo_Bluda()
        {
            InitializeComponent();
        }

        private void Plus_Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            int count = Convert.ToInt32(Text_Kolichestvo.Text);
            if (button.Name == "Plus_Button")
            {
                count++;
                Text_Kolichestvo.Text = count.ToString();
            }
            else if (button.Name == "Minus_Button")
            {
                if (count > 0)
                {
                    count--;
                    Text_Kolichestvo.Text = count.ToString();
                }
            }
        }

        private void Plus_Button_Copy(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            int count = Convert.ToInt32(Text_Kolichestvo.Text);
            if (button.Name == "Plus_Button_Copy1")
            {
                count+=10;
                Text_Kolichestvo.Text = count.ToString();
            }
            else if (button.Name == "Minus_Button_Copy1")
            {
                if (count > 10)
                {
                    count-=10;
                    Text_Kolichestvo.Text = count.ToString();
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
