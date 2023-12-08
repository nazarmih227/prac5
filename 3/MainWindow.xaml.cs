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

namespace _3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            TextBlockAnswer.Clear();
            if (int.TryParse(TbNumberA.Text, out int a) && int.TryParse(TbNumberB.Text, out int b))
            {
                int sum = 0;
                for (int i = a; i <= b; i++)
                {
                    sum += i * i;
                }
                TextBlockAnswer.Text += $"Сумма {sum}\n";
            }
        }
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbNumberB.Text))
            {
                return;
            }
            try
            {
                int xa = int.Parse(TbNumberA.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены некорректные данные");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            ListBoxData.Items.Add($"{TbNumberA.Text}\n{TbNumberB.Text}");
        }

        private void BtnCancelClick(object sender, RoutedEventArgs e)
        {
            ListBoxData.Items.Clear();
            TextBlockAnswer.Clear();         
}

        private void BtnCancelClick1(object sender, RoutedEventArgs e)
        {
            ListBoxData.Items.Clear();
            TextBlockAnswer.Clear();
        }

        private void BtnAdd_Click1(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbNumberB.Text))
            {
                return;
            }
            try
            {
                int xa = int.Parse(TbNumberA.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены некорректные данные");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            ListBoxData.Items.Add($"{TbNumberA.Text}\n{TbNumberB.Text}");
        }

        private void BtnOKClick1(object sender, RoutedEventArgs e)
        {
            TextBlockAnswer.Clear();
            if (int.TryParse(TbNumberA.Text, out int a) && int.TryParse(TbNumberB.Text, out int b))
            {
                int sum = 0;
                for (int i = a; i <= b; i++)
                {
                    sum += i * i;
                }
                TextBlockAnswer.Text += $"Сумма {sum}\n";
            }
        }
    }
}
