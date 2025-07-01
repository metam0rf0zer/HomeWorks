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

namespace WPF_Task_1_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int cnt = 1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            cnt++;
            if (cnt > 3)
            {
                cnt = 1;
            }
            switch (cnt)
            {
                case 1:
                    red.Fill = Brushes.Red;
                    yellow.Fill = Brushes.Gray;
                    green.Fill = Brushes.Gray;
                    break;
                case 2:
                    red.Fill = Brushes.Gray;
                    yellow.Fill = Brushes.Yellow;
                    green.Fill = Brushes.Gray;
                    break;
                case 3:
                    red.Fill = Brushes.Gray;
                    yellow.Fill = Brushes.Gray;
                    green.Fill = Brushes.Green;
                    break;

            }
            

            
        }
    }
}