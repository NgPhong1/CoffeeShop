namespace CoffeeShop.Models
{
    public class ProductRepository
    {
        private static List<Product> _products = new List<Product>
        {
            new Product { Id = 1, Name = "Espresso", Detail = "Strong coffee", ImageUrl = "/images/espresso.jpg", Price = 2.99m },
            new Product { Id = 2, Name = "Latte", Detail = "Milk coffee", ImageUrl = "/images/latte.jpg", Price = 3.99m }
        };

        public Product GetProductDetail(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }
    }
}
