using System;

namespace Shop.Models
{
    public class OrderItemViewModel
    {
        public int Id { get; set; }
        public ProductViewModel Product { get; set; }
        public int Amount { get; set; }

        public decimal Price => Amount * Product.Price;

    }
}
