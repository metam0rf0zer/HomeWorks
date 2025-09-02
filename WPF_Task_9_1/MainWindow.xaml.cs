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

namespace WPF_Task_9_1
{
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
                if (_colorHistory.Count == 0 || _colorHistory.Peek() != value)
                {
                    _colorHistory.Push(value);
                }
                
                this.Background = _currentColor;
                
                CommandManager.InvalidateRequerySuggested();
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            
            CurrentColor = Brushes.White;
        }

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

        private void ChangeColorCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void UndoExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            if (_colorHistory.Count > 1)
            {
                _colorHistory.Pop();         
                CurrentColor = _colorHistory.Peek(); 
            }
        }

        
        private void UndoCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = _colorHistory.Count > 1;
        }
    }
}
