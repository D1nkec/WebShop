using Castle.Components.DictionaryAdapter;
using System.ComponentModel.DataAnnotations;
using WebShopFresh.Shared.Interfaces;
using WebShopFresh.Shared.Models.Base.Address;
using System.ComponentModel.DataAnnotations;
namespace WebShopFresh.Models.Dbo.AddressModels
{
    public class Address : AddressBase, IBaseTableAtributes
    {
        
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool Valid { get; set; }

    }
}
