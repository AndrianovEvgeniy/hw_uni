using System;
using System.Collections.Generic;

namespace ACM.BL.Entities
{
    public class Order
    {
        public int OrderId { get; private set; }
        public int CustomerId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int ShippingAddressId { get; set; } // Ссылка на конкретный ID из сущности Address
        public List<OrderItem> OrderItems { get; set; }

        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }

        public bool Validate()
        {
            var isValid = true;
            if (OrderDate == null) isValid = false;
            return isValid;
        }
    }
}
