


namespace WebShopFresh.Shared.Interfaces
{
   public interface IBaseTableAtributes
    {
        DateTime Created { get; set; }
        long Id { get; set; }
        DateTime Updated { get; set; }
        bool Valid { get; set; }
    }
}
