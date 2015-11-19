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

namespace JogoDaVelha
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Button[] Squares;
        private TicTacToe Game;
        private int NumberPlays;

        public MainWindow()
        {
            InitializeComponent();

            Squares = new Button[9];
            Squares[0] = btnUpperLeft;
            Squares[1] = btnUpperMiddle;
            Squares[2] = btnUpperRight;
            Squares[3] = btnLeft;
            Squares[4] = btnMiddle;
            Squares[5] = btnRight;
            Squares[6] = btnLowerLeft;
            Squares[7] = btnLowerMiddle;
            Squares[8] = btnLowerRight;

            Game = new TicTacToe();
            NumberPlays = 0;
        }

        private string GetWinner()
        {
            return (Game.GetWinner())? "Player 2" : "Player 1";
        }

        private void Check()
        {
            bool gameCondition = Game.IsFinished();
            bool boardCondition = (NumberPlays == 9);

            if (gameCondition || boardCondition)
            {
                foreach (Button button in Squares)
                    button.IsEnabled = false;

                if (gameCondition)
                    lblCurrentPlayer.Content = GetWinner() + " wins :)";
                else
                    lblCurrentPlayer.Content = "no one won :/";

            }
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            Game = new TicTacToe();
            lblCurrentPlayer.Content = null;
            NumberPlays = 0;

            foreach (Button button in Squares)
            {
                button.Content = null;
                button.IsEnabled = true;
            }
        }

        private void ButtonClick(Button button, int x, int y)
        {
            string symbol = (Game.Player) ? "O" : "X";

            if (button.Content == null)
            {
                button.Content = symbol;
                Game.SetPlace(symbol, x, y);
                Game.NextPlayer();
                NumberPlays++;
                Check();
            }
        }

        private void btnUpperLeft_Click(object sender, RoutedEventArgs e)
        {
            ButtonClick(btnUpperLeft, 0, 0);
        }

        private void btnUpperMiddle_Click(object sender, RoutedEventArgs e)
        {
            ButtonClick(btnUpperMiddle, 1, 0);
        }

        private void btnUpperRight_Click(object sender, RoutedEventArgs e)
        {
            ButtonClick(btnUpperRight, 2, 0);
        }

        private void btnLeft_Click(object sender, RoutedEventArgs e)
        {
            ButtonClick(btnLeft, 0, 1);
        }

        private void btnMiddle_Click(object sender, RoutedEventArgs e)
        {
            ButtonClick(btnMiddle, 1, 1);
        }

        private void btnRight_Click(object sender, RoutedEventArgs e)
        {
            ButtonClick(btnRight, 2, 1);
        }

        private void btnLowerLeft_Click(object sender, RoutedEventArgs e)
        {
            ButtonClick(btnLowerLeft, 0, 2);
        }

        private void btnLowerMiddle_Click(object sender, RoutedEventArgs e)
        {
            ButtonClick(btnLowerMiddle, 1, 2);
        }

        private void btnLowerRight_Click(object sender, RoutedEventArgs e)
        {
            ButtonClick(btnLowerRight, 2, 2);
        }
    }
}
