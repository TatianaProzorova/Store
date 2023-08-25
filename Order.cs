using System.Collections.Generic;

namespace Store
{
    public class Order
    {
        public List<Product> Products;
        public decimal FullPrice;
        public Order(List<Product> products)
        {
            Products = products;

            foreach (var product in products)
            {
                FullPrice += product.Price;
            }
        }
    }
}
