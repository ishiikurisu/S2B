using System.Windows;
using System.Collections;
using System;
using System.Windows.Controls;
using System.Windows.Input;

namespace QuadradoMagico
{
    public partial class MainWindow : Window
    {
        public ArrayList Dificuldades = new ArrayList();
        public MotorJogo Jogo = new MotorJogo();

        public MainWindow()
        {
            InitializeComponent();

            Dificuldades.Add("Fácil");
            Dificuldades.Add("Médio");
            Dificuldades.Add("Difícil");

            /* Populate combo box */
            foreach (var dificuldade in Dificuldades)
                comboDifficulty.Items.Add(dificuldade);
        }

        private void comboDifficulty_SelectionChanged
        (object sender, SelectionChangedEventArgs e)
        {
            Console.WriteLine(comboDifficulty.SelectedValue.ToString());
        }
    }
}
