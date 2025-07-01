using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Task_1_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random randomPosition = new Random();
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            double horizontal = randomPosition.Next(0, 650);
            double vertical = randomPosition.Next(0, 400);
            myButton.Margin=new Thickness(horizontal,vertical,0,0);
        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            myButton.Content = "Молодец, поймал!";
        }

        private void myButton_MouseLeave(object sender, MouseEventArgs e)
        {
            myButton.Content = "Поймай меня!";
        }
    }
}
