using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL.Entities;
using ACM.BL.Repositories;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // Arrange
            Customer customer = new Customer(1);
            customer.FirstName = "Frodo";
            customer.LastName = "Baggins";

            string expected = "Baggins, Frodo";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RetrieveExistingCustomerTest()
        {
            // Arrange
            var customerRepository = new CustomerRepository();
            var expectedLastName = "Baggins";
            var expectedFirstName = "Frodo";
            var expectedEmail = "fbaggins@hobbiton.me";

            // Act
            var actual = customerRepository.Retrieve(1);

            // Assert
            Assert.AreEqual(expectedLastName, actual.LastName);
            Assert.AreEqual(expectedFirstName, actual.FirstName);
            Assert.AreEqual(expectedEmail, actual.EmailAddress);
            // Проверяем, что адрес подгрузился из репозитория адресов
            Assert.AreEqual("Hobbiton", actual.AddressList[0].City); 
        }
    }
}
