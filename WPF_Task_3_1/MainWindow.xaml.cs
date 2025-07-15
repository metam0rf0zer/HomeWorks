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
            //Проверка что введено имя
            if (NameStudentTextBox.Text == "Введите имя" || NameStudentTextBox.Text == "")
            {
                MessageBox.Show("Необходимо ввести имя");
            }
            else
            {
                if (FacultyComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Необходимо выбрать факультет");
                }
                else
                {
                    if (AvailableCoursesListBox.SelectedItems.Count == 0)
                    {
                        MessageBox.Show("Необходимо вбрать один или несколько курсов");
                    }
                    else
                    {
                        if (!Apply.IsChecked.HasValue || !Apply.IsChecked.Value)
                        {
                            MessageBox.Show("Необходимо согласие на обработку данных");
                        }
                        else
                        {
                            string chosenCourses = string.Join(", ", AvailableCoursesListBox.SelectedItems.Cast<ListBoxItem>().Select(item => item.Content));
                            var chosenFaculty = FacultyComboBox.Text;
                            MessageBox.Show($"Имя студента: {NameStudentTextBox.Text}\nФакультет: {chosenFaculty} \nКурс: {chosenCourses}");
                        }
                    }
                }
            }
        }

        private void Apply_Checked(object sender, RoutedEventArgs e)
        {

        }

    }
}