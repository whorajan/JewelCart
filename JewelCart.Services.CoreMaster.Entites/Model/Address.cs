namespace JewelCart.Services.CoreMaster.Entites.Model
{
    public class Address
	{
        public Guid Id { get; set; }

        public string HouseNo { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string AddressLine3 { get; set; }

        public string Street { get; set; }

        public City City { get; set; }

        public State State { get; set; }

        public Country Country { get; set; }

        public string ZipCode { get; set; }

        public string ContactNo { get; set; }

        public string ContactName { get; set; }

        public string CreateLogId { get; set; }
    }
}

