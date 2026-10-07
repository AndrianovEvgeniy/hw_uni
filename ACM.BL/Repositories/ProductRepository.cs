using ACM.BL.Entities;

namespace ACM.BL.Repositories
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);
            
            // Имитация загрузки из базы данных для тестов
            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.Description = "Yellow flowers";
                product.CurrentPrice = 15.97M;
            }
            return product;
        }

        public bool Save(Product product)
        {
            // Логика сохранения продукта в базу данных
            return true;
        }
    }
}
