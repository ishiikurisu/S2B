using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace HandsOnAula7
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Rectangle_MouseEnter(object sender, MouseEventArgs e)
        {
            FriendBlock.Fill = new SolidColorBrush(Colors.Blue);
        }

        private void Rectangle_MouseLeave(object sender, MouseEventArgs e)
        {
            FriendBlock.Fill = new SolidColorBrush(Colors.Tomato);
        }

        private void BadBlock_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            MainWindow mw = new MainWindow();
            this.Hide();
            mw.Show();
        }
    }
}
