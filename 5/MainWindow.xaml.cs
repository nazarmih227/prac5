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
using static System.Math;

namespace _5
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
            if (!double.TryParse(NumberP.Text, out double n))
            {
                MessageBox.Show("Введите число!");
            }
            double a1, b1;
            a1 = b1 = 1;
            double ak = a1;
            double bk = b1;
            double sum = a1 * b1;
            for (int k = 2; k <= n; k++)
            {
                b1 = a1 += k + 1;
                ak = (1.0 / 2) * (Sqrt(b1) + (1.0 / 2 * (Sqrt(a1))));
                bk = 2 * Pow(a1, 3) + b1;
                sum += ak * bk;
            }
            Answer.Text += $"{sum:f2}";
        }
        }
}
