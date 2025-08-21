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

namespace WPF_Task_8_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product> products = new List<Product>();

        public MainWindow()
        {
            InitializeComponent();
            products.Add(new Product()
            {
                ProductName="Помидор",
                Price=99.99,
                ProductType=ProductTypes.Food,
                Image= "C:\\Users\\sdpsd\\source\\repos\\HomeWorks\\WPF_Task_8_1\\Image\\Помидор.png"

            });
            products.Add(new Product()
            {
                ProductName = "Пылесос",
                Price = 20000.99,
                ProductType = ProductTypes.HomeAppliances,
                Image = "C:\\Users\\sdpsd\\source\\repos\\HomeWorks\\WPF_Task_8_1\\Image\\Пылесос.jpeg"

            });
            products.Add(new Product()
            {
                ProductName = "Дыня",
                Price = 19.99,
                ProductType = ProductTypes.Food,
                Image = "C:\\Users\\sdpsd\\source\\repos\\HomeWorks\\WPF_Task_8_1\\Image\\Дыня.jpeg"

            });
            listBox.ItemsSource = products;
        }
    }
}