using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_ProductList.Models
{
    public class Product : ViewModelBase
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public decimal Price { get; set; }

        private int _quantity;
        public int Quantity
        {
            get => _quantity;
            set { SetProperty(ref _quantity, value); }
        }
        public string ImagePath => $"Resources/{Name}.jpg";
    }
}
