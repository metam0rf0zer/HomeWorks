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
using Microsoft.Win32;
using System.IO;

namespace WPF_Task_2_1
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

        private void open_Click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            status.Text = $"Открытие файла...";
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                txtBox.Text = File.ReadAllText(openFileDialog.FileName);
                status.Text = $"Открытыт файл {openFileDialog.FileName}";
            }
            else
            {
                status.Text = "Готово";
            }
        }
            
                
                
        

        private void save_Click(object sender, RoutedEventArgs e)
        {
            status.Text = $"Сохранение файла...";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter= "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if(saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, txtBox.Text);
                status.Text = $"Файл сохранён как {saveFileDialog.FileName} ";
            }
        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            AboutWindow aboutWindow = new AboutWindow();   
            aboutWindow.WindowStyle=WindowStyle.None;
            aboutWindow.Show();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result=MessageBox.Show("Вы действительно хотите выйти?","Подтверждение",MessageBoxButton.YesNo,MessageBoxImage.Question);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}