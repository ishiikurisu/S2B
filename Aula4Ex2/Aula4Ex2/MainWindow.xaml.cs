using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Aula4Ex2
{
    public partial class MainWindow : Window
    {
        IMCCalculator IMC;

        public MainWindow()
        {
            InitializeComponent();
            IMC = new IMCCalculator();
        }
        
        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            IMC.Peso = double.Parse(txtPeso.Text);
            IMC.Altura = double.Parse(txtAltura.Text);
            this.definirBarra(IMC.Calcular(), IMC.Avaliar());
        }

        private void definirBarra(double imc, string avaliacao)
        {
            TypeConverter cc = new ColorConverter();
            string texto = "IMC";

            Console.WriteLine("IMC: " + imc);
            rectObesityBar.Width = 340 * (imc / 50.0);
            switch (avaliacao)
            {
                case "Normal":
                    rectObesityBar.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString("Blue");
                    texto = "Seu IMC está bom";
                    break;
                case "Magro":
                    rectObesityBar.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString("Green");
                    texto = "Você está subnutrido";
                    break;
                case "Obeso":
                    rectObesityBar.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString("Red");
                    texto = "Você está com obesidade";
                    break;
            }

            lblResultado.Content = texto;
        }
    }
}
