using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_ProductList.Models
{
    public class Cart : ViewModelBase
    {
        public ObservableCollection<Product> Products { get; set; }
        public Cart() => Products = new ObservableCollection<Product>();
        private int _count;
        public int Count
        {
            get => _count;
            set { SetProperty(ref _count, value); }
        }
        private decimal _total;
        public decimal Total
        {
            get => _total;
            set { SetProperty(ref _total, value); }
        }
        public void AddToCart(Product product)
        {
            if (product.Quantity != 0)
            {
                Product existingProduct = Products.FirstOrDefault(p => p.Id == product.Id);

                if (existingProduct != null)
                {
                    Total += existingProduct.Price;
                    Count += 1;
                    existingProduct.Quantity--;

                    OnPropertyChanged(nameof(existingProduct.Quantity));
                    OnPropertyChanged(nameof(Total));
                    OnPropertyChanged(nameof(Count));
                }
                else
                {
                    Products.Add(product);
                    product.Quantity--;
                    Count += 1;
                    Total += product.Price;

                    OnPropertyChanged(nameof(product.Quantity));
                    OnPropertyChanged(nameof(Total));
                    OnPropertyChanged(nameof(Count));
                }
            }
        }
    }
}