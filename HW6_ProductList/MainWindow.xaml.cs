using HW6_ProductList.Models;
using System.Collections.ObjectModel;
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

namespace HW6_ProductList
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<Product> products;
        private Cart cart;
        public MainWindow()
        {
            InitializeComponent();
            cart = new Cart();
            products = new ObservableCollection<Product>
            {
                new Product{ Name = "Oranges", Price = 65.23m, Quantity = 126 },
                new Product{ Name = "Bananas", Price = 58.92m, Quantity = 221 },
                new Product{ Name = "Lemons", Price = 53.23m, Quantity = 137 },
                new Product{ Name = "Mandarines", Price = 49.92m, Quantity = 301 }
            };
            productListBox.ItemsSource = products;
            DataContext = cart;
        }
        private void buyButton_Click(object sender, RoutedEventArgs e)
        {
            Button buyButton = (Button)sender;
            Product selectedProduct = (Product)buyButton.Tag;

            cart.AddToCart(selectedProduct);
        }
    }
}