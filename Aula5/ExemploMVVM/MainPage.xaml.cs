using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using System;
using Windows.UI.Xaml.Controls.Primitives;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ExemploMVVM
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private string Usuario = "joefrank";
        private string Senha = "bacon";

        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void btnLogar_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog msg;

            if (txtUsuario.Text.Equals(Usuario) &&
                psbSenha.Password.Equals(Senha) &&
                sliIdade.Value >= 18)
            {
                msg = new MessageDialog(get_text(), "SENAI S2B");
                await msg.ShowAsync();
                lblMensagem.Text = "Yay :D";
            }
            else
            {
                msg = new MessageDialog("Ooops", "Oh shit");
                await msg.ShowAsync();
                lblMensagem.Text = "No :(";
            }
        }

        private string get_text()
        {
            string text = "";

            if (chkAdmin.IsChecked == true)
                text += "Você é Administrador ";
            else
                text += "Você é usuário ";

            if (radBSB.IsChecked == true)
                text += "de Brasília. ";
            else if (radSP.IsChecked == true)
                text += "de São Paulo. ";

            text += "Seja Bem-vindo! :)";
            return text;
        }

        private void sliIdade_ValueChanged
        (object sender, RangeBaseValueChangedEventArgs e)
        {
            txtIdade.Text = sliIdade.Value.ToString();
        }

        private void txtIdade_TextChanged(object sender, TextChangedEventArgs e)
        {
            string txt = txtIdade.Text;

            if (txt.Length == 0)
                sliIdade.Value = sliIdade.Minimum;
            else
            {
                double value = double.Parse(txt);
                if (value < sliIdade.Minimum)
                    sliIdade.Value = sliIdade.Minimum;
                else if (value > sliIdade.Maximum)
                    sliIdade.Value = sliIdade.Maximum;
                else
                    sliIdade.Value = value;
            }
        }
    }
}
