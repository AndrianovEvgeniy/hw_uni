namespace ACM.BL.Entities
{
    public class Address
    {
        public int AddressId { get; set; }
        public int AddressType { get; set; } // Например: 1 - Home, 2 - Work, 3 - Shipping
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(PostalCode)) isValid = false;
            return isValid;
        }
    }
}
