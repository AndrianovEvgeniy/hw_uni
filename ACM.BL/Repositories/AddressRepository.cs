using System.Collections.Generic;
using ACM.BL.Entities;

namespace ACM.BL.Repositories
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);
            // Заглушка получения данных
            return address;
        }

        // Позволяет получить все адреса конкретного клиента
        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Bag End",
                City = "Hobbiton",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "123"
            };
            addressList.Add(address);

            return addressList;
        }

        public bool Save(Address address)
        {
            // Логика сохранения адреса в базу данных
            return true;
        }
    }
}
