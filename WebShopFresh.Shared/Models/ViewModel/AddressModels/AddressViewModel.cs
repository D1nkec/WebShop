using WebShopFresh.Shared.Models.Base.Address;

namespace WebShopFresh.Shared.Models.ViewModel.AddressModels
{
    public class AddressViewModel : AddressBase
    {
        public long Id { get; set; }
        public DateTime Updated { get; set; }
    }
}
