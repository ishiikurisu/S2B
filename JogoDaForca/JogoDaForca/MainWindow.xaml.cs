using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace JogoDaForca
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        private Hangman Game { get; set; }
        private string Word { get; set; }
        private Label[] Letters;
        private int Mistakes;

        public MainWindow()
        {
            InitializeComponent();
            Style = (Style)FindResource(typeof(Window));
        }

        private void NewGame()
        {
            Game = new Hangman();
            Word = Game.Word;
            Letters = PopulateLetters();
            Mistakes = 0;
            FillWindow();
        }

        private void FillWindow()
        {
            stackLetters.Children.Clear();

            foreach (Label letter in Letters)
            {
                stackLetters.Children.Add(letter);
            }

            lblTry.Content = Game.NumberTries;
            btnTry.IsEnabled = true;
            txtTry.IsEnabled = true;
            lblResult.Content = "";
            imgHangman.Source = (ImageSource)FindResource("Image0");
        }

        private Label[] PopulateLetters()
        {
            int howMany = Word.Length;
            Label[] letters = new Label[howMany];
            Label letter;

            for (int i = 0; i < howMany; ++i)
            {
                letter = new Label();
                letter.Content = "_";
                letter.Margin = new Thickness(5);
                letter.FontSize = 20;
                letters[i] = letter;
            }

            return letters;
        }

        private void Check()
        {
            if (Game.IsFinished())
            {
                btnTry.IsEnabled = false;
                txtTry.IsEnabled = false;

                if (Game.Winner)
                    lblResult.Content = "You win :)";
                else
                    lblResult.Content = "You died X_X";
            }
        }

        private void btnNewGame_Click(object sender, RoutedEventArgs e)
        {
            NewGame();
        }

        private void btnTry_Click(object sender, RoutedEventArgs e)
        {
            string input = txtTry.Text;

            if (input.Length != 1)
                return;

            Mistakes += (Game.InsertChar(input.ToLower()[0]))? 0 : 1;
            UpdateScreen();
            Check();
        }

        private void UpdateScreen()
        {
            int howMany = Word.Length;
            int i;

            lblTry.Content = Game.NumberTries;
            for (i = 0; i < howMany; ++i)
                if (Game.Answers[i])
                    Letters[i].Content = Word[i];

            imgHangman.Source = (ImageSource)FindResource(string.Format("Image{0}", Mistakes));
        }
    }
}
