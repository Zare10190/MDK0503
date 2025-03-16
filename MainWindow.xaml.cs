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

namespace TreugTest0501
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TA.Visibility = Visibility.Hidden;
            TB.Visibility = Visibility.Hidden;
            TC.Visibility = Visibility.Hidden;
            Chek.Visibility = Visibility.Hidden;
            Text1.Visibility = Visibility.Hidden;
            Run.Visibility = Visibility.Visible;
            Text2.Visibility = Visibility.Visible;

            try
            {
                string A, B, C;

                A = TA.Text;
                int S = int.Parse(A);

                B = TB.Text;
                int D = int.Parse(B);

                C = TC.Text;
                int F = int.Parse(C);

                if (S < D + F && D < S + F && F < S + D) // проверка есть ли такой треугольник
                {
                    if (D == F && D == S && F == S)
                    {
                        Text2.Text = "это равносторонний треугольник";
                    }
                    else if (D == F || D == S || S == F)
                    {
                        Text2.Text = "это равнобедренный треугольник";
                    }
                    else
                    {
                        Text2.Text = "это разносторонний треугольник";
                    }
                }
                else // иначе если такого треугольника нет
                {
                    Text2.Text = "такого треугольника быть не может";
                }
            }
            catch
            {
                Text2.Text = "неправильный ввод";
            }

        }

        private void Run_Click(object sender, RoutedEventArgs e)
        {
            TA.Visibility = Visibility.Visible;
            TB.Visibility = Visibility.Visible;
            TC.Visibility = Visibility.Visible;
            Chek.Visibility = Visibility.Visible;
            Text1.Visibility = Visibility.Visible;
            Run.Visibility = Visibility.Hidden;
            Text2.Visibility = Visibility.Hidden;
        }
    }
}
