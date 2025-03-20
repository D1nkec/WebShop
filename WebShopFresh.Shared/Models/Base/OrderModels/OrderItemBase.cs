namespace WebShopFresh.Shared.Models.Base.OrderModels
{
    public abstract class OrderItemBase
    {
        public virtual decimal Quantity { get; set; }
        public decimal Price { get; set; }
    }
}

