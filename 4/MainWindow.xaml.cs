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

namespace _4
{
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ReadyButton_Click(object sender, RoutedEventArgs e)
        {
            Answer.Clear();
            if (!int.TryParse(NumberA.Text, out int a))
            {
                Answer.Text += "Введите число";
            }
            double answer = 0;
            double fac = 1;
            for (int i = 1; i <= a; i++)
            {
                fac *= i;
                answer += fac;
            }
            Answer.Text += $"{answer}\n";
        }
        }
}
