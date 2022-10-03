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

namespace Wpf_Yshakow_PR3
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            B.Text = "";
            P.Text = "";
            C.Text = "";
            A.Text = "";
            Itog.Text = "Вариант 12 ИСП Ушаков С.А";
        }

        private void Schet_Click(object sender, RoutedEventArgs e)
        {
            Itog.Text += Environment.NewLine + "Практическая работа 2";
            // Считывание значения B
            double b = double.Parse(B.Text);
            // Вывод значения B в окно
            Itog.Text += Environment.NewLine + "b = " + b.ToString();

            // Считывание значения C
            double c = double.Parse(C.Text);
            // Вывод значения Y в окно
            Itog.Text += Environment.NewLine + "c = " + c.ToString();

            // Считывание значения P
            double p = double.Parse(P.Text);
            // Вывод значения Z в окно
            Itog.Text += Environment.NewLine + "p = " + p.ToString();

            // Считывание значения A
            double a = double.Parse(A.Text);
            // Вывод значения A в окно
            Itog.Text += Environment.NewLine + "a = " + a.ToString();

            // Вычисляем 
            double d = Math.Sqrt(1 / 2 * b * c * p*(p-a));
            double be = (b + c);
            double betta = (d / be);

            //Выводим результат в окно
            Itog.Text += Environment.NewLine + "Результат BA = " + betta.ToString();

        }
    }
}
