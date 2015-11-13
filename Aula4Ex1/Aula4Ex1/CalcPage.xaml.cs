using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Aula4Ex1
{

    public sealed partial class CalcPage : Page
    {
        static Calc Cat;

        public CalcPage()
        {
            this.InitializeComponent();
            Cat = new Calc();
        }

        private void btnRetornar_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void btnSomar_Click(object sender, RoutedEventArgs e)
        {
            Cat.Numero1 = double.Parse(txtNum1.Text);
            Cat.Numero2 = double.Parse(txtNum2.Text);
            lblResultado.Text = Cat.Somar().ToString();
        }

        private void btnSubtrair_Click(object sender, RoutedEventArgs e)
        {
            Cat.Numero1 = double.Parse(txtNum1.Text);
            Cat.Numero2 = double.Parse(txtNum2.Text);
            lblResultado.Text = Cat.Subtrair().ToString();
        }

        private void btnDividir_Click(object sender, RoutedEventArgs e)
        {
            Cat.Numero1 = double.Parse(txtNum1.Text);
            Cat.Numero2 = double.Parse(txtNum2.Text);
            lblResultado.Text = Cat.Dividir().ToString();
        }
    }
}