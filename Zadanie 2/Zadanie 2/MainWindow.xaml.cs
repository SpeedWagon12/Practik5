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

namespace Zadanie_2
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

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if ((String.IsNullOrEmpty(Dan.Text)))
            {
                return;
            }
            try
            {
                int xa = Convert.ToInt32(Dan.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены не корректные данные");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ListBoxData.Items.Add(Dan.Text);
        }

        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            {
                try
                {
                    int c = 0;
                    int k = 0;
                    int n = ListBoxData.Items.Count;
                    for (int i = 0; i < n; i++)
                    {
                        int m = Convert.ToInt32(ListBoxData.Items[i]);
                        if (m >= 10 && m <= 99 && m % 8 == 0)
                        {
                            c ++;
                            k++;
                        }
                    }
                    if (k != 0)
                    {
                        Answer.Text = $"Ответ:\n{c}";
                    }
                    else
                    {
                        Answer.Text = $"Ответ:\nНеправильно!";
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
        }
        private void BtnCancelClick(object sender, RoutedEventArgs e)
        {
            ListBoxData.Items.Clear();
        }

    }
}
