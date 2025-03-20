namespace WebShopFresh.Shared.Models.Base.Address
{
    public abstract class AddressBase
    {
        public string Street { get; set; }
        public string Number { get; set; }
        public string City { get; set; }
        public string  Country { get; set; }
    }
}
