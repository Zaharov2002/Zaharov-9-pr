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

namespace Zaharov_9_pr
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem ibi = (ListBoxItem)(phonesList.ItemContainerGenerator.ContainerFromIndex(1));
            int len;
            string text;

            if (phonesList.SelectedItem !=null)
            {
                ListBoxItem li = (ListBoxItem)phonesList.Items[phonesList.SelectedIndex];
                text = (string)li.Content;
                len = text.Length;
                int count = 0;
                int i = 0;
                while (i < len - 1)
                {
                    if (text[i] == ' ')
                        count++;
                    i++;
                }
                Schet.Text = Convert.ToString(count);
            }
            TextBlock.Text = ibi.Content.ToString();

        }
    }
}
