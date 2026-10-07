using System.Collections.Generic;
using ACM.BL.Entities;

namespace ACM.BL.Repositories
{
    public class CustomerRepository
    {
        private AddressRepository addressRepository { get; set; }

        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            // Имитация загрузки из базы данных для тестов
            if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                // Загружаем связанные адреса через AddressRepository (Разделение ответственностей)
                customer.AddressList = (List<Address>)addressRepository.RetrieveByCustomerId(customerId);
            }
            return customer;
        }

        public bool Save(Customer customer)
        {
            // Логика сохранения клиента в базу данных
            return true;
        }
    }
}
