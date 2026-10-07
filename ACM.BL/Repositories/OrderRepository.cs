using ACM.BL.Entities;

namespace ACM.BL.Repositories
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);
            // Заглушка получения данных
            return order;
        }

        public bool Save(Order order)
        {
            // Логика сохранения заказа в базу данных
            return true;
        }
    }
}
