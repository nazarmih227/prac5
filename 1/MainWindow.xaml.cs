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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            }

        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            try
            {
                int k = 0;
                int n = ListBoxData.Items.Count;
                int max = 0;
                for (int i = 0; i < n; i++)
                {
                    int m = Convert.ToInt32(ListBoxData.Items[i]);
                    if (m % 10 == 4 && m % 6 == 0)
                    {
                        max += m;
                        k++;
                    }
                }
                if (k != 0)
                {
                    TextBlockAnswer.Text = $"Ответ:\n{max}";
                }
                else
                {
                    TextBlockAnswer.Text = $"Ответ:\nНеправильно!";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены некорректные данные");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCancelClick(object sender, RoutedEventArgs e)
        {
            ListBoxData.Items.Clear();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if ((String.IsNullOrEmpty(TbNumber.Text)))
            {
                return;
            }
            try
            {
                int xa = Convert.ToInt32(TbNumber.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены не корректные данные");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ListBoxData.Items.Add(TbNumber.Text);
        }
    }
}
