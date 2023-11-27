using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HW6_ProductList.Models
{
    public partial class CartWindow : Window
    {
        Cart Cart { get; set; }

        public CartWindow(Cart cart)
        {
            Cart = cart;
            InitializeComponent();
            cartListBox.ItemsSource = Cart.Products;
            DataContext = Cart;
        }
        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            Button removeButton = (Button)sender;
            Product selectedProduct = (Product)removeButton.Tag;

            Cart.RemoveFromCart(selectedProduct);
        }
    }
}
