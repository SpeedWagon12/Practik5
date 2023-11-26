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

namespace Zadanie_3
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
            if (!double.TryParse(Dan.Text, out double a))
            {
                MessageBox.Show("Введите число!");
            }
            if (!double.TryParse(Dan1.Text, out double b))
            {
                MessageBox.Show("Введите число!");
            }
            int c = 0;

            for (double i = a; i <= b; i++)
            {
                Answer.Text += i   + "\n";
                c++;
            }
            Answer1.Text += c;
        }
        

    private void BtnCancelClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
