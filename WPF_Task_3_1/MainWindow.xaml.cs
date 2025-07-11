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

namespace WPF_Task_3_1
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!Apply.IsChecked.HasValue || !Apply.IsChecked.Value)
            {
                ErrorWindow errorWindow = new ErrorWindow();
                errorWindow.WindowStyle = WindowStyle.ToolWindow;
                errorWindow.ShowDialog();
                MessageBox.Show("asd");
            }
            else
            {
                string studentName = NameStudentTextBox.Text;
                SuccessWindow successWindow = new SuccessWindow(studentName);
                successWindow.WindowStyle = WindowStyle.ToolWindow;
                successWindow.ShowDialog();                
            }

            
             
        }

        private void Apply_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}