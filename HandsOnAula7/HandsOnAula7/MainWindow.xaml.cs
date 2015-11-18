using System.Windows;
using System.Windows.Input;

namespace HandsOnAula7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Rectangle_MouseEnter(object sender, MouseEventArgs e)
        {
            Window1 w1 = new Window1();
            w1.Show();
            this.Hide();
        }

        private void Rectangle_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Window2 w2 = new Window2();
            w2.Show();
            this.Hide();
        }

        private void GreenRect_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Window3 w3 = new Window3();
            w3.Show();
            this.Hide();
        }
    }
}
