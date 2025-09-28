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

namespace WPF_TEST_9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Stack<Brush> _colorHistory = new Stack<Brush>();
        private Brush _currentColor;

        public Brush CurrentColor
        {
            get => _currentColor;
            set
            {
                _currentColor = value;
                // Сохраняем текущий цвет в историю (если он новый)
                if (_colorHistory.Count == 0 || _colorHistory.Peek() != value)
                {
                    _colorHistory.Push(value);
                }
                // Меняем фон
                Dock.Background = _currentColor;
                // Обновляем состояние команд
                CommandManager.InvalidateRequerySuggested();
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            // Инициализируем первый цвет (белый)
            CurrentColor = Brushes.White;
        }

        // Обработчик команды "Изменить цвет"
        private void ChangeColorExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            var random = new Random();
            var color = Color.FromRgb(
                (byte)random.Next(256),
                (byte)random.Next(256),
                (byte)random.Next(256)
            );
            CurrentColor = new SolidColorBrush(color);
        }

        // CanExecute для ChangeColor — всегда доступна
        private void ChangeColorCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        // Обработчик команды "Отменить"
        private void UndoExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            if (_colorHistory.Count > 1)
            {
                _colorHistory.Pop();         // Удаляем текущий цвет
                CurrentColor = _colorHistory.Peek(); // Берём предыдущий
            }
        }

        // CanExecute для Undo — только если есть что отменять
        private void UndoCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = _colorHistory.Count > 1;
        }
    }
}