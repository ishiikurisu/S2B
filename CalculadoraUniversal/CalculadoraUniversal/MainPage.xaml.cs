using CalculadoraUniversal.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace CalculadoraUniversal
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        static CalculadoraDTO Calculadora;

        public MainPage()
        {
            this.InitializeComponent();
            Calculadora = new CalculadoraDTO();
        }

        private void btnSomar_Click(object sender, RoutedEventArgs e)
        {
            Calculadora.Entrada1 = double.Parse(txtNum1.Text);
            Calculadora.Entrada2 = double.Parse(txtNum2.Text);
            lblResultado.Text = Calculadora.Somar().ToString();
        }
    }
}
